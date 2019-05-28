package md5aeb53b2c3c1c5b7d47264be238b9c0c1;


public class PagerGridLayoutManager
	extends android.support.v7.widget.RecyclerView.LayoutManager
	implements
		mono.android.IGCUserPeer,
		android.support.v7.widget.RecyclerView.SmoothScroller.ScrollVectorProvider
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAttachedToWindow:(Landroid/support/v7/widget/RecyclerView;)V:GetOnAttachedToWindow_Landroid_support_v7_widget_RecyclerView_Handler\n" +
			"n_onLayoutChildren:(Landroid/support/v7/widget/RecyclerView$Recycler;Landroid/support/v7/widget/RecyclerView$State;)V:GetOnLayoutChildren_Landroid_support_v7_widget_RecyclerView_Recycler_Landroid_support_v7_widget_RecyclerView_State_Handler\n" +
			"n_onLayoutCompleted:(Landroid/support/v7/widget/RecyclerView$State;)V:GetOnLayoutCompleted_Landroid_support_v7_widget_RecyclerView_State_Handler\n" +
			"n_scrollHorizontallyBy:(ILandroid/support/v7/widget/RecyclerView$Recycler;Landroid/support/v7/widget/RecyclerView$State;)I:GetScrollHorizontallyBy_ILandroid_support_v7_widget_RecyclerView_Recycler_Landroid_support_v7_widget_RecyclerView_State_Handler\n" +
			"n_scrollVerticallyBy:(ILandroid/support/v7/widget/RecyclerView$Recycler;Landroid/support/v7/widget/RecyclerView$State;)I:GetScrollVerticallyBy_ILandroid_support_v7_widget_RecyclerView_Recycler_Landroid_support_v7_widget_RecyclerView_State_Handler\n" +
			"n_onScrollStateChanged:(I)V:GetOnScrollStateChanged_IHandler\n" +
			"n_generateDefaultLayoutParams:()Landroid/support/v7/widget/RecyclerView$LayoutParams;:GetGenerateDefaultLayoutParamsHandler\n" +
			"n_onMeasure:(Landroid/support/v7/widget/RecyclerView$Recycler;Landroid/support/v7/widget/RecyclerView$State;II)V:GetOnMeasure_Landroid_support_v7_widget_RecyclerView_Recycler_Landroid_support_v7_widget_RecyclerView_State_IIHandler\n" +
			"n_canScrollHorizontally:()Z:GetCanScrollHorizontallyHandler\n" +
			"n_canScrollVertically:()Z:GetCanScrollVerticallyHandler\n" +
			"n_smoothScrollToPosition:(Landroid/support/v7/widget/RecyclerView;Landroid/support/v7/widget/RecyclerView$State;I)V:GetSmoothScrollToPosition_Landroid_support_v7_widget_RecyclerView_Landroid_support_v7_widget_RecyclerView_State_IHandler\n" +
			"n_scrollToPosition:(I)V:GetScrollToPosition_IHandler\n" +
			"n_computeScrollVectorForPosition:(I)Landroid/graphics/PointF;:GetComputeScrollVectorForPosition_IHandler:Android.Support.V7.Widget.RecyclerView/SmoothScroller/IScrollVectorProviderInvoker, Xamarin.Android.Support.v7.RecyclerView\n" +
			"";
		mono.android.Runtime.register ("Caka_App.Widget.PagerLayout.PagerGridLayoutManager, Caka_App", PagerGridLayoutManager.class, __md_methods);
	}


	public PagerGridLayoutManager ()
	{
		super ();
		if (getClass () == PagerGridLayoutManager.class)
			mono.android.TypeManager.Activate ("Caka_App.Widget.PagerLayout.PagerGridLayoutManager, Caka_App", "", this, new java.lang.Object[] {  });
	}

	public PagerGridLayoutManager (int p0, int p1, int p2)
	{
		super ();
		if (getClass () == PagerGridLayoutManager.class)
			mono.android.TypeManager.Activate ("Caka_App.Widget.PagerLayout.PagerGridLayoutManager, Caka_App", "System.Int32, mscorlib:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onAttachedToWindow (android.support.v7.widget.RecyclerView p0)
	{
		n_onAttachedToWindow (p0);
	}

	private native void n_onAttachedToWindow (android.support.v7.widget.RecyclerView p0);


	public void onLayoutChildren (android.support.v7.widget.RecyclerView.Recycler p0, android.support.v7.widget.RecyclerView.State p1)
	{
		n_onLayoutChildren (p0, p1);
	}

	private native void n_onLayoutChildren (android.support.v7.widget.RecyclerView.Recycler p0, android.support.v7.widget.RecyclerView.State p1);


	public void onLayoutCompleted (android.support.v7.widget.RecyclerView.State p0)
	{
		n_onLayoutCompleted (p0);
	}

	private native void n_onLayoutCompleted (android.support.v7.widget.RecyclerView.State p0);


	public int scrollHorizontallyBy (int p0, android.support.v7.widget.RecyclerView.Recycler p1, android.support.v7.widget.RecyclerView.State p2)
	{
		return n_scrollHorizontallyBy (p0, p1, p2);
	}

	private native int n_scrollHorizontallyBy (int p0, android.support.v7.widget.RecyclerView.Recycler p1, android.support.v7.widget.RecyclerView.State p2);


	public int scrollVerticallyBy (int p0, android.support.v7.widget.RecyclerView.Recycler p1, android.support.v7.widget.RecyclerView.State p2)
	{
		return n_scrollVerticallyBy (p0, p1, p2);
	}

	private native int n_scrollVerticallyBy (int p0, android.support.v7.widget.RecyclerView.Recycler p1, android.support.v7.widget.RecyclerView.State p2);


	public void onScrollStateChanged (int p0)
	{
		n_onScrollStateChanged (p0);
	}

	private native void n_onScrollStateChanged (int p0);


	public android.support.v7.widget.RecyclerView.LayoutParams generateDefaultLayoutParams ()
	{
		return n_generateDefaultLayoutParams ();
	}

	private native android.support.v7.widget.RecyclerView.LayoutParams n_generateDefaultLayoutParams ();


	public void onMeasure (android.support.v7.widget.RecyclerView.Recycler p0, android.support.v7.widget.RecyclerView.State p1, int p2, int p3)
	{
		n_onMeasure (p0, p1, p2, p3);
	}

	private native void n_onMeasure (android.support.v7.widget.RecyclerView.Recycler p0, android.support.v7.widget.RecyclerView.State p1, int p2, int p3);


	public boolean canScrollHorizontally ()
	{
		return n_canScrollHorizontally ();
	}

	private native boolean n_canScrollHorizontally ();


	public boolean canScrollVertically ()
	{
		return n_canScrollVertically ();
	}

	private native boolean n_canScrollVertically ();


	public void smoothScrollToPosition (android.support.v7.widget.RecyclerView p0, android.support.v7.widget.RecyclerView.State p1, int p2)
	{
		n_smoothScrollToPosition (p0, p1, p2);
	}

	private native void n_smoothScrollToPosition (android.support.v7.widget.RecyclerView p0, android.support.v7.widget.RecyclerView.State p1, int p2);


	public void scrollToPosition (int p0)
	{
		n_scrollToPosition (p0);
	}

	private native void n_scrollToPosition (int p0);


	public android.graphics.PointF computeScrollVectorForPosition (int p0)
	{
		return n_computeScrollVectorForPosition (p0);
	}

	private native android.graphics.PointF n_computeScrollVectorForPosition (int p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
