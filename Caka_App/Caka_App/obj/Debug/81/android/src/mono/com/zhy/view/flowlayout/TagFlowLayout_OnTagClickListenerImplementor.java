package mono.com.zhy.view.flowlayout;


public class TagFlowLayout_OnTagClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.zhy.view.flowlayout.TagFlowLayout.OnTagClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTagClick:(Landroid/view/View;ILcom/zhy/view/flowlayout/FlowLayout;)Z:GetOnTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_Handler:Com.Zhy.View.Flowlayout.TagFlowLayout/IOnTagClickListenerInvoker, Caka.TabFlow.Droid\n" +
			"";
		mono.android.Runtime.register ("Com.Zhy.View.Flowlayout.TagFlowLayout+IOnTagClickListenerImplementor, Caka.TabFlow.Droid", TagFlowLayout_OnTagClickListenerImplementor.class, __md_methods);
	}


	public TagFlowLayout_OnTagClickListenerImplementor ()
	{
		super ();
		if (getClass () == TagFlowLayout_OnTagClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Zhy.View.Flowlayout.TagFlowLayout+IOnTagClickListenerImplementor, Caka.TabFlow.Droid", "", this, new java.lang.Object[] {  });
	}


	public boolean onTagClick (android.view.View p0, int p1, com.zhy.view.flowlayout.FlowLayout p2)
	{
		return n_onTagClick (p0, p1, p2);
	}

	private native boolean n_onTagClick (android.view.View p0, int p1, com.zhy.view.flowlayout.FlowLayout p2);

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
