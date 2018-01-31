using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoRemote']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/LinkInfoRemote", DoNotGenerateAcw=true)]
	public partial class LinkInfoRemote : global::Artifex.MuPdf.LinkInfo {


		static IntPtr fileSpec_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoRemote']/field[@name='fileSpec']"
		[Register ("fileSpec")]
		public string FileSpec {
			get {
				if (fileSpec_jfieldId == IntPtr.Zero)
					fileSpec_jfieldId = JNIEnv.GetFieldID (class_ref, "fileSpec", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, fileSpec_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (fileSpec_jfieldId == IntPtr.Zero)
					fileSpec_jfieldId = JNIEnv.GetFieldID (class_ref, "fileSpec", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fileSpec_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr newWindow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoRemote']/field[@name='newWindow']"
		[Register ("newWindow")]
		public bool NewWindow {
			get {
				if (newWindow_jfieldId == IntPtr.Zero)
					newWindow_jfieldId = JNIEnv.GetFieldID (class_ref, "newWindow", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, newWindow_jfieldId);
			}
			set {
				if (newWindow_jfieldId == IntPtr.Zero)
					newWindow_jfieldId = JNIEnv.GetFieldID (class_ref, "newWindow", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, newWindow_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr pageNumber_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoRemote']/field[@name='pageNumber']"
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
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/LinkInfoRemote", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LinkInfoRemote); }
		}

		protected LinkInfoRemote (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFFFLjava_lang_String_IZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoRemote']/constructor[@name='LinkInfoRemote' and count(parameter)=7 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int'] and parameter[7][@type='boolean']]"
		[Register (".ctor", "(FFFFLjava/lang/String;IZ)V", "")]
		public unsafe LinkInfoRemote (float p0, float p1, float p2, float p3, string p4, int p5, bool p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				if (((object) this).GetType () != typeof (LinkInfoRemote)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(FFFFLjava/lang/String;IZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFFFLjava/lang/String;IZ)V", __args);
					return;
				}

				if (id_ctor_FFFFLjava_lang_String_IZ == IntPtr.Zero)
					id_ctor_FFFFLjava_lang_String_IZ = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFFLjava/lang/String;IZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFFLjava_lang_String_IZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFFFLjava_lang_String_IZ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
