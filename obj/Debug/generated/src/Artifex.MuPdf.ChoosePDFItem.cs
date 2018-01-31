using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ChoosePDFItem']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/ChoosePDFItem", DoNotGenerateAcw=true)]
	public partial class ChoosePDFItem : global::Java.Lang.Object {


		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ChoosePDFItem']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ChoosePDFItem.Type']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/ChoosePDFItem$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr DIR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ChoosePDFItem.Type']/field[@name='DIR']"
			[Register ("DIR")]
			public static global::Artifex.MuPdf.ChoosePDFItem.Type Dir {
				get {
					if (DIR_jfieldId == IntPtr.Zero)
						DIR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIR", "Lcom/artifex/mupdfdemo/ChoosePDFItem$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ChoosePDFItem.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DOC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ChoosePDFItem.Type']/field[@name='DOC']"
			[Register ("DOC")]
			public static global::Artifex.MuPdf.ChoosePDFItem.Type Doc {
				get {
					if (DOC_jfieldId == IntPtr.Zero)
						DOC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOC", "Lcom/artifex/mupdfdemo/ChoosePDFItem$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ChoosePDFItem.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PARENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ChoosePDFItem.Type']/field[@name='PARENT']"
			[Register ("PARENT")]
			public static global::Artifex.MuPdf.ChoosePDFItem.Type Parent {
				get {
					if (PARENT_jfieldId == IntPtr.Zero)
						PARENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARENT", "Lcom/artifex/mupdfdemo/ChoosePDFItem$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ChoosePDFItem.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/ChoosePDFItem$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/ChoosePDFItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChoosePDFItem); }
		}

		protected ChoosePDFItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_artifex_mupdfdemo_ChoosePDFItem_Type_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ChoosePDFItem']/constructor[@name='ChoosePDFItem' and count(parameter)=2 and parameter[1][@type='com.artifex.mupdfdemo.ChoosePDFItem.Type'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/artifex/mupdfdemo/ChoosePDFItem$Type;Ljava/lang/String;)V", "")]
		public unsafe ChoosePDFItem (global::Artifex.MuPdf.ChoosePDFItem.Type p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (ChoosePDFItem)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/artifex/mupdfdemo/ChoosePDFItem$Type;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/artifex/mupdfdemo/ChoosePDFItem$Type;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_artifex_mupdfdemo_ChoosePDFItem_Type_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_artifex_mupdfdemo_ChoosePDFItem_Type_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/artifex/mupdfdemo/ChoosePDFItem$Type;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_artifex_mupdfdemo_ChoosePDFItem_Type_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_artifex_mupdfdemo_ChoosePDFItem_Type_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
