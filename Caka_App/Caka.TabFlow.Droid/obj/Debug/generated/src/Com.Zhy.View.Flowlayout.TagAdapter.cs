using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Zhy.View.Flowlayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']"
	[global::Android.Runtime.Register ("com/zhy/view/flowlayout/TagAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class TagAdapter : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.zhy.view.flowlayout']/interface[@name='TagAdapter.OnDataChangedListener']"
		[Register ("com/zhy/view/flowlayout/TagAdapter$OnDataChangedListener", "", "Com.Zhy.View.Flowlayout.TagAdapter/IOnDataChangedListenerInvoker")]
		public partial interface IOnDataChangedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/interface[@name='TagAdapter.OnDataChangedListener']/method[@name='onChanged' and count(parameter)=0]"
			[Register ("onChanged", "()V", "GetOnChangedHandler:Com.Zhy.View.Flowlayout.TagAdapter/IOnDataChangedListenerInvoker, Caka.TabFlow.Droid")]
			void OnChanged ();

		}

		[global::Android.Runtime.Register ("com/zhy/view/flowlayout/TagAdapter$OnDataChangedListener", DoNotGenerateAcw=true)]
		internal class IOnDataChangedListenerInvoker : global::Java.Lang.Object, IOnDataChangedListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/zhy/view/flowlayout/TagAdapter$OnDataChangedListener", typeof (IOnDataChangedListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnDataChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDataChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.zhy.view.flowlayout.TagAdapter.OnDataChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDataChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onChanged;
#pragma warning disable 0169
			static Delegate GetOnChangedHandler ()
			{
				if (cb_onChanged == null)
					cb_onChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnChanged);
				return cb_onChanged;
			}

			static void n_OnChanged (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Zhy.View.Flowlayout.TagAdapter.IOnDataChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagAdapter.IOnDataChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnChanged ();
			}
#pragma warning restore 0169

			IntPtr id_onChanged;
			public unsafe void OnChanged ()
			{
				if (id_onChanged == IntPtr.Zero)
					id_onChanged = JNIEnv.GetMethodID (class_ref, "onChanged", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChanged);
			}

		}

		[global::Android.Runtime.Register ("mono/com/zhy/view/flowlayout/TagAdapter_OnDataChangedListenerImplementor")]
		internal sealed partial class IOnDataChangedListenerImplementor : global::Java.Lang.Object, IOnDataChangedListener {

			object sender;

			public IOnDataChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/zhy/view/flowlayout/TagAdapter_OnDataChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnChanged ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnDataChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/zhy/view/flowlayout/TagAdapter", typeof (TagAdapter));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected TagAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']/constructor[@name='TagAdapter' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe TagAdapter (global::System.Collections.IList datas)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_datas = global::Android.Runtime.JavaList.ToLocalJniHandle (datas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_datas);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_datas);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']/constructor[@name='TagAdapter' and count(parameter)=1 and parameter[1][@type='T[]']]"
		[Register (".ctor", "([Ljava/lang/Object;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe TagAdapter (global::Java.Lang.Object[] datas)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_datas = JNIEnv.NewArray (datas);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_datas);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (datas != null) {
					JNIEnv.CopyArray (native_datas, datas);
					JNIEnv.DeleteLocalRef (native_datas);
				}
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Zhy.View.Flowlayout.TagAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		public virtual unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::Com.Zhy.View.Flowlayout.TagAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (position));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
		public virtual unsafe global::Java.Lang.Object GetItem (int position)
		{
			const string __id = "getItem.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getView_Lcom_zhy_view_flowlayout_FlowLayout_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetView_Lcom_zhy_view_flowlayout_FlowLayout_ILjava_lang_Object_Handler ()
		{
			if (cb_getView_Lcom_zhy_view_flowlayout_FlowLayout_ILjava_lang_Object_ == null)
				cb_getView_Lcom_zhy_view_flowlayout_FlowLayout_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetView_Lcom_zhy_view_flowlayout_FlowLayout_ILjava_lang_Object_);
			return cb_getView_Lcom_zhy_view_flowlayout_FlowLayout_ILjava_lang_Object_;
		}

		static IntPtr n_GetView_Lcom_zhy_view_flowlayout_FlowLayout_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Zhy.View.Flowlayout.TagAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Zhy.View.Flowlayout.FlowLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.FlowLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='com.zhy.view.flowlayout.FlowLayout'] and parameter[2][@type='int'] and parameter[3][@type='T']]"
		[Register ("getView", "(Lcom/zhy/view/flowlayout/FlowLayout;ILjava/lang/Object;)Landroid/view/View;", "GetGetView_Lcom_zhy_view_flowlayout_FlowLayout_ILjava_lang_Object_Handler")]
		public abstract global::Android.Views.View GetView (global::Com.Zhy.View.Flowlayout.FlowLayout p0, int p1, global::Java.Lang.Object p2);

		static Delegate cb_notifyDataChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataChangedHandler ()
		{
			if (cb_notifyDataChanged == null)
				cb_notifyDataChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataChanged);
			return cb_notifyDataChanged;
		}

		static void n_NotifyDataChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Zhy.View.Flowlayout.TagAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']/method[@name='notifyDataChanged' and count(parameter)=0]"
		[Register ("notifyDataChanged", "()V", "GetNotifyDataChangedHandler")]
		public virtual unsafe void NotifyDataChanged ()
		{
			const string __id = "notifyDataChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onSelected_ILandroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnSelected_ILandroid_view_View_Handler ()
		{
			if (cb_onSelected_ILandroid_view_View_ == null)
				cb_onSelected_ILandroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnSelected_ILandroid_view_View_);
			return cb_onSelected_ILandroid_view_View_;
		}

		static void n_OnSelected_ILandroid_view_View_ (IntPtr jnienv, IntPtr native__this, int position, IntPtr native_view)
		{
			global::Com.Zhy.View.Flowlayout.TagAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.OnSelected (position, view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']/method[@name='onSelected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.View']]"
		[Register ("onSelected", "(ILandroid/view/View;)V", "GetOnSelected_ILandroid_view_View_Handler")]
		public virtual unsafe void OnSelected (int position, global::Android.Views.View view)
		{
			const string __id = "onSelected.(ILandroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (position);
				__args [1] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSelected_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetSelected_ILjava_lang_Object_Handler ()
		{
			if (cb_setSelected_ILjava_lang_Object_ == null)
				cb_setSelected_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_SetSelected_ILjava_lang_Object_);
			return cb_setSelected_ILjava_lang_Object_;
		}

		static bool n_SetSelected_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int position, IntPtr native_t)
		{
			global::Com.Zhy.View.Flowlayout.TagAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object t = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_t, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetSelected (position, t);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']/method[@name='setSelected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("setSelected", "(ILjava/lang/Object;)Z", "GetSetSelected_ILjava_lang_Object_Handler")]
		public virtual unsafe bool SetSelected (int position, global::Java.Lang.Object t)
		{
			const string __id = "setSelected.(ILjava/lang/Object;)Z";
			IntPtr native_t = JNIEnv.ToLocalJniHandle (t);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (position);
				__args [1] = new JniArgumentValue (native_t);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_t);
			}
		}

		static Delegate cb_setSelectedList_arrayI;
#pragma warning disable 0169
		static Delegate GetSetSelectedList_arrayIHandler ()
		{
			if (cb_setSelectedList_arrayI == null)
				cb_setSelectedList_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectedList_arrayI);
			return cb_setSelectedList_arrayI;
		}

		static void n_SetSelectedList_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_poses)
		{
			global::Com.Zhy.View.Flowlayout.TagAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] poses = (int[]) JNIEnv.GetArray (native_poses, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetSelectedList (poses);
			if (poses != null)
				JNIEnv.CopyArray (poses, native_poses);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']/method[@name='setSelectedList' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Obsolete (@"deprecated")]
		[Register ("setSelectedList", "([I)V", "GetSetSelectedList_arrayIHandler")]
		public virtual unsafe void SetSelectedList (params int[] poses)
		{
			const string __id = "setSelectedList.([I)V";
			IntPtr native_poses = JNIEnv.NewArray (poses);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_poses);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (poses != null) {
					JNIEnv.CopyArray (native_poses, poses);
					JNIEnv.DeleteLocalRef (native_poses);
				}
			}
		}

		static Delegate cb_setSelectedList_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetSelectedList_Ljava_util_Set_Handler ()
		{
			if (cb_setSelectedList_Ljava_util_Set_ == null)
				cb_setSelectedList_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectedList_Ljava_util_Set_);
			return cb_setSelectedList_Ljava_util_Set_;
		}

		static void n_SetSelectedList_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_set)
		{
			global::Com.Zhy.View.Flowlayout.TagAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var set = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (native_set, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectedList (set);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']/method[@name='setSelectedList' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.Integer&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("setSelectedList", "(Ljava/util/Set;)V", "GetSetSelectedList_Ljava_util_Set_Handler")]
		public virtual unsafe void SetSelectedList (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> set)
		{
			const string __id = "setSelectedList.(Ljava/util/Set;)V";
			IntPtr native_set = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (set);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_set);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_set);
			}
		}

		static Delegate cb_unSelected_ILandroid_view_View_;
#pragma warning disable 0169
		static Delegate GetUnSelected_ILandroid_view_View_Handler ()
		{
			if (cb_unSelected_ILandroid_view_View_ == null)
				cb_unSelected_ILandroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_UnSelected_ILandroid_view_View_);
			return cb_unSelected_ILandroid_view_View_;
		}

		static void n_UnSelected_ILandroid_view_View_ (IntPtr jnienv, IntPtr native__this, int position, IntPtr native_view)
		{
			global::Com.Zhy.View.Flowlayout.TagAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.UnSelected (position, view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']/method[@name='unSelected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.View']]"
		[Register ("unSelected", "(ILandroid/view/View;)V", "GetUnSelected_ILandroid_view_View_Handler")]
		public virtual unsafe void UnSelected (int position, global::Android.Views.View view)
		{
			const string __id = "unSelected.(ILandroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (position);
				__args [1] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/zhy/view/flowlayout/TagAdapter", DoNotGenerateAcw=true)]
	internal partial class TagAdapterInvoker : TagAdapter {

		public TagAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/zhy/view/flowlayout/TagAdapter", typeof (TagAdapterInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='com.zhy.view.flowlayout.FlowLayout'] and parameter[2][@type='int'] and parameter[3][@type='T']]"
		[Register ("getView", "(Lcom/zhy/view/flowlayout/FlowLayout;ILjava/lang/Object;)Landroid/view/View;", "GetGetView_Lcom_zhy_view_flowlayout_FlowLayout_ILjava_lang_Object_Handler")]
		public override unsafe global::Android.Views.View GetView (global::Com.Zhy.View.Flowlayout.FlowLayout p0, int p1, global::Java.Lang.Object p2)
		{
			const string __id = "getView.(Lcom/zhy/view/flowlayout/FlowLayout;ILjava/lang/Object;)Landroid/view/View;";
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

}
