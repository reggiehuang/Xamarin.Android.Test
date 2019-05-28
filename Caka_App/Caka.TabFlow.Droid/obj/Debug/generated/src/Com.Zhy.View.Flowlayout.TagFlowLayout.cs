using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Zhy.View.Flowlayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagFlowLayout']"
	[global::Android.Runtime.Register ("com/zhy/view/flowlayout/TagFlowLayout", DoNotGenerateAcw=true)]
	public partial class TagFlowLayout : global::Com.Zhy.View.Flowlayout.FlowLayout, global::Com.Zhy.View.Flowlayout.TagAdapter.IOnDataChangedListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.zhy.view.flowlayout']/interface[@name='TagFlowLayout.OnSelectListener']"
		[Register ("com/zhy/view/flowlayout/TagFlowLayout$OnSelectListener", "", "Com.Zhy.View.Flowlayout.TagFlowLayout/IOnSelectListenerInvoker")]
		public partial interface IOnSelectListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/interface[@name='TagFlowLayout.OnSelectListener']/method[@name='onSelected' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.Integer&gt;']]"
			[Register ("onSelected", "(Ljava/util/Set;)V", "GetOnSelected_Ljava_util_Set_Handler:Com.Zhy.View.Flowlayout.TagFlowLayout/IOnSelectListenerInvoker, Caka.TabFlow.Droid")]
			void OnSelected (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0);

		}

		[global::Android.Runtime.Register ("com/zhy/view/flowlayout/TagFlowLayout$OnSelectListener", DoNotGenerateAcw=true)]
		internal class IOnSelectListenerInvoker : global::Java.Lang.Object, IOnSelectListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/zhy/view/flowlayout/TagFlowLayout$OnSelectListener", typeof (IOnSelectListenerInvoker));

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

			public static IOnSelectListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSelectListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.zhy.view.flowlayout.TagFlowLayout.OnSelectListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSelectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSelected_Ljava_util_Set_;
#pragma warning disable 0169
			static Delegate GetOnSelected_Ljava_util_Set_Handler ()
			{
				if (cb_onSelected_Ljava_util_Set_ == null)
					cb_onSelected_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSelected_Ljava_util_Set_);
				return cb_onSelected_Ljava_util_Set_;
			}

			static void n_OnSelected_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListener __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSelected (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSelected_Ljava_util_Set_;
			public unsafe void OnSelected (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0)
			{
				if (id_onSelected_Ljava_util_Set_ == IntPtr.Zero)
					id_onSelected_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "onSelected", "(Ljava/util/Set;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSelected_Ljava_util_Set_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// event args for com.zhy.view.flowlayout.TagFlowLayout.OnSelectListener.onSelected
		public partial class SelectEventArgs : global::System.EventArgs {

			public SelectEventArgs (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0)
			{
				this.p0 = p0;
			}

			global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0;
			public global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/zhy/view/flowlayout/TagFlowLayout_OnSelectListenerImplementor")]
		internal sealed partial class IOnSelectListenerImplementor : global::Java.Lang.Object, IOnSelectListener {

			object sender;

			public IOnSelectListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/zhy/view/flowlayout/TagFlowLayout_OnSelectListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SelectEventArgs> Handler;
#pragma warning restore 0649

			public void OnSelected (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SelectEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnSelectListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.zhy.view.flowlayout']/interface[@name='TagFlowLayout.OnTagClickListener']"
		[Register ("com/zhy/view/flowlayout/TagFlowLayout$OnTagClickListener", "", "Com.Zhy.View.Flowlayout.TagFlowLayout/IOnTagClickListenerInvoker")]
		public partial interface IOnTagClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/interface[@name='TagFlowLayout.OnTagClickListener']/method[@name='onTagClick' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='com.zhy.view.flowlayout.FlowLayout']]"
			[Register ("onTagClick", "(Landroid/view/View;ILcom/zhy/view/flowlayout/FlowLayout;)Z", "GetOnTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_Handler:Com.Zhy.View.Flowlayout.TagFlowLayout/IOnTagClickListenerInvoker, Caka.TabFlow.Droid")]
			bool OnTagClick (global::Android.Views.View p0, int p1, global::Com.Zhy.View.Flowlayout.FlowLayout p2);

		}

		[global::Android.Runtime.Register ("com/zhy/view/flowlayout/TagFlowLayout$OnTagClickListener", DoNotGenerateAcw=true)]
		internal class IOnTagClickListenerInvoker : global::Java.Lang.Object, IOnTagClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/zhy/view/flowlayout/TagFlowLayout$OnTagClickListener", typeof (IOnTagClickListenerInvoker));

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

			public static IOnTagClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnTagClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.zhy.view.flowlayout.TagFlowLayout.OnTagClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnTagClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_;
#pragma warning disable 0169
			static Delegate GetOnTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_Handler ()
			{
				if (cb_onTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_ == null)
					cb_onTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_OnTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_);
				return cb_onTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_;
			}

			static bool n_OnTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Zhy.View.Flowlayout.FlowLayout p2 = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.FlowLayout> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTagClick (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_;
			public unsafe bool OnTagClick (global::Android.Views.View p0, int p1, global::Com.Zhy.View.Flowlayout.FlowLayout p2)
			{
				if (id_onTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_ == IntPtr.Zero)
					id_onTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_ = JNIEnv.GetMethodID (class_ref, "onTagClick", "(Landroid/view/View;ILcom/zhy/view/flowlayout/FlowLayout;)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTagClick_Landroid_view_View_ILcom_zhy_view_flowlayout_FlowLayout_, __args);
				return __ret;
			}

		}

		// event args for com.zhy.view.flowlayout.TagFlowLayout.OnTagClickListener.onTagClick
		public partial class TagClickEventArgs : global::System.EventArgs {

			public TagClickEventArgs (bool handled, global::Android.Views.View p0, int p1, global::Com.Zhy.View.Flowlayout.FlowLayout p2)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			global::Com.Zhy.View.Flowlayout.FlowLayout p2;
			public global::Com.Zhy.View.Flowlayout.FlowLayout P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/zhy/view/flowlayout/TagFlowLayout_OnTagClickListenerImplementor")]
		internal sealed partial class IOnTagClickListenerImplementor : global::Java.Lang.Object, IOnTagClickListener {

			object sender;

			public IOnTagClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/zhy/view/flowlayout/TagFlowLayout_OnTagClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<TagClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnTagClick (global::Android.Views.View p0, int p1, global::Com.Zhy.View.Flowlayout.FlowLayout p2)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new TagClickEventArgs (true, p0, p1, p2);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnTagClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/zhy/view/flowlayout/TagFlowLayout", typeof (TagFlowLayout));
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

		protected TagFlowLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagFlowLayout']/constructor[@name='TagFlowLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TagFlowLayout (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagFlowLayout']/constructor[@name='TagFlowLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe TagFlowLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagFlowLayout']/constructor[@name='TagFlowLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe TagFlowLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAdapter;
#pragma warning disable 0169
		static Delegate GetGetAdapterHandler ()
		{
			if (cb_getAdapter == null)
				cb_getAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdapter);
			return cb_getAdapter;
		}

		static IntPtr n_GetAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Zhy.View.Flowlayout.TagFlowLayout __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagFlowLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Adapter);
		}
#pragma warning restore 0169

		static Delegate cb_setAdapter_Lcom_zhy_view_flowlayout_TagAdapter_;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Lcom_zhy_view_flowlayout_TagAdapter_Handler ()
		{
			if (cb_setAdapter_Lcom_zhy_view_flowlayout_TagAdapter_ == null)
				cb_setAdapter_Lcom_zhy_view_flowlayout_TagAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdapter_Lcom_zhy_view_flowlayout_TagAdapter_);
			return cb_setAdapter_Lcom_zhy_view_flowlayout_TagAdapter_;
		}

		static void n_SetAdapter_Lcom_zhy_view_flowlayout_TagAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
		{
			global::Com.Zhy.View.Flowlayout.TagFlowLayout __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagFlowLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Zhy.View.Flowlayout.TagAdapter adapter = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagAdapter> (native_adapter, JniHandleOwnership.DoNotTransfer);
			__this.Adapter = adapter;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Zhy.View.Flowlayout.TagAdapter Adapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagFlowLayout']/method[@name='getAdapter' and count(parameter)=0]"
			[Register ("getAdapter", "()Lcom/zhy/view/flowlayout/TagAdapter;", "GetGetAdapterHandler")]
			get {
				const string __id = "getAdapter.()Lcom/zhy/view/flowlayout/TagAdapter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagFlowLayout']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='com.zhy.view.flowlayout.TagAdapter']]"
			[Register ("setAdapter", "(Lcom/zhy/view/flowlayout/TagAdapter;)V", "GetSetAdapter_Lcom_zhy_view_flowlayout_TagAdapter_Handler")]
			set {
				const string __id = "setAdapter.(Lcom/zhy/view/flowlayout/TagAdapter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedList;
#pragma warning disable 0169
		static Delegate GetGetSelectedListHandler ()
		{
			if (cb_getSelectedList == null)
				cb_getSelectedList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedList);
			return cb_getSelectedList;
		}

		static IntPtr n_GetSelectedList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Zhy.View.Flowlayout.TagFlowLayout __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagFlowLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.SelectedList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> SelectedList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagFlowLayout']/method[@name='getSelectedList' and count(parameter)=0]"
			[Register ("getSelectedList", "()Ljava/util/Set;", "GetGetSelectedListHandler")]
			get {
				const string __id = "getSelectedList.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagFlowLayout']/method[@name='dip2px' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='float']]"
		[Register ("dip2px", "(Landroid/content/Context;F)I", "")]
		public static unsafe int Dip2px (global::Android.Content.Context context, float dpValue)
		{
			const string __id = "dip2px.(Landroid/content/Context;F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (dpValue);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
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
			global::Com.Zhy.View.Flowlayout.TagFlowLayout __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagFlowLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagFlowLayout']/method[@name='onChanged' and count(parameter)=0]"
		[Register ("onChanged", "()V", "GetOnChangedHandler")]
		public virtual unsafe void OnChanged ()
		{
			const string __id = "onChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setMaxSelectCount_I;
#pragma warning disable 0169
		static Delegate GetSetMaxSelectCount_IHandler ()
		{
			if (cb_setMaxSelectCount_I == null)
				cb_setMaxSelectCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxSelectCount_I);
			return cb_setMaxSelectCount_I;
		}

		static void n_SetMaxSelectCount_I (IntPtr jnienv, IntPtr native__this, int count)
		{
			global::Com.Zhy.View.Flowlayout.TagFlowLayout __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagFlowLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxSelectCount (count);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagFlowLayout']/method[@name='setMaxSelectCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxSelectCount", "(I)V", "GetSetMaxSelectCount_IHandler")]
		public virtual unsafe void SetMaxSelectCount (int count)
		{
			const string __id = "setMaxSelectCount.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (count);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnSelectListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnSelectListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSelectListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnSelectListener_Handler ()
		{
			if (cb_setOnSelectListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnSelectListener_ == null)
				cb_setOnSelectListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnSelectListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnSelectListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnSelectListener_);
			return cb_setOnSelectListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnSelectListener_;
		}

		static void n_SetOnSelectListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnSelectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onSelectListener)
		{
			global::Com.Zhy.View.Flowlayout.TagFlowLayout __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagFlowLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListener onSelectListener = (global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListener)global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListener> (native_onSelectListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnSelectListener (onSelectListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagFlowLayout']/method[@name='setOnSelectListener' and count(parameter)=1 and parameter[1][@type='com.zhy.view.flowlayout.TagFlowLayout.OnSelectListener']]"
		[Register ("setOnSelectListener", "(Lcom/zhy/view/flowlayout/TagFlowLayout$OnSelectListener;)V", "GetSetOnSelectListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnSelectListener_Handler")]
		public virtual unsafe void SetOnSelectListener (global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListener onSelectListener)
		{
			const string __id = "setOnSelectListener.(Lcom/zhy/view/flowlayout/TagFlowLayout$OnSelectListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onSelectListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onSelectListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnTagClickListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnTagClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnTagClickListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnTagClickListener_Handler ()
		{
			if (cb_setOnTagClickListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnTagClickListener_ == null)
				cb_setOnTagClickListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnTagClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnTagClickListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnTagClickListener_);
			return cb_setOnTagClickListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnTagClickListener_;
		}

		static void n_SetOnTagClickListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnTagClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onTagClickListener)
		{
			global::Com.Zhy.View.Flowlayout.TagFlowLayout __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagFlowLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListener onTagClickListener = (global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListener)global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListener> (native_onTagClickListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnTagClickListener (onTagClickListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagFlowLayout']/method[@name='setOnTagClickListener' and count(parameter)=1 and parameter[1][@type='com.zhy.view.flowlayout.TagFlowLayout.OnTagClickListener']]"
		[Register ("setOnTagClickListener", "(Lcom/zhy/view/flowlayout/TagFlowLayout$OnTagClickListener;)V", "GetSetOnTagClickListener_Lcom_zhy_view_flowlayout_TagFlowLayout_OnTagClickListener_Handler")]
		public virtual unsafe void SetOnTagClickListener (global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListener onTagClickListener)
		{
			const string __id = "setOnTagClickListener.(Lcom/zhy/view/flowlayout/TagFlowLayout$OnTagClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onTagClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onTagClickListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListener"
		public event EventHandler<global::Com.Zhy.View.Flowlayout.TagFlowLayout.SelectEventArgs> Select {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListener, global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListenerImplementor>(
						ref weak_implementor_SetOnSelectListener,
						__CreateIOnSelectListenerImplementor,
						SetOnSelectListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListener, global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListenerImplementor>(
						ref weak_implementor_SetOnSelectListener,
						global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListenerImplementor.__IsEmpty,
						__v => SetOnSelectListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnSelectListener;

		global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListenerImplementor __CreateIOnSelectListenerImplementor ()
		{
			return new global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnSelectListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListener"
		public event EventHandler<global::Com.Zhy.View.Flowlayout.TagFlowLayout.TagClickEventArgs> TagClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListener, global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListenerImplementor>(
						ref weak_implementor_SetOnTagClickListener,
						__CreateIOnTagClickListenerImplementor,
						SetOnTagClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListener, global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListenerImplementor>(
						ref weak_implementor_SetOnTagClickListener,
						global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListenerImplementor.__IsEmpty,
						__v => SetOnTagClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnTagClickListener;

		global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListenerImplementor __CreateIOnTagClickListenerImplementor ()
		{
			return new global::Com.Zhy.View.Flowlayout.TagFlowLayout.IOnTagClickListenerImplementor (this);
		}
#endregion
	}
}
