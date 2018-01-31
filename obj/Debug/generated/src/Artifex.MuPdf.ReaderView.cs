using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/ReaderView", DoNotGenerateAcw=true)]
	public partial class ReaderView : global::Android.Widget.AdapterView, global::Android.Views.GestureDetector.IOnGestureListener, global::Android.Views.ScaleGestureDetector.IOnScaleGestureListener, global::Java.Lang.IRunnable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView.ViewMapper']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/ReaderView$ViewMapper", DoNotGenerateAcw=true)]
		public abstract partial class ViewMapper : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/ReaderView$ViewMapper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ViewMapper); }
			}

			protected ViewMapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/ReaderView$ViewMapper", DoNotGenerateAcw=true)]
		internal partial class ViewMapperInvoker : ViewMapper {

			public ViewMapperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ViewMapperInvoker); }
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/ReaderView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReaderView); }
		}

		protected ReaderView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/constructor[@name='ReaderView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ReaderView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ReaderView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/constructor[@name='ReaderView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ReaderView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ReaderView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/constructor[@name='ReaderView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ReaderView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ReaderView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getDisplayedView;
#pragma warning disable 0169
		static Delegate GetGetDisplayedViewHandler ()
		{
			if (cb_getDisplayedView == null)
				cb_getDisplayedView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayedView);
			return cb_getDisplayedView;
		}

		static IntPtr n_GetDisplayedView (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisplayedView);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayedView;
		public virtual unsafe global::Android.Views.View DisplayedView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='getDisplayedView' and count(parameter)=0]"
			[Register ("getDisplayedView", "()Landroid/view/View;", "GetGetDisplayedViewHandler")]
			get {
				if (id_getDisplayedView == IntPtr.Zero)
					id_getDisplayedView = JNIEnv.GetMethodID (class_ref, "getDisplayedView", "()Landroid/view/View;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayedView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayedView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayedViewIndex;
#pragma warning disable 0169
		static Delegate GetGetDisplayedViewIndexHandler ()
		{
			if (cb_getDisplayedViewIndex == null)
				cb_getDisplayedViewIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayedViewIndex);
			return cb_getDisplayedViewIndex;
		}

		static int n_GetDisplayedViewIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayedViewIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayedViewIndex_I;
#pragma warning disable 0169
		static Delegate GetSetDisplayedViewIndex_IHandler ()
		{
			if (cb_setDisplayedViewIndex_I == null)
				cb_setDisplayedViewIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDisplayedViewIndex_I);
			return cb_setDisplayedViewIndex_I;
		}

		static void n_SetDisplayedViewIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayedViewIndex = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayedViewIndex;
		static IntPtr id_setDisplayedViewIndex_I;
		public virtual unsafe int DisplayedViewIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='getDisplayedViewIndex' and count(parameter)=0]"
			[Register ("getDisplayedViewIndex", "()I", "GetGetDisplayedViewIndexHandler")]
			get {
				if (id_getDisplayedViewIndex == IntPtr.Zero)
					id_getDisplayedViewIndex = JNIEnv.GetMethodID (class_ref, "getDisplayedViewIndex", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayedViewIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayedViewIndex", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='setDisplayedViewIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDisplayedViewIndex", "(I)V", "GetSetDisplayedViewIndex_IHandler")]
			set {
				if (id_setDisplayedViewIndex_I == IntPtr.Zero)
					id_setDisplayedViewIndex_I = JNIEnv.GetMethodID (class_ref, "setDisplayedViewIndex", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayedViewIndex_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayedViewIndex", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedView;
#pragma warning disable 0169
		static Delegate GetGetSelectedViewHandler ()
		{
			if (cb_getSelectedView == null)
				cb_getSelectedView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedView);
			return cb_getSelectedView;
		}

		static IntPtr n_GetSelectedView (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedView);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedView;
		public override unsafe global::Android.Views.View SelectedView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='getSelectedView' and count(parameter)=0]"
			[Register ("getSelectedView", "()Landroid/view/View;", "GetGetSelectedViewHandler")]
			get {
				if (id_getSelectedView == IntPtr.Zero)
					id_getSelectedView = JNIEnv.GetMethodID (class_ref, "getSelectedView", "()Landroid/view/View;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getView_I;
#pragma warning disable 0169
		static Delegate GetGetView_IHandler ()
		{
			if (cb_getView_I == null)
				cb_getView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetView_I);
			return cb_getView_I;
		}

		static IntPtr n_GetView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetView (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='getView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getView", "(I)Landroid/view/View;", "GetGetView_IHandler")]
		public virtual unsafe global::Android.Views.View GetView (int p0)
		{
			if (id_getView_I == IntPtr.Zero)
				id_getView_I = JNIEnv.GetMethodID (class_ref, "getView", "(I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "(I)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_moveToNext;
#pragma warning disable 0169
		static Delegate GetMoveToNextHandler ()
		{
			if (cb_moveToNext == null)
				cb_moveToNext = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MoveToNext);
			return cb_moveToNext;
		}

		static void n_MoveToNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveToNext ();
		}
#pragma warning restore 0169

		static IntPtr id_moveToNext;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='moveToNext' and count(parameter)=0]"
		[Register ("moveToNext", "()V", "GetMoveToNextHandler")]
		public virtual unsafe void MoveToNext ()
		{
			if (id_moveToNext == IntPtr.Zero)
				id_moveToNext = JNIEnv.GetMethodID (class_ref, "moveToNext", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveToNext);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveToNext", "()V"));
			} finally {
			}
		}

		static Delegate cb_moveToPrevious;
#pragma warning disable 0169
		static Delegate GetMoveToPreviousHandler ()
		{
			if (cb_moveToPrevious == null)
				cb_moveToPrevious = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MoveToPrevious);
			return cb_moveToPrevious;
		}

		static void n_MoveToPrevious (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveToPrevious ();
		}
#pragma warning restore 0169

		static IntPtr id_moveToPrevious;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='moveToPrevious' and count(parameter)=0]"
		[Register ("moveToPrevious", "()V", "GetMoveToPreviousHandler")]
		public virtual unsafe void MoveToPrevious ()
		{
			if (id_moveToPrevious == IntPtr.Zero)
				id_moveToPrevious = JNIEnv.GetMethodID (class_ref, "moveToPrevious", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveToPrevious);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveToPrevious", "()V"));
			} finally {
			}
		}

		static Delegate cb_onChildSetup_ILandroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnChildSetup_ILandroid_view_View_Handler ()
		{
			if (cb_onChildSetup_ILandroid_view_View_ == null)
				cb_onChildSetup_ILandroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnChildSetup_ILandroid_view_View_);
			return cb_onChildSetup_ILandroid_view_View_;
		}

		static void n_OnChildSetup_ILandroid_view_View_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnChildSetup (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onChildSetup_ILandroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onChildSetup' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.View']]"
		[Register ("onChildSetup", "(ILandroid/view/View;)V", "GetOnChildSetup_ILandroid_view_View_Handler")]
		protected virtual unsafe void OnChildSetup (int p0, global::Android.Views.View p1)
		{
			if (id_onChildSetup_ILandroid_view_View_ == IntPtr.Zero)
				id_onChildSetup_ILandroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onChildSetup", "(ILandroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChildSetup_ILandroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onChildSetup", "(ILandroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDown_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnDown_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onDown_Landroid_view_MotionEvent_ == null)
				cb_onDown_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDown_Landroid_view_MotionEvent_);
			return cb_onDown_Landroid_view_MotionEvent_;
		}

		static bool n_OnDown_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDown (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onDown_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onDown' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onDown", "(Landroid/view/MotionEvent;)Z", "GetOnDown_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnDown (global::Android.Views.MotionEvent p0)
		{
			if (id_onDown_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onDown_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onDown", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onDown_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDown", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
		static Delegate GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler ()
		{
			if (cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == null)
				cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF);
			return cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
		}

		static bool n_OnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnFling (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onFling' and count(parameter)=4 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", "GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler")]
		public virtual unsafe bool OnFling (global::Android.Views.MotionEvent p0, global::Android.Views.MotionEvent p1, float p2, float p3)
		{
			if (id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == IntPtr.Zero)
				id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNIEnv.GetMethodID (class_ref, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onLongPress_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnLongPress_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onLongPress_Landroid_view_MotionEvent_ == null)
				cb_onLongPress_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLongPress_Landroid_view_MotionEvent_);
			return cb_onLongPress_Landroid_view_MotionEvent_;
		}

		static void n_OnLongPress_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLongPress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLongPress_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onLongPress' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onLongPress", "(Landroid/view/MotionEvent;)V", "GetOnLongPress_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void OnLongPress (global::Android.Views.MotionEvent p0)
		{
			if (id_onLongPress_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onLongPress_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onLongPress", "(Landroid/view/MotionEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLongPress_Landroid_view_MotionEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLongPress", "(Landroid/view/MotionEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onMoveOffChild_I;
#pragma warning disable 0169
		static Delegate GetOnMoveOffChild_IHandler ()
		{
			if (cb_onMoveOffChild_I == null)
				cb_onMoveOffChild_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnMoveOffChild_I);
			return cb_onMoveOffChild_I;
		}

		static void n_OnMoveOffChild_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMoveOffChild (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onMoveOffChild_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onMoveOffChild' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onMoveOffChild", "(I)V", "GetOnMoveOffChild_IHandler")]
		protected virtual unsafe void OnMoveOffChild (int p0)
		{
			if (id_onMoveOffChild_I == IntPtr.Zero)
				id_onMoveOffChild_I = JNIEnv.GetMethodID (class_ref, "onMoveOffChild", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMoveOffChild_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMoveOffChild", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onMoveToChild_I;
#pragma warning disable 0169
		static Delegate GetOnMoveToChild_IHandler ()
		{
			if (cb_onMoveToChild_I == null)
				cb_onMoveToChild_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnMoveToChild_I);
			return cb_onMoveToChild_I;
		}

		static void n_OnMoveToChild_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMoveToChild (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onMoveToChild_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onMoveToChild' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onMoveToChild", "(I)V", "GetOnMoveToChild_IHandler")]
		protected virtual unsafe void OnMoveToChild (int p0)
		{
			if (id_onMoveToChild_I == IntPtr.Zero)
				id_onMoveToChild_I = JNIEnv.GetMethodID (class_ref, "onMoveToChild", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMoveToChild_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMoveToChild", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onNotInUse_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnNotInUse_Landroid_view_View_Handler ()
		{
			if (cb_onNotInUse_Landroid_view_View_ == null)
				cb_onNotInUse_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNotInUse_Landroid_view_View_);
			return cb_onNotInUse_Landroid_view_View_;
		}

		static void n_OnNotInUse_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNotInUse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNotInUse_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onNotInUse' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onNotInUse", "(Landroid/view/View;)V", "GetOnNotInUse_Landroid_view_View_Handler")]
		protected virtual unsafe void OnNotInUse (global::Android.Views.View p0)
		{
			if (id_onNotInUse_Landroid_view_View_ == IntPtr.Zero)
				id_onNotInUse_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onNotInUse", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotInUse_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNotInUse", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onScale_Landroid_view_ScaleGestureDetector_;
#pragma warning disable 0169
		static Delegate GetOnScale_Landroid_view_ScaleGestureDetector_Handler ()
		{
			if (cb_onScale_Landroid_view_ScaleGestureDetector_ == null)
				cb_onScale_Landroid_view_ScaleGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnScale_Landroid_view_ScaleGestureDetector_);
			return cb_onScale_Landroid_view_ScaleGestureDetector_;
		}

		static bool n_OnScale_Landroid_view_ScaleGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ScaleGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ScaleGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnScale (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onScale_Landroid_view_ScaleGestureDetector_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onScale' and count(parameter)=1 and parameter[1][@type='android.view.ScaleGestureDetector']]"
		[Register ("onScale", "(Landroid/view/ScaleGestureDetector;)Z", "GetOnScale_Landroid_view_ScaleGestureDetector_Handler")]
		public virtual unsafe bool OnScale (global::Android.Views.ScaleGestureDetector p0)
		{
			if (id_onScale_Landroid_view_ScaleGestureDetector_ == IntPtr.Zero)
				id_onScale_Landroid_view_ScaleGestureDetector_ = JNIEnv.GetMethodID (class_ref, "onScale", "(Landroid/view/ScaleGestureDetector;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onScale_Landroid_view_ScaleGestureDetector_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScale", "(Landroid/view/ScaleGestureDetector;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onScaleBegin_Landroid_view_ScaleGestureDetector_;
#pragma warning disable 0169
		static Delegate GetOnScaleBegin_Landroid_view_ScaleGestureDetector_Handler ()
		{
			if (cb_onScaleBegin_Landroid_view_ScaleGestureDetector_ == null)
				cb_onScaleBegin_Landroid_view_ScaleGestureDetector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnScaleBegin_Landroid_view_ScaleGestureDetector_);
			return cb_onScaleBegin_Landroid_view_ScaleGestureDetector_;
		}

		static bool n_OnScaleBegin_Landroid_view_ScaleGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ScaleGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ScaleGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnScaleBegin (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onScaleBegin_Landroid_view_ScaleGestureDetector_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onScaleBegin' and count(parameter)=1 and parameter[1][@type='android.view.ScaleGestureDetector']]"
		[Register ("onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z", "GetOnScaleBegin_Landroid_view_ScaleGestureDetector_Handler")]
		public virtual unsafe bool OnScaleBegin (global::Android.Views.ScaleGestureDetector p0)
		{
			if (id_onScaleBegin_Landroid_view_ScaleGestureDetector_ == IntPtr.Zero)
				id_onScaleBegin_Landroid_view_ScaleGestureDetector_ = JNIEnv.GetMethodID (class_ref, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onScaleBegin_Landroid_view_ScaleGestureDetector_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onScaleChild_Landroid_view_View_Ljava_lang_Float_;
#pragma warning disable 0169
		static Delegate GetOnScaleChild_Landroid_view_View_Ljava_lang_Float_Handler ()
		{
			if (cb_onScaleChild_Landroid_view_View_Ljava_lang_Float_ == null)
				cb_onScaleChild_Landroid_view_View_Ljava_lang_Float_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnScaleChild_Landroid_view_View_Ljava_lang_Float_);
			return cb_onScaleChild_Landroid_view_View_Ljava_lang_Float_;
		}

		static void n_OnScaleChild_Landroid_view_View_Ljava_lang_Float_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Float p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnScaleChild (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onScaleChild_Landroid_view_View_Ljava_lang_Float_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onScaleChild' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Float']]"
		[Register ("onScaleChild", "(Landroid/view/View;Ljava/lang/Float;)V", "GetOnScaleChild_Landroid_view_View_Ljava_lang_Float_Handler")]
		protected virtual unsafe void OnScaleChild (global::Android.Views.View p0, global::Java.Lang.Float p1)
		{
			if (id_onScaleChild_Landroid_view_View_Ljava_lang_Float_ == IntPtr.Zero)
				id_onScaleChild_Landroid_view_View_Ljava_lang_Float_ = JNIEnv.GetMethodID (class_ref, "onScaleChild", "(Landroid/view/View;Ljava/lang/Float;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScaleChild_Landroid_view_View_Ljava_lang_Float_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScaleChild", "(Landroid/view/View;Ljava/lang/Float;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onScaleEnd_Landroid_view_ScaleGestureDetector_;
#pragma warning disable 0169
		static Delegate GetOnScaleEnd_Landroid_view_ScaleGestureDetector_Handler ()
		{
			if (cb_onScaleEnd_Landroid_view_ScaleGestureDetector_ == null)
				cb_onScaleEnd_Landroid_view_ScaleGestureDetector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnScaleEnd_Landroid_view_ScaleGestureDetector_);
			return cb_onScaleEnd_Landroid_view_ScaleGestureDetector_;
		}

		static void n_OnScaleEnd_Landroid_view_ScaleGestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ScaleGestureDetector p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ScaleGestureDetector> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScaleEnd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onScaleEnd_Landroid_view_ScaleGestureDetector_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onScaleEnd' and count(parameter)=1 and parameter[1][@type='android.view.ScaleGestureDetector']]"
		[Register ("onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V", "GetOnScaleEnd_Landroid_view_ScaleGestureDetector_Handler")]
		public virtual unsafe void OnScaleEnd (global::Android.Views.ScaleGestureDetector p0)
		{
			if (id_onScaleEnd_Landroid_view_ScaleGestureDetector_ == IntPtr.Zero)
				id_onScaleEnd_Landroid_view_ScaleGestureDetector_ = JNIEnv.GetMethodID (class_ref, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScaleEnd_Landroid_view_ScaleGestureDetector_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
		static Delegate GetOnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler ()
		{
			if (cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == null)
				cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF);
			return cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
		}

		static bool n_OnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnScroll (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", "GetOnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler")]
		public virtual unsafe bool OnScroll (global::Android.Views.MotionEvent p0, global::Android.Views.MotionEvent p1, float p2, float p3)
		{
			if (id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == IntPtr.Zero)
				id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNIEnv.GetMethodID (class_ref, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onSettle_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnSettle_Landroid_view_View_Handler ()
		{
			if (cb_onSettle_Landroid_view_View_ == null)
				cb_onSettle_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSettle_Landroid_view_View_);
			return cb_onSettle_Landroid_view_View_;
		}

		static void n_OnSettle_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSettle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSettle_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onSettle' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onSettle", "(Landroid/view/View;)V", "GetOnSettle_Landroid_view_View_Handler")]
		protected virtual unsafe void OnSettle (global::Android.Views.View p0)
		{
			if (id_onSettle_Landroid_view_View_ == IntPtr.Zero)
				id_onSettle_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onSettle", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSettle_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSettle", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onShowPress_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnShowPress_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onShowPress_Landroid_view_MotionEvent_ == null)
				cb_onShowPress_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnShowPress_Landroid_view_MotionEvent_);
			return cb_onShowPress_Landroid_view_MotionEvent_;
		}

		static void n_OnShowPress_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnShowPress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onShowPress_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onShowPress' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onShowPress", "(Landroid/view/MotionEvent;)V", "GetOnShowPress_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void OnShowPress (global::Android.Views.MotionEvent p0)
		{
			if (id_onShowPress_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onShowPress_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onShowPress", "(Landroid/view/MotionEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onShowPress_Landroid_view_MotionEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onShowPress", "(Landroid/view/MotionEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSingleTapUp_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnSingleTapUp_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onSingleTapUp_Landroid_view_MotionEvent_ == null)
				cb_onSingleTapUp_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSingleTapUp_Landroid_view_MotionEvent_);
			return cb_onSingleTapUp_Landroid_view_MotionEvent_;
		}

		static bool n_OnSingleTapUp_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSingleTapUp (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSingleTapUp_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onSingleTapUp' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onSingleTapUp", "(Landroid/view/MotionEvent;)Z", "GetOnSingleTapUp_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnSingleTapUp (global::Android.Views.MotionEvent p0)
		{
			if (id_onSingleTapUp_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onSingleTapUp_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onSingleTapUp_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onUnsettle_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnUnsettle_Landroid_view_View_Handler ()
		{
			if (cb_onUnsettle_Landroid_view_View_ == null)
				cb_onUnsettle_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUnsettle_Landroid_view_View_);
			return cb_onUnsettle_Landroid_view_View_;
		}

		static void n_OnUnsettle_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUnsettle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onUnsettle_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='onUnsettle' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onUnsettle", "(Landroid/view/View;)V", "GetOnUnsettle_Landroid_view_View_Handler")]
		protected virtual unsafe void OnUnsettle (global::Android.Views.View p0)
		{
			if (id_onUnsettle_Landroid_view_View_ == IntPtr.Zero)
				id_onUnsettle_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onUnsettle", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnsettle_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUnsettle", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_refresh_Z;
#pragma warning disable 0169
		static Delegate GetRefresh_ZHandler ()
		{
			if (cb_refresh_Z == null)
				cb_refresh_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Refresh_Z);
			return cb_refresh_Z;
		}

		static void n_Refresh_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Refresh (p0);
		}
#pragma warning restore 0169

		static IntPtr id_refresh_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='refresh' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("refresh", "(Z)V", "GetRefresh_ZHandler")]
		public virtual unsafe void Refresh (bool p0)
		{
			if (id_refresh_Z == IntPtr.Zero)
				id_refresh_Z = JNIEnv.GetMethodID (class_ref, "refresh", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refresh_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refresh", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_resetupChildren;
#pragma warning disable 0169
		static Delegate GetResetupChildrenHandler ()
		{
			if (cb_resetupChildren == null)
				cb_resetupChildren = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetupChildren);
			return cb_resetupChildren;
		}

		static void n_ResetupChildren (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetupChildren ();
		}
#pragma warning restore 0169

		static IntPtr id_resetupChildren;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='resetupChildren' and count(parameter)=0]"
		[Register ("resetupChildren", "()V", "GetResetupChildrenHandler")]
		public virtual unsafe void ResetupChildren ()
		{
			if (id_resetupChildren == IntPtr.Zero)
				id_resetupChildren = JNIEnv.GetMethodID (class_ref, "resetupChildren", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetupChildren);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetupChildren", "()V"));
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAdapter_Landroid_widget_Adapter_;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Landroid_widget_Adapter_Handler ()
		{
			if (cb_setAdapter_Landroid_widget_Adapter_ == null)
				cb_setAdapter_Landroid_widget_Adapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdapter_Landroid_widget_Adapter_);
			return cb_setAdapter_Landroid_widget_Adapter_;
		}

		static void n_SetAdapter_Landroid_widget_Adapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.IAdapter p0 = (global::Android.Widget.IAdapter)global::Java.Lang.Object.GetObject<global::Android.Widget.IAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdapter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdapter_Landroid_widget_Adapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.Adapter']]"
		[Register ("setAdapter", "(Landroid/widget/Adapter;)V", "GetSetAdapter_Landroid_widget_Adapter_Handler")]
		public virtual unsafe void SetAdapter (global::Android.Widget.IAdapter p0)
		{
			if (id_setAdapter_Landroid_widget_Adapter_ == IntPtr.Zero)
				id_setAdapter_Landroid_widget_Adapter_ = JNIEnv.GetMethodID (class_ref, "setAdapter", "(Landroid/widget/Adapter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdapter_Landroid_widget_Adapter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdapter", "(Landroid/widget/Adapter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelection_I;
#pragma warning disable 0169
		static Delegate GetSetSelection_IHandler ()
		{
			if (cb_setSelection_I == null)
				cb_setSelection_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelection_I);
			return cb_setSelection_I;
		}

		static void n_SetSelection_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelection_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='setSelection' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelection", "(I)V", "GetSetSelection_IHandler")]
		public override unsafe void SetSelection (int p0)
		{
			if (id_setSelection_I == IntPtr.Zero)
				id_setSelection_I = JNIEnv.GetMethodID (class_ref, "setSelection", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelection_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelection", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_smartMoveBackwards;
#pragma warning disable 0169
		static Delegate GetSmartMoveBackwardsHandler ()
		{
			if (cb_smartMoveBackwards == null)
				cb_smartMoveBackwards = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SmartMoveBackwards);
			return cb_smartMoveBackwards;
		}

		static void n_SmartMoveBackwards (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmartMoveBackwards ();
		}
#pragma warning restore 0169

		static IntPtr id_smartMoveBackwards;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='smartMoveBackwards' and count(parameter)=0]"
		[Register ("smartMoveBackwards", "()V", "GetSmartMoveBackwardsHandler")]
		public virtual unsafe void SmartMoveBackwards ()
		{
			if (id_smartMoveBackwards == IntPtr.Zero)
				id_smartMoveBackwards = JNIEnv.GetMethodID (class_ref, "smartMoveBackwards", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_smartMoveBackwards);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smartMoveBackwards", "()V"));
			} finally {
			}
		}

		static Delegate cb_smartMoveForwards;
#pragma warning disable 0169
		static Delegate GetSmartMoveForwardsHandler ()
		{
			if (cb_smartMoveForwards == null)
				cb_smartMoveForwards = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SmartMoveForwards);
			return cb_smartMoveForwards;
		}

		static void n_SmartMoveForwards (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmartMoveForwards ();
		}
#pragma warning restore 0169

		static IntPtr id_smartMoveForwards;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='smartMoveForwards' and count(parameter)=0]"
		[Register ("smartMoveForwards", "()V", "GetSmartMoveForwardsHandler")]
		public virtual unsafe void SmartMoveForwards ()
		{
			if (id_smartMoveForwards == IntPtr.Zero)
				id_smartMoveForwards = JNIEnv.GetMethodID (class_ref, "smartMoveForwards", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_smartMoveForwards);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smartMoveForwards", "()V"));
			} finally {
			}
		}

	}
}
