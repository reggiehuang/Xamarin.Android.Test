package md5e938e9d3275bd6f37b714d127b06e428;


public class SingleChooseFragment
	extends android.support.v4.app.Fragment
	implements
		mono.android.IGCUserPeer,
		com.zhy.view.flowlayout.TagFlowLayout.OnTagClickListener,
		com.zhy.view.flowlayout.TagFlowLayout.OnSelectListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"n_onViewCreated:(Landroid/view/View;Landroid/os/Bundle;)V:GetOnViewCreated_Landroid_view_View_Landroid_os_Bundle_Handler\n" +
			"n_onTagClick:(Landroid/view/View;ILcom/zhy/view/flowlayout/FlowLayout;)Z:GetOnTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_Handler:Com.Zhy.View.Flowlayout.TagFlowLayout/IOnTagClickListenerInvoker, Caka.TabFlow.Droid\n" +
			"n_onSelected:(Ljava/util/Set;)V:GetOnSelected_Ljava_util_Set_Handler:Com.Zhy.View.Flowlayout.TagFlowLayout/IOnSelectListenerInvoker, Caka.TabFlow.Droid\n" +
			"";
		mono.android.Runtime.register ("Caka_App.Activities.SingleChooseFragment, Caka_App", SingleChooseFragment.class, __md_methods);
	}


	public SingleChooseFragment ()
	{
		super ();
		if (getClass () == SingleChooseFragment.class)
			mono.android.TypeManager.Activate ("Caka_App.Activities.SingleChooseFragment, Caka_App", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);


	public void onViewCreated (android.view.View p0, android.os.Bundle p1)
	{
		n_onViewCreated (p0, p1);
	}

	private native void n_onViewCreated (android.view.View p0, android.os.Bundle p1);


	public boolean onTagClick (android.view.View p0, int p1, com.zhy.view.flowlayout.FlowLayout p2)
	{
		return n_onTagClick (p0, p1, p2);
	}

	private native boolean n_onTagClick (android.view.View p0, int p1, com.zhy.view.flowlayout.FlowLayout p2);


	public void onSelected (java.util.Set p0)
	{
		n_onSelected (p0);
	}

	private native void n_onSelected (java.util.Set p0);

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
