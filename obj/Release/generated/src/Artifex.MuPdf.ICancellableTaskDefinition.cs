using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='CancellableTaskDefinition']"
	[Register ("com/artifex/mupdfdemo/CancellableTaskDefinition", "", "Artifex.MuPdf.ICancellableTaskDefinitionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Params", "Result"})]
	public partial interface ICancellableTaskDefinition : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='CancellableTaskDefinition']/method[@name='doCancel' and count(parameter)=0]"
		[Register ("doCancel", "()V", "GetDoCancelHandler:Artifex.MuPdf.ICancellableTaskDefinitionInvoker, MuPdfibrary")]
		void DoCancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='CancellableTaskDefinition']/method[@name='doCleanup' and count(parameter)=0]"
		[Register ("doCleanup", "()V", "GetDoCleanupHandler:Artifex.MuPdf.ICancellableTaskDefinitionInvoker, MuPdfibrary")]
		void DoCleanup ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='CancellableTaskDefinition']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='Params...']]"
		[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler:Artifex.MuPdf.ICancellableTaskDefinitionInvoker, MuPdfibrary")]
		global::Java.Lang.Object DoInBackground (params global:: Java.Lang.Object[] p0);

	}

	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/CancellableTaskDefinition", DoNotGenerateAcw=true)]
	internal class ICancellableTaskDefinitionInvoker : global::Java.Lang.Object, ICancellableTaskDefinition {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/artifex/mupdfdemo/CancellableTaskDefinition");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICancellableTaskDefinitionInvoker); }
		}

		IntPtr class_ref;

		public static ICancellableTaskDefinition GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICancellableTaskDefinition> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.artifex.mupdfdemo.CancellableTaskDefinition"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICancellableTaskDefinitionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Artifex.MuPdf.ICancellableTaskDefinition __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ICancellableTaskDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoCancel ();
		}
#pragma warning restore 0169

		IntPtr id_doCancel;
		public unsafe void DoCancel ()
		{
			if (id_doCancel == IntPtr.Zero)
				id_doCancel = JNIEnv.GetMethodID (class_ref, "doCancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doCancel);
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
			global::Artifex.MuPdf.ICancellableTaskDefinition __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ICancellableTaskDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoCleanup ();
		}
#pragma warning restore 0169

		IntPtr id_doCleanup;
		public unsafe void DoCleanup ()
		{
			if (id_doCleanup == IntPtr.Zero)
				id_doCleanup = JNIEnv.GetMethodID (class_ref, "doCleanup", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doCleanup);
		}

		static Delegate cb_doInBackground_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler ()
		{
			if (cb_doInBackground_arrayLjava_lang_Object_ == null)
				cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Object_);
			return cb_doInBackground_arrayLjava_lang_Object_;
		}

		static IntPtr n_DoInBackground_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ICancellableTaskDefinition __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ICancellableTaskDefinition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_doInBackground_arrayLjava_lang_Object_;
		public unsafe global::Java.Lang.Object DoInBackground (params global:: Java.Lang.Object[] p0)
		{
			if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
