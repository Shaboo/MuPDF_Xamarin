using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SearchTaskResult']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/SearchTaskResult", DoNotGenerateAcw=true)]
	public partial class SearchTaskResult : global::Java.Lang.Object {


		static IntPtr pageNumber_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SearchTaskResult']/field[@name='pageNumber']"
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

		static IntPtr searchBoxes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SearchTaskResult']/field[@name='searchBoxes']"
		[Register ("searchBoxes")]
		public IList<Android.Graphics.RectF> SearchBoxes {
			get {
				if (searchBoxes_jfieldId == IntPtr.Zero)
					searchBoxes_jfieldId = JNIEnv.GetFieldID (class_ref, "searchBoxes", "[Landroid/graphics/RectF;");
				return global::Android.Runtime.JavaArray<global::Android.Graphics.RectF>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, searchBoxes_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (searchBoxes_jfieldId == IntPtr.Zero)
					searchBoxes_jfieldId = JNIEnv.GetFieldID (class_ref, "searchBoxes", "[Landroid/graphics/RectF;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Android.Graphics.RectF>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, searchBoxes_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr txt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SearchTaskResult']/field[@name='txt']"
		[Register ("txt")]
		public string Txt {
			get {
				if (txt_jfieldId == IntPtr.Zero)
					txt_jfieldId = JNIEnv.GetFieldID (class_ref, "txt", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, txt_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (txt_jfieldId == IntPtr.Zero)
					txt_jfieldId = JNIEnv.GetFieldID (class_ref, "txt", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, txt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/SearchTaskResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SearchTaskResult); }
		}

		protected SearchTaskResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SearchTaskResult']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/artifex/mupdfdemo/SearchTaskResult;", "")]
		public static unsafe global::Artifex.MuPdf.SearchTaskResult Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lcom/artifex/mupdfdemo/SearchTaskResult;");
			try {
				return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.SearchTaskResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_set_Lcom_artifex_mupdfdemo_SearchTaskResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='SearchTaskResult']/method[@name='set' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.SearchTaskResult']]"
		[Register ("set", "(Lcom/artifex/mupdfdemo/SearchTaskResult;)V", "")]
		public static unsafe void Set (global::Artifex.MuPdf.SearchTaskResult p0)
		{
			if (id_set_Lcom_artifex_mupdfdemo_SearchTaskResult_ == IntPtr.Zero)
				id_set_Lcom_artifex_mupdfdemo_SearchTaskResult_ = JNIEnv.GetStaticMethodID (class_ref, "set", "(Lcom/artifex/mupdfdemo/SearchTaskResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_set_Lcom_artifex_mupdfdemo_SearchTaskResult_, __args);
			} finally {
			}
		}

	}
}
