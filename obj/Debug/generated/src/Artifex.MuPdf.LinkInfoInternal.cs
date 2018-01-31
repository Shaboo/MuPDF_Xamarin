using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoInternal']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/LinkInfoInternal", DoNotGenerateAcw=true)]
	public partial class LinkInfoInternal : global::Artifex.MuPdf.LinkInfo {


		static IntPtr pageNumber_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoInternal']/field[@name='pageNumber']"
		[Register ("pageNumber")]
		public int PageNumber {
			get {
				if (pageNumber_jfieldId == IntPtr.Zero)
					pageNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "pageNumber", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, pageNumber_jfieldId);
			}
			set {
				if (pageNumber_jfieldId == IntPtr.Zero)
					pageNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "pageNumber", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pageNumber_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/LinkInfoInternal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LinkInfoInternal); }
		}

		protected LinkInfoInternal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFFFI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoInternal']/constructor[@name='LinkInfoInternal' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int']]"
		[Register (".ctor", "(FFFFI)V", "")]
		public unsafe LinkInfoInternal (float p0, float p1, float p2, float p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (LinkInfoInternal)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(FFFFI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFFFI)V", __args);
					return;
				}

				if (id_ctor_FFFFI == IntPtr.Zero)
					id_ctor_FFFFI = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFFI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFFI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFFFI, __args);
			} finally {
			}
		}

	}
}
