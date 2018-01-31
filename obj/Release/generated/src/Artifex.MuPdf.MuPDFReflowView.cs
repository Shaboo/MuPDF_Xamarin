using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFReflowView", DoNotGenerateAcw=true)]
	public partial class MuPDFReflowView : global::Android.Webkit.WebView, global::Artifex.MuPdf.IMuPDFView {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFReflowView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuPDFReflowView); }
		}

		protected MuPDFReflowView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_MuPDFCore_Landroid_graphics_Point_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/constructor[@name='MuPDFReflowView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.artifex.mupdfdemo.MuPDFCore'] and parameter[3][@type='android.graphics.Point']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/artifex/mupdfdemo/MuPDFCore;Landroid/graphics/Point;)V", "")]
		public unsafe MuPDFReflowView (global::Android.Content.Context p0, global::Artifex.MuPdf.MuPDFCore p1, global::Android.Graphics.Point p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MuPDFReflowView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/artifex/mupdfdemo/MuPDFCore;Landroid/graphics/Point;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/artifex/mupdfdemo/MuPDFCore;Landroid/graphics/Point;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_MuPDFCore_Landroid_graphics_Point_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_MuPDFCore_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/artifex/mupdfdemo/MuPDFCore;Landroid/graphics/Point;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_MuPDFCore_Landroid_graphics_Point_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_MuPDFCore_Landroid_graphics_Point_, __args);
			} finally {
			}
		}

		static Delegate cb_getPage;
#pragma warning disable 0169
		static Delegate GetGetPageHandler ()
		{
			if (cb_getPage == null)
				cb_getPage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPage);
			return cb_getPage;
		}

		static int n_GetPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Page;
		}
#pragma warning restore 0169

		static IntPtr id_getPage;
		public virtual unsafe int Page {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='getPage' and count(parameter)=0]"
			[Register ("getPage", "()I", "GetGetPageHandler")]
			get {
				if (id_getPage == IntPtr.Zero)
					id_getPage = JNIEnv.GetMethodID (class_ref, "getPage", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPage);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPage", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_blank_I;
#pragma warning disable 0169
		static Delegate GetBlank_IHandler ()
		{
			if (cb_blank_I == null)
				cb_blank_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Blank_I);
			return cb_blank_I;
		}

		static void n_Blank_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Blank (p0);
		}
#pragma warning restore 0169

		static IntPtr id_blank_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='blank' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("blank", "(I)V", "GetBlank_IHandler")]
		public virtual unsafe void Blank (int p0)
		{
			if (id_blank_I == IntPtr.Zero)
				id_blank_I = JNIEnv.GetMethodID (class_ref, "blank", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blank_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "blank", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_cancelDraw;
#pragma warning disable 0169
		static Delegate GetCancelDrawHandler ()
		{
			if (cb_cancelDraw == null)
				cb_cancelDraw = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelDraw);
			return cb_cancelDraw;
		}

		static void n_CancelDraw (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelDraw ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelDraw;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='cancelDraw' and count(parameter)=0]"
		[Register ("cancelDraw", "()V", "GetCancelDrawHandler")]
		public virtual unsafe void CancelDraw ()
		{
			if (id_cancelDraw == IntPtr.Zero)
				id_cancelDraw = JNIEnv.GetMethodID (class_ref, "cancelDraw", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelDraw);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelDraw", "()V"));
			} finally {
			}
		}

		static Delegate cb_continueDraw_FF;
#pragma warning disable 0169
		static Delegate GetContinueDraw_FFHandler ()
		{
			if (cb_continueDraw_FF == null)
				cb_continueDraw_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_ContinueDraw_FF);
			return cb_continueDraw_FF;
		}

		static void n_ContinueDraw_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContinueDraw (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_continueDraw_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='continueDraw' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("continueDraw", "(FF)V", "GetContinueDraw_FFHandler")]
		public virtual unsafe void ContinueDraw (float p0, float p1)
		{
			if (id_continueDraw_FF == IntPtr.Zero)
				id_continueDraw_FF = JNIEnv.GetMethodID (class_ref, "continueDraw", "(FF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_continueDraw_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "continueDraw", "(FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_copySelection;
#pragma warning disable 0169
		static Delegate GetCopySelectionHandler ()
		{
			if (cb_copySelection == null)
				cb_copySelection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CopySelection);
			return cb_copySelection;
		}

		static bool n_CopySelection (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CopySelection ();
		}
#pragma warning restore 0169

		static IntPtr id_copySelection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='copySelection' and count(parameter)=0]"
		[Register ("copySelection", "()Z", "GetCopySelectionHandler")]
		public virtual unsafe bool CopySelection ()
		{
			if (id_copySelection == IntPtr.Zero)
				id_copySelection = JNIEnv.GetMethodID (class_ref, "copySelection", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_copySelection);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copySelection", "()Z"));
			} finally {
			}
		}

		static Delegate cb_deleteSelectedAnnotation;
#pragma warning disable 0169
		static Delegate GetDeleteSelectedAnnotationHandler ()
		{
			if (cb_deleteSelectedAnnotation == null)
				cb_deleteSelectedAnnotation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteSelectedAnnotation);
			return cb_deleteSelectedAnnotation;
		}

		static void n_DeleteSelectedAnnotation (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteSelectedAnnotation ();
		}
#pragma warning restore 0169

		static IntPtr id_deleteSelectedAnnotation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='deleteSelectedAnnotation' and count(parameter)=0]"
		[Register ("deleteSelectedAnnotation", "()V", "GetDeleteSelectedAnnotationHandler")]
		public virtual unsafe void DeleteSelectedAnnotation ()
		{
			if (id_deleteSelectedAnnotation == IntPtr.Zero)
				id_deleteSelectedAnnotation = JNIEnv.GetMethodID (class_ref, "deleteSelectedAnnotation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteSelectedAnnotation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteSelectedAnnotation", "()V"));
			} finally {
			}
		}

		static Delegate cb_deselectAnnotation;
#pragma warning disable 0169
		static Delegate GetDeselectAnnotationHandler ()
		{
			if (cb_deselectAnnotation == null)
				cb_deselectAnnotation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeselectAnnotation);
			return cb_deselectAnnotation;
		}

		static void n_DeselectAnnotation (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeselectAnnotation ();
		}
#pragma warning restore 0169

		static IntPtr id_deselectAnnotation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='deselectAnnotation' and count(parameter)=0]"
		[Register ("deselectAnnotation", "()V", "GetDeselectAnnotationHandler")]
		public virtual unsafe void DeselectAnnotation ()
		{
			if (id_deselectAnnotation == IntPtr.Zero)
				id_deselectAnnotation = JNIEnv.GetMethodID (class_ref, "deselectAnnotation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deselectAnnotation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deselectAnnotation", "()V"));
			} finally {
			}
		}

		static Delegate cb_deselectText;
#pragma warning disable 0169
		static Delegate GetDeselectTextHandler ()
		{
			if (cb_deselectText == null)
				cb_deselectText = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeselectText);
			return cb_deselectText;
		}

		static void n_DeselectText (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeselectText ();
		}
#pragma warning restore 0169

		static IntPtr id_deselectText;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='deselectText' and count(parameter)=0]"
		[Register ("deselectText", "()V", "GetDeselectTextHandler")]
		public virtual unsafe void DeselectText ()
		{
			if (id_deselectText == IntPtr.Zero)
				id_deselectText = JNIEnv.GetMethodID (class_ref, "deselectText", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deselectText);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deselectText", "()V"));
			} finally {
			}
		}

		static Delegate cb_hitLink_FF;
#pragma warning disable 0169
		static Delegate GetHitLink_FFHandler ()
		{
			if (cb_hitLink_FF == null)
				cb_hitLink_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_HitLink_FF);
			return cb_hitLink_FF;
		}

		static IntPtr n_HitLink_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HitLink (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_hitLink_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='hitLink' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("hitLink", "(FF)Lcom/artifex/mupdfdemo/LinkInfo;", "GetHitLink_FFHandler")]
		public virtual unsafe global::Artifex.MuPdf.LinkInfo HitLink (float p0, float p1)
		{
			if (id_hitLink_FF == IntPtr.Zero)
				id_hitLink_FF = JNIEnv.GetMethodID (class_ref, "hitLink", "(FF)Lcom/artifex/mupdfdemo/LinkInfo;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.LinkInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hitLink_FF, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.LinkInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hitLink", "(FF)Lcom/artifex/mupdfdemo/LinkInfo;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_releaseBitmaps;
#pragma warning disable 0169
		static Delegate GetReleaseBitmapsHandler ()
		{
			if (cb_releaseBitmaps == null)
				cb_releaseBitmaps = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseBitmaps);
			return cb_releaseBitmaps;
		}

		static void n_ReleaseBitmaps (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseBitmaps ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseBitmaps;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='releaseBitmaps' and count(parameter)=0]"
		[Register ("releaseBitmaps", "()V", "GetReleaseBitmapsHandler")]
		public virtual unsafe void ReleaseBitmaps ()
		{
			if (id_releaseBitmaps == IntPtr.Zero)
				id_releaseBitmaps = JNIEnv.GetMethodID (class_ref, "releaseBitmaps", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseBitmaps);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseBitmaps", "()V"));
			} finally {
			}
		}

		static Delegate cb_releaseResources;
#pragma warning disable 0169
		static Delegate GetReleaseResourcesHandler ()
		{
			if (cb_releaseResources == null)
				cb_releaseResources = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseResources);
			return cb_releaseResources;
		}

		static void n_ReleaseResources (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseResources ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseResources;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='releaseResources' and count(parameter)=0]"
		[Register ("releaseResources", "()V", "GetReleaseResourcesHandler")]
		public virtual unsafe void ReleaseResources ()
		{
			if (id_releaseResources == IntPtr.Zero)
				id_releaseResources = JNIEnv.GetMethodID (class_ref, "releaseResources", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseResources);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseResources", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeHq;
#pragma warning disable 0169
		static Delegate GetRemoveHqHandler ()
		{
			if (cb_removeHq == null)
				cb_removeHq = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveHq);
			return cb_removeHq;
		}

		static void n_RemoveHq (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveHq ();
		}
#pragma warning restore 0169

		static IntPtr id_removeHq;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='removeHq' and count(parameter)=0]"
		[Register ("removeHq", "()V", "GetRemoveHqHandler")]
		public virtual unsafe void RemoveHq ()
		{
			if (id_removeHq == IntPtr.Zero)
				id_removeHq = JNIEnv.GetMethodID (class_ref, "removeHq", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeHq);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeHq", "()V"));
			} finally {
			}
		}

		static Delegate cb_saveDraw;
#pragma warning disable 0169
		static Delegate GetSaveDrawHandler ()
		{
			if (cb_saveDraw == null)
				cb_saveDraw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SaveDraw);
			return cb_saveDraw;
		}

		static bool n_SaveDraw (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SaveDraw ();
		}
#pragma warning restore 0169

		static IntPtr id_saveDraw;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='saveDraw' and count(parameter)=0]"
		[Register ("saveDraw", "()Z", "GetSaveDrawHandler")]
		public virtual unsafe bool SaveDraw ()
		{
			if (id_saveDraw == IntPtr.Zero)
				id_saveDraw = JNIEnv.GetMethodID (class_ref, "saveDraw", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_saveDraw);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveDraw", "()Z"));
			} finally {
			}
		}

		static Delegate cb_selectText_FFFF;
#pragma warning disable 0169
		static Delegate GetSelectText_FFFFHandler ()
		{
			if (cb_selectText_FFFF == null)
				cb_selectText_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_SelectText_FFFF);
			return cb_selectText_FFFF;
		}

		static void n_SelectText_FFFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, float p3)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectText (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_selectText_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='selectText' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("selectText", "(FFFF)V", "GetSelectText_FFFFHandler")]
		public virtual unsafe void SelectText (float p0, float p1, float p2, float p3)
		{
			if (id_selectText_FFFF == IntPtr.Zero)
				id_selectText_FFFF = JNIEnv.GetMethodID (class_ref, "selectText", "(FFFF)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_selectText_FFFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectText", "(FFFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setChangeReporter_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSetChangeReporter_Ljava_lang_Runnable_Handler ()
		{
			if (cb_setChangeReporter_Ljava_lang_Runnable_ == null)
				cb_setChangeReporter_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChangeReporter_Ljava_lang_Runnable_);
			return cb_setChangeReporter_Ljava_lang_Runnable_;
		}

		static void n_SetChangeReporter_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetChangeReporter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setChangeReporter_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='setChangeReporter' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setChangeReporter", "(Ljava/lang/Runnable;)V", "GetSetChangeReporter_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void SetChangeReporter (global::Java.Lang.IRunnable p0)
		{
			if (id_setChangeReporter_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setChangeReporter_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "setChangeReporter", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChangeReporter_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChangeReporter", "(Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLinkHighlighting_Z;
#pragma warning disable 0169
		static Delegate GetSetLinkHighlighting_ZHandler ()
		{
			if (cb_setLinkHighlighting_Z == null)
				cb_setLinkHighlighting_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLinkHighlighting_Z);
			return cb_setLinkHighlighting_Z;
		}

		static void n_SetLinkHighlighting_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLinkHighlighting (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLinkHighlighting_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='setLinkHighlighting' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLinkHighlighting", "(Z)V", "GetSetLinkHighlighting_ZHandler")]
		public virtual unsafe void SetLinkHighlighting (bool p0)
		{
			if (id_setLinkHighlighting_Z == IntPtr.Zero)
				id_setLinkHighlighting_Z = JNIEnv.GetMethodID (class_ref, "setLinkHighlighting", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLinkHighlighting_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLinkHighlighting", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPage_ILandroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetSetPage_ILandroid_graphics_PointF_Handler ()
		{
			if (cb_setPage_ILandroid_graphics_PointF_ == null)
				cb_setPage_ILandroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetPage_ILandroid_graphics_PointF_);
			return cb_setPage_ILandroid_graphics_PointF_;
		}

		static void n_SetPage_ILandroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetPage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setPage_ILandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='setPage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.PointF']]"
		[Register ("setPage", "(ILandroid/graphics/PointF;)V", "GetSetPage_ILandroid_graphics_PointF_Handler")]
		public virtual unsafe void SetPage (int p0, global::Android.Graphics.PointF p1)
		{
			if (id_setPage_ILandroid_graphics_PointF_ == IntPtr.Zero)
				id_setPage_ILandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "setPage", "(ILandroid/graphics/PointF;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPage_ILandroid_graphics_PointF_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPage", "(ILandroid/graphics/PointF;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScale_F;
#pragma warning disable 0169
		static Delegate GetSetScale_FHandler ()
		{
			if (cb_setScale_F == null)
				cb_setScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetScale_F);
			return cb_setScale_F;
		}

		static void n_SetScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScale (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScale_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='setScale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setScale", "(F)V", "GetSetScale_FHandler")]
		public virtual unsafe void SetScale (float p0)
		{
			if (id_setScale_F == IntPtr.Zero)
				id_setScale_F = JNIEnv.GetMethodID (class_ref, "setScale", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScale_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScale", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSearchBoxes_arrayLandroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetSetSearchBoxes_arrayLandroid_graphics_RectF_Handler ()
		{
			if (cb_setSearchBoxes_arrayLandroid_graphics_RectF_ == null)
				cb_setSearchBoxes_arrayLandroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSearchBoxes_arrayLandroid_graphics_RectF_);
			return cb_setSearchBoxes_arrayLandroid_graphics_RectF_;
		}

		static void n_SetSearchBoxes_arrayLandroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF[] p0 = (global::Android.Graphics.RectF[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.RectF));
			__this.SetSearchBoxes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSearchBoxes_arrayLandroid_graphics_RectF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='setSearchBoxes' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF[]']]"
		[Register ("setSearchBoxes", "([Landroid/graphics/RectF;)V", "GetSetSearchBoxes_arrayLandroid_graphics_RectF_Handler")]
		public virtual unsafe void SetSearchBoxes (global::Android.Graphics.RectF[] p0)
		{
			if (id_setSearchBoxes_arrayLandroid_graphics_RectF_ == IntPtr.Zero)
				id_setSearchBoxes_arrayLandroid_graphics_RectF_ = JNIEnv.GetMethodID (class_ref, "setSearchBoxes", "([Landroid/graphics/RectF;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSearchBoxes_arrayLandroid_graphics_RectF_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSearchBoxes", "([Landroid/graphics/RectF;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_startDraw_FF;
#pragma warning disable 0169
		static Delegate GetStartDraw_FFHandler ()
		{
			if (cb_startDraw_FF == null)
				cb_startDraw_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_StartDraw_FF);
			return cb_startDraw_FF;
		}

		static void n_StartDraw_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDraw (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startDraw_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='startDraw' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("startDraw", "(FF)V", "GetStartDraw_FFHandler")]
		public virtual unsafe void StartDraw (float p0, float p1)
		{
			if (id_startDraw_FF == IntPtr.Zero)
				id_startDraw_FF = JNIEnv.GetMethodID (class_ref, "startDraw", "(FF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startDraw_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDraw", "(FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_update;
#pragma warning disable 0169
		static Delegate GetUpdateHandler ()
		{
			if (cb_update == null)
				cb_update = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Update);
			return cb_update;
		}

		static void n_Update (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update ();
		}
#pragma warning restore 0169

		static IntPtr id_update;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='update' and count(parameter)=0]"
		[Register ("update", "()V", "GetUpdateHandler")]
		public virtual unsafe void Update ()
		{
			if (id_update == IntPtr.Zero)
				id_update = JNIEnv.GetMethodID (class_ref, "update", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateHq_Z;
#pragma warning disable 0169
		static Delegate GetUpdateHq_ZHandler ()
		{
			if (cb_updateHq_Z == null)
				cb_updateHq_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_UpdateHq_Z);
			return cb_updateHq_Z;
		}

		static void n_UpdateHq_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Artifex.MuPdf.MuPDFReflowView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFReflowView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateHq (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateHq_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFReflowView']/method[@name='updateHq' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("updateHq", "(Z)V", "GetUpdateHq_ZHandler")]
		public virtual unsafe void UpdateHq (bool p0)
		{
			if (id_updateHq_Z == IntPtr.Zero)
				id_updateHq_Z = JNIEnv.GetMethodID (class_ref, "updateHq", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateHq_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateHq", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
