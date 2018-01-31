using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='CancellableAsyncTask']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/CancellableAsyncTask", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Params", "Result"})]
	public partial class CancellableAsyncTask : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/CancellableAsyncTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CancellableAsyncTask); }
		}

		protected CancellableAsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_artifex_mupdfdemo_CancellableTaskDefinition_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='CancellableAsyncTask']/constructor[@name='CancellableAsyncTask' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.CancellableTaskDefinition&lt;Params, Result&gt;']]"
		[Register (".ctor", "(Lcom/artifex/mupdfdemo/CancellableTaskDefinition;)V", "")]
		public unsafe CancellableAsyncTask (global::Artifex.MuPdf.ICancellableTaskDefinition p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CancellableAsyncTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/artifex/mupdfdemo/CancellableTaskDefinition;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/artifex/mupdfdemo/CancellableTaskDefinition;)V", __args);
					return;
				}

				if (id_ctor_Lcom_artifex_mupdfdemo_CancellableTaskDefinition_ == IntPtr.Zero)
					id_ctor_Lcom_artifex_mupdfdemo_CancellableTaskDefinition_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/artifex/mupdfdemo/CancellableTaskDefinition;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_artifex_mupdfdemo_CancellableTaskDefinition_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_artifex_mupdfdemo_CancellableTaskDefinition_, __args);
			} finally {
			}
		}

		static Delegate cb_cancelAndWait;
#pragma warning disable 0169
		static Delegate GetCancelAndWaitHandler ()
		{
			if (cb_cancelAndWait == null)
				cb_cancelAndWait = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelAndWait);
			return cb_cancelAndWait;
		}

		static void n_CancelAndWait (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.CancellableAsyncTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.CancellableAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelAndWait ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelAndWait;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='CancellableAsyncTask']/method[@name='cancelAndWait' and count(parameter)=0]"
		[Register ("cancelAndWait", "()V", "GetCancelAndWaitHandler")]
		public virtual unsafe void CancelAndWait ()
		{
			if (id_cancelAndWait == IntPtr.Zero)
				id_cancelAndWait = JNIEnv.GetMethodID (class_ref, "cancelAndWait", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelAndWait);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelAndWait", "()V"));
			} finally {
			}
		}

		static Delegate cb_execute_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetExecute_arrayLjava_lang_Object_Handler ()
		{
			if (cb_execute_arrayLjava_lang_Object_ == null)
				cb_execute_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Execute_arrayLjava_lang_Object_);
			return cb_execute_arrayLjava_lang_Object_;
		}

		static void n_Execute_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.CancellableAsyncTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.CancellableAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Execute (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_execute_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='CancellableAsyncTask']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='Params...']]"
		[Register ("execute", "([Ljava/lang/Object;)V", "GetExecute_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void Execute (params global:: Java.Lang.Object[] p0)
		{
			if (id_execute_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_execute_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "execute", "([Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute_arrayLjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "([Ljava/lang/Object;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_onPostExecute_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnPostExecute_Ljava_lang_Object_Handler ()
		{
			if (cb_onPostExecute_Ljava_lang_Object_ == null)
				cb_onPostExecute_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Object_);
			return cb_onPostExecute_Ljava_lang_Object_;
		}

		static void n_OnPostExecute_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.CancellableAsyncTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.CancellableAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='CancellableAsyncTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='Result']]"
		[Register ("onPostExecute", "(Ljava/lang/Object;)V", "GetOnPostExecute_Ljava_lang_Object_Handler")]
		public virtual unsafe void OnPostExecute (global::Java.Lang.Object p0)
		{
			if (id_onPostExecute_Ljava_lang_Object_ == IntPtr.Zero)
				id_onPostExecute_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPostExecute_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onPreExecute;
#pragma warning disable 0169
		static Delegate GetOnPreExecuteHandler ()
		{
			if (cb_onPreExecute == null)
				cb_onPreExecute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPreExecute);
			return cb_onPreExecute;
		}

		static void n_OnPreExecute (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.CancellableAsyncTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.CancellableAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPreExecute ();
		}
#pragma warning restore 0169

		static IntPtr id_onPreExecute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='CancellableAsyncTask']/method[@name='onPreExecute' and count(parameter)=0]"
		[Register ("onPreExecute", "()V", "GetOnPreExecuteHandler")]
		public virtual unsafe void OnPreExecute ()
		{
			if (id_onPreExecute == IntPtr.Zero)
				id_onPreExecute = JNIEnv.GetMethodID (class_ref, "onPreExecute", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPreExecute);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreExecute", "()V"));
			} finally {
			}
		}

	}
}
