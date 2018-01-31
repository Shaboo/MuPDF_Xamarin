using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Stepper']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/Stepper", DoNotGenerateAcw=true)]
	public partial class Stepper : global::Java.Lang.Object {


		static IntPtr mPending_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Stepper']/field[@name='mPending']"
		[Register ("mPending")]
		protected bool MPending {
			get {
				if (mPending_jfieldId == IntPtr.Zero)
					mPending_jfieldId = JNIEnv.GetFieldID (class_ref, "mPending", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mPending_jfieldId);
			}
			set {
				if (mPending_jfieldId == IntPtr.Zero)
					mPending_jfieldId = JNIEnv.GetFieldID (class_ref, "mPending", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPending_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mPoster_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Stepper']/field[@name='mPoster']"
		[Register ("mPoster")]
		protected global::Android.Views.View MPoster {
			get {
				if (mPoster_jfieldId == IntPtr.Zero)
					mPoster_jfieldId = JNIEnv.GetFieldID (class_ref, "mPoster", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPoster_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPoster_jfieldId == IntPtr.Zero)
					mPoster_jfieldId = JNIEnv.GetFieldID (class_ref, "mPoster", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPoster_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mTask_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Stepper']/field[@name='mTask']"
		[Register ("mTask")]
		protected global::Java.Lang.IRunnable MTask {
			get {
				if (mTask_jfieldId == IntPtr.Zero)
					mTask_jfieldId = JNIEnv.GetFieldID (class_ref, "mTask", "Ljava/lang/Runnable;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTask_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTask_jfieldId == IntPtr.Zero)
					mTask_jfieldId = JNIEnv.GetFieldID (class_ref, "mTask", "Ljava/lang/Runnable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTask_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/Stepper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Stepper); }
		}

		protected Stepper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_Ljava_lang_Runnable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Stepper']/constructor[@name='Stepper' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Runnable']]"
		[Register (".ctor", "(Landroid/view/View;Ljava/lang/Runnable;)V", "")]
		public unsafe Stepper (global::Android.Views.View p0, global::Java.Lang.IRunnable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Stepper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;Ljava/lang/Runnable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;Ljava/lang/Runnable;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Ljava/lang/Runnable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Ljava_lang_Runnable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static Delegate cb_prod;
#pragma warning disable 0169
		static Delegate GetProdHandler ()
		{
			if (cb_prod == null)
				cb_prod = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Prod);
			return cb_prod;
		}

		static void n_Prod (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.Stepper __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Stepper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Prod ();
		}
#pragma warning restore 0169

		static IntPtr id_prod;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Stepper']/method[@name='prod' and count(parameter)=0]"
		[Register ("prod", "()V", "GetProdHandler")]
		public virtual unsafe void Prod ()
		{
			if (id_prod == IntPtr.Zero)
				id_prod = JNIEnv.GetMethodID (class_ref, "prod", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prod);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prod", "()V"));
			} finally {
			}
		}

	}
}
