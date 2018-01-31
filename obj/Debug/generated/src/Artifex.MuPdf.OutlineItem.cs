using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='OutlineItem']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/OutlineItem", DoNotGenerateAcw=true)]
	public partial class OutlineItem : global::Java.Lang.Object {


		static IntPtr level_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='OutlineItem']/field[@name='level']"
		[Register ("level")]
		public int Level {
			get {
				if (level_jfieldId == IntPtr.Zero)
					level_jfieldId = JNIEnv.GetFieldID (class_ref, "level", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, level_jfieldId);
			}
			set {
				if (level_jfieldId == IntPtr.Zero)
					level_jfieldId = JNIEnv.GetFieldID (class_ref, "level", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, level_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr page_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='OutlineItem']/field[@name='page']"
		[Register ("page")]
		public int Page {
			get {
				if (page_jfieldId == IntPtr.Zero)
					page_jfieldId = JNIEnv.GetFieldID (class_ref, "page", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, page_jfieldId);
			}
			set {
				if (page_jfieldId == IntPtr.Zero)
					page_jfieldId = JNIEnv.GetFieldID (class_ref, "page", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, page_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr title_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='OutlineItem']/field[@name='title']"
		[Register ("title")]
		public string Title {
			get {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, title_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (title_jfieldId == IntPtr.Zero)
					title_jfieldId = JNIEnv.GetFieldID (class_ref, "title", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, title_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/OutlineItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OutlineItem); }
		}

		protected OutlineItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
