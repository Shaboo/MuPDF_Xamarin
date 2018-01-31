using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageAdapter']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFPageAdapter", DoNotGenerateAcw=true)]
	public partial class MuPDFPageAdapter : global::Android.Widget.BaseAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFPageAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuPDFPageAdapter); }
		}

		protected MuPDFPageAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_FilePicker_FilePickerSupport_Lcom_artifex_mupdfdemo_MuPDFCore_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageAdapter']/constructor[@name='MuPDFPageAdapter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.artifex.mupdfdemo.FilePicker.FilePickerSupport'] and parameter[3][@type='com.artifex.mupdfdemo.MuPDFCore']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/artifex/mupdfdemo/FilePicker$FilePickerSupport;Lcom/artifex/mupdfdemo/MuPDFCore;)V", "")]
		public unsafe MuPDFPageAdapter (global::Android.Content.Context p0, global::Artifex.MuPdf.FilePicker.IFilePickerSupport p1, global::Artifex.MuPdf.MuPDFCore p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MuPDFPageAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/artifex/mupdfdemo/FilePicker$FilePickerSupport;Lcom/artifex/mupdfdemo/MuPDFCore;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/artifex/mupdfdemo/FilePicker$FilePickerSupport;Lcom/artifex/mupdfdemo/MuPDFCore;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_FilePicker_FilePickerSupport_Lcom_artifex_mupdfdemo_MuPDFCore_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_FilePicker_FilePickerSupport_Lcom_artifex_mupdfdemo_MuPDFCore_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/artifex/mupdfdemo/FilePicker$FilePickerSupport;Lcom/artifex/mupdfdemo/MuPDFCore;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_FilePicker_FilePickerSupport_Lcom_artifex_mupdfdemo_MuPDFCore_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_artifex_mupdfdemo_FilePicker_FilePickerSupport_Lcom_artifex_mupdfdemo_MuPDFCore_, __args);
			} finally {
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFPageAdapter __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.MuPDFPageAdapter __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
		public override unsafe global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getItemId_I;
#pragma warning disable 0169
		static Delegate GetGetItemId_IHandler ()
		{
			if (cb_getItemId_I == null)
				cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
			return cb_getItemId_I;
		}

		static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.MuPDFPageAdapter __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
		public override unsafe long GetItemId (int p0)
		{
			if (id_getItemId_I == IntPtr.Zero)
				id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getItemId_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemId", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Artifex.MuPdf.MuPDFPageAdapter __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public override unsafe global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Artifex.MuPdf.MuPDFPageAdapter __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseBitmaps ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseBitmaps;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFPageAdapter']/method[@name='releaseBitmaps' and count(parameter)=0]"
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

	}
}
