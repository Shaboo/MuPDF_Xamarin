using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFReaderView", DoNotGenerateAcw=true)]
	public partial class MuPDFReaderView : global::Artifex.MuPdf.ReaderView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView.Mode']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFReaderView$Mode", DoNotGenerateAcw=true)]
		public sealed partial class Mode : global::Java.Lang.Enum {


			static IntPtr Drawing_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView.Mode']/field[@name='Drawing']"
			[Register ("Drawing")]
			public static global::Artifex.MuPdf.MuPDFReaderView.Mode Drawing {
				get {
					if (Drawing_jfieldId == IntPtr.Zero)
						Drawing_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Drawing", "Lcom/artifex/mupdfdemo/MuPDFReaderView$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Drawing_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReaderView.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Selecting_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView.Mode']/field[@name='Selecting']"
			[Register ("Selecting")]
			public static global::Artifex.MuPdf.MuPDFReaderView.Mode Selecting {
				get {
					if (Selecting_jfieldId == IntPtr.Zero)
						Selecting_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Selecting", "Lcom/artifex/mupdfdemo/MuPDFReaderView$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Selecting_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReaderView.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Viewing_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView.Mode']/field[@name='Viewing']"
			[Register ("Viewing")]
			public static global::Artifex.MuPdf.MuPDFReaderView.Mode Viewing {
				get {
					if (Viewing_jfieldId == IntPtr.Zero)
						Viewing_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Viewing", "Lcom/artifex/mupdfdemo/MuPDFReaderView$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Viewing_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReaderView.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFReaderView$Mode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Mode); }
			}

			internal Mode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView.Mode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/artifex/mupdfdemo/MuPDFReaderView$Mode;", "")]
			public static unsafe global::Artifex.MuPdf.MuPDFReaderView.Mode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/artifex/mupdfdemo/MuPDFReaderView$Mode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Artifex.MuPdf.MuPDFReaderView.Mode __ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReaderView.Mode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView.Mode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/artifex/mupdfdemo/MuPDFReaderView$Mode;", "")]
			public static unsafe global::Artifex.MuPdf.MuPDFReaderView.Mode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/artifex/mupdfdemo/MuPDFReaderView$Mode;");
				try {
					return (global::Artifex.MuPdf.MuPDFReaderView.Mode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.MuPDFReaderView.Mode));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFReaderView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuPDFReaderView); }
		}

		protected MuPDFReaderView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView']/constructor[@name='MuPDFReaderView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MuPDFReaderView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MuPDFReaderView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView']/constructor[@name='MuPDFReaderView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MuPDFReaderView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MuPDFReaderView)) {
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

		static Delegate cb_onDocMotion;
#pragma warning disable 0169
		static Delegate GetOnDocMotionHandler ()
		{
			if (cb_onDocMotion == null)
				cb_onDocMotion = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDocMotion);
			return cb_onDocMotion;
		}

		static void n_OnDocMotion (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDocMotion ();
		}
#pragma warning restore 0169

		static IntPtr id_onDocMotion;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView']/method[@name='onDocMotion' and count(parameter)=0]"
		[Register ("onDocMotion", "()V", "GetOnDocMotionHandler")]
		protected virtual unsafe void OnDocMotion ()
		{
			if (id_onDocMotion == IntPtr.Zero)
				id_onDocMotion = JNIEnv.GetMethodID (class_ref, "onDocMotion", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDocMotion);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDocMotion", "()V"));
			} finally {
			}
		}

		static Delegate cb_onTapMainDocArea;
#pragma warning disable 0169
		static Delegate GetOnTapMainDocAreaHandler ()
		{
			if (cb_onTapMainDocArea == null)
				cb_onTapMainDocArea = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTapMainDocArea);
			return cb_onTapMainDocArea;
		}

		static void n_OnTapMainDocArea (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTapMainDocArea ();
		}
#pragma warning restore 0169

		static IntPtr id_onTapMainDocArea;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView']/method[@name='onTapMainDocArea' and count(parameter)=0]"
		[Register ("onTapMainDocArea", "()V", "GetOnTapMainDocAreaHandler")]
		protected virtual unsafe void OnTapMainDocArea ()
		{
			if (id_onTapMainDocArea == IntPtr.Zero)
				id_onTapMainDocArea = JNIEnv.GetMethodID (class_ref, "onTapMainDocArea", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTapMainDocArea);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTapMainDocArea", "()V"));
			} finally {
			}
		}

		static Delegate cb_setLinksEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetLinksEnabled_ZHandler ()
		{
			if (cb_setLinksEnabled_Z == null)
				cb_setLinksEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLinksEnabled_Z);
			return cb_setLinksEnabled_Z;
		}

		static void n_SetLinksEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Artifex.MuPdf.MuPDFReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLinksEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLinksEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView']/method[@name='setLinksEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLinksEnabled", "(Z)V", "GetSetLinksEnabled_ZHandler")]
		public virtual unsafe void SetLinksEnabled (bool p0)
		{
			if (id_setLinksEnabled_Z == IntPtr.Zero)
				id_setLinksEnabled_Z = JNIEnv.GetMethodID (class_ref, "setLinksEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLinksEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLinksEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMode_Lcom_artifex_mupdfdemo_MuPDFReaderView_Mode_;
#pragma warning disable 0169
		static Delegate GetSetMode_Lcom_artifex_mupdfdemo_MuPDFReaderView_Mode_Handler ()
		{
			if (cb_setMode_Lcom_artifex_mupdfdemo_MuPDFReaderView_Mode_ == null)
				cb_setMode_Lcom_artifex_mupdfdemo_MuPDFReaderView_Mode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMode_Lcom_artifex_mupdfdemo_MuPDFReaderView_Mode_);
			return cb_setMode_Lcom_artifex_mupdfdemo_MuPDFReaderView_Mode_;
		}

		static void n_SetMode_Lcom_artifex_mupdfdemo_MuPDFReaderView_Mode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFReaderView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReaderView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Artifex.MuPdf.MuPDFReaderView.Mode p0 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReaderView.Mode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMode_Lcom_artifex_mupdfdemo_MuPDFReaderView_Mode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReaderView']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.MuPDFReaderView.Mode']]"
		[Register ("setMode", "(Lcom/artifex/mupdfdemo/MuPDFReaderView$Mode;)V", "GetSetMode_Lcom_artifex_mupdfdemo_MuPDFReaderView_Mode_Handler")]
		public virtual unsafe void SetMode (global::Artifex.MuPdf.MuPDFReaderView.Mode p0)
		{
			if (id_setMode_Lcom_artifex_mupdfdemo_MuPDFReaderView_Mode_ == IntPtr.Zero)
				id_setMode_Lcom_artifex_mupdfdemo_MuPDFReaderView_Mode_ = JNIEnv.GetMethodID (class_ref, "setMode", "(Lcom/artifex/mupdfdemo/MuPDFReaderView$Mode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMode_Lcom_artifex_mupdfdemo_MuPDFReaderView_Mode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMode", "(Lcom/artifex/mupdfdemo/MuPDFReaderView$Mode;)V"), __args);
			} finally {
			}
		}

	}
}
