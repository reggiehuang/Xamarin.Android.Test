package md5aeb53b2c3c1c5b7d47264be238b9c0c1;


public class PagerGridSnapHelper
	extends android.support.v7.widget.SnapHelper
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_attachToRecyclerView:(Landroid/support/v7/widget/RecyclerView;)V:GetAttachToRecyclerView_Landroid_support_v7_widget_RecyclerView_Handler\n" +
			"n_calculateDistanceToFinalSnap:(Landroid/support/v7/widget/RecyclerView$LayoutManager;Landroid/view/View;)[I:GetCalculateDistanceToFinalSnap_Landroid_support_v7_widget_RecyclerView_LayoutManager_Landroid_view_View_Handler\n" +
			"n_findSnapView:(Landroid/support/v7/widget/RecyclerView$LayoutManager;)Landroid/view/View;:GetFindSnapView_Landroid_support_v7_widget_RecyclerView_LayoutManager_Handler\n" +
			"n_findTargetSnapPosition:(Landroid/support/v7/widget/RecyclerView$LayoutManager;II)I:GetFindTargetSnapPosition_Landroid_support_v7_widget_RecyclerView_LayoutManager_IIHandler\n" +
			"";
		mono.android.Runtime.register ("Caka_App.Widget.PagerLayout.PagerGridSnapHelper, Caka_App", PagerGridSnapHelper.class, __md_methods);
	}


	public PagerGridSnapHelper ()
	{
		super ();
		if (getClass () == PagerGridSnapHelper.class)
			mono.android.TypeManager.Activate ("Caka_App.Widget.PagerLayout.PagerGridSnapHelper, Caka_App", "", this, new java.lang.Object[] {  });
	}


	public void attachToRecyclerView (android.support.v7.widget.RecyclerView p0)
	{
		n_attachToRecyclerView (p0);
	}

	private native void n_attachToRecyclerView (android.support.v7.widget.RecyclerView p0);


	public int[] calculateDistanceToFinalSnap (android.support.v7.widget.RecyclerView.LayoutManager p0, android.view.View p1)
	{
		return n_calculateDistanceToFinalSnap (p0, p1);
	}

	private native int[] n_calculateDistanceToFinalSnap (android.support.v7.widget.RecyclerView.LayoutManager p0, android.view.View p1);


	public android.view.View findSnapView (android.support.v7.widget.RecyclerView.LayoutManager p0)
	{
		return n_findSnapView (p0);
	}

	private native android.view.View n_findSnapView (android.support.v7.widget.RecyclerView.LayoutManager p0);


	public int findTargetSnapPosition (android.support.v7.widget.RecyclerView.LayoutManager p0, int p1, int p2)
	{
		return n_findTargetSnapPosition (p0, p1, p2);
	}

	private native int n_findTargetSnapPosition (android.support.v7.widget.RecyclerView.LayoutManager p0, int p1, int p2);

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
