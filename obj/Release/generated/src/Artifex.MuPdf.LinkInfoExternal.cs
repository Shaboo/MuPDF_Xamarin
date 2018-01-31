using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoExternal']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/LinkInfoExternal", DoNotGenerateAcw=true)]
	public partial class LinkInfoExternal : global::Artifex.MuPdf.LinkInfo {


		static IntPtr url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoExternal']/field[@name='url']"
		[Register ("url")]
		public string Url {
			get {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, url_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, url_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/LinkInfoExternal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LinkInfoExternal); }
		}

		protected LinkInfoExternal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFFFLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoExternal']/constructor[@name='LinkInfoExternal' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(FFFFLjava/lang/String;)V", "")]
		public unsafe LinkInfoExternal (float p0, float p1, float p2, float p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (LinkInfoExternal)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(FFFFLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFFFLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_FFFFLjava_lang_String_ == IntPtr.Zero)
					id_ctor_FFFFLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFFLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFFLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFFFLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
