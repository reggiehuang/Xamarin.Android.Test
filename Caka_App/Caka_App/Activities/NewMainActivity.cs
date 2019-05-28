using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using Caka_App.Widget.PagerLayout;
using Java.Lang;

namespace Caka_App.Activities
{
    [Activity(Label = "NewMainActivity")]
    public class NewMainActivity : Activity, PagerGridLayoutManager.IPageListener, RadioGroup.IOnCheckedChangeListener, View.IOnTouchListener
    {
        private int mRows = 3;
        private int mColumns = 2;
        private RecyclerView mRecyclerView;
        public static MainItemAdapter mAdapter;
        private PagerGridLayoutManager mLayoutManager;
        private RadioGroup mRadioGroup;
        private TextView mPageTotal;        // 总页数
        private TextView mPageCurrent;      // 当前页数
        private TextView t_page_bar_process;
        private int mTotal = 0;
        private int mCurrent = 0;

        public SeekBar _seekBar = null;
        public void OnCheckedChanged(RadioGroup group, int checkedId)
        {
            //throw new NotImplementedException();
            int type = -1;
            if (checkedId == Resource.Id.type_horizontal)
            {
                type = mLayoutManager.SetOrientationType(PagerGridLayoutManager.HORIZONTAL);
            }
            else if (checkedId == Resource.Id.type_vertical)
            {
                type = mLayoutManager.SetOrientationType(PagerGridLayoutManager.VERTICAL);
            }
            else
            {
                throw new RuntimeException("不支持的方向类型");
            }

            Log.Info("GCST", "type == " + type);
        }

        public void onPageSelect(int pageIndex)
        {
            //throw new NotImplementedException();
            mCurrent = pageIndex;
            Log.Error("TAG", "选中页码 = " + pageIndex);
            mPageCurrent.Text = @"第 " + (pageIndex + 1) + " 页";
            var nowIndex = pageIndex + 1;
            _seekBar.Progress = nowIndex;
            var processArr = t_page_bar_process.Text.Split('/');
            t_page_bar_process.Text = nowIndex + "/" + processArr[1];
        }

        public void onPageSizeChanged(int pageSize)
        {
            //throw new NotImplementedException();
            mTotal = pageSize;
            Log.Error("TAG", "总页数 = " + pageSize);
            mPageTotal.Text = @"共 " + pageSize + " 页";//.SetText("共 " + pageSize + " 页");
            var processArr = t_page_bar_process.Text.Split('/');
            t_page_bar_process.Text = processArr[0] + "/" + pageSize;

            _seekBar.Max = pageSize;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.main);
            Log.Info("GCS", "onCreate");

            _seekBar = FindViewById<SeekBar>(Resource.Id.seekBar1);
            _seekBar.SetOnTouchListener(this);


            mRadioGroup = this.FindViewById<RadioGroup>(Resource.Id.orientation_type);// (RadioGroup)findViewById(R.id.orientation_type);
            mRadioGroup.SetOnCheckedChangeListener(this);

            mPageTotal = (TextView)FindViewById(Resource.Id.page_total);
            mPageCurrent = (TextView)FindViewById(Resource.Id.page_current);
            t_page_bar_process = FindViewById<TextView>(Resource.Id.page_bar_process);
            mLayoutManager = new PagerGridLayoutManager(mRows, mColumns, PagerGridLayoutManager
                    .HORIZONTAL);


            // 系统带的 RecyclerView，无需自定义
            mRecyclerView = (RecyclerView)FindViewById(Resource.Id.recycler_view);

            // 水平分页布局管理器
            mLayoutManager.SetPageListener(this);    // 设置页面变化监听器
            mRecyclerView.SetLayoutManager(mLayoutManager);

            // 设置滚动辅助工具
            PagerGridSnapHelper pageSnapHelper = new PagerGridSnapHelper();
            pageSnapHelper.AttachToRecyclerView(mRecyclerView);

            // 如果需要查看调试日志可以设置为true，一般情况忽略即可
            PagerConfig.SetShowLog(true);
            List<string> data = new List<string>();
            for (int i = 1; i <= 15; i++)
            {
                data.Add(i + "");
            }
            // 使用原生的 Adapter 即可
            mAdapter = new MainItemAdapter(data);
            RecyclerView.AdapterDataObserver observer = new DataObserverModel(mAdapter);
            mAdapter.RegisterAdapterDataObserver(observer);
            mRecyclerView.SetAdapter(mAdapter);

            Button btn_addone = this.FindViewById<Button>(Resource.Id.AddOneFunc);
            btn_addone.Click += delegate
            {
                mAdapter.items.Add("add");
                mAdapter.NotifyDataSetChanged();
            };

        }

        public void AddOne(View view)
        {
            mAdapter.items.Add("add");
            mAdapter.NotifyDataSetChanged();
        }

        public void RemoveOne(View view)
        {
            if (mAdapter.items.Count() > 0)
            {
                mAdapter.items.RemoveAt(0);//.Remove(0);
                mAdapter.NotifyDataSetChanged();
            }
        }

        public void AddMore(View view)
        {
            List<string> data = new List<string>();// ArrayList<>();
            for (int i = 1; i <= 5; i++)
            {
                data.Add(i + "a");
            }
            mAdapter.items.AddRange(data);
            mAdapter.NotifyDataSetChanged();
        }

        public void PrePage(View view)
        {
            mLayoutManager.PrePage();
        }

        public void NextPage(View view)
        {
            mLayoutManager.NextPage();
        }

        public void SmoothPrePage(View view)
        {
            mLayoutManager.SmoothPrePage();
        }

        public void SmoothNextPage(View view)
        {
            mLayoutManager.SmoothNextPage();
        }

        public void FirstPage(View view)
        {
            mRecyclerView.SmoothScrollToPosition(0);
        }

        public void LastPage(View view)
        {
            mRecyclerView.SmoothScrollToPosition(mAdapter.ItemCount - 1);
        }

        public bool OnTouch(View v, MotionEvent e)
        {
            return true;
            //throw new NotImplementedException();
        }

        public class DataObserverModel : RecyclerView.AdapterDataObserver
        {
            public int count = 0;
            public MainItemAdapter _myItem = null;
            public DataObserverModel(MainItemAdapter item)
            {
                _myItem = item;
            }
            public override void OnChanged()
            {
                base.OnChanged();
                count = mAdapter.ItemCount;// data.Count;//.ItemCount;// .myItem.ItemCount;
            }
        }
    }
}