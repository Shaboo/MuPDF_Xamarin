using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCancellableTaskDefinition']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFCancellableTaskDefinition", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Params", "Result"})]
	public abstract partial class MuPDFCancellableTaskDefinition : global::Java.Lang.Object, global::Artifex.MuPdf.ICancellableTaskDefinition {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFCancellableTaskDefinition", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuPDFCancellableTaskDefinition); }
		}

		protected MuPDFCancellableTaskDefinition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_artifex_mupdfdemo_MuPDFCore_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCancellableTaskDefinition']/constructor[@name='MuPDFCancellableTaskDefinition' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.MuPDFCore']]"
		[Register (".ctor", "(Lcom/artifex/mupdfdemo/MuPDFCore;)V", "")]
		public unsafe MuPDFCancellableTaskDefinition (global::Artifex.MuPdf.MuPDFCore p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MuPDFCancellableTaskDefinition)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/artifex/mupdfdemo/MuPDFCore;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/artifex/mupdfdemo/MuPDFCore;)V", __args);
					return;
				}

				if (id_ctor_Lcom_artifex_mupdfdemo_MuPDFCore_ == IntPtr.Zero)
					id_ctor_Lcom_artifex_mupdfdemo_MuPDFCore_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/artifex/mupdfdemo/MuPDFCore;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_artifex_mupdfdemo_MuPDFCore_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_artifex_mupdfdemo_MuPDFCore_, __args);
			} finally {
			}
		}

		static Delegate cb_doCancel;
#pragma warning disable 0169
		static Delegate GetDoCancelHandler ()
		{
			if (cb_doCancel == null)
				cb_doCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoCancel);
			return cb_doCancel;
		}

		static void n_DoCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCancellableTaskDefinition __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCancellableTaskDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoCancel ();
		}
#pragma warning restore 0169

		static IntPtr id_doCancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCancellableTaskDefinition']/method[@name='doCancel' and count(parameter)=0]"
		[Register ("doCancel", "()V", "GetDoCancelHandler")]
		public virtual unsafe void DoCancel ()
		{
			if (id_doCancel == IntPtr.Zero)
				id_doCancel = JNIEnv.GetMethodID (class_ref, "doCancel", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doCancel);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doCancel", "()V"));
			} finally {
			}
		}

		static Delegate cb_doCleanup;
#pragma warning disable 0169
		static Delegate GetDoCleanupHandler ()
		{
			if (cb_doCleanup == null)
				cb_doCleanup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoCleanup);
			return cb_doCleanup;
		}

		static void n_DoCleanup (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCancellableTaskDefinition __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCancellableTaskDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoCleanup ();
		}
#pragma warning restore 0169

		static IntPtr id_doCleanup;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCancellableTaskDefinition']/method[@name='doCleanup' and count(parameter)=0]"
		[Register ("doCleanup", "()V", "GetDoCleanupHandler")]
		public virtual unsafe void DoCleanup ()
		{
			if (id_doCleanup == IntPtr.Zero)
				id_doCleanup = JNIEnv.GetMethodID (class_ref, "doCleanup", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doCleanup);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doCleanup", "()V"));
			} finally {
			}
		}

		static IntPtr id_doInBackground_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCancellableTaskDefinition']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='Params...']]"
		[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object DoInBackground (params global:: Java.Lang.Object[] p0)
		{
			if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_doInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_Handler ()
		{
			if (cb_doInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_ == null)
				cb_doInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_);
			return cb_doInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_;
		}

		static IntPtr n_DoInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Artifex.MuPdf.MuPDFCancellableTaskDefinition __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCancellableTaskDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Artifex.MuPdf.MuPDFCore.Cookie p0 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore.Cookie> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCancellableTaskDefinition']/method[@name='doInBackground' and count(parameter)=2 and parameter[1][@type='com.artifex.mupdfdemo.MuPDFCore.Cookie'] and parameter[2][@type='Params...']]"
		[Register ("doInBackground", "(Lcom/artifex/mupdfdemo/MuPDFCore$Cookie;[Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_Handler")]
		public abstract global::Java.Lang.Object DoInBackground (global::Artifex.MuPdf.MuPDFCore.Cookie p0, params global:: Java.Lang.Object[] p1);

	}

	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFCancellableTaskDefinition", DoNotGenerateAcw=true)]
	internal partial class MuPDFCancellableTaskDefinitionInvoker : MuPDFCancellableTaskDefinition, global::Artifex.MuPdf.ICancellableTaskDefinition {

		public MuPDFCancellableTaskDefinitionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuPDFCancellableTaskDefinitionInvoker); }
		}

		static IntPtr id_doInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCancellableTaskDefinition']/method[@name='doInBackground' and count(parameter)=2 and parameter[1][@type='com.artifex.mupdfdemo.MuPDFCore.Cookie'] and parameter[2][@type='Params...']]"
		[Register ("doInBackground", "(Lcom/artifex/mupdfdemo/MuPDFCore$Cookie;[Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_Handler")]
		public override unsafe global::Java.Lang.Object DoInBackground (global::Artifex.MuPdf.MuPDFCore.Cookie p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_doInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_doInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "(Lcom/artifex/mupdfdemo/MuPDFCore$Cookie;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_Lcom_artifex_mupdfdemo_MuPDFCore_Cookie_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}

}
