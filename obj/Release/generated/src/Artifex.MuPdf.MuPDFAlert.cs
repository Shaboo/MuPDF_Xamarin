using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFAlert", DoNotGenerateAcw=true)]
	public partial class MuPDFAlert : global::Java.Lang.Object {


		static IntPtr message_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert']/field[@name='message']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert']/field[@name='title']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonGroupType']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFAlert$ButtonGroupType", DoNotGenerateAcw=true)]
		public sealed partial class ButtonGroupType : global::Java.Lang.Enum {


			static IntPtr Ok_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonGroupType']/field[@name='Ok']"
			[Register ("Ok")]
			public static global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType Ok {
				get {
					if (Ok_jfieldId == IntPtr.Zero)
						Ok_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ok", "Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonGroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ok_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OkCancel_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonGroupType']/field[@name='OkCancel']"
			[Register ("OkCancel")]
			public static global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType OkCancel {
				get {
					if (OkCancel_jfieldId == IntPtr.Zero)
						OkCancel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OkCancel", "Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonGroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OkCancel_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr YesNo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonGroupType']/field[@name='YesNo']"
			[Register ("YesNo")]
			public static global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType YesNo {
				get {
					if (YesNo_jfieldId == IntPtr.Zero)
						YesNo_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YesNo", "Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonGroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YesNo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr YesNoCancel_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonGroupType']/field[@name='YesNoCancel']"
			[Register ("YesNoCancel")]
			public static global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType YesNoCancel {
				get {
					if (YesNoCancel_jfieldId == IntPtr.Zero)
						YesNoCancel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YesNoCancel", "Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonGroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YesNoCancel_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFAlert$ButtonGroupType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ButtonGroupType); }
			}

			internal ButtonGroupType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonGroupType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonGroupType;", "")]
			public static unsafe global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonGroupType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType __ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonGroupType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonGroupType;", "")]
			public static unsafe global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonGroupType;");
				try {
					return (global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.MuPDFAlert.ButtonGroupType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonPressed']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFAlert$ButtonPressed", DoNotGenerateAcw=true)]
		public sealed partial class ButtonPressed : global::Java.Lang.Enum {


			static IntPtr Cancel_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonPressed']/field[@name='Cancel']"
			[Register ("Cancel")]
			public static global::Artifex.MuPdf.MuPDFAlert.ButtonPressed Cancel {
				get {
					if (Cancel_jfieldId == IntPtr.Zero)
						Cancel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Cancel", "Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonPressed;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Cancel_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.ButtonPressed> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr No_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonPressed']/field[@name='No']"
			[Register ("No")]
			public static global::Artifex.MuPdf.MuPDFAlert.ButtonPressed No {
				get {
					if (No_jfieldId == IntPtr.Zero)
						No_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "No", "Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonPressed;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, No_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.ButtonPressed> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr None_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonPressed']/field[@name='None']"
			[Register ("None")]
			public static global::Artifex.MuPdf.MuPDFAlert.ButtonPressed None {
				get {
					if (None_jfieldId == IntPtr.Zero)
						None_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "None", "Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonPressed;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, None_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.ButtonPressed> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Ok_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonPressed']/field[@name='Ok']"
			[Register ("Ok")]
			public static global::Artifex.MuPdf.MuPDFAlert.ButtonPressed Ok {
				get {
					if (Ok_jfieldId == IntPtr.Zero)
						Ok_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ok", "Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonPressed;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ok_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.ButtonPressed> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Yes_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonPressed']/field[@name='Yes']"
			[Register ("Yes")]
			public static global::Artifex.MuPdf.MuPDFAlert.ButtonPressed Yes {
				get {
					if (Yes_jfieldId == IntPtr.Zero)
						Yes_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Yes", "Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonPressed;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Yes_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.ButtonPressed> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFAlert$ButtonPressed", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ButtonPressed); }
			}

			internal ButtonPressed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonPressed']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonPressed;", "")]
			public static unsafe global::Artifex.MuPdf.MuPDFAlert.ButtonPressed ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonPressed;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Artifex.MuPdf.MuPDFAlert.ButtonPressed __ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.ButtonPressed> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.ButtonPressed']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonPressed;", "")]
			public static unsafe global::Artifex.MuPdf.MuPDFAlert.ButtonPressed[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/artifex/mupdfdemo/MuPDFAlert$ButtonPressed;");
				try {
					return (global::Artifex.MuPdf.MuPDFAlert.ButtonPressed[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.MuPDFAlert.ButtonPressed));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.IconType']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFAlert$IconType", DoNotGenerateAcw=true)]
		public sealed partial class IconType : global::Java.Lang.Enum {


			static IntPtr Error_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.IconType']/field[@name='Error']"
			[Register ("Error")]
			public static global::Artifex.MuPdf.MuPDFAlert.IconType Error {
				get {
					if (Error_jfieldId == IntPtr.Zero)
						Error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Error", "Lcom/artifex/mupdfdemo/MuPDFAlert$IconType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Error_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.IconType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Question_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.IconType']/field[@name='Question']"
			[Register ("Question")]
			public static global::Artifex.MuPdf.MuPDFAlert.IconType Question {
				get {
					if (Question_jfieldId == IntPtr.Zero)
						Question_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Question", "Lcom/artifex/mupdfdemo/MuPDFAlert$IconType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Question_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.IconType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Status_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.IconType']/field[@name='Status']"
			[Register ("Status")]
			public static global::Artifex.MuPdf.MuPDFAlert.IconType Status {
				get {
					if (Status_jfieldId == IntPtr.Zero)
						Status_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Status", "Lcom/artifex/mupdfdemo/MuPDFAlert$IconType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Status_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.IconType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Warning_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.IconType']/field[@name='Warning']"
			[Register ("Warning")]
			public static global::Artifex.MuPdf.MuPDFAlert.IconType Warning {
				get {
					if (Warning_jfieldId == IntPtr.Zero)
						Warning_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Warning", "Lcom/artifex/mupdfdemo/MuPDFAlert$IconType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Warning_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.IconType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFAlert$IconType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IconType); }
			}

			internal IconType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.IconType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/artifex/mupdfdemo/MuPDFAlert$IconType;", "")]
			public static unsafe global::Artifex.MuPdf.MuPDFAlert.IconType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/artifex/mupdfdemo/MuPDFAlert$IconType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Artifex.MuPdf.MuPDFAlert.IconType __ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert.IconType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFAlert.IconType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/artifex/mupdfdemo/MuPDFAlert$IconType;", "")]
			public static unsafe global::Artifex.MuPdf.MuPDFAlert.IconType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/artifex/mupdfdemo/MuPDFAlert$IconType;");
				try {
					return (global::Artifex.MuPdf.MuPDFAlert.IconType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.MuPDFAlert.IconType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFAlert", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuPDFAlert); }
		}

		protected MuPDFAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
