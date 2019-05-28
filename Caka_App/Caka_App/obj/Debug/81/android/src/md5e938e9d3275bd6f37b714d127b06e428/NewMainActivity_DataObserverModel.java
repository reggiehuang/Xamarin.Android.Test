package md5e938e9d3275bd6f37b714d127b06e428;


public class NewMainActivity_DataObserverModel
	extends android.support.v7.widget.RecyclerView.AdapterDataObserver
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onChanged:()V:GetOnChangedHandler\n" +
			"";
		mono.android.Runtime.register ("Caka_App.Activities.NewMainActivity+DataObserverModel, Caka_App", NewMainActivity_DataObserverModel.class, __md_methods);
	}


	public NewMainActivity_DataObserverModel ()
	{
		super ();
		if (getClass () == NewMainActivity_DataObserverModel.class)
			mono.android.TypeManager.Activate ("Caka_App.Activities.NewMainActivity+DataObserverModel, Caka_App", "", this, new java.lang.Object[] {  });
	}

	public NewMainActivity_DataObserverModel (md5e938e9d3275bd6f37b714d127b06e428.MainItemAdapter p0)
	{
		super ();
		if (getClass () == NewMainActivity_DataObserverModel.class)
			mono.android.TypeManager.Activate ("Caka_App.Activities.NewMainActivity+DataObserverModel, Caka_App", "Caka_App.Activities.MainItemAdapter, Caka_App", this, new java.lang.Object[] { p0 });
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
