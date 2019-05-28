package mono.com.zhy.view.flowlayout;


public class TagFlowLayout_OnSelectListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.zhy.view.flowlayout.TagFlowLayout.OnSelectListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSelected:(Ljava/util/Set;)V:GetOnSelected_Ljava_util_Set_Handler:Com.Zhy.View.Flowlayout.TagFlowLayout/IOnSelectListenerInvoker, Caka.TabFlow.Droid\n" +
			"";
		mono.android.Runtime.register ("Com.Zhy.View.Flowlayout.TagFlowLayout+IOnSelectListenerImplementor, Caka.TabFlow.Droid", TagFlowLayout_OnSelectListenerImplementor.class, __md_methods);
	}


	public TagFlowLayout_OnSelectListenerImplementor ()
	{
		super ();
		if (getClass () == TagFlowLayout_OnSelectListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Zhy.View.Flowlayout.TagFlowLayout+IOnSelectListenerImplementor, Caka.TabFlow.Droid", "", this, new java.lang.Object[] {  });
	}


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
