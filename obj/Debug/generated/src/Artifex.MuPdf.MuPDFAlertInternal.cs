using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlertInternal']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFAlertInternal", DoNotGenerateAcw=true)]
	public partial class MuPDFAlertInternal : global::Java.Lang.Object {


		static IntPtr buttonGroupType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlertInternal']/field[@name='buttonGroupType']"
		[Register ("buttonGroupType")]
		public int ButtonGroupType {
			get {
				if (buttonGroupType_jfieldId == IntPtr.Zero)
					buttonGroupType_jfieldId = JNIEnv.GetFieldID (class_ref, "buttonGroupType", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, buttonGroupType_jfieldId);
			}
			set {
				if (buttonGroupType_jfieldId == IntPtr.Zero)
					buttonGroupType_jfieldId = JNIEnv.GetFieldID (class_ref, "buttonGroupType", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, buttonGroupType_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr buttonPressed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlertInternal']/field[@name='buttonPressed']"
		[Register ("buttonPressed")]
		public int ButtonPressed {
			get {
				if (buttonPressed_jfieldId == IntPtr.Zero)
					buttonPressed_jfieldId = JNIEnv.GetFieldID (class_ref, "buttonPressed", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, buttonPressed_jfieldId);
			}
			set {
				if (buttonPressed_jfieldId == IntPtr.Zero)
					buttonPressed_jfieldId = JNIEnv.GetFieldID (class_ref, "buttonPressed", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, buttonPressed_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr iconType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlertInternal']/field[@name='iconType']"
		[Register ("iconType")]
		public int IconType {
			get {
				if (iconType_jfieldId == IntPtr.Zero)
					iconType_jfieldId = JNIEnv.GetFieldID (class_ref, "iconType", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, iconType_jfieldId);
			}
			set {
				if (iconType_jfieldId == IntPtr.Zero)
					iconType_jfieldId = JNIEnv.GetFieldID (class_ref, "iconType", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, iconType_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr message_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlertInternal']/field[@name='message']"
		[Register ("message")]
		public string Message {
			get {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, message_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, message_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr title_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlertInternal']/field[@name='title']"
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
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFAlertInternal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuPDFAlertInternal); }
		}

		protected MuPDFAlertInternal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
