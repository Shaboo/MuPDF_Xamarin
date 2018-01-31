using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SafeAnimatorInflater']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/SafeAnimatorInflater", DoNotGenerateAcw=true)]
	public partial class SafeAnimatorInflater : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/SafeAnimatorInflater", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SafeAnimatorInflater); }
		}

		protected SafeAnimatorInflater (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_ILandroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SafeAnimatorInflater']/constructor[@name='SafeAnimatorInflater' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/app/Activity;ILandroid/view/View;)V", "")]
		public unsafe SafeAnimatorInflater (global::Android.App.Activity p0, int p1, global::Android.Views.View p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (SafeAnimatorInflater)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;ILandroid/view/View;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;ILandroid/view/View;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ILandroid_view_View_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ILandroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;ILandroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_ILandroid_view_View_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_ILandroid_view_View_, __args);
			} finally {
			}
		}

	}
}
