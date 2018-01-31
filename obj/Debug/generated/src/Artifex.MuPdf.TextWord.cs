using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='TextWord']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/TextWord", DoNotGenerateAcw=true)]
	public partial class TextWord : global::Android.Graphics.RectF {


		static IntPtr w_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='TextWord']/field[@name='w']"
		[Register ("w")]
		public string W {
			get {
				if (w_jfieldId == IntPtr.Zero)
					w_jfieldId = JNIEnv.GetFieldID (class_ref, "w", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, w_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (w_jfieldId == IntPtr.Zero)
					w_jfieldId = JNIEnv.GetFieldID (class_ref, "w", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, w_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/TextWord", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextWord); }
		}

		protected TextWord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='TextWord']/constructor[@name='TextWord' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextWord ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TextWord)) {
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

		static Delegate cb_Add_Lcom_artifex_mupdfdemo_TextChar_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_artifex_mupdfdemo_TextChar_Handler ()
		{
			if (cb_Add_Lcom_artifex_mupdfdemo_TextChar_ == null)
				cb_Add_Lcom_artifex_mupdfdemo_TextChar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lcom_artifex_mupdfdemo_TextChar_);
			return cb_Add_Lcom_artifex_mupdfdemo_TextChar_;
		}

		static void n_Add_Lcom_artifex_mupdfdemo_TextChar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.TextWord __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.TextWord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Artifex.MuPdf.TextChar p0 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.TextChar> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_Add_Lcom_artifex_mupdfdemo_TextChar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='TextWord']/method[@name='Add' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.TextChar']]"
		[Register ("Add", "(Lcom/artifex/mupdfdemo/TextChar;)V", "GetAdd_Lcom_artifex_mupdfdemo_TextChar_Handler")]
		public virtual unsafe void Add (global::Artifex.MuPdf.TextChar p0)
		{
			if (id_Add_Lcom_artifex_mupdfdemo_TextChar_ == IntPtr.Zero)
				id_Add_Lcom_artifex_mupdfdemo_TextChar_ = JNIEnv.GetMethodID (class_ref, "Add", "(Lcom/artifex/mupdfdemo/TextChar;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Add_Lcom_artifex_mupdfdemo_TextChar_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Add", "(Lcom/artifex/mupdfdemo/TextChar;)V"), __args);
			} finally {
			}
		}

	}
}
