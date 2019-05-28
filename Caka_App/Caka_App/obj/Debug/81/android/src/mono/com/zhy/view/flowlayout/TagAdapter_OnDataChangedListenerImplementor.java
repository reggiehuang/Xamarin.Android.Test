package mono.com.zhy.view.flowlayout;


public class TagAdapter_OnDataChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.zhy.view.flowlayout.TagAdapter.OnDataChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onChanged:()V:GetOnChangedHandler:Com.Zhy.View.Flowlayout.TagAdapter/IOnDataChangedListenerInvoker, Caka.TabFlow.Droid\n" +
			"";
		mono.android.Runtime.register ("Com.Zhy.View.Flowlayout.TagAdapter+IOnDataChangedListenerImplementor, Caka.TabFlow.Droid", TagAdapter_OnDataChangedListenerImplementor.class, __md_methods);
	}


	public TagAdapter_OnDataChangedListenerImplementor ()
	{
		super ();
		if (getClass () == TagAdapter_OnDataChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Zhy.View.Flowlayout.TagAdapter+IOnDataChangedListenerImplementor, Caka.TabFlow.Droid", "", this, new java.lang.Object[] {  });
	}


	public void onChanged ()
	{
		n_onChanged ();
	}

	private native void n_onChanged ();

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
