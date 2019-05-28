using System;
using Android.Views;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views.Animations;
using static Caka_App.Widget.PagerLayout.PagerConfig;

namespace Caka_App.Widget.PagerLayout
{
    public class PagerGridSmoothScroller : LinearSmoothScroller
    {
        private RecyclerView mRecyclerView;

        public PagerGridSmoothScroller(RecyclerView recyclerView) : base(recyclerView.Context)
        {
            mRecyclerView = recyclerView;
        }

        protected override void OnTargetFound(View targetView, RecyclerView.State state, Action action)
        {
            RecyclerView.LayoutManager manager = mRecyclerView.GetLayoutManager();
            if (null == manager) return;
            if (manager is PagerGridLayoutManager)
            {
                PagerGridLayoutManager layoutManager = (PagerGridLayoutManager)manager;
                int pos = mRecyclerView.GetChildAdapterPosition(targetView);
                int[] snapDistances = layoutManager.GetSnapOffset(pos);
                int dx = snapDistances[0];
                int dy = snapDistances[1];
                Logi("dx = " + dx);
                Logi("dy = " + dy);
                int time = CalculateTimeForScrolling(Math.Max(Math.Abs(dx), Math.Abs(dy)));
                if (time > 0)
                {
                    action.Update(dx, dy, time, new DecelerateInterpolator());
                }
            }
        }


        protected override float CalculateSpeedPerPixel(DisplayMetrics displayMetrics)
        {
            return PagerConfig.GetMillisecondsPreInch() / (int)displayMetrics.DensityDpi;
        }

    }
}