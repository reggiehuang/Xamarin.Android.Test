using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Zhy.View.Flowlayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagView']"
	[global::Android.Runtime.Register ("com/zhy/view/flowlayout/TagView", DoNotGenerateAcw=true)]
	public partial class TagView : global::Android.Widget.FrameLayout, global::Android.Widget.ICheckable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/zhy/view/flowlayout/TagView", typeof (TagView));
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

		protected TagView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagView']/constructor[@name='TagView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TagView (global::Android.Content.Context context)
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

		static Delegate cb_isChecked;
#pragma warning disable 0169
		static Delegate GetIsCheckedHandler ()
		{
			if (cb_isChecked == null)
				cb_isChecked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsChecked);
			return cb_isChecked;
		}

		static bool n_IsChecked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Zhy.View.Flowlayout.TagView __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Checked;
		}
#pragma warning restore 0169

		static Delegate cb_setChecked_Z;
#pragma warning disable 0169
		static Delegate GetSetChecked_ZHandler ()
		{
			if (cb_setChecked_Z == null)
				cb_setChecked_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetChecked_Z);
			return cb_setChecked_Z;
		}

		static void n_SetChecked_Z (IntPtr jnienv, IntPtr native__this, bool @checked)
		{
			global::Com.Zhy.View.Flowlayout.TagView __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Checked = @checked;
		}
#pragma warning restore 0169

		public virtual unsafe bool Checked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagView']/method[@name='isChecked' and count(parameter)=0]"
			[Register ("isChecked", "()Z", "GetIsCheckedHandler")]
			get {
				const string __id = "isChecked.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagView']/method[@name='setChecked' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setChecked", "(Z)V", "GetSetChecked_ZHandler")]
			set {
				const string __id = "setChecked.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTagView;
#pragma warning disable 0169
		static Delegate GetGetTagViewHandler ()
		{
			if (cb_getTagView == null)
				cb_getTagView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTagView);
			return cb_getTagView;
		}

		static IntPtr n_GetTagView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Zhy.View.Flowlayout.TagView __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTagView ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagView']/method[@name='getTagView' and count(parameter)=0]"
		[Register ("getTagView", "()Landroid/view/View;", "GetGetTagViewHandler")]
		public virtual unsafe global::Android.Views.View GetTagView ()
		{
			const string __id = "getTagView.()Landroid/view/View;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onCreateDrawableState_I;
#pragma warning disable 0169
		static Delegate GetOnCreateDrawableState_IHandler ()
		{
			if (cb_onCreateDrawableState_I == null)
				cb_onCreateDrawableState_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_OnCreateDrawableState_I);
			return cb_onCreateDrawableState_I;
		}

		static IntPtr n_OnCreateDrawableState_I (IntPtr jnienv, IntPtr native__this, int extraSpace)
		{
			global::Com.Zhy.View.Flowlayout.TagView __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.OnCreateDrawableState (extraSpace));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagView']/method[@name='onCreateDrawableState' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCreateDrawableState", "(I)[I", "GetOnCreateDrawableState_IHandler")]
		public virtual unsafe int[] OnCreateDrawableState (int extraSpace)
		{
			const string __id = "onCreateDrawableState.(I)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (extraSpace);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_toggle;
#pragma warning disable 0169
		static Delegate GetToggleHandler ()
		{
			if (cb_toggle == null)
				cb_toggle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Toggle);
			return cb_toggle;
		}

		static void n_Toggle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Zhy.View.Flowlayout.TagView __this = global::Java.Lang.Object.GetObject<global::Com.Zhy.View.Flowlayout.TagView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Toggle ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.zhy.view.flowlayout']/class[@name='TagView']/method[@name='toggle' and count(parameter)=0]"
		[Register ("toggle", "()V", "GetToggleHandler")]
		public virtual unsafe void Toggle ()
		{
			const string __id = "toggle.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
