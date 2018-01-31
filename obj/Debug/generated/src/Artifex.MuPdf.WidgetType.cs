using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='WidgetType']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/WidgetType", DoNotGenerateAcw=true)]
	public sealed partial class WidgetType : global::Java.Lang.Enum {


		static IntPtr COMBOBOX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='WidgetType']/field[@name='COMBOBOX']"
		[Register ("COMBOBOX")]
		public static global::Artifex.MuPdf.WidgetType Combobox {
			get {
				if (COMBOBOX_jfieldId == IntPtr.Zero)
					COMBOBOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMBOBOX", "Lcom/artifex/mupdfdemo/WidgetType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMBOBOX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.WidgetType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LISTBOX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='WidgetType']/field[@name='LISTBOX']"
		[Register ("LISTBOX")]
		public static global::Artifex.MuPdf.WidgetType Listbox {
			get {
				if (LISTBOX_jfieldId == IntPtr.Zero)
					LISTBOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LISTBOX", "Lcom/artifex/mupdfdemo/WidgetType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LISTBOX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.WidgetType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='WidgetType']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Artifex.MuPdf.WidgetType None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/artifex/mupdfdemo/WidgetType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.WidgetType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIGNATURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='WidgetType']/field[@name='SIGNATURE']"
		[Register ("SIGNATURE")]
		public static global::Artifex.MuPdf.WidgetType Signature {
			get {
				if (SIGNATURE_jfieldId == IntPtr.Zero)
					SIGNATURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIGNATURE", "Lcom/artifex/mupdfdemo/WidgetType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIGNATURE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.WidgetType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='WidgetType']/field[@name='TEXT']"
		[Register ("TEXT")]
		public static global::Artifex.MuPdf.WidgetType Text {
			get {
				if (TEXT_jfieldId == IntPtr.Zero)
					TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lcom/artifex/mupdfdemo/WidgetType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.WidgetType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/WidgetType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WidgetType); }
		}

		internal WidgetType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='WidgetType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/artifex/mupdfdemo/WidgetType;", "")]
		public static unsafe global::Artifex.MuPdf.WidgetType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/artifex/mupdfdemo/WidgetType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Artifex.MuPdf.WidgetType __ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.WidgetType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='WidgetType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/artifex/mupdfdemo/WidgetType;", "")]
		public static unsafe global::Artifex.MuPdf.WidgetType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/artifex/mupdfdemo/WidgetType;");
			try {
				return (global::Artifex.MuPdf.WidgetType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.WidgetType));
			} finally {
			}
		}

	}
}
