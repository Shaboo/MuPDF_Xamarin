using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFActivity", DoNotGenerateAcw=true)]
	public partial class MuPDFActivity : global::Android.App.Activity, global::Artifex.MuPdf.FilePicker.IFilePickerSupport {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.AcceptMode']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFActivity$AcceptMode", DoNotGenerateAcw=true)]
		public sealed partial class AcceptMode : global::Java.Lang.Enum {


			static IntPtr CopyText_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.AcceptMode']/field[@name='CopyText']"
			[Register ("CopyText")]
			public static global::Artifex.MuPdf.MuPDFActivity.AcceptMode CopyText {
				get {
					if (CopyText_jfieldId == IntPtr.Zero)
						CopyText_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CopyText", "Lcom/artifex/mupdfdemo/MuPDFActivity$AcceptMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CopyText_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity.AcceptMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Highlight_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.AcceptMode']/field[@name='Highlight']"
			[Register ("Highlight")]
			public static global::Artifex.MuPdf.MuPDFActivity.AcceptMode Highlight {
				get {
					if (Highlight_jfieldId == IntPtr.Zero)
						Highlight_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Highlight", "Lcom/artifex/mupdfdemo/MuPDFActivity$AcceptMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Highlight_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity.AcceptMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Ink_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.AcceptMode']/field[@name='Ink']"
			[Register ("Ink")]
			public static global::Artifex.MuPdf.MuPDFActivity.AcceptMode Ink {
				get {
					if (Ink_jfieldId == IntPtr.Zero)
						Ink_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ink", "Lcom/artifex/mupdfdemo/MuPDFActivity$AcceptMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ink_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity.AcceptMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr StrikeOut_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.AcceptMode']/field[@name='StrikeOut']"
			[Register ("StrikeOut")]
			public static global::Artifex.MuPdf.MuPDFActivity.AcceptMode StrikeOut {
				get {
					if (StrikeOut_jfieldId == IntPtr.Zero)
						StrikeOut_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "StrikeOut", "Lcom/artifex/mupdfdemo/MuPDFActivity$AcceptMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, StrikeOut_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity.AcceptMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Underline_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.AcceptMode']/field[@name='Underline']"
			[Register ("Underline")]
			public static global::Artifex.MuPdf.MuPDFActivity.AcceptMode Underline {
				get {
					if (Underline_jfieldId == IntPtr.Zero)
						Underline_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Underline", "Lcom/artifex/mupdfdemo/MuPDFActivity$AcceptMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Underline_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity.AcceptMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFActivity$AcceptMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AcceptMode); }
			}

			internal AcceptMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.TopBarMode']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFActivity$TopBarMode", DoNotGenerateAcw=true)]
		public sealed partial class TopBarMode : global::Java.Lang.Enum {


			static IntPtr Accept_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.TopBarMode']/field[@name='Accept']"
			[Register ("Accept")]
			public static global::Artifex.MuPdf.MuPDFActivity.TopBarMode Accept {
				get {
					if (Accept_jfieldId == IntPtr.Zero)
						Accept_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Accept", "Lcom/artifex/mupdfdemo/MuPDFActivity$TopBarMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Accept_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity.TopBarMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Annot_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.TopBarMode']/field[@name='Annot']"
			[Register ("Annot")]
			public static global::Artifex.MuPdf.MuPDFActivity.TopBarMode Annot {
				get {
					if (Annot_jfieldId == IntPtr.Zero)
						Annot_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Annot", "Lcom/artifex/mupdfdemo/MuPDFActivity$TopBarMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Annot_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity.TopBarMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Delete_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.TopBarMode']/field[@name='Delete']"
			[Register ("Delete")]
			public static global::Artifex.MuPdf.MuPDFActivity.TopBarMode Delete {
				get {
					if (Delete_jfieldId == IntPtr.Zero)
						Delete_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Delete", "Lcom/artifex/mupdfdemo/MuPDFActivity$TopBarMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Delete_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity.TopBarMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Main_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.TopBarMode']/field[@name='Main']"
			[Register ("Main")]
			public static global::Artifex.MuPdf.MuPDFActivity.TopBarMode Main {
				get {
					if (Main_jfieldId == IntPtr.Zero)
						Main_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Main", "Lcom/artifex/mupdfdemo/MuPDFActivity$TopBarMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Main_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity.TopBarMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr More_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.TopBarMode']/field[@name='More']"
			[Register ("More")]
			public static global::Artifex.MuPdf.MuPDFActivity.TopBarMode More {
				get {
					if (More_jfieldId == IntPtr.Zero)
						More_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "More", "Lcom/artifex/mupdfdemo/MuPDFActivity$TopBarMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, More_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity.TopBarMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Search_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity.TopBarMode']/field[@name='Search']"
			[Register ("Search")]
			public static global::Artifex.MuPdf.MuPDFActivity.TopBarMode Search {
				get {
					if (Search_jfieldId == IntPtr.Zero)
						Search_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Search", "Lcom/artifex/mupdfdemo/MuPDFActivity$TopBarMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Search_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity.TopBarMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFActivity$TopBarMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TopBarMode); }
			}

			internal TopBarMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuPDFActivity); }
		}

		protected MuPDFActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/constructor[@name='MuPDFActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MuPDFActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MuPDFActivity)) {
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

		static IntPtr id_getAlertBuilder;
		public static unsafe global::Android.App.AlertDialog.Builder AlertBuilder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='getAlertBuilder' and count(parameter)=0]"
			[Register ("getAlertBuilder", "()Landroid/app/AlertDialog$Builder;", "GetGetAlertBuilderHandler")]
			get {
				if (id_getAlertBuilder == IntPtr.Zero)
					id_getAlertBuilder = JNIEnv.GetStaticMethodID (class_ref, "getAlertBuilder", "()Landroid/app/AlertDialog$Builder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.App.AlertDialog.Builder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAlertBuilder), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isProofing;
#pragma warning disable 0169
		static Delegate GetIsProofingHandler ()
		{
			if (cb_isProofing == null)
				cb_isProofing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsProofing);
			return cb_isProofing;
		}

		static bool n_IsProofing (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsProofing;
		}
#pragma warning restore 0169

		static IntPtr id_isProofing;
		public virtual unsafe bool IsProofing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='isProofing' and count(parameter)=0]"
			[Register ("isProofing", "()Z", "GetIsProofingHandler")]
			get {
				if (id_isProofing == IntPtr.Zero)
					id_isProofing = JNIEnv.GetMethodID (class_ref, "isProofing", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isProofing);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isProofing", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_OnAcceptButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnAcceptButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnAcceptButtonClick_Landroid_view_View_ == null)
				cb_OnAcceptButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAcceptButtonClick_Landroid_view_View_);
			return cb_OnAcceptButtonClick_Landroid_view_View_;
		}

		static void n_OnAcceptButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAcceptButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnAcceptButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnAcceptButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnAcceptButtonClick", "(Landroid/view/View;)V", "GetOnAcceptButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnAcceptButtonClick (global::Android.Views.View p0)
		{
			if (id_OnAcceptButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnAcceptButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnAcceptButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnAcceptButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnAcceptButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnCancelAcceptButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnCancelAcceptButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnCancelAcceptButtonClick_Landroid_view_View_ == null)
				cb_OnCancelAcceptButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancelAcceptButtonClick_Landroid_view_View_);
			return cb_OnCancelAcceptButtonClick_Landroid_view_View_;
		}

		static void n_OnCancelAcceptButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelAcceptButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnCancelAcceptButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnCancelAcceptButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnCancelAcceptButtonClick", "(Landroid/view/View;)V", "GetOnCancelAcceptButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnCancelAcceptButtonClick (global::Android.Views.View p0)
		{
			if (id_OnCancelAcceptButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnCancelAcceptButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnCancelAcceptButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCancelAcceptButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnCancelAcceptButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnCancelAnnotButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnCancelAnnotButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnCancelAnnotButtonClick_Landroid_view_View_ == null)
				cb_OnCancelAnnotButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancelAnnotButtonClick_Landroid_view_View_);
			return cb_OnCancelAnnotButtonClick_Landroid_view_View_;
		}

		static void n_OnCancelAnnotButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelAnnotButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnCancelAnnotButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnCancelAnnotButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnCancelAnnotButtonClick", "(Landroid/view/View;)V", "GetOnCancelAnnotButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnCancelAnnotButtonClick (global::Android.Views.View p0)
		{
			if (id_OnCancelAnnotButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnCancelAnnotButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnCancelAnnotButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCancelAnnotButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnCancelAnnotButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnCancelDeleteButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnCancelDeleteButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnCancelDeleteButtonClick_Landroid_view_View_ == null)
				cb_OnCancelDeleteButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancelDeleteButtonClick_Landroid_view_View_);
			return cb_OnCancelDeleteButtonClick_Landroid_view_View_;
		}

		static void n_OnCancelDeleteButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelDeleteButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnCancelDeleteButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnCancelDeleteButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnCancelDeleteButtonClick", "(Landroid/view/View;)V", "GetOnCancelDeleteButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnCancelDeleteButtonClick (global::Android.Views.View p0)
		{
			if (id_OnCancelDeleteButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnCancelDeleteButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnCancelDeleteButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCancelDeleteButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnCancelDeleteButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnCancelMoreButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnCancelMoreButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnCancelMoreButtonClick_Landroid_view_View_ == null)
				cb_OnCancelMoreButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancelMoreButtonClick_Landroid_view_View_);
			return cb_OnCancelMoreButtonClick_Landroid_view_View_;
		}

		static void n_OnCancelMoreButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelMoreButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnCancelMoreButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnCancelMoreButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnCancelMoreButtonClick", "(Landroid/view/View;)V", "GetOnCancelMoreButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnCancelMoreButtonClick (global::Android.Views.View p0)
		{
			if (id_OnCancelMoreButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnCancelMoreButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnCancelMoreButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCancelMoreButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnCancelMoreButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnCancelSearchButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnCancelSearchButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnCancelSearchButtonClick_Landroid_view_View_ == null)
				cb_OnCancelSearchButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancelSearchButtonClick_Landroid_view_View_);
			return cb_OnCancelSearchButtonClick_Landroid_view_View_;
		}

		static void n_OnCancelSearchButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelSearchButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnCancelSearchButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnCancelSearchButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnCancelSearchButtonClick", "(Landroid/view/View;)V", "GetOnCancelSearchButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnCancelSearchButtonClick (global::Android.Views.View p0)
		{
			if (id_OnCancelSearchButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnCancelSearchButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnCancelSearchButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCancelSearchButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnCancelSearchButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnCopyTextButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnCopyTextButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnCopyTextButtonClick_Landroid_view_View_ == null)
				cb_OnCopyTextButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCopyTextButtonClick_Landroid_view_View_);
			return cb_OnCopyTextButtonClick_Landroid_view_View_;
		}

		static void n_OnCopyTextButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCopyTextButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnCopyTextButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnCopyTextButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnCopyTextButtonClick", "(Landroid/view/View;)V", "GetOnCopyTextButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnCopyTextButtonClick (global::Android.Views.View p0)
		{
			if (id_OnCopyTextButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnCopyTextButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnCopyTextButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCopyTextButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnCopyTextButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnDeleteButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnDeleteButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnDeleteButtonClick_Landroid_view_View_ == null)
				cb_OnDeleteButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDeleteButtonClick_Landroid_view_View_);
			return cb_OnDeleteButtonClick_Landroid_view_View_;
		}

		static void n_OnDeleteButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDeleteButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnDeleteButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnDeleteButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnDeleteButtonClick", "(Landroid/view/View;)V", "GetOnDeleteButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnDeleteButtonClick (global::Android.Views.View p0)
		{
			if (id_OnDeleteButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnDeleteButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnDeleteButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnDeleteButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnDeleteButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnEditAnnotButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnEditAnnotButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnEditAnnotButtonClick_Landroid_view_View_ == null)
				cb_OnEditAnnotButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEditAnnotButtonClick_Landroid_view_View_);
			return cb_OnEditAnnotButtonClick_Landroid_view_View_;
		}

		static void n_OnEditAnnotButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEditAnnotButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnEditAnnotButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnEditAnnotButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnEditAnnotButtonClick", "(Landroid/view/View;)V", "GetOnEditAnnotButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnEditAnnotButtonClick (global::Android.Views.View p0)
		{
			if (id_OnEditAnnotButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnEditAnnotButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnEditAnnotButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnEditAnnotButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnEditAnnotButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnHighlightButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnHighlightButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnHighlightButtonClick_Landroid_view_View_ == null)
				cb_OnHighlightButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHighlightButtonClick_Landroid_view_View_);
			return cb_OnHighlightButtonClick_Landroid_view_View_;
		}

		static void n_OnHighlightButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHighlightButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnHighlightButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnHighlightButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnHighlightButtonClick", "(Landroid/view/View;)V", "GetOnHighlightButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnHighlightButtonClick (global::Android.Views.View p0)
		{
			if (id_OnHighlightButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnHighlightButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnHighlightButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnHighlightButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnHighlightButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnInkButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnInkButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnInkButtonClick_Landroid_view_View_ == null)
				cb_OnInkButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInkButtonClick_Landroid_view_View_);
			return cb_OnInkButtonClick_Landroid_view_View_;
		}

		static void n_OnInkButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInkButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnInkButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnInkButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnInkButtonClick", "(Landroid/view/View;)V", "GetOnInkButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnInkButtonClick (global::Android.Views.View p0)
		{
			if (id_OnInkButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnInkButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnInkButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnInkButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnInkButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnMoreButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnMoreButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnMoreButtonClick_Landroid_view_View_ == null)
				cb_OnMoreButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMoreButtonClick_Landroid_view_View_);
			return cb_OnMoreButtonClick_Landroid_view_View_;
		}

		static void n_OnMoreButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMoreButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnMoreButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnMoreButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnMoreButtonClick", "(Landroid/view/View;)V", "GetOnMoreButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnMoreButtonClick (global::Android.Views.View p0)
		{
			if (id_OnMoreButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnMoreButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnMoreButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMoreButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnMoreButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnPrintButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnPrintButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnPrintButtonClick_Landroid_view_View_ == null)
				cb_OnPrintButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPrintButtonClick_Landroid_view_View_);
			return cb_OnPrintButtonClick_Landroid_view_View_;
		}

		static void n_OnPrintButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPrintButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnPrintButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnPrintButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnPrintButtonClick", "(Landroid/view/View;)V", "GetOnPrintButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnPrintButtonClick (global::Android.Views.View p0)
		{
			if (id_OnPrintButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnPrintButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnPrintButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnPrintButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnPrintButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnProofButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnProofButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnProofButtonClick_Landroid_view_View_ == null)
				cb_OnProofButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProofButtonClick_Landroid_view_View_);
			return cb_OnProofButtonClick_Landroid_view_View_;
		}

		static void n_OnProofButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnProofButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnProofButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnProofButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnProofButtonClick", "(Landroid/view/View;)V", "GetOnProofButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnProofButtonClick (global::Android.Views.View p0)
		{
			if (id_OnProofButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnProofButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnProofButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnProofButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnProofButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnSepsButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnSepsButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnSepsButtonClick_Landroid_view_View_ == null)
				cb_OnSepsButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSepsButtonClick_Landroid_view_View_);
			return cb_OnSepsButtonClick_Landroid_view_View_;
		}

		static void n_OnSepsButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSepsButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnSepsButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnSepsButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnSepsButtonClick", "(Landroid/view/View;)V", "GetOnSepsButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnSepsButtonClick (global::Android.Views.View p0)
		{
			if (id_OnSepsButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnSepsButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnSepsButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnSepsButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnSepsButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnStrikeOutButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnStrikeOutButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnStrikeOutButtonClick_Landroid_view_View_ == null)
				cb_OnStrikeOutButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStrikeOutButtonClick_Landroid_view_View_);
			return cb_OnStrikeOutButtonClick_Landroid_view_View_;
		}

		static void n_OnStrikeOutButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStrikeOutButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnStrikeOutButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnStrikeOutButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnStrikeOutButtonClick", "(Landroid/view/View;)V", "GetOnStrikeOutButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnStrikeOutButtonClick (global::Android.Views.View p0)
		{
			if (id_OnStrikeOutButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnStrikeOutButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnStrikeOutButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnStrikeOutButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnStrikeOutButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_OnUnderlineButtonClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnUnderlineButtonClick_Landroid_view_View_Handler ()
		{
			if (cb_OnUnderlineButtonClick_Landroid_view_View_ == null)
				cb_OnUnderlineButtonClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUnderlineButtonClick_Landroid_view_View_);
			return cb_OnUnderlineButtonClick_Landroid_view_View_;
		}

		static void n_OnUnderlineButtonClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUnderlineButtonClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_OnUnderlineButtonClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='OnUnderlineButtonClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("OnUnderlineButtonClick", "(Landroid/view/View;)V", "GetOnUnderlineButtonClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnUnderlineButtonClick (global::Android.Views.View p0)
		{
			if (id_OnUnderlineButtonClick_Landroid_view_View_ == IntPtr.Zero)
				id_OnUnderlineButtonClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "OnUnderlineButtonClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnUnderlineButtonClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnUnderlineButtonClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_createAlertWaiter;
#pragma warning disable 0169
		static Delegate GetCreateAlertWaiterHandler ()
		{
			if (cb_createAlertWaiter == null)
				cb_createAlertWaiter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CreateAlertWaiter);
			return cb_createAlertWaiter;
		}

		static void n_CreateAlertWaiter (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateAlertWaiter ();
		}
#pragma warning restore 0169

		static IntPtr id_createAlertWaiter;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='createAlertWaiter' and count(parameter)=0]"
		[Register ("createAlertWaiter", "()V", "GetCreateAlertWaiterHandler")]
		public virtual unsafe void CreateAlertWaiter ()
		{
			if (id_createAlertWaiter == IntPtr.Zero)
				id_createAlertWaiter = JNIEnv.GetMethodID (class_ref, "createAlertWaiter", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createAlertWaiter);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAlertWaiter", "()V"));
			} finally {
			}
		}

		static Delegate cb_createUI_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetCreateUI_Landroid_os_Bundle_Handler ()
		{
			if (cb_createUI_Landroid_os_Bundle_ == null)
				cb_createUI_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateUI_Landroid_os_Bundle_);
			return cb_createUI_Landroid_os_Bundle_;
		}

		static void n_CreateUI_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateUI (p0);
		}
#pragma warning restore 0169

		static IntPtr id_createUI_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='createUI' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("createUI", "(Landroid/os/Bundle;)V", "GetCreateUI_Landroid_os_Bundle_Handler")]
		public virtual unsafe void CreateUI (global::Android.OS.Bundle p0)
		{
			if (id_createUI_Landroid_os_Bundle_ == IntPtr.Zero)
				id_createUI_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "createUI", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createUI_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createUI", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_destroyAlertWaiter;
#pragma warning disable 0169
		static Delegate GetDestroyAlertWaiterHandler ()
		{
			if (cb_destroyAlertWaiter == null)
				cb_destroyAlertWaiter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DestroyAlertWaiter);
			return cb_destroyAlertWaiter;
		}

		static void n_DestroyAlertWaiter (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DestroyAlertWaiter ();
		}
#pragma warning restore 0169

		static IntPtr id_destroyAlertWaiter;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='destroyAlertWaiter' and count(parameter)=0]"
		[Register ("destroyAlertWaiter", "()V", "GetDestroyAlertWaiterHandler")]
		public virtual unsafe void DestroyAlertWaiter ()
		{
			if (id_destroyAlertWaiter == IntPtr.Zero)
				id_destroyAlertWaiter = JNIEnv.GetMethodID (class_ref, "destroyAlertWaiter", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroyAlertWaiter);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroyAlertWaiter", "()V"));
			} finally {
			}
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_;
#pragma warning disable 0169
		static Delegate GetPerformPickFor_Lcom_artifex_mupdfdemo_FilePicker_Handler ()
		{
			if (cb_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_ == null)
				cb_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PerformPickFor_Lcom_artifex_mupdfdemo_FilePicker_);
			return cb_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_;
		}

		static void n_PerformPickFor_Lcom_artifex_mupdfdemo_FilePicker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Artifex.MuPdf.FilePicker p0 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.FilePicker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PerformPickFor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='performPickFor' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.FilePicker']]"
		[Register ("performPickFor", "(Lcom/artifex/mupdfdemo/FilePicker;)V", "GetPerformPickFor_Lcom_artifex_mupdfdemo_FilePicker_Handler")]
		public virtual unsafe void PerformPickFor (global::Artifex.MuPdf.FilePicker p0)
		{
			if (id_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_ == IntPtr.Zero)
				id_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_ = JNIEnv.GetMethodID (class_ref, "performPickFor", "(Lcom/artifex/mupdfdemo/FilePicker;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_performPickFor_Lcom_artifex_mupdfdemo_FilePicker_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "performPickFor", "(Lcom/artifex/mupdfdemo/FilePicker;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_proofWithResolution_I;
#pragma warning disable 0169
		static Delegate GetProofWithResolution_IHandler ()
		{
			if (cb_proofWithResolution_I == null)
				cb_proofWithResolution_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ProofWithResolution_I);
			return cb_proofWithResolution_I;
		}

		static void n_ProofWithResolution_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProofWithResolution (p0);
		}
#pragma warning restore 0169

		static IntPtr id_proofWithResolution_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='proofWithResolution' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("proofWithResolution", "(I)V", "GetProofWithResolution_IHandler")]
		public virtual unsafe void ProofWithResolution (int p0)
		{
			if (id_proofWithResolution_I == IntPtr.Zero)
				id_proofWithResolution_I = JNIEnv.GetMethodID (class_ref, "proofWithResolution", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_proofWithResolution_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "proofWithResolution", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_requestPassword_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRequestPassword_Landroid_os_Bundle_Handler ()
		{
			if (cb_requestPassword_Landroid_os_Bundle_ == null)
				cb_requestPassword_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestPassword_Landroid_os_Bundle_);
			return cb_requestPassword_Landroid_os_Bundle_;
		}

		static void n_RequestPassword_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFActivity __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestPassword (p0);
		}
#pragma warning restore 0169

		static IntPtr id_requestPassword_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFActivity']/method[@name='requestPassword' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("requestPassword", "(Landroid/os/Bundle;)V", "GetRequestPassword_Landroid_os_Bundle_Handler")]
		public virtual unsafe void RequestPassword (global::Android.OS.Bundle p0)
		{
			if (id_requestPassword_Landroid_os_Bundle_ == IntPtr.Zero)
				id_requestPassword_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "requestPassword", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestPassword_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestPassword", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

	}
}
