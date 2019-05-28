package md5e938e9d3275bd6f37b714d127b06e428;


public class ItemTagModel
	extends com.zhy.view.flowlayout.TagAdapter
	implements
		mono.android.IGCUserPeer,
		com.zhy.view.flowlayout.TagAdapter.OnDataChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getView:(Lcom/zhy/view/flowlayout/FlowLayout;ILjava/lang/Object;)Landroid/view/View;:GetGetView_Lcom_zhy_view_flowlayout_FlowLayout_ILjava_lang_Object_Handler\n" +
			"n_onChanged:()V:GetOnChangedHandler:Com.Zhy.View.Flowlayout.TagAdapter/IOnDataChangedListenerInvoker, Caka.TabFlow.Droid\n" +
			"";
		mono.android.Runtime.register ("Caka_App.Activities.ItemTagModel, Caka_App", ItemTagModel.class, __md_methods);
	}


	public ItemTagModel (java.util.List p0)
	{
		super (p0);
		if (getClass () == ItemTagModel.class)
			mono.android.TypeManager.Activate ("Caka_App.Activities.ItemTagModel, Caka_App", "System.Collections.IList, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public ItemTagModel (java.lang.Object[] p0)
	{
		super (p0);
		if (getClass () == ItemTagModel.class)
			mono.android.TypeManager.Activate ("Caka_App.Activities.ItemTagModel, Caka_App", "Java.Lang.Object[], Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public android.view.View getView (com.zhy.view.flowlayout.FlowLayout p0, int p1, java.lang.Object p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (com.zhy.view.flowlayout.FlowLayout p0, int p1, java.lang.Object p2);


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
