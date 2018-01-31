using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='OutlineActivityData']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/OutlineActivityData", DoNotGenerateAcw=true)]
	public partial class OutlineActivityData : global::Java.Lang.Object {


		static IntPtr items_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='OutlineActivityData']/field[@name='items']"
		[Register ("items")]
		public IList<Artifex.MuPdf.OutlineItem> Items {
			get {
				if (items_jfieldId == IntPtr.Zero)
					items_jfieldId = JNIEnv.GetFieldID (class_ref, "items", "[Lcom/artifex/mupdfdemo/OutlineItem;");
				return global::Android.Runtime.JavaArray<global::Artifex.MuPdf.OutlineItem>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, items_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (items_jfieldId == IntPtr.Zero)
					items_jfieldId = JNIEnv.GetFieldID (class_ref, "items", "[Lcom/artifex/mupdfdemo/OutlineItem;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Artifex.MuPdf.OutlineItem>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, items_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr position_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='OutlineActivityData']/field[@name='position']"
		[Register ("position")]
		public int Position {
			get {
				if (position_jfieldId == IntPtr.Zero)
					position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, position_jfieldId);
			}
			set {
				if (position_jfieldId == IntPtr.Zero)
					position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, position_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/OutlineActivityData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OutlineActivityData); }
		}

		protected OutlineActivityData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='OutlineActivityData']/constructor[@name='OutlineActivityData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OutlineActivityData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OutlineActivityData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='OutlineActivityData']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/artifex/mupdfdemo/OutlineActivityData;", "")]
		public static unsafe global::Artifex.MuPdf.OutlineActivityData Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetStaticMethodID (class_ref, "get", "()Lcom/artifex/mupdfdemo/OutlineActivityData;");
			try {
				return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.OutlineActivityData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_set_Lcom_artifex_mupdfdemo_OutlineActivityData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='OutlineActivityData']/method[@name='set' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.OutlineActivityData']]"
		[Register ("set", "(Lcom/artifex/mupdfdemo/OutlineActivityData;)V", "")]
		public static unsafe void Set (global::Artifex.MuPdf.OutlineActivityData p0)
		{
			if (id_set_Lcom_artifex_mupdfdemo_OutlineActivityData_ == IntPtr.Zero)
				id_set_Lcom_artifex_mupdfdemo_OutlineActivityData_ = JNIEnv.GetStaticMethodID (class_ref, "set", "(Lcom/artifex/mupdfdemo/OutlineActivityData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_set_Lcom_artifex_mupdfdemo_OutlineActivityData_, __args);
			} finally {
			}
		}

	}
}
