using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']"
	[Register ("com/artifex/mupdfdemo/MuPDFView", "", "Artifex.MuPdf.IMuPDFViewInvoker")]
	public partial interface IMuPDFView : IJavaObject {

		int Page {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='getPage' and count(parameter)=0]"
			[Register ("getPage", "()I", "GetGetPageHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='blank' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("blank", "(I)V", "GetBlank_IHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void Blank (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='cancelDraw' and count(parameter)=0]"
		[Register ("cancelDraw", "()V", "GetCancelDrawHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void CancelDraw ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='continueDraw' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("continueDraw", "(FF)V", "GetContinueDraw_FFHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void ContinueDraw (float p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='copySelection' and count(parameter)=0]"
		[Register ("copySelection", "()Z", "GetCopySelectionHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		bool CopySelection ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='deleteSelectedAnnotation' and count(parameter)=0]"
		[Register ("deleteSelectedAnnotation", "()V", "GetDeleteSelectedAnnotationHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void DeleteSelectedAnnotation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='deselectAnnotation' and count(parameter)=0]"
		[Register ("deselectAnnotation", "()V", "GetDeselectAnnotationHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void DeselectAnnotation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='deselectText' and count(parameter)=0]"
		[Register ("deselectText", "()V", "GetDeselectTextHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void DeselectText ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='hitLink' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("hitLink", "(FF)Lcom/artifex/mupdfdemo/LinkInfo;", "GetHitLink_FFHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		global::Artifex.MuPdf.LinkInfo HitLink (float p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='releaseBitmaps' and count(parameter)=0]"
		[Register ("releaseBitmaps", "()V", "GetReleaseBitmapsHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void ReleaseBitmaps ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='releaseResources' and count(parameter)=0]"
		[Register ("releaseResources", "()V", "GetReleaseResourcesHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void ReleaseResources ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='removeHq' and count(parameter)=0]"
		[Register ("removeHq", "()V", "GetRemoveHqHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void RemoveHq ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='saveDraw' and count(parameter)=0]"
		[Register ("saveDraw", "()Z", "GetSaveDrawHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		bool SaveDraw ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='selectText' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("selectText", "(FFFF)V", "GetSelectText_FFFFHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void SelectText (float p0, float p1, float p2, float p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='setChangeReporter' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setChangeReporter", "(Ljava/lang/Runnable;)V", "GetSetChangeReporter_Ljava_lang_Runnable_Handler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void SetChangeReporter (global::Java.Lang.IRunnable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='setLinkHighlighting' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLinkHighlighting", "(Z)V", "GetSetLinkHighlighting_ZHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void SetLinkHighlighting (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='setPage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.PointF']]"
		[Register ("setPage", "(ILandroid/graphics/PointF;)V", "GetSetPage_ILandroid_graphics_PointF_Handler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void SetPage (int p0, global::Android.Graphics.PointF p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='setScale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setScale", "(F)V", "GetSetScale_FHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void SetScale (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='setSearchBoxes' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF[]']]"
		[Register ("setSearchBoxes", "([Landroid/graphics/RectF;)V", "GetSetSearchBoxes_arrayLandroid_graphics_RectF_Handler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void SetSearchBoxes (global::Android.Graphics.RectF[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='startDraw' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("startDraw", "(FF)V", "GetStartDraw_FFHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void StartDraw (float p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='update' and count(parameter)=0]"
		[Register ("update", "()V", "GetUpdateHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void Update ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/interface[@name='MuPDFView']/method[@name='updateHq' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("updateHq", "(Z)V", "GetUpdateHq_ZHandler:Artifex.MuPdf.IMuPDFViewInvoker, MuPdfibrary")]
		void UpdateHq (bool p0);

	}

	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFView", DoNotGenerateAcw=true)]
	internal class IMuPDFViewInvoker : global::Java.Lang.Object, IMuPDFView {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFView");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMuPDFViewInvoker); }
		}

		IntPtr class_ref;

		public static IMuPDFView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMuPDFView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.artifex.mupdfdemo.MuPDFView"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMuPDFViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Page;
		}
#pragma warning restore 0169

		IntPtr id_getPage;
		public unsafe int Page {
			get {
				if (id_getPage == IntPtr.Zero)
					id_getPage = JNIEnv.GetMethodID (class_ref, "getPage", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPage);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Blank (p0);
		}
#pragma warning restore 0169

		IntPtr id_blank_I;
		public unsafe void Blank (int p0)
		{
			if (id_blank_I == IntPtr.Zero)
				id_blank_I = JNIEnv.GetMethodID (class_ref, "blank", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blank_I, __args);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelDraw ();
		}
#pragma warning restore 0169

		IntPtr id_cancelDraw;
		public unsafe void CancelDraw ()
		{
			if (id_cancelDraw == IntPtr.Zero)
				id_cancelDraw = JNIEnv.GetMethodID (class_ref, "cancelDraw", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelDraw);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContinueDraw (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_continueDraw_FF;
		public unsafe void ContinueDraw (float p0, float p1)
		{
			if (id_continueDraw_FF == IntPtr.Zero)
				id_continueDraw_FF = JNIEnv.GetMethodID (class_ref, "continueDraw", "(FF)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_continueDraw_FF, __args);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CopySelection ();
		}
#pragma warning restore 0169

		IntPtr id_copySelection;
		public unsafe bool CopySelection ()
		{
			if (id_copySelection == IntPtr.Zero)
				id_copySelection = JNIEnv.GetMethodID (class_ref, "copySelection", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_copySelection);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteSelectedAnnotation ();
		}
#pragma warning restore 0169

		IntPtr id_deleteSelectedAnnotation;
		public unsafe void DeleteSelectedAnnotation ()
		{
			if (id_deleteSelectedAnnotation == IntPtr.Zero)
				id_deleteSelectedAnnotation = JNIEnv.GetMethodID (class_ref, "deleteSelectedAnnotation", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteSelectedAnnotation);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeselectAnnotation ();
		}
#pragma warning restore 0169

		IntPtr id_deselectAnnotation;
		public unsafe void DeselectAnnotation ()
		{
			if (id_deselectAnnotation == IntPtr.Zero)
				id_deselectAnnotation = JNIEnv.GetMethodID (class_ref, "deselectAnnotation", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deselectAnnotation);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeselectText ();
		}
#pragma warning restore 0169

		IntPtr id_deselectText;
		public unsafe void DeselectText ()
		{
			if (id_deselectText == IntPtr.Zero)
				id_deselectText = JNIEnv.GetMethodID (class_ref, "deselectText", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deselectText);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HitLink (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_hitLink_FF;
		public unsafe global::Artifex.MuPdf.LinkInfo HitLink (float p0, float p1)
		{
			if (id_hitLink_FF == IntPtr.Zero)
				id_hitLink_FF = JNIEnv.GetMethodID (class_ref, "hitLink", "(FF)Lcom/artifex/mupdfdemo/LinkInfo;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.LinkInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hitLink_FF, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseBitmaps ();
		}
#pragma warning restore 0169

		IntPtr id_releaseBitmaps;
		public unsafe void ReleaseBitmaps ()
		{
			if (id_releaseBitmaps == IntPtr.Zero)
				id_releaseBitmaps = JNIEnv.GetMethodID (class_ref, "releaseBitmaps", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseBitmaps);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseResources ();
		}
#pragma warning restore 0169

		IntPtr id_releaseResources;
		public unsafe void ReleaseResources ()
		{
			if (id_releaseResources == IntPtr.Zero)
				id_releaseResources = JNIEnv.GetMethodID (class_ref, "releaseResources", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseResources);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveHq ();
		}
#pragma warning restore 0169

		IntPtr id_removeHq;
		public unsafe void RemoveHq ()
		{
			if (id_removeHq == IntPtr.Zero)
				id_removeHq = JNIEnv.GetMethodID (class_ref, "removeHq", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeHq);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SaveDraw ();
		}
#pragma warning restore 0169

		IntPtr id_saveDraw;
		public unsafe bool SaveDraw ()
		{
			if (id_saveDraw == IntPtr.Zero)
				id_saveDraw = JNIEnv.GetMethodID (class_ref, "saveDraw", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_saveDraw);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectText (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_selectText_FFFF;
		public unsafe void SelectText (float p0, float p1, float p2, float p3)
		{
			if (id_selectText_FFFF == IntPtr.Zero)
				id_selectText_FFFF = JNIEnv.GetMethodID (class_ref, "selectText", "(FFFF)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_selectText_FFFF, __args);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetChangeReporter (p0);
		}
#pragma warning restore 0169

		IntPtr id_setChangeReporter_Ljava_lang_Runnable_;
		public unsafe void SetChangeReporter (global::Java.Lang.IRunnable p0)
		{
			if (id_setChangeReporter_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setChangeReporter_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "setChangeReporter", "(Ljava/lang/Runnable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChangeReporter_Ljava_lang_Runnable_, __args);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLinkHighlighting (p0);
		}
#pragma warning restore 0169

		IntPtr id_setLinkHighlighting_Z;
		public unsafe void SetLinkHighlighting (bool p0)
		{
			if (id_setLinkHighlighting_Z == IntPtr.Zero)
				id_setLinkHighlighting_Z = JNIEnv.GetMethodID (class_ref, "setLinkHighlighting", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLinkHighlighting_Z, __args);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetPage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setPage_ILandroid_graphics_PointF_;
		public unsafe void SetPage (int p0, global::Android.Graphics.PointF p1)
		{
			if (id_setPage_ILandroid_graphics_PointF_ == IntPtr.Zero)
				id_setPage_ILandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "setPage", "(ILandroid/graphics/PointF;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPage_ILandroid_graphics_PointF_, __args);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScale (p0);
		}
#pragma warning restore 0169

		IntPtr id_setScale_F;
		public unsafe void SetScale (float p0)
		{
			if (id_setScale_F == IntPtr.Zero)
				id_setScale_F = JNIEnv.GetMethodID (class_ref, "setScale", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScale_F, __args);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF[] p0 = (global::Android.Graphics.RectF[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.RectF));
			__this.SetSearchBoxes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setSearchBoxes_arrayLandroid_graphics_RectF_;
		public unsafe void SetSearchBoxes (global::Android.Graphics.RectF[] p0)
		{
			if (id_setSearchBoxes_arrayLandroid_graphics_RectF_ == IntPtr.Zero)
				id_setSearchBoxes_arrayLandroid_graphics_RectF_ = JNIEnv.GetMethodID (class_ref, "setSearchBoxes", "([Landroid/graphics/RectF;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSearchBoxes_arrayLandroid_graphics_RectF_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDraw (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_startDraw_FF;
		public unsafe void StartDraw (float p0, float p1)
		{
			if (id_startDraw_FF == IntPtr.Zero)
				id_startDraw_FF = JNIEnv.GetMethodID (class_ref, "startDraw", "(FF)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startDraw_FF, __args);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update ();
		}
#pragma warning restore 0169

		IntPtr id_update;
		public unsafe void Update ()
		{
			if (id_update == IntPtr.Zero)
				id_update = JNIEnv.GetMethodID (class_ref, "update", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update);
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
			global::Artifex.MuPdf.IMuPDFView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.IMuPDFView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateHq (p0);
		}
#pragma warning restore 0169

		IntPtr id_updateHq_Z;
		public unsafe void UpdateHq (bool p0)
		{
			if (id_updateHq_Z == IntPtr.Zero)
				id_updateHq_Z = JNIEnv.GetMethodID (class_ref, "updateHq", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateHq_Z, __args);
		}

	}

}
