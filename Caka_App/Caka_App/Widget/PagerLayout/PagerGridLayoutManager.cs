
using Android.Graphics;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using System;
using static Caka_App.Widget.PagerLayout.PagerConfig;

namespace Caka_App.Widget.PagerLayout
{
    /**
 * 作用：分页的网格布局管理器
 * 作者：Reggie
 * 摘要：
 * 1. 网格布局
 * 2. 支持水平分页和垂直分页
 * 3. 杜绝高内存占用
 */
    public class PagerGridLayoutManager : RecyclerView.LayoutManager, RecyclerView.SmoothScroller.IScrollVectorProvider
    {

        private static string TAG = "pglManager";

        public static int VERTICAL = 0;           // 垂直滚动
        public static int HORIZONTAL = 1;         // 水平滚动


        //public @interface OrientationType { }            // 滚动类型

        //    @OrientationType
        private int mOrientation;                       // 默认水平滚动

        private int mOffsetX = 0;                       // 水平滚动距离(偏移量)
        private int mOffsetY = 0;                       // 垂直滚动距离(偏移量)

        private int mRows;                              // 行数
        private int mColumns;                           // 列数
        private int mOnePageSize;                       // 一页的条目数量

        private SparseArray<Rect> mItemFrames;          // 条目的显示区域

        private int mItemWidth = 0;                     // 条目宽度
        private int mItemHeight = 0;                    // 条目高度

        private int mWidthUsed = 0;                     // 已经使用空间，用于测量View
        private int mHeightUsed = 0;                    // 已经使用空间，用于测量View

        private int mMaxScrollX;                        // 最大允许滑动的宽度
        private int mMaxScrollY;                        // 最大允许滑动的高度
        private int mScrollState = RecyclerView.ScrollStateIdle; // SCROLL_STATE_IDLE;   // 滚动状态

        private bool mAllowContinuousScroll = true;  // 是否允许连续滚动

        private RecyclerView mRecyclerView;

        /**
         * 构造函数
         *
         * @param rows        行数
         * @param columns     列数
         * @param orientation 方向
         */
        public PagerGridLayoutManager(int rows, int columns, int orientation)
        {
            mItemFrames = new SparseArray<Rect>();
            mOrientation = orientation;
            mRows = rows;
            mColumns = columns;
            mOnePageSize = mRows * mColumns;
        }

        public override void OnAttachedToWindow(RecyclerView view)
        {
            base.OnAttachedToWindow(view);
            mRecyclerView = view;
        }

        //public void Logi(string msg)
        //{
        //    Log.Info(TAG, msg);
        //}

        //public void Loge(string err)
        //{
        //    Log.Error(TAG, err);
        //}
        //--- 处理布局 ----------------------------------------------------------------------------------

        /**
         * 布局子View
         *
         * @param recycler Recycler
         * @param state    State
         */

        public override void OnLayoutChildren(RecyclerView.Recycler recycler, RecyclerView.State state)
        {
            Log.Info(TAG, "Item onLayoutChildren");
            Log.Info(TAG, "Item onLayoutChildren isPreLayout = " + state.IsPreLayout);
            Log.Info(TAG, "Item onLayoutChildren isMeasuring = " + state.IsMeasuring);
            Log.Info(TAG, "Item onLayoutChildren state = " + state);

            // 如果是 preLayout 则不重新布局
            if (state.IsPreLayout || !state.DidStructureChange())
            {
                return;
            }

            if (ItemCount == 0)
            {
                RemoveAndRecycleAllViews(recycler);
                // 页面变化回调
                SetPageCount(0);
                SetPageIndex(0, false);
                return;
            }
            else
            {
                SetPageCount(GetTotalPageCount());
                SetPageIndex(GetPageIndexByOffset(), false);
            }

            // 计算页面数量
            int mPageCount = ItemCount / mOnePageSize;
            if (ItemCount % mOnePageSize != 0)
            {
                mPageCount++;
            }

            // 计算可以滚动的最大数值，并对滚动距离进行修正
            if (CanScrollHorizontally())
            {
                mMaxScrollX = (mPageCount - 1) * GetUsableWidth();
                mMaxScrollY = 0;
                if (mOffsetX > mMaxScrollX)
                {
                    mOffsetX = mMaxScrollX;
                }
            }
            else
            {
                mMaxScrollX = 0;
                mMaxScrollY = (mPageCount - 1) * GetUsableHeight();
                if (mOffsetY > mMaxScrollY)
                {
                    mOffsetY = mMaxScrollY;
                }
            }

            // 接口回调
            // setPageCount(mPageCount);
            // setPageIndex(mCurrentPageIndex, false);

            Logi("count = " + ItemCount);

            if (mItemWidth <= 0)
            {
                mItemWidth = GetUsableWidth() / mColumns;
            }
            if (mItemHeight <= 0)
            {
                mItemHeight = GetUsableHeight() / mRows;
            }

            mWidthUsed = GetUsableWidth() - mItemWidth;
            mHeightUsed = GetUsableHeight() - mItemHeight;

            // 预存储两页的View显示区域
            for (int i = 0; i < mOnePageSize * 2; i++)
            {
                GetItemFrameByPosition(i);
            }

            if (mOffsetX == 0 && mOffsetY == 0)
            {
                // 预存储View
                for (int i = 0; i < mOnePageSize; i++)
                {
                    if (i >= ItemCount) break; // 防止数据过少时导致数组越界异常
                    View view = recycler.GetViewForPosition(i);
                    AddView(view);
                    MeasureChildWithMargins(view, mWidthUsed, mHeightUsed);
                }
            }

            // 回收和填充布局
            RecycleAndFillItems(recycler, state, true);
        }

        /**
         * 布局结束
         *
         * @param state State
         */
        public override void OnLayoutCompleted(RecyclerView.State state)
        {
            base.OnLayoutCompleted(state);
            if (state.IsPreLayout) return;
            // 页面状态回调
            SetPageCount(GetTotalPageCount());
            SetPageIndex(GetPageIndexByOffset(), false);
        }

        /**
         * 回收和填充布局
         *
         * @param recycler Recycler
         * @param state    State
         * @param isStart  是否从头开始，用于控制View遍历方向，true 为从头到尾，false 为从尾到头
         */
        //@SuppressLint("CheckResult")
        private void RecycleAndFillItems(RecyclerView.Recycler recycler, RecyclerView.State state,
                                         bool isStart)
        {
            if (state.IsPreLayout)
            {
                return;
            }

            Logi("mOffsetX = " + mOffsetX);
            Logi("mOffsetY = " + mOffsetY);

            // 计算显示区域区前后多存储一列或则一行
            Rect displayRect = new Rect(mOffsetX - mItemWidth, mOffsetY - mItemHeight,
                    GetUsableWidth() + mOffsetX + mItemWidth, GetUsableHeight() + mOffsetY + mItemHeight);
            // 对显显示区域进行修正(计算当前显示区域和最大显示区域对交集)
            displayRect.Intersect(0, 0, mMaxScrollX + GetUsableWidth(), mMaxScrollY + GetUsableHeight());
            Loge("displayRect = " + displayRect.ToString());

            int startPos = 0;                  // 获取第一个条目的Pos
            int pageIndex = GetPageIndexByOffset();
            startPos = pageIndex * mOnePageSize;
            Logi("startPos = " + startPos);
            startPos = startPos - mOnePageSize * 2;
            if (startPos < 0)
            {
                startPos = 0;
            }
            int stopPos = startPos + mOnePageSize * 4;
            if (stopPos > ItemCount)
            {
                stopPos = ItemCount;
            }

            Loge("startPos = " + startPos);
            Loge("stopPos = " + stopPos);

            DetachAndScrapAttachedViews(recycler); // 移除所有View

            if (isStart)
            {
                for (int i = startPos; i < stopPos; i++)
                {
                    AddOrRemove(recycler, displayRect, i);
                }
            }
            else
            {
                for (int i = stopPos - 1; i >= startPos; i--)
                {
                    AddOrRemove(recycler, displayRect, i);
                }
            }
            Loge("child count = " + ChildCount);// getChildCount());
        }

        /**
         * 添加或者移除条目
         *
         * @param recycler    RecyclerView
         * @param displayRect 显示区域
         * @param i           条目下标
         */
        private void AddOrRemove(RecyclerView.Recycler recycler, Rect displayRect, int i)
        {
            View child = recycler.GetViewForPosition(i);
            Rect rect = GetItemFrameByPosition(i);
            if (!Rect.Intersects(displayRect, rect))
            {
                RemoveAndRecycleView(child, recycler);   // 回收入暂存区
            }
            else
            {
                AddView(child);
                MeasureChildWithMargins(child, mWidthUsed, mHeightUsed);
                RecyclerView.LayoutParams lp = (RecyclerView.LayoutParams)child.LayoutParameters;// getLayoutParams();
                LayoutDecorated(child,
                        rect.Left - mOffsetX + lp.LeftMargin + PaddingLeft,
                        rect.Top - mOffsetY + lp.TopMargin + PaddingTop,
                        rect.Right - mOffsetX - lp.RightMargin + PaddingLeft,
                        rect.Bottom - mOffsetY - lp.BottomMargin + PaddingTop);
            }
        }


        //--- 处理滚动 ----------------------------------------------------------------------------------

        /**
         * 水平滚动
         *
         * @param dx       滚动距离
         * @param recycler 回收器
         * @param state    滚动状态
         * @return 实际滚动距离
         */
        public override int ScrollHorizontallyBy(int dx, RecyclerView.Recycler recycler, RecyclerView.State
                state)
        {
            int newX = mOffsetX + dx;
            int result = dx;
            if (newX > mMaxScrollX)
            {
                result = mMaxScrollX - mOffsetX;
            }
            else if (newX < 0)
            {
                result = 0 - mOffsetX;
            }
            mOffsetX += result;
            SetPageIndex(GetPageIndexByOffset(), true);
            OffsetChildrenHorizontal(-result);
            if (result > 0)
            {
                RecycleAndFillItems(recycler, state, true);
            }
            else
            {
                RecycleAndFillItems(recycler, state, false);
            }
            return result;
        }

        /**
         * 垂直滚动
         *
         * @param dy       滚动距离
         * @param recycler 回收器
         * @param state    滚动状态
         * @return 实际滚动距离
         */
        //@Override
        public override int ScrollVerticallyBy(int dy, RecyclerView.Recycler recycler, RecyclerView.State
                state)
        {
            int newY = mOffsetY + dy;
            int result = dy;
            if (newY > mMaxScrollY)
            {
                result = mMaxScrollY - mOffsetY;
            }
            else if (newY < 0)
            {
                result = 0 - mOffsetY;
            }
            mOffsetY += result;
            SetPageIndex(GetPageIndexByOffset(), true);
            OffsetChildrenVertical(-result);
            if (result > 0)
            {
                RecycleAndFillItems(recycler, state, true);
            }
            else
            {
                RecycleAndFillItems(recycler, state, false);
            }
            return result;
        }

        /**
         * 监听滚动状态，滚动结束后通知当前选中的页面
         *
         * @param state 滚动状态
         */
        //@Override
        public override void OnScrollStateChanged(int state)
        {
            Logi("onScrollStateChanged = " + state);
            mScrollState = state;
            base.OnScrollStateChanged(state);
            if (state == RecyclerView.ScrollStateIdle)
            {
                SetPageIndex(GetPageIndexByOffset(), false);
            }
        }


        //--- 私有方法 ----------------------------------------------------------------------------------

        /**
         * 获取条目显示区域
         *
         * @param pos 位置下标
         * @return 显示区域
         */
        private Rect GetItemFrameByPosition(int pos)
        {
            Rect rect = mItemFrames.Get(pos);
            if (null == rect)
            {
                rect = new Rect();
                // 计算显示区域 Rect

                // 1. 获取当前View所在页数
                int page = pos / mOnePageSize;

                // 2. 计算当前页数左上角的总偏移量
                int offsetX = 0;
                int offsetY = 0;
                if (CanScrollHorizontally())
                {
                    offsetX += GetUsableWidth() * page;
                }
                else
                {
                    offsetY += GetUsableHeight() * page;
                }

                // 3. 根据在当前页面中的位置确定具体偏移量
                int pagePos = pos % mOnePageSize;       // 在当前页面中是第几个
                int row = pagePos / mColumns;           // 获取所在行
                int col = pagePos - (row * mColumns);   // 获取所在列

                offsetX += col * mItemWidth;
                offsetY += row * mItemHeight;

                // 状态输出，用于调试
                Logi("pagePos = " + pagePos);
                Logi("行 = " + row);
                Logi("列 = " + col);

                Logi("offsetX = " + offsetX);
                Logi("offsetY = " + offsetY);

                rect.Left = offsetX;
                rect.Top = offsetY;
                rect.Right = offsetX + mItemWidth;
                rect.Bottom = offsetY + mItemHeight;

                // 存储
                mItemFrames.Put(pos, rect);
            }
            return rect;
        }

        /**
         * 获取可用的宽度
         *
         * @return 宽度 - padding
         */
        private int GetUsableWidth()
        {
            return Width - PaddingLeft - PaddingRight;//  GetWidth() - etPaddingLeft() - getPaddingRight();
        }

        /**
         * 获取可用的高度
         *
         * @return 高度 - padding
         */
        private int GetUsableHeight()
        {
            return Height - PaddingTop - PaddingBottom;// getHeight() - getPaddingTop() - getPaddingBottom();
        }


        //--- 页面相关(私有) -----------------------------------------------------------------------------

        /**
         * 获取总页数
         */
        private int GetTotalPageCount()
        {
            if (ItemCount <= 0) return 0;
            int totalCount = ItemCount / mOnePageSize;
            if (ItemCount % mOnePageSize != 0)
            {
                totalCount++;
            }
            return totalCount;
        }

        /**
         * 根据pos，获取该View所在的页面
         *
         * @param pos position
         * @return 页面的页码
         */
        private int GetPageIndexByPos(int pos)
        {
            return pos / mOnePageSize;
        }

        /**
         * 根据 offset 获取页面Index
         *
         * @return 页面 Index
         */
        private int GetPageIndexByOffset()
        {
            int pageIndex;
            if (CanScrollVertically())
            {
                int pageHeight = GetUsableHeight();
                if (mOffsetY <= 0 || pageHeight <= 0)
                {
                    pageIndex = 0;
                }
                else
                {
                    pageIndex = mOffsetY / pageHeight;
                    if (mOffsetY % pageHeight > pageHeight / 2)
                    {
                        pageIndex++;
                    }
                }
            }
            else
            {
                int pageWidth = GetUsableWidth();
                if (mOffsetX <= 0 || pageWidth <= 0)
                {
                    pageIndex = 0;
                }
                else
                {
                    pageIndex = mOffsetX / pageWidth;
                    if (mOffsetX % pageWidth > pageWidth / 2)
                    {
                        pageIndex++;
                    }
                }
            }
            Logi("getPageIndexByOffset pageIndex = " + pageIndex);
            return pageIndex;
        }


        //--- 公开方法 ----------------------------------------------------------------------------------

        /**
         * 创建默认布局参数
         *
         * @return 默认布局参数
         */
        //@Override
        public override RecyclerView.LayoutParams GenerateDefaultLayoutParams()
        {
            return new RecyclerView.LayoutParams(ViewGroup.LayoutParams.WrapContent,
                    ViewGroup.LayoutParams.WrapContent);
        }

        /**
         * 处理测量逻辑
         *
         * @param recycler          RecyclerView
         * @param state             状态
         * @param widthMeasureSpec  宽度属性
         * @param heightMeasureSpec 高估属性
         */
        //@Override
        public override void OnMeasure(RecyclerView.Recycler recycler, RecyclerView.State state, int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(recycler, state, widthMeasureSpec, heightMeasureSpec);
            int widthsize = View.MeasureSpec.GetSize(widthMeasureSpec);      //取出宽度的确切数值
            MeasureSpecMode widthmode = View.MeasureSpec.GetMode(widthMeasureSpec);      //取出宽度的测量模式

            int heightsize = View.MeasureSpec.GetSize(heightMeasureSpec);    //取出高度的确切数值
            MeasureSpecMode heightmode = View.MeasureSpec.GetMode(heightMeasureSpec);    //取出高度的测量模式

            // 将 wrap_content 转换为 match_parent
            if (widthmode != MeasureSpecMode.Exactly && widthsize > 0)
            {
                widthmode = MeasureSpecMode.Exactly;
            }
            if (heightmode != MeasureSpecMode.Exactly && heightsize > 0)
            {
                heightmode = MeasureSpecMode.Exactly;
            }
            SetMeasuredDimension(View.MeasureSpec.MakeMeasureSpec(widthsize, widthmode),
                    View.MeasureSpec.MakeMeasureSpec(heightsize, heightmode));
        }

        /**
         * 是否可以水平滚动
         *
         * @return true 是，false 不是。
         */

        public override bool CanScrollHorizontally()
        {
            return mOrientation == HORIZONTAL;
        }

        /**
         * 是否可以垂直滚动
         *
         * @return true 是，false 不是。
         */
        //@Override
        public override bool CanScrollVertically()
        {
            return mOrientation == VERTICAL;
        }

        /**
         * 找到下一页第一个条目的位置
         *
         * @return 第一个搞条目的位置
         */
        public int FindNextPageFirstPos()
        {
            int page = mLastPageIndex;
            page++;
            if (page >= GetTotalPageCount())
            {
                page = GetTotalPageCount() - 1;
            }
            Loge("computeScrollVectorForPosition next = " + page);
            return page * mOnePageSize;
        }

        /**
         * 找到上一页的第一个条目的位置
         *
         * @return 第一个条目的位置
         */
        public int FindPrePageFirstPos()
        {
            // 在获取时由于前一页的View预加载出来了，所以获取到的直接就是前一页
            int page = mLastPageIndex;
            page--;
            Loge("computeScrollVectorForPosition pre = " + page);
            if (page < 0)
            {
                page = 0;
            }
            Loge("computeScrollVectorForPosition pre = " + page);
            return page * mOnePageSize;
        }

        /**
         * 获取当前 X 轴偏移量
         *
         * @return X 轴偏移量
         */
        public int getOffsetX()
        {
            return mOffsetX;
        }

        /**
         * 获取当前 Y 轴偏移量
         *
         * @return Y 轴偏移量
         */
        public int getOffsetY()
        {
            return mOffsetY;
        }


        //--- 页面对齐 ----------------------------------------------------------------------------------

        /**
         * 计算到目标位置需要滚动的距离{@link RecyclerView.SmoothScroller.ScrollVectorProvider}
         *
         * @param targetPosition 目标控件
         * @return 需要滚动的距离
         */
        public PointF ComputeScrollVectorForPosition(int targetPosition)
        {
            PointF vector = new PointF();
            int[] pos = GetSnapOffset(targetPosition);
            vector.X = pos[0];
            vector.Y = pos[1];
            return vector;
        }

        /**
         * 获取偏移量(为PagerGridSnapHelper准备)
         * 用于分页滚动，确定需要滚动的距离。
         * {@link PagerGridSnapHelper}
         *
         * @param targetPosition 条目下标
         */
        public int[] GetSnapOffset(int targetPosition)
        {
            int[] offset = new int[2];
            int[] pos = GetPageLeftTopByPosition(targetPosition);
            offset[0] = pos[0] - mOffsetX;
            offset[1] = pos[1] - mOffsetY;
            return offset;
        }

        /**
         * 根据条目下标获取该条目所在页面的左上角位置
         *
         * @param pos 条目下标
         * @return 左上角位置
         */
        private int[] GetPageLeftTopByPosition(int pos)
        {
            int[] leftTop = new int[2];
            int page = GetPageIndexByPos(pos);
            if (CanScrollHorizontally())
            {
                leftTop[0] = page * GetUsableWidth();
                leftTop[1] = 0;
            }
            else
            {
                leftTop[0] = 0;
                leftTop[1] = page * GetUsableHeight();
            }
            return leftTop;
        }

        /**
         * 获取需要对齐的View
         *
         * @return 需要对齐的View
         */
        public View FindSnapView()
        {
            if (null != FocusedChild) // GetFocusedChild())
            {
                return FocusedChild;
            }
            if (ChildCount <= 0)
            {
                return null;
            }
            int targetPos = GetPageIndexByOffset() * mOnePageSize;   // 目标Pos
            for (int i = 0; i < ChildCount; i++)
            {
                int childPos = GetPosition(GetChildAt(i));
                if (childPos == targetPos)
                {
                    return GetChildAt(i);
                }
            }
            return GetChildAt(0);
        }


        //--- 处理页码变化 -------------------------------------------------------------------------------

        private bool mChangeSelectInScrolling = true;    // 是否在滚动过程中对页面变化回调
        private int mLastPageCount = -1;                    // 上次页面总数
        private int mLastPageIndex = -1;                    // 上次页面下标

        /**
         * 设置页面总数
         *
         * @param pageCount 页面总数
         */
        private void SetPageCount(int pageCount)
        {
            if (pageCount >= 0)
            {
                if (mPageListener != null && pageCount != mLastPageCount)
                {
                    mPageListener.onPageSizeChanged(pageCount);
                }
                mLastPageCount = pageCount;
            }
        }

        /**
         * 设置当前选中页面
         *
         * @param pageIndex   页面下标
         * @param isScrolling 是否处于滚动状态
         */
        private void SetPageIndex(int pageIndex, bool isScrolling)
        {
            Loge("setPageIndex = " + pageIndex + ":" + isScrolling);
            if (pageIndex == mLastPageIndex) return;
            // 如果允许连续滚动，那么在滚动过程中就会更新页码记录
            if (isAllowContinuousScroll())
            {
                mLastPageIndex = pageIndex;
            }
            else
            {
                // 否则，只有等滚动停下时才会更新页码记录
                if (!isScrolling)
                {
                    mLastPageIndex = pageIndex;
                }
            }
            if (isScrolling && !mChangeSelectInScrolling) return;
            if (pageIndex >= 0)
            {
                if (null != mPageListener)
                {
                    mPageListener.onPageSelect(pageIndex);
                }
            }
        }

        /**
         * 设置是否在滚动状态更新选中页码
         *
         * @param changeSelectInScrolling true：更新、false：不更新
         */
        public void SetChangeSelectInScrolling(bool changeSelectInScrolling)
        {
            mChangeSelectInScrolling = changeSelectInScrolling;
        }

        /**
         * 设置滚动方向
         *
         * @param orientation 滚动方向
         * @return 最终的滚动方向
         */
        //@OrientationType
        public int SetOrientationType(int orientation)
        {
            if (mOrientation == orientation || mScrollState != RecyclerView.ScrollStateIdle) return mOrientation;
            mOrientation = orientation;
            mItemFrames.Clear();
            int x = mOffsetX;
            int y = mOffsetY;
            mOffsetX = y / GetUsableHeight() * GetUsableWidth();
            mOffsetY = x / GetUsableWidth() * GetUsableHeight();
            int mx = mMaxScrollX;
            int my = mMaxScrollY;
            mMaxScrollX = my / GetUsableHeight() * GetUsableWidth();
            mMaxScrollY = mx / GetUsableWidth() * GetUsableHeight();
            return mOrientation;
        }

        //--- 滚动到指定位置 -----------------------------------------------------------------------------

        public override void SmoothScrollToPosition(RecyclerView recyclerView, RecyclerView.State state, int position)
        {
            int targetPageIndex = GetPageIndexByPos(position);
            SmoothScrollToPage(targetPageIndex);
        }

        /**
         * 平滑滚动到上一页
         */
        public void SmoothPrePage()
        {
            SmoothScrollToPage(GetPageIndexByOffset() - 1);
        }

        /**
         * 平滑滚动到下一页
         */
        public void SmoothNextPage()
        {
            SmoothScrollToPage(GetPageIndexByOffset() + 1);
        }

        /**
         * 平滑滚动到指定页面
         *
         * @param pageIndex 页面下标
         */
        public void SmoothScrollToPage(int pageIndex)
        {
            if (pageIndex < 0 || pageIndex >= mLastPageCount)
            {
                Log.Error(TAG, "pageIndex is outOfIndex, must in [0, " + mLastPageCount + ").");
                return;
            }
            if (null == mRecyclerView)
            {
                Log.Error(TAG, "RecyclerView Not Found!");
                return;
            }

            // 如果滚动到页面之间距离过大，先直接滚动到目标页面到临近页面，在使用 smoothScroll 最终滚动到目标
            // 否则在滚动距离很大时，会导致滚动耗费的时间非常长
            int currentPageIndex = GetPageIndexByOffset();
            if (Math.Abs(pageIndex - currentPageIndex) > 3)
            {
                if (pageIndex > currentPageIndex)
                {
                    ScrollToPage(pageIndex - 3);
                }
                else if (pageIndex < currentPageIndex)
                {
                    ScrollToPage(pageIndex + 3);
                }
            }

            // 具体执行滚动
            LinearSmoothScroller smoothScroller = new PagerGridSmoothScroller(mRecyclerView);
            int position = pageIndex * mOnePageSize;
            smoothScroller.TargetPosition = position;// SetTargetPosition(position);
            StartSmoothScroll(smoothScroller);
        }

        //=== 直接滚动 ===

        //@Override
        public override void ScrollToPosition(int position)
        {
            int pageIndex = GetPageIndexByPos(position);
            ScrollToPage(pageIndex);
        }

        /**
         * 上一页
         */
        public void PrePage()
        {
            ScrollToPage(GetPageIndexByOffset() - 1);
        }

        /**
         * 下一页
         */
        public void NextPage()
        {
            ScrollToPage(GetPageIndexByOffset() + 1);
        }

        /**
         * 滚动到指定页面
         *
         * @param pageIndex 页面下标
         */
        public void ScrollToPage(int pageIndex)
        {
            if (pageIndex < 0 || pageIndex >= mLastPageCount)
            {
                Log.Error(TAG, "pageIndex = " + pageIndex + " is out of bounds, mast in [0, " + mLastPageCount + ")");
                return;
            }

            if (null == mRecyclerView)
            {
                Log.Error(TAG, "RecyclerView Not Found!");
                return;
            }

            int mTargetOffsetXBy = 0;
            int mTargetOffsetYBy = 0;
            if (CanScrollVertically())
            {
                mTargetOffsetXBy = 0;
                mTargetOffsetYBy = pageIndex * GetUsableHeight() - mOffsetY;
            }
            else
            {
                mTargetOffsetXBy = pageIndex * GetUsableWidth() - mOffsetX;
                mTargetOffsetYBy = 0;
            }
            Loge("mTargetOffsetXBy = " + mTargetOffsetXBy);
            Loge("mTargetOffsetYBy = " + mTargetOffsetYBy);
            mRecyclerView.ScrollBy(mTargetOffsetXBy, mTargetOffsetYBy);
            SetPageIndex(pageIndex, false);
        }

        /**
         * 是否允许连续滚动，默认为允许
         *
         * @return true 允许， false 不允许
         */
        public bool isAllowContinuousScroll()
        {
            return mAllowContinuousScroll;
        }

        /**
         * 设置是否允许连续滚动
         *
         * @param allowContinuousScroll true 允许，false 不允许
         */
        public void setAllowContinuousScroll(bool allowContinuousScroll)
        {
            mAllowContinuousScroll = allowContinuousScroll;
        }

        //--- 对外接口 ----------------------------------------------------------------------------------

        private IPageListener mPageListener = null;

        public void SetPageListener(IPageListener pageListener)
        {
            mPageListener = pageListener;
        }

        public interface IPageListener
        {
            /**
             * 页面总数量变化
             *
             * @param pageSize 页面总数
             */
            void onPageSizeChanged(int pageSize);

            /**
             * 页面被选中
             *
             * @param pageIndex 选中的页面
             */
            void onPageSelect(int pageIndex);
        }

        //public PointF ComputeScrollVectorForPosition(int targetPosition)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public override RecyclerView.LayoutParams GenerateDefaultLayoutParams()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }


    public enum IntDef
    {
        VERTICAL,
        HORIZONTAL
    }

}