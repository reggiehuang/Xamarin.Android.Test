package md5aeb53b2c3c1c5b7d47264be238b9c0c1;


public class PagerGridSmoothScroller
	extends android.support.v7.widget.LinearSmoothScroller
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTargetFound:(Landroid/view/View;Landroid/support/v7/widget/RecyclerView$State;Landroid/support/v7/widget/RecyclerView$SmoothScroller$Action;)V:GetOnTargetFound_Landroid_view_View_Landroid_support_v7_widget_RecyclerView_State_Landroid_support_v7_widget_RecyclerView_SmoothScroller_Action_Handler\n" +
			"n_calculateSpeedPerPixel:(Landroid/util/DisplayMetrics;)F:GetCalculateSpeedPerPixel_Landroid_util_DisplayMetrics_Handler\n" +
			"";
		mono.android.Runtime.register ("Caka_App.Widget.PagerLayout.PagerGridSmoothScroller, Caka_App", PagerGridSmoothScroller.class, __md_methods);
	}


	public PagerGridSmoothScroller (android.content.Context p0)
	{
		super (p0);
		if (getClass () == PagerGridSmoothScroller.class)
			mono.android.TypeManager.Activate ("Caka_App.Widget.PagerLayout.PagerGridSmoothScroller, Caka_App", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onTargetFound (android.view.View p0, android.support.v7.widget.RecyclerView.State p1, android.support.v7.widget.RecyclerView.SmoothScroller.Action p2)
	{
		n_onTargetFound (p0, p1, p2);
	}

	private native void n_onTargetFound (android.view.View p0, android.support.v7.widget.RecyclerView.State p1, android.support.v7.widget.RecyclerView.SmoothScroller.Action p2);


	public float calculateSpeedPerPixel (android.util.DisplayMetrics p0)
	{
		return n_calculateSpeedPerPixel (p0);
	}

	private native float n_calculateSpeedPerPixel (android.util.DisplayMetrics p0);

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
