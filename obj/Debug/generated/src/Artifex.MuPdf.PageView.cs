using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/PageView", DoNotGenerateAcw=true)]
	public abstract partial class PageView : global::Android.Views.ViewGroup {


		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mDrawing_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/field[@name='mDrawing']"
		[Register ("mDrawing")]
		protected global::System.Collections.IList MDrawing {
			get {
				if (mDrawing_jfieldId == IntPtr.Zero)
					mDrawing_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawing", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mDrawing_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDrawing_jfieldId == IntPtr.Zero)
					mDrawing_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawing", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDrawing_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mLinks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/field[@name='mLinks']"
		[Register ("mLinks")]
		protected IList<Artifex.MuPdf.LinkInfo> MLinks {
			get {
				if (mLinks_jfieldId == IntPtr.Zero)
					mLinks_jfieldId = JNIEnv.GetFieldID (class_ref, "mLinks", "[Lcom/artifex/mupdfdemo/LinkInfo;");
				return global::Android.Runtime.JavaArray<global::Artifex.MuPdf.LinkInfo>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mLinks_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLinks_jfieldId == IntPtr.Zero)
					mLinks_jfieldId = JNIEnv.GetFieldID (class_ref, "mLinks", "[Lcom/artifex/mupdfdemo/LinkInfo;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Artifex.MuPdf.LinkInfo>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLinks_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mPageNumber_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/field[@name='mPageNumber']"
		[Register ("mPageNumber")]
		protected int MPageNumber {
			get {
				if (mPageNumber_jfieldId == IntPtr.Zero)
					mPageNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "mPageNumber", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mPageNumber_jfieldId);
			}
			set {
				if (mPageNumber_jfieldId == IntPtr.Zero)
					mPageNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "mPageNumber", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPageNumber_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/field[@name='mSize']"
		[Register ("mSize")]
		protected global::Android.Graphics.Point MSize {
			get {
				if (mSize_jfieldId == IntPtr.Zero)
					mSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mSize", "Landroid/graphics/Point;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSize_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSize_jfieldId == IntPtr.Zero)
					mSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mSize", "Landroid/graphics/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSize_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSourceScale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/field[@name='mSourceScale']"
		[Register ("mSourceScale")]
		protected float MSourceScale {
			get {
				if (mSourceScale_jfieldId == IntPtr.Zero)
					mSourceScale_jfieldId = JNIEnv.GetFieldID (class_ref, "mSourceScale", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, mSourceScale_jfieldId);
			}
			set {
				if (mSourceScale_jfieldId == IntPtr.Zero)
					mSourceScale_jfieldId = JNIEnv.GetFieldID (class_ref, "mSourceScale", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSourceScale_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/PageView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PageView); }
		}

		protected PageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_graphics_Point_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/constructor[@name='PageView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.Point'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/graphics/Point;Landroid/graphics/Bitmap;)V", "")]
		public unsafe PageView (global::Android.Content.Context p0, global::Android.Graphics.Point p1, global::Android.Graphics.Bitmap p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (PageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/graphics/Point;Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/graphics/Point;Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_graphics_Point_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_graphics_Point_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/graphics/Point;Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_graphics_Point_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_graphics_Point_Landroid_graphics_Bitmap_, __args);
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Page;
		}
#pragma warning restore 0169

		static IntPtr id_getPage;
		public virtual unsafe int Page {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='getPage' and count(parameter)=0]"
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Blank (p0);
		}
#pragma warning restore 0169

		static IntPtr id_blank_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='blank' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelDraw ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelDraw;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='cancelDraw' and count(parameter)=0]"
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContinueDraw (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_continueDraw_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='continueDraw' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeselectText ();
		}
#pragma warning restore 0169

		static IntPtr id_deselectText;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='deselectText' and count(parameter)=0]"
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

		static Delegate cb_getDraw;
#pragma warning disable 0169
		static Delegate GetGetDrawHandler ()
		{
			if (cb_getDraw == null)
				cb_getDraw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDraw);
			return cb_getDraw;
		}

		static IntPtr n_GetDraw (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDraw ());
		}
#pragma warning restore 0169

		static IntPtr id_getDraw;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='getDraw' and count(parameter)=0]"
		[Register ("getDraw", "()[[Landroid/graphics/PointF;", "GetGetDrawHandler")]
		protected virtual unsafe global::Android.Graphics.PointF[][] GetDraw ()
		{
			if (id_getDraw == IntPtr.Zero)
				id_getDraw = JNIEnv.GetMethodID (class_ref, "getDraw", "()[[Landroid/graphics/PointF;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Android.Graphics.PointF[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDraw), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Graphics.PointF[]));
				else
					return (global::Android.Graphics.PointF[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDraw", "()[[Landroid/graphics/PointF;")), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Graphics.PointF[]));
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDrawPageTask (p0, p1, p2, p3, p4, p5, p6));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='getDrawPageTask' and count(parameter)=7 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("getDrawPageTask", "(Landroid/graphics/Bitmap;IIIIII)Lcom/artifex/mupdfdemo/CancellableTaskDefinition;", "GetGetDrawPageTask_Landroid_graphics_Bitmap_IIIIIIHandler")]
		protected abstract global::Artifex.MuPdf.ICancellableTaskDefinition GetDrawPageTask (global::Android.Graphics.Bitmap p0, int p1, int p2, int p3, int p4, int p5, int p6);

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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLinkInfo ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='getLinkInfo' and count(parameter)=0]"
		[Register ("getLinkInfo", "()[Lcom/artifex/mupdfdemo/LinkInfo;", "GetGetLinkInfoHandler")]
		protected abstract global::Artifex.MuPdf.LinkInfo[] GetLinkInfo ();

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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetText ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='getText' and count(parameter)=0]"
		[Register ("getText", "()[[Lcom/artifex/mupdfdemo/TextWord;", "GetGetTextHandler")]
		protected abstract global::Artifex.MuPdf.TextWord[][] GetText ();

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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUpdatePageTask (p0, p1, p2, p3, p4, p5, p6));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='getUpdatePageTask' and count(parameter)=7 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("getUpdatePageTask", "(Landroid/graphics/Bitmap;IIIIII)Lcom/artifex/mupdfdemo/CancellableTaskDefinition;", "GetGetUpdatePageTask_Landroid_graphics_Bitmap_IIIIIIHandler")]
		protected abstract global::Artifex.MuPdf.ICancellableTaskDefinition GetUpdatePageTask (global::Android.Graphics.Bitmap p0, int p1, int p2, int p3, int p4, int p5, int p6);

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, int p3, int p4)
		{
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLayout_ZIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayout", "(ZIIII)V"), __args);
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseBitmaps ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseBitmaps;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='releaseBitmaps' and count(parameter)=0]"
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseResources ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseResources;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='releaseResources' and count(parameter)=0]"
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveHq ();
		}
#pragma warning restore 0169

		static IntPtr id_removeHq;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='removeHq' and count(parameter)=0]"
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectText (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_selectText_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='selectText' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
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

		static Delegate cb_setItemSelectBox_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetSetItemSelectBox_Landroid_graphics_RectF_Handler ()
		{
			if (cb_setItemSelectBox_Landroid_graphics_RectF_ == null)
				cb_setItemSelectBox_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetItemSelectBox_Landroid_graphics_RectF_);
			return cb_setItemSelectBox_Landroid_graphics_RectF_;
		}

		static void n_SetItemSelectBox_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetItemSelectBox (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setItemSelectBox_Landroid_graphics_RectF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='setItemSelectBox' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
		[Register ("setItemSelectBox", "(Landroid/graphics/RectF;)V", "GetSetItemSelectBox_Landroid_graphics_RectF_Handler")]
		public virtual unsafe void SetItemSelectBox (global::Android.Graphics.RectF p0)
		{
			if (id_setItemSelectBox_Landroid_graphics_RectF_ == IntPtr.Zero)
				id_setItemSelectBox_Landroid_graphics_RectF_ = JNIEnv.GetMethodID (class_ref, "setItemSelectBox", "(Landroid/graphics/RectF;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemSelectBox_Landroid_graphics_RectF_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemSelectBox", "(Landroid/graphics/RectF;)V"), __args);
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLinkHighlighting (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLinkHighlighting_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='setLinkHighlighting' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetPage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setPage_ILandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='setPage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.PointF']]"
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF[] p0 = (global::Android.Graphics.RectF[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.RectF));
			__this.SetSearchBoxes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSearchBoxes_arrayLandroid_graphics_RectF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='setSearchBoxes' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF[]']]"
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDraw (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startDraw_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='startDraw' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update ();
		}
#pragma warning restore 0169

		static IntPtr id_update;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='update' and count(parameter)=0]"
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
			global::Artifex.MuPdf.PageView __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.PageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateHq (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateHq_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='updateHq' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/PageView", DoNotGenerateAcw=true)]
	internal partial class PageViewInvoker : PageView {

		public PageViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PageViewInvoker); }
		}

		static IntPtr id_getDrawPageTask_Landroid_graphics_Bitmap_IIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='getDrawPageTask' and count(parameter)=7 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
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
				global::Artifex.MuPdf.ICancellableTaskDefinition __ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ICancellableTaskDefinition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawPageTask_Landroid_graphics_Bitmap_IIIIII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLinkInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='getLinkInfo' and count(parameter)=0]"
		[Register ("getLinkInfo", "()[Lcom/artifex/mupdfdemo/LinkInfo;", "GetGetLinkInfoHandler")]
		protected override unsafe global::Artifex.MuPdf.LinkInfo[] GetLinkInfo ()
		{
			if (id_getLinkInfo == IntPtr.Zero)
				id_getLinkInfo = JNIEnv.GetMethodID (class_ref, "getLinkInfo", "()[Lcom/artifex/mupdfdemo/LinkInfo;");
			try {
				return (global::Artifex.MuPdf.LinkInfo[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLinkInfo), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.LinkInfo));
			} finally {
			}
		}

		static IntPtr id_getText;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='getText' and count(parameter)=0]"
		[Register ("getText", "()[[Lcom/artifex/mupdfdemo/TextWord;", "GetGetTextHandler")]
		protected override unsafe global::Artifex.MuPdf.TextWord[][] GetText ()
		{
			if (id_getText == IntPtr.Zero)
				id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()[[Lcom/artifex/mupdfdemo/TextWord;");
			try {
				return (global::Artifex.MuPdf.TextWord[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getText), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.TextWord[]));
			} finally {
			}
		}

		static IntPtr id_getUpdatePageTask_Landroid_graphics_Bitmap_IIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='PageView']/method[@name='getUpdatePageTask' and count(parameter)=7 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
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
				global::Artifex.MuPdf.ICancellableTaskDefinition __ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ICancellableTaskDefinition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdatePageTask_Landroid_graphics_Bitmap_IIIIII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
