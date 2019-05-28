using Android.Support.V7.Widget;
using Android.Views;
using static Caka_App.Widget.PagerLayout.PagerConfig;


namespace Caka_App.Widget.PagerLayout
{
    public class PagerGridSnapHelper : SnapHelper
    {
        private RecyclerView mRecyclerView;                     // RecyclerView

        public override void AttachToRecyclerView(RecyclerView recyclerView)
        {
            base.AttachToRecyclerView(recyclerView);
            mRecyclerView = recyclerView;
        }


        public override int[] CalculateDistanceToFinalSnap(RecyclerView.LayoutManager layoutManager, View targetView)
        {
            //throw new NotImplementedException();
            int pos = layoutManager.GetPosition(targetView);
            Loge("findTargetSnapPosition, pos = " + pos);
            int[] offset = new int[2];
            if (layoutManager is PagerGridLayoutManager)
            {
                PagerGridLayoutManager manager = (PagerGridLayoutManager)layoutManager;
                offset = manager.GetSnapOffset(pos);
            }
            return offset;
        }

        public override View FindSnapView(RecyclerView.LayoutManager layoutManager)
        {
            //throw new NotImplementedException();
            if (layoutManager is PagerGridLayoutManager)
            {
                PagerGridLayoutManager manager = (PagerGridLayoutManager)layoutManager;
                return manager.FindSnapView();
            }
            return null;
        }

        public override int FindTargetSnapPosition(RecyclerView.LayoutManager layoutManager, int velocityX, int velocityY)
        {
            //throw new NotImplementedException();
            int target = RecyclerView.NoPosition;//.NO_POSITION;
            Loge("findTargetSnapPosition, velocityX = " + velocityX + ", velocityY" + velocityY);
            if (null != layoutManager && layoutManager is PagerGridLayoutManager)
            {
                PagerGridLayoutManager manager = (PagerGridLayoutManager)layoutManager;
                if (manager.CanScrollHorizontally())
                {
                    if (velocityX > PagerConfig.GetFlingThreshold())
                    {
                        target = manager.FindNextPageFirstPos();
                    }
                    else if (velocityX < -PagerConfig.GetFlingThreshold())
                    {
                        target = manager.FindPrePageFirstPos();
                    }
                }
                else if (manager.CanScrollVertically())
                {
                    if (velocityY > PagerConfig.GetFlingThreshold())
                    {
                        target = manager.FindNextPageFirstPos();
                    }
                    else if (velocityY < -PagerConfig.GetFlingThreshold())
                    {
                        target = manager.FindPrePageFirstPos();
                    }
                }
            }
            Loge("findTargetSnapPosition, target = " + target);
            return target;
        }
    }
}