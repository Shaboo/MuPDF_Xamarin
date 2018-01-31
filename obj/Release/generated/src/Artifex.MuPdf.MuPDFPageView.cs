using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFPageView", DoNotGenerateAcw=true)]
	public partial class MuPDFPageView : global::Artifex.MuPdf.PageView, global::Artifex.MuPdf.IMuPDFView {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFPageView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuPDFPageView); }
		}

		protected MuPDFPageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_FilePicker_FilePickerSupport_Lcom_artifex_mupdfdemo_MuPDFCore_Landroid_graphics_Point_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']/constructor[@name='MuPDFPageView' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.artifex.mupdfdemo.FilePicker.FilePickerSupport'] and parameter[3][@type='com.artifex.mupdfdemo.MuPDFCore'] and parameter[4][@type='android.graphics.Point'] and parameter[5][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/artifex/mupdfdemo/FilePicker$FilePickerSupport;Lcom/artifex/mupdfdemo/MuPDFCore;Landroid/graphics/Point;Landroid/graphics/Bitmap;)V", "")]
		public unsafe MuPDFPageView (global::Android.Content.Context p0, global::Artifex.MuPdf.FilePicker.IFilePickerSupport p1, global::Artifex.MuPdf.MuPDFCore p2, global::Android.Graphics.Point p3, global::Android.Graphics.Bitmap p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (MuPDFPageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/artifex/mupdfdemo/FilePicker$FilePickerSupport;Lcom/artifex/mupdfdemo/MuPDFCore;Landroid/graphics/Point;Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/artifex/mupdfdemo/FilePicker$FilePickerSupport;Lcom/artifex/mupdfdemo/MuPDFCore;Landroid/graphics/Point;Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_FilePicker_FilePickerSupport_Lcom_artifex_mupdfdemo_MuPDFCore_Landroid_graphics_Point_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_FilePicker_FilePickerSupport_Lcom_artifex_mupdfdemo_MuPDFCore_Landroid_graphics_Point_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/artifex/mupdfdemo/FilePicker$FilePickerSupport;Lcom/artifex/mupdfdemo/MuPDFCore;Landroid/graphics/Point;Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_FilePicker_FilePickerSupport_Lcom_artifex_mupdfdemo_MuPDFCore_Landroid_graphics_Point_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_FilePicker_FilePickerSupport_Lcom_artifex_mupdfdemo_MuPDFCore_Landroid_graphics_Point_Landroid_graphics_Bitmap_, __args);
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
			global::Artifex.MuPdf.MuPDFPageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CopySelection ();
		}
#pragma warning restore 0169

		static IntPtr id_copySelection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']/method[@name='copySelection' and count(parameter)=0]"
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
			global::Artifex.MuPdf.MuPDFPageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteSelectedAnnotation ();
		}
#pragma warning restore 0169

		static IntPtr id_deleteSelectedAnnotation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']/method[@name='deleteSelectedAnnotation' and count(parameter)=0]"
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
			global::Artifex.MuPdf.MuPDFPageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeselectAnnotation ();
		}
#pragma warning restore 0169

		static IntPtr id_deselectAnnotation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']/method[@name='deselectAnnotation' and count(parameter)=0]"
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

		static Delegate cb_getDrawPageTask_Landroid_graphics_Bitmap_IIIIII;
#pragma warning disable 0169
		static Delegate GetGetDrawPageTask_Landroid_graphics_Bitmap_IIIIIIHandler ()
		{
			if (cb_getDrawPageTask_Landroid_graphics_Bitmap_IIIIII == null)
				cb_getDrawPageTask_Landroid_graphics_Bitmap_IIIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, IntPtr>) n_GetDrawPageTask_Landroid_graphics_Bitmap_IIIIII);
			return cb_getDrawPageTask_Landroid_graphics_Bitmap_IIIIII;
		}

		static IntPtr n_GetDrawPageTask_Landroid_graphics_Bitmap_IIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, int p5, int p6)
		{
			global::Artifex.MuPdf.MuPDFPageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDrawPageTask (p0, p1, p2, p3, p4, p5, p6));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDrawPageTask_Landroid_graphics_Bitmap_IIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']/method[@name='getDrawPageTask' and count(parameter)=7 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("getDrawPageTask", "(Landroid/graphics/Bitmap;IIIIII)Lcom/artifex/mupdfdemo/CancellableTaskDefinition;", "GetGetDrawPageTask_Landroid_graphics_Bitmap_IIIIIIHandler")]
		protected override unsafe global::Artifex.MuPdf.ICancellableTaskDefinition GetDrawPageTask (global::Android.Graphics.Bitmap p0, int p1, int p2, int p3, int p4, int p5, int p6)
		{
			if (id_getDrawPageTask_Landroid_graphics_Bitmap_IIIIII == IntPtr.Zero)
				id_getDrawPageTask_Landroid_graphics_Bitmap_IIIIII = JNIEnv.GetMethodID (class_ref, "getDrawPageTask", "(Landroid/graphics/Bitmap;IIIIII)Lcom/artifex/mupdfdemo/CancellableTaskDefinition;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				global::Artifex.MuPdf.ICancellableTaskDefinition __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ICancellableTaskDefinition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawPageTask_Landroid_graphics_Bitmap_IIIIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ICancellableTaskDefinition> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawPageTask", "(Landroid/graphics/Bitmap;IIIIII)Lcom/artifex/mupdfdemo/CancellableTaskDefinition;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getLinkInfo;
#pragma warning disable 0169
		static Delegate GetGetLinkInfoHandler ()
		{
			if (cb_getLinkInfo == null)
				cb_getLinkInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLinkInfo);
			return cb_getLinkInfo;
		}

		static IntPtr n_GetLinkInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFPageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLinkInfo ());
		}
#pragma warning restore 0169

		static IntPtr id_getLinkInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']/method[@name='getLinkInfo' and count(parameter)=0]"
		[Register ("getLinkInfo", "()[Lcom/artifex/mupdfdemo/LinkInfo;", "GetGetLinkInfoHandler")]
		protected override unsafe global::Artifex.MuPdf.LinkInfo[] GetLinkInfo ()
		{
			if (id_getLinkInfo == IntPtr.Zero)
				id_getLinkInfo = JNIEnv.GetMethodID (class_ref, "getLinkInfo", "()[Lcom/artifex/mupdfdemo/LinkInfo;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Artifex.MuPdf.LinkInfo[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLinkInfo), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.LinkInfo));
				else
					return (global::Artifex.MuPdf.LinkInfo[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLinkInfo", "()[Lcom/artifex/mupdfdemo/LinkInfo;")), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.LinkInfo));
			} finally {
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFPageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetText ());
		}
#pragma warning restore 0169

		static IntPtr id_getText;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']/method[@name='getText' and count(parameter)=0]"
		[Register ("getText", "()[[Lcom/artifex/mupdfdemo/TextWord;", "GetGetTextHandler")]
		protected override unsafe global::Artifex.MuPdf.TextWord[][] GetText ()
		{
			if (id_getText == IntPtr.Zero)
				id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()[[Lcom/artifex/mupdfdemo/TextWord;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Artifex.MuPdf.TextWord[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getText), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.TextWord[]));
				else
					return (global::Artifex.MuPdf.TextWord[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getText", "()[[Lcom/artifex/mupdfdemo/TextWord;")), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.TextWord[]));
			} finally {
			}
		}

		static Delegate cb_getUpdatePageTask_Landroid_graphics_Bitmap_IIIIII;
#pragma warning disable 0169
		static Delegate GetGetUpdatePageTask_Landroid_graphics_Bitmap_IIIIIIHandler ()
		{
			if (cb_getUpdatePageTask_Landroid_graphics_Bitmap_IIIIII == null)
				cb_getUpdatePageTask_Landroid_graphics_Bitmap_IIIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, IntPtr>) n_GetUpdatePageTask_Landroid_graphics_Bitmap_IIIIII);
			return cb_getUpdatePageTask_Landroid_graphics_Bitmap_IIIIII;
		}

		static IntPtr n_GetUpdatePageTask_Landroid_graphics_Bitmap_IIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, int p5, int p6)
		{
			global::Artifex.MuPdf.MuPDFPageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUpdatePageTask (p0, p1, p2, p3, p4, p5, p6));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUpdatePageTask_Landroid_graphics_Bitmap_IIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']/method[@name='getUpdatePageTask' and count(parameter)=7 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("getUpdatePageTask", "(Landroid/graphics/Bitmap;IIIIII)Lcom/artifex/mupdfdemo/CancellableTaskDefinition;", "GetGetUpdatePageTask_Landroid_graphics_Bitmap_IIIIIIHandler")]
		protected override unsafe global::Artifex.MuPdf.ICancellableTaskDefinition GetUpdatePageTask (global::Android.Graphics.Bitmap p0, int p1, int p2, int p3, int p4, int p5, int p6)
		{
			if (id_getUpdatePageTask_Landroid_graphics_Bitmap_IIIIII == IntPtr.Zero)
				id_getUpdatePageTask_Landroid_graphics_Bitmap_IIIIII = JNIEnv.GetMethodID (class_ref, "getUpdatePageTask", "(Landroid/graphics/Bitmap;IIIIII)Lcom/artifex/mupdfdemo/CancellableTaskDefinition;");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				global::Artifex.MuPdf.ICancellableTaskDefinition __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ICancellableTaskDefinition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdatePageTask_Landroid_graphics_Bitmap_IIIIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ICancellableTaskDefinition> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdatePageTask", "(Landroid/graphics/Bitmap;IIIIII)Lcom/artifex/mupdfdemo/CancellableTaskDefinition;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Artifex.MuPdf.MuPDFPageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HitLink (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_hitLink_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']/method[@name='hitLink' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
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
			global::Artifex.MuPdf.MuPDFPageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SaveDraw ();
		}
#pragma warning restore 0169

		static IntPtr id_saveDraw;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']/method[@name='saveDraw' and count(parameter)=0]"
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
			global::Artifex.MuPdf.MuPDFPageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetChangeReporter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setChangeReporter_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']/method[@name='setChangeReporter' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
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
			global::Artifex.MuPdf.MuPDFPageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScale (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScale_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageView']/method[@name='setScale' and count(parameter)=1 and parameter[1][@type='float']]"
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

	}
}
