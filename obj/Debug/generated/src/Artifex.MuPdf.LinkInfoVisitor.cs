using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoVisitor']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/LinkInfoVisitor", DoNotGenerateAcw=true)]
	public abstract partial class LinkInfoVisitor : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/LinkInfoVisitor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LinkInfoVisitor); }
		}

		protected LinkInfoVisitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoVisitor']/constructor[@name='LinkInfoVisitor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinkInfoVisitor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LinkInfoVisitor)) {
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

		static Delegate cb_visitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_;
#pragma warning disable 0169
		static Delegate GetVisitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_Handler ()
		{
			if (cb_visitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_ == null)
				cb_visitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_VisitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_);
			return cb_visitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_;
		}

		static void n_VisitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.LinkInfoVisitor __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.LinkInfoVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Artifex.MuPdf.LinkInfoExternal p0 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.LinkInfoExternal> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VisitExternal (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoVisitor']/method[@name='visitExternal' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.LinkInfoExternal']]"
		[Register ("visitExternal", "(Lcom/artifex/mupdfdemo/LinkInfoExternal;)V", "GetVisitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_Handler")]
		public abstract void VisitExternal (global::Artifex.MuPdf.LinkInfoExternal p0);

		static Delegate cb_visitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_;
#pragma warning disable 0169
		static Delegate GetVisitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_Handler ()
		{
			if (cb_visitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_ == null)
				cb_visitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_VisitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_);
			return cb_visitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_;
		}

		static void n_VisitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.LinkInfoVisitor __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.LinkInfoVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Artifex.MuPdf.LinkInfoInternal p0 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.LinkInfoInternal> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VisitInternal (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoVisitor']/method[@name='visitInternal' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.LinkInfoInternal']]"
		[Register ("visitInternal", "(Lcom/artifex/mupdfdemo/LinkInfoInternal;)V", "GetVisitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_Handler")]
		public abstract void VisitInternal (global::Artifex.MuPdf.LinkInfoInternal p0);

		static Delegate cb_visitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_;
#pragma warning disable 0169
		static Delegate GetVisitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_Handler ()
		{
			if (cb_visitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_ == null)
				cb_visitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_VisitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_);
			return cb_visitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_;
		}

		static void n_VisitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.LinkInfoVisitor __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.LinkInfoVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Artifex.MuPdf.LinkInfoRemote p0 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.LinkInfoRemote> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VisitRemote (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoVisitor']/method[@name='visitRemote' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.LinkInfoRemote']]"
		[Register ("visitRemote", "(Lcom/artifex/mupdfdemo/LinkInfoRemote;)V", "GetVisitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_Handler")]
		public abstract void VisitRemote (global::Artifex.MuPdf.LinkInfoRemote p0);

	}

	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/LinkInfoVisitor", DoNotGenerateAcw=true)]
	internal partial class LinkInfoVisitorInvoker : LinkInfoVisitor {

		public LinkInfoVisitorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LinkInfoVisitorInvoker); }
		}

		static IntPtr id_visitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoVisitor']/method[@name='visitExternal' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.LinkInfoExternal']]"
		[Register ("visitExternal", "(Lcom/artifex/mupdfdemo/LinkInfoExternal;)V", "GetVisitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_Handler")]
		public override unsafe void VisitExternal (global::Artifex.MuPdf.LinkInfoExternal p0)
		{
			if (id_visitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_ == IntPtr.Zero)
				id_visitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_ = JNIEnv.GetMethodID (class_ref, "visitExternal", "(Lcom/artifex/mupdfdemo/LinkInfoExternal;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visitExternal_Lcom_artifex_mupdfdemo_LinkInfoExternal_, __args);
			} finally {
			}
		}

		static IntPtr id_visitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoVisitor']/method[@name='visitInternal' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.LinkInfoInternal']]"
		[Register ("visitInternal", "(Lcom/artifex/mupdfdemo/LinkInfoInternal;)V", "GetVisitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_Handler")]
		public override unsafe void VisitInternal (global::Artifex.MuPdf.LinkInfoInternal p0)
		{
			if (id_visitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_ == IntPtr.Zero)
				id_visitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_ = JNIEnv.GetMethodID (class_ref, "visitInternal", "(Lcom/artifex/mupdfdemo/LinkInfoInternal;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visitInternal_Lcom_artifex_mupdfdemo_LinkInfoInternal_, __args);
			} finally {
			}
		}

		static IntPtr id_visitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='LinkInfoVisitor']/method[@name='visitRemote' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.LinkInfoRemote']]"
		[Register ("visitRemote", "(Lcom/artifex/mupdfdemo/LinkInfoRemote;)V", "GetVisitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_Handler")]
		public override unsafe void VisitRemote (global::Artifex.MuPdf.LinkInfoRemote p0)
		{
			if (id_visitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_ == IntPtr.Zero)
				id_visitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_ = JNIEnv.GetMethodID (class_ref, "visitRemote", "(Lcom/artifex/mupdfdemo/LinkInfoRemote;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visitRemote_Lcom_artifex_mupdfdemo_LinkInfoRemote_, __args);
			} finally {
			}
		}

	}

}
