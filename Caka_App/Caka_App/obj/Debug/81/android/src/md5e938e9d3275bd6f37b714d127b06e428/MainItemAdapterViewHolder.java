package md5e938e9d3275bd6f37b714d127b06e428;


public class MainItemAdapterViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Caka_App.Activities.MainItemAdapterViewHolder, Caka_App", MainItemAdapterViewHolder.class, __md_methods);
	}


	public MainItemAdapterViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == MainItemAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("Caka_App.Activities.MainItemAdapterViewHolder, Caka_App", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
