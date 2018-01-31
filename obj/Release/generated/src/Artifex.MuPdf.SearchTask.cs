using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SearchTask']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/SearchTask", DoNotGenerateAcw=true)]
	public abstract partial class SearchTask : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/SearchTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SearchTask); }
		}

		protected SearchTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_MuPDFCore_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SearchTask']/constructor[@name='SearchTask' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.artifex.mupdfdemo.MuPDFCore']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/artifex/mupdfdemo/MuPDFCore;)V", "")]
		public unsafe SearchTask (global::Android.Content.Context p0, global::Artifex.MuPdf.MuPDFCore p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SearchTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/artifex/mupdfdemo/MuPDFCore;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/artifex/mupdfdemo/MuPDFCore;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_MuPDFCore_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_MuPDFCore_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/artifex/mupdfdemo/MuPDFCore;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_MuPDFCore_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_MuPDFCore_, __args);
			} finally {
			}
		}

		static Delegate cb_go_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetGo_Ljava_lang_String_IIIHandler ()
		{
			if (cb_go_Ljava_lang_String_III == null)
				cb_go_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_Go_Ljava_lang_String_III);
			return cb_go_Ljava_lang_String_III;
		}

		static void n_Go_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Artifex.MuPdf.SearchTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.SearchTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Go (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_go_Ljava_lang_String_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SearchTask']/method[@name='go' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("go", "(Ljava/lang/String;III)V", "GetGo_Ljava_lang_String_IIIHandler")]
		public virtual unsafe void Go (string p0, int p1, int p2, int p3)
		{
			if (id_go_Ljava_lang_String_III == IntPtr.Zero)
				id_go_Ljava_lang_String_III = JNIEnv.GetMethodID (class_ref, "go", "(Ljava/lang/String;III)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_go_Ljava_lang_String_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "go", "(Ljava/lang/String;III)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_;
#pragma warning disable 0169
		static Delegate GetOnTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_Handler ()
		{
			if (cb_onTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_ == null)
				cb_onTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_);
			return cb_onTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_;
		}

		static void n_OnTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.SearchTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.SearchTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Artifex.MuPdf.SearchTaskResult p0 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.SearchTaskResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTextFound (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SearchTask']/method[@name='onTextFound' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.SearchTaskResult']]"
		[Register ("onTextFound", "(Lcom/artifex/mupdfdemo/SearchTaskResult;)V", "GetOnTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_Handler")]
		protected abstract void OnTextFound (global::Artifex.MuPdf.SearchTaskResult p0);

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.SearchTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.SearchTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SearchTask']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/SearchTask", DoNotGenerateAcw=true)]
	internal partial class SearchTaskInvoker : SearchTask {

		public SearchTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SearchTaskInvoker); }
		}

		static IntPtr id_onTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SearchTask']/method[@name='onTextFound' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.SearchTaskResult']]"
		[Register ("onTextFound", "(Lcom/artifex/mupdfdemo/SearchTaskResult;)V", "GetOnTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_Handler")]
		protected override unsafe void OnTextFound (global::Artifex.MuPdf.SearchTaskResult p0)
		{
			if (id_onTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_ == IntPtr.Zero)
				id_onTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_ = JNIEnv.GetMethodID (class_ref, "onTextFound", "(Lcom/artifex/mupdfdemo/SearchTaskResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTextFound_Lcom_artifex_mupdfdemo_SearchTaskResult_, __args);
			} finally {
			}
		}

	}

}
