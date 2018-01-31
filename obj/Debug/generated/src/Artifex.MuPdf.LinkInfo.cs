using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfo']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/LinkInfo", DoNotGenerateAcw=true)]
	public partial class LinkInfo : global::Java.Lang.Object {


		static IntPtr rect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfo']/field[@name='rect']"
		[Register ("rect")]
		public global::Android.Graphics.RectF Rect {
			get {
				if (rect_jfieldId == IntPtr.Zero)
					rect_jfieldId = JNIEnv.GetFieldID (class_ref, "rect", "Landroid/graphics/RectF;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, rect_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (rect_jfieldId == IntPtr.Zero)
					rect_jfieldId = JNIEnv.GetFieldID (class_ref, "rect", "Landroid/graphics/RectF;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rect_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/LinkInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LinkInfo); }
		}

		protected LinkInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFFF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfo']/constructor[@name='LinkInfo' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register (".ctor", "(FFFF)V", "")]
		public unsafe LinkInfo (float p0, float p1, float p2, float p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (LinkInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(FFFF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFFF)V", __args);
					return;
				}

				if (id_ctor_FFFF == IntPtr.Zero)
					id_ctor_FFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFFF, __args);
			} finally {
			}
		}

		static Delegate cb_acceptVisitor_Lcom_artifex_mupdfdemo_LinkInfoVisitor_;
#pragma warning disable 0169
		static Delegate GetAcceptVisitor_Lcom_artifex_mupdfdemo_LinkInfoVisitor_Handler ()
		{
			if (cb_acceptVisitor_Lcom_artifex_mupdfdemo_LinkInfoVisitor_ == null)
				cb_acceptVisitor_Lcom_artifex_mupdfdemo_LinkInfoVisitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AcceptVisitor_Lcom_artifex_mupdfdemo_LinkInfoVisitor_);
			return cb_acceptVisitor_Lcom_artifex_mupdfdemo_LinkInfoVisitor_;
		}

		static void n_AcceptVisitor_Lcom_artifex_mupdfdemo_LinkInfoVisitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.LinkInfo __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.LinkInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Artifex.MuPdf.LinkInfoVisitor p0 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.LinkInfoVisitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AcceptVisitor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_acceptVisitor_Lcom_artifex_mupdfdemo_LinkInfoVisitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfo']/method[@name='acceptVisitor' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.LinkInfoVisitor']]"
		[Register ("acceptVisitor", "(Lcom/artifex/mupdfdemo/LinkInfoVisitor;)V", "GetAcceptVisitor_Lcom_artifex_mupdfdemo_LinkInfoVisitor_Handler")]
		public virtual unsafe void AcceptVisitor (global::Artifex.MuPdf.LinkInfoVisitor p0)
		{
			if (id_acceptVisitor_Lcom_artifex_mupdfdemo_LinkInfoVisitor_ == IntPtr.Zero)
				id_acceptVisitor_Lcom_artifex_mupdfdemo_LinkInfoVisitor_ = JNIEnv.GetMethodID (class_ref, "acceptVisitor", "(Lcom/artifex/mupdfdemo/LinkInfoVisitor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acceptVisitor_Lcom_artifex_mupdfdemo_LinkInfoVisitor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "acceptVisitor", "(Lcom/artifex/mupdfdemo/LinkInfoVisitor;)V"), __args);
			} finally {
			}
		}

	}
}
