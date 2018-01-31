using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='FilePicker']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/FilePicker", DoNotGenerateAcw=true)]
	public abstract partial class FilePicker : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='FilePicker.FilePickerSupport']"
		[Register ("com/artifex/mupdfdemo/FilePicker$FilePickerSupport", "", "Artifex.MuPdf.FilePicker/IFilePickerSupportInvoker")]
		public partial interface IFilePickerSupport : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='FilePicker.FilePickerSupport']/method[@name='performPickFor' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.FilePicker']]"
			[Register ("performPickFor", "(Lcom/artifex/mupdfdemo/FilePicker;)V", "GetPerformPickFor_Lcom_artifex_mupdfdemo_FilePicker_Handler:Artifex.MuPdf.FilePicker/IFilePickerSupportInvoker, MuPdfibrary")]
			void PerformPickFor (global::Artifex.MuPdf.FilePicker p0);

		}

		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/FilePicker$FilePickerSupport", DoNotGenerateAcw=true)]
		internal class IFilePickerSupportInvoker : global::Java.Lang.Object, IFilePickerSupport {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/artifex/mupdfdemo/FilePicker$FilePickerSupport");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFilePickerSupportInvoker); }
			}

			IntPtr class_ref;

			public static IFilePickerSupport GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFilePickerSupport> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.artifex.mupdfdemo.FilePicker.FilePickerSupport"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFilePickerSupportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_;
#pragma warning disable 0169
			static Delegate GetPerformPickFor_Lcom_artifex_mupdfdemo_FilePicker_Handler ()
			{
				if (cb_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_ == null)
					cb_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PerformPickFor_Lcom_artifex_mupdfdemo_FilePicker_);
				return cb_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_;
			}

			static void n_PerformPickFor_Lcom_artifex_mupdfdemo_FilePicker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Artifex.MuPdf.FilePicker.IFilePickerSupport __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.FilePicker.IFilePickerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Artifex.MuPdf.FilePicker p0 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.FilePicker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.PerformPickFor (p0);
			}
#pragma warning restore 0169

			IntPtr id_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_;
			public unsafe void PerformPickFor (global::Artifex.MuPdf.FilePicker p0)
			{
				if (id_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_ == IntPtr.Zero)
					id_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_ = JNIEnv.GetMethodID (class_ref, "performPickFor", "(Lcom/artifex/mupdfdemo/FilePicker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_, __args);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/FilePicker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FilePicker); }
		}

		protected FilePicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/FilePicker", DoNotGenerateAcw=true)]
	internal partial class FilePickerInvoker : FilePicker {

		public FilePickerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FilePickerInvoker); }
		}

	}

}
