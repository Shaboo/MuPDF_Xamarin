using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFCore", DoNotGenerateAcw=true)]
	public partial class MuPDFCore : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore.Cookie']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/MuPDFCore$Cookie", DoNotGenerateAcw=true)]
		public partial class Cookie : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFCore$Cookie", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Cookie); }
			}

			protected Cookie (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_artifex_mupdfdemo_MuPDFCore_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore.Cookie']/constructor[@name='MuPDFCore.Cookie' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.MuPDFCore']]"
			[Register (".ctor", "(Lcom/artifex/mupdfdemo/MuPDFCore;)V", "")]
			public unsafe Cookie (global::Artifex.MuPdf.MuPDFCore __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (Cookie)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_artifex_mupdfdemo_MuPDFCore_ == IntPtr.Zero)
						id_ctor_Lcom_artifex_mupdfdemo_MuPDFCore_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/artifex/mupdfdemo/MuPDFCore;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_artifex_mupdfdemo_MuPDFCore_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_artifex_mupdfdemo_MuPDFCore_, __args);
				} finally {
				}
			}

			static Delegate cb_abort;
#pragma warning disable 0169
			static Delegate GetAbortHandler ()
			{
				if (cb_abort == null)
					cb_abort = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Abort);
				return cb_abort;
			}

			static void n_Abort (IntPtr jnienv, IntPtr native__this)
			{
				global::Artifex.MuPdf.MuPDFCore.Cookie __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore.Cookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Abort ();
			}
#pragma warning restore 0169

			static IntPtr id_abort;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore.Cookie']/method[@name='abort' and count(parameter)=0]"
			[Register ("abort", "()V", "GetAbortHandler")]
			public virtual unsafe void Abort ()
			{
				if (id_abort == IntPtr.Zero)
					id_abort = JNIEnv.GetMethodID (class_ref, "abort", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_abort);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "abort", "()V"));
				} finally {
				}
			}

			static Delegate cb_destroy;
#pragma warning disable 0169
			static Delegate GetDestroyHandler ()
			{
				if (cb_destroy == null)
					cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
				return cb_destroy;
			}

			static void n_Destroy (IntPtr jnienv, IntPtr native__this)
			{
				global::Artifex.MuPdf.MuPDFCore.Cookie __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore.Cookie> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Destroy ();
			}
#pragma warning restore 0169

			static IntPtr id_destroy;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore.Cookie']/method[@name='destroy' and count(parameter)=0]"
			[Register ("destroy", "()V", "GetDestroyHandler")]
			public virtual unsafe void Destroy ()
			{
				if (id_destroy == IntPtr.Zero)
					id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/MuPDFCore", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuPDFCore); }
		}

		protected MuPDFCore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_arrayBLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/constructor[@name='MuPDFCore' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;[BLjava/lang/String;)V", "")]
		public unsafe MuPDFCore (global::Android.Content.Context p0, byte[] p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (MuPDFCore)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;[BLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;[BLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_arrayBLjava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;[BLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_arrayBLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_arrayBLjava_lang_String_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/constructor[@name='MuPDFCore' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe MuPDFCore (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (MuPDFCore)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_hasChanges;
#pragma warning disable 0169
		static Delegate GetHasChangesHandler ()
		{
			if (cb_hasChanges == null)
				cb_hasChanges = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasChanges);
			return cb_hasChanges;
		}

		static bool n_HasChanges (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasChanges;
		}
#pragma warning restore 0169

		static IntPtr id_hasChanges;
		public virtual unsafe bool HasChanges {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='hasChanges' and count(parameter)=0]"
			[Register ("hasChanges", "()Z", "GetHasChangesHandler")]
			get {
				if (id_hasChanges == IntPtr.Zero)
					id_hasChanges = JNIEnv.GetMethodID (class_ref, "hasChanges", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasChanges);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasChanges", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasOutline;
#pragma warning disable 0169
		static Delegate GetHasOutlineHandler ()
		{
			if (cb_hasOutline == null)
				cb_hasOutline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasOutline);
			return cb_hasOutline;
		}

		static bool n_HasOutline (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasOutline;
		}
#pragma warning restore 0169

		static IntPtr id_hasOutline;
		public virtual unsafe bool HasOutline {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='hasOutline' and count(parameter)=0]"
			[Register ("hasOutline", "()Z", "GetHasOutlineHandler")]
			get {
				if (id_hasOutline == IntPtr.Zero)
					id_hasOutline = JNIEnv.GetMethodID (class_ref, "hasOutline", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasOutline);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasOutline", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isUnencryptedPDF;
#pragma warning disable 0169
		static Delegate GetIsUnencryptedPDFHandler ()
		{
			if (cb_isUnencryptedPDF == null)
				cb_isUnencryptedPDF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUnencryptedPDF);
			return cb_isUnencryptedPDF;
		}

		static bool n_IsUnencryptedPDF (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnencryptedPDF;
		}
#pragma warning restore 0169

		static IntPtr id_isUnencryptedPDF;
		public virtual unsafe bool IsUnencryptedPDF {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='isUnencryptedPDF' and count(parameter)=0]"
			[Register ("isUnencryptedPDF", "()Z", "GetIsUnencryptedPDFHandler")]
			get {
				if (id_isUnencryptedPDF == IntPtr.Zero)
					id_isUnencryptedPDF = JNIEnv.GetMethodID (class_ref, "isUnencryptedPDF", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUnencryptedPDF);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUnencryptedPDF", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_addInkAnnotation_IarrayarrayLandroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetAddInkAnnotation_IarrayarrayLandroid_graphics_PointF_Handler ()
		{
			if (cb_addInkAnnotation_IarrayarrayLandroid_graphics_PointF_ == null)
				cb_addInkAnnotation_IarrayarrayLandroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddInkAnnotation_IarrayarrayLandroid_graphics_PointF_);
			return cb_addInkAnnotation_IarrayarrayLandroid_graphics_PointF_;
		}

		static void n_AddInkAnnotation_IarrayarrayLandroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF[][] p1 = (global::Android.Graphics.PointF[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.PointF[]));
			__this.AddInkAnnotation (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_addInkAnnotation_IarrayarrayLandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='addInkAnnotation' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.PointF[][]']]"
		[Register ("addInkAnnotation", "(I[[Landroid/graphics/PointF;)V", "GetAddInkAnnotation_IarrayarrayLandroid_graphics_PointF_Handler")]
		public virtual unsafe void AddInkAnnotation (int p0, global::Android.Graphics.PointF[][] p1)
		{
			if (id_addInkAnnotation_IarrayarrayLandroid_graphics_PointF_ == IntPtr.Zero)
				id_addInkAnnotation_IarrayarrayLandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "addInkAnnotation", "(I[[Landroid/graphics/PointF;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addInkAnnotation_IarrayarrayLandroid_graphics_PointF_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addInkAnnotation", "(I[[Landroid/graphics/PointF;)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_authenticatePassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAuthenticatePassword_Ljava_lang_String_Handler ()
		{
			if (cb_authenticatePassword_Ljava_lang_String_ == null)
				cb_authenticatePassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AuthenticatePassword_Ljava_lang_String_);
			return cb_authenticatePassword_Ljava_lang_String_;
		}

		static bool n_AuthenticatePassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AuthenticatePassword (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_authenticatePassword_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='authenticatePassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("authenticatePassword", "(Ljava/lang/String;)Z", "GetAuthenticatePassword_Ljava_lang_String_Handler")]
		public virtual unsafe bool AuthenticatePassword (string p0)
		{
			if (id_authenticatePassword_Ljava_lang_String_ == IntPtr.Zero)
				id_authenticatePassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "authenticatePassword", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_authenticatePassword_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authenticatePassword", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_canProof;
#pragma warning disable 0169
		static Delegate GetCanProofHandler ()
		{
			if (cb_canProof == null)
				cb_canProof = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanProof);
			return cb_canProof;
		}

		static bool n_CanProof (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanProof ();
		}
#pragma warning restore 0169

		static IntPtr id_canProof;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='canProof' and count(parameter)=0]"
		[Register ("canProof", "()Z", "GetCanProofHandler")]
		public virtual unsafe bool CanProof ()
		{
			if (id_canProof == IntPtr.Zero)
				id_canProof = JNIEnv.GetMethodID (class_ref, "canProof", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canProof);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canProof", "()Z"));
			} finally {
			}
		}

		static Delegate cb_checkFocusedSignature;
#pragma warning disable 0169
		static Delegate GetCheckFocusedSignatureHandler ()
		{
			if (cb_checkFocusedSignature == null)
				cb_checkFocusedSignature = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CheckFocusedSignature);
			return cb_checkFocusedSignature;
		}

		static IntPtr n_CheckFocusedSignature (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CheckFocusedSignature ());
		}
#pragma warning restore 0169

		static IntPtr id_checkFocusedSignature;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='checkFocusedSignature' and count(parameter)=0]"
		[Register ("checkFocusedSignature", "()Ljava/lang/String;", "GetCheckFocusedSignatureHandler")]
		public virtual unsafe string CheckFocusedSignature ()
		{
			if (id_checkFocusedSignature == IntPtr.Zero)
				id_checkFocusedSignature = JNIEnv.GetMethodID (class_ref, "checkFocusedSignature", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_checkFocusedSignature), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkFocusedSignature", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_controlSepOnPage_IIZ;
#pragma warning disable 0169
		static Delegate GetControlSepOnPage_IIZHandler ()
		{
			if (cb_controlSepOnPage_IIZ == null)
				cb_controlSepOnPage_IIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool, int>) n_ControlSepOnPage_IIZ);
			return cb_controlSepOnPage_IIZ;
		}

		static int n_ControlSepOnPage_IIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ControlSepOnPage (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_controlSepOnPage_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='controlSepOnPage' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("controlSepOnPage", "(IIZ)I", "GetControlSepOnPage_IIZHandler")]
		public virtual unsafe int ControlSepOnPage (int p0, int p1, bool p2)
		{
			if (id_controlSepOnPage_IIZ == IntPtr.Zero)
				id_controlSepOnPage_IIZ = JNIEnv.GetMethodID (class_ref, "controlSepOnPage", "(IIZ)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_controlSepOnPage_IIZ, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "controlSepOnPage", "(IIZ)I"), __args);
			} finally {
			}
		}

		static Delegate cb_countPages;
#pragma warning disable 0169
		static Delegate GetCountPagesHandler ()
		{
			if (cb_countPages == null)
				cb_countPages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_CountPages);
			return cb_countPages;
		}

		static int n_CountPages (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CountPages ();
		}
#pragma warning restore 0169

		static IntPtr id_countPages;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='countPages' and count(parameter)=0]"
		[Register ("countPages", "()I", "GetCountPagesHandler")]
		public virtual unsafe int CountPages ()
		{
			if (id_countPages == IntPtr.Zero)
				id_countPages = JNIEnv.GetMethodID (class_ref, "countPages", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_countPages);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "countPages", "()I"));
			} finally {
			}
		}

		static Delegate cb_deleteAnnotation_II;
#pragma warning disable 0169
		static Delegate GetDeleteAnnotation_IIHandler ()
		{
			if (cb_deleteAnnotation_II == null)
				cb_deleteAnnotation_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_DeleteAnnotation_II);
			return cb_deleteAnnotation_II;
		}

		static void n_DeleteAnnotation_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAnnotation (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_deleteAnnotation_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='deleteAnnotation' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("deleteAnnotation", "(II)V", "GetDeleteAnnotation_IIHandler")]
		public virtual unsafe void DeleteAnnotation (int p0, int p1)
		{
			if (id_deleteAnnotation_II == IntPtr.Zero)
				id_deleteAnnotation_II = JNIEnv.GetMethodID (class_ref, "deleteAnnotation", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAnnotation_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAnnotation", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_drawPage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_;
#pragma warning disable 0169
		static Delegate GetDrawPage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_Handler ()
		{
			if (cb_drawPage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_ == null)
				cb_drawPage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, int, IntPtr>) n_DrawPage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_);
			return cb_drawPage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_;
		}

		static void n_DrawPage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, IntPtr native_p8)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Artifex.MuPdf.MuPDFCore.Cookie p8 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore.Cookie> (native_p8, JniHandleOwnership.DoNotTransfer);
			__this.DrawPage (p0, p1, p2, p3, p4, p5, p6, p7, p8);
		}
#pragma warning restore 0169

		static IntPtr id_drawPage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='drawPage' and count(parameter)=9 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='com.artifex.mupdfdemo.MuPDFCore.Cookie']]"
		[Register ("drawPage", "(Landroid/graphics/Bitmap;IIIIIIILcom/artifex/mupdfdemo/MuPDFCore$Cookie;)V", "GetDrawPage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_Handler")]
		public virtual unsafe void DrawPage (global::Android.Graphics.Bitmap p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, global::Artifex.MuPdf.MuPDFCore.Cookie p8)
		{
			if (id_drawPage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_ == IntPtr.Zero)
				id_drawPage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_ = JNIEnv.GetMethodID (class_ref, "drawPage", "(Landroid/graphics/Bitmap;IIIIIIILcom/artifex/mupdfdemo/MuPDFCore$Cookie;)V");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drawPage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawPage", "(Landroid/graphics/Bitmap;IIIIIIILcom/artifex/mupdfdemo/MuPDFCore$Cookie;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_endProof_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEndProof_Ljava_lang_String_Handler ()
		{
			if (cb_endProof_Ljava_lang_String_ == null)
				cb_endProof_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EndProof_Ljava_lang_String_);
			return cb_endProof_Ljava_lang_String_;
		}

		static void n_EndProof_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EndProof (p0);
		}
#pragma warning restore 0169

		static IntPtr id_endProof_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='endProof' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("endProof", "(Ljava/lang/String;)V", "GetEndProof_Ljava_lang_String_Handler")]
		public virtual unsafe void EndProof (string p0)
		{
			if (id_endProof_Ljava_lang_String_ == IntPtr.Zero)
				id_endProof_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "endProof", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endProof_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endProof", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_fileFormat;
#pragma warning disable 0169
		static Delegate GetFileFormatHandler ()
		{
			if (cb_fileFormat == null)
				cb_fileFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FileFormat);
			return cb_fileFormat;
		}

		static IntPtr n_FileFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileFormat ());
		}
#pragma warning restore 0169

		static IntPtr id_fileFormat;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='fileFormat' and count(parameter)=0]"
		[Register ("fileFormat", "()Ljava/lang/String;", "GetFileFormatHandler")]
		public virtual unsafe string FileFormat ()
		{
			if (id_fileFormat == IntPtr.Zero)
				id_fileFormat = JNIEnv.GetMethodID (class_ref, "fileFormat", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fileFormat), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fileFormat", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAnnoations_I;
#pragma warning disable 0169
		static Delegate GetGetAnnoations_IHandler ()
		{
			if (cb_getAnnoations_I == null)
				cb_getAnnoations_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetAnnoations_I);
			return cb_getAnnoations_I;
		}

		static IntPtr n_GetAnnoations_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAnnoations (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getAnnoations_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='getAnnoations' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAnnoations", "(I)[Lcom/artifex/mupdfdemo/Annotation;", "GetGetAnnoations_IHandler")]
		public virtual unsafe global::Artifex.MuPdf.Annotation[] GetAnnoations (int p0)
		{
			if (id_getAnnoations_I == IntPtr.Zero)
				id_getAnnoations_I = JNIEnv.GetMethodID (class_ref, "getAnnoations", "(I)[Lcom/artifex/mupdfdemo/Annotation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return (global::Artifex.MuPdf.Annotation[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnnoations_I, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.Annotation));
				else
					return (global::Artifex.MuPdf.Annotation[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnnoations", "(I)[Lcom/artifex/mupdfdemo/Annotation;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.Annotation));
			} finally {
			}
		}

		static Delegate cb_getNumSepsOnPage_I;
#pragma warning disable 0169
		static Delegate GetGetNumSepsOnPage_IHandler ()
		{
			if (cb_getNumSepsOnPage_I == null)
				cb_getNumSepsOnPage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetNumSepsOnPage_I);
			return cb_getNumSepsOnPage_I;
		}

		static int n_GetNumSepsOnPage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetNumSepsOnPage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getNumSepsOnPage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='getNumSepsOnPage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNumSepsOnPage", "(I)I", "GetGetNumSepsOnPage_IHandler")]
		public virtual unsafe int GetNumSepsOnPage (int p0)
		{
			if (id_getNumSepsOnPage_I == IntPtr.Zero)
				id_getNumSepsOnPage_I = JNIEnv.GetMethodID (class_ref, "getNumSepsOnPage", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumSepsOnPage_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumSepsOnPage", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getOutline;
#pragma warning disable 0169
		static Delegate GetGetOutlineHandler ()
		{
			if (cb_getOutline == null)
				cb_getOutline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutline);
			return cb_getOutline;
		}

		static IntPtr n_GetOutline (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOutline ());
		}
#pragma warning restore 0169

		static IntPtr id_getOutline;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='getOutline' and count(parameter)=0]"
		[Register ("getOutline", "()[Lcom/artifex/mupdfdemo/OutlineItem;", "GetGetOutlineHandler")]
		public virtual unsafe global::Artifex.MuPdf.OutlineItem[] GetOutline ()
		{
			if (id_getOutline == IntPtr.Zero)
				id_getOutline = JNIEnv.GetMethodID (class_ref, "getOutline", "()[Lcom/artifex/mupdfdemo/OutlineItem;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Artifex.MuPdf.OutlineItem[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutline), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.OutlineItem));
				else
					return (global::Artifex.MuPdf.OutlineItem[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutline", "()[Lcom/artifex/mupdfdemo/OutlineItem;")), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.OutlineItem));
			} finally {
			}
		}

		static Delegate cb_getPageLinks_I;
#pragma warning disable 0169
		static Delegate GetGetPageLinks_IHandler ()
		{
			if (cb_getPageLinks_I == null)
				cb_getPageLinks_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPageLinks_I);
			return cb_getPageLinks_I;
		}

		static IntPtr n_GetPageLinks_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPageLinks (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getPageLinks_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='getPageLinks' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPageLinks", "(I)[Lcom/artifex/mupdfdemo/LinkInfo;", "GetGetPageLinks_IHandler")]
		public virtual unsafe global::Artifex.MuPdf.LinkInfo[] GetPageLinks (int p0)
		{
			if (id_getPageLinks_I == IntPtr.Zero)
				id_getPageLinks_I = JNIEnv.GetMethodID (class_ref, "getPageLinks", "(I)[Lcom/artifex/mupdfdemo/LinkInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return (global::Artifex.MuPdf.LinkInfo[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageLinks_I, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.LinkInfo));
				else
					return (global::Artifex.MuPdf.LinkInfo[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageLinks", "(I)[Lcom/artifex/mupdfdemo/LinkInfo;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.LinkInfo));
			} finally {
			}
		}

		static Delegate cb_getPageSize_I;
#pragma warning disable 0169
		static Delegate GetGetPageSize_IHandler ()
		{
			if (cb_getPageSize_I == null)
				cb_getPageSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPageSize_I);
			return cb_getPageSize_I;
		}

		static IntPtr n_GetPageSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPageSize (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getPageSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='getPageSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPageSize", "(I)Landroid/graphics/PointF;", "GetGetPageSize_IHandler")]
		public virtual unsafe global::Android.Graphics.PointF GetPageSize (int p0)
		{
			if (id_getPageSize_I == IntPtr.Zero)
				id_getPageSize_I = JNIEnv.GetMethodID (class_ref, "getPageSize", "(I)Landroid/graphics/PointF;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageSize_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPageSize", "(I)Landroid/graphics/PointF;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSep_II;
#pragma warning disable 0169
		static Delegate GetGetSep_IIHandler ()
		{
			if (cb_getSep_II == null)
				cb_getSep_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_GetSep_II);
			return cb_getSep_II;
		}

		static IntPtr n_GetSep_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSep (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_getSep_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='getSep' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getSep", "(II)Lcom/artifex/mupdfdemo/Separation;", "GetGetSep_IIHandler")]
		public virtual unsafe global::Artifex.MuPdf.Separation GetSep (int p0, int p1)
		{
			if (id_getSep_II == IntPtr.Zero)
				id_getSep_II = JNIEnv.GetMethodID (class_ref, "getSep", "(II)Lcom/artifex/mupdfdemo/Separation;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Separation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSep_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Separation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSep", "(II)Lcom/artifex/mupdfdemo/Separation;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getWidgetAreas_I;
#pragma warning disable 0169
		static Delegate GetGetWidgetAreas_IHandler ()
		{
			if (cb_getWidgetAreas_I == null)
				cb_getWidgetAreas_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetWidgetAreas_I);
			return cb_getWidgetAreas_I;
		}

		static IntPtr n_GetWidgetAreas_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetWidgetAreas (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getWidgetAreas_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='getWidgetAreas' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getWidgetAreas", "(I)[Landroid/graphics/RectF;", "GetGetWidgetAreas_IHandler")]
		public virtual unsafe global::Android.Graphics.RectF[] GetWidgetAreas (int p0)
		{
			if (id_getWidgetAreas_I == IntPtr.Zero)
				id_getWidgetAreas_I = JNIEnv.GetMethodID (class_ref, "getWidgetAreas", "(I)[Landroid/graphics/RectF;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return (global::Android.Graphics.RectF[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWidgetAreas_I, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Graphics.RectF));
				else
					return (global::Android.Graphics.RectF[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidgetAreas", "(I)[Landroid/graphics/RectF;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Graphics.RectF));
			} finally {
			}
		}

		static IntPtr id_gprfSupported;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='gprfSupported' and count(parameter)=0]"
		[Register ("gprfSupported", "()Z", "")]
		public static unsafe bool GprfSupported ()
		{
			if (id_gprfSupported == IntPtr.Zero)
				id_gprfSupported = JNIEnv.GetStaticMethodID (class_ref, "gprfSupported", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_gprfSupported);
			} finally {
			}
		}

		static Delegate cb_html_I;
#pragma warning disable 0169
		static Delegate GetHtml_IHandler ()
		{
			if (cb_html_I == null)
				cb_html_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Html_I);
			return cb_html_I;
		}

		static IntPtr n_Html_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Html (p0));
		}
#pragma warning restore 0169

		static IntPtr id_html_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='html' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("html", "(I)[B", "GetHtml_IHandler")]
		public virtual unsafe byte[] Html (int p0)
		{
			if (id_html_I == IntPtr.Zero)
				id_html_I = JNIEnv.GetMethodID (class_ref, "html", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_html_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "html", "(I)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_javascriptSupported;
#pragma warning disable 0169
		static Delegate GetJavascriptSupportedHandler ()
		{
			if (cb_javascriptSupported == null)
				cb_javascriptSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_JavascriptSupported);
			return cb_javascriptSupported;
		}

		static bool n_JavascriptSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.JavascriptSupported ();
		}
#pragma warning restore 0169

		static IntPtr id_javascriptSupported;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='javascriptSupported' and count(parameter)=0]"
		[Register ("javascriptSupported", "()Z", "GetJavascriptSupportedHandler")]
		public virtual unsafe bool JavascriptSupported ()
		{
			if (id_javascriptSupported == IntPtr.Zero)
				id_javascriptSupported = JNIEnv.GetMethodID (class_ref, "javascriptSupported", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_javascriptSupported);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "javascriptSupported", "()Z"));
			} finally {
			}
		}

		static Delegate cb_needsPassword;
#pragma warning disable 0169
		static Delegate GetNeedsPasswordHandler ()
		{
			if (cb_needsPassword == null)
				cb_needsPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NeedsPassword);
			return cb_needsPassword;
		}

		static bool n_NeedsPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedsPassword ();
		}
#pragma warning restore 0169

		static IntPtr id_needsPassword;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='needsPassword' and count(parameter)=0]"
		[Register ("needsPassword", "()Z", "GetNeedsPasswordHandler")]
		public virtual unsafe bool NeedsPassword ()
		{
			if (id_needsPassword == IntPtr.Zero)
				id_needsPassword = JNIEnv.GetMethodID (class_ref, "needsPassword", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_needsPassword);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "needsPassword", "()Z"));
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
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='onDestroy' and count(parameter)=0]"
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

		static Delegate cb_replyToAlert_Lcom_artifex_mupdfdemo_MuPDFAlert_;
#pragma warning disable 0169
		static Delegate GetReplyToAlert_Lcom_artifex_mupdfdemo_MuPDFAlert_Handler ()
		{
			if (cb_replyToAlert_Lcom_artifex_mupdfdemo_MuPDFAlert_ == null)
				cb_replyToAlert_Lcom_artifex_mupdfdemo_MuPDFAlert_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReplyToAlert_Lcom_artifex_mupdfdemo_MuPDFAlert_);
			return cb_replyToAlert_Lcom_artifex_mupdfdemo_MuPDFAlert_;
		}

		static void n_ReplyToAlert_Lcom_artifex_mupdfdemo_MuPDFAlert_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Artifex.MuPdf.MuPDFAlert p0 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReplyToAlert (p0);
		}
#pragma warning restore 0169

		static IntPtr id_replyToAlert_Lcom_artifex_mupdfdemo_MuPDFAlert_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='replyToAlert' and count(parameter)=1 and parameter[1][@type='com.artifex.mupdfdemo.MuPDFAlert']]"
		[Register ("replyToAlert", "(Lcom/artifex/mupdfdemo/MuPDFAlert;)V", "GetReplyToAlert_Lcom_artifex_mupdfdemo_MuPDFAlert_Handler")]
		public virtual unsafe void ReplyToAlert (global::Artifex.MuPdf.MuPDFAlert p0)
		{
			if (id_replyToAlert_Lcom_artifex_mupdfdemo_MuPDFAlert_ == IntPtr.Zero)
				id_replyToAlert_Lcom_artifex_mupdfdemo_MuPDFAlert_ = JNIEnv.GetMethodID (class_ref, "replyToAlert", "(Lcom/artifex/mupdfdemo/MuPDFAlert;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replyToAlert_Lcom_artifex_mupdfdemo_MuPDFAlert_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replyToAlert", "(Lcom/artifex/mupdfdemo/MuPDFAlert;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_save;
#pragma warning disable 0169
		static Delegate GetSaveHandler ()
		{
			if (cb_save == null)
				cb_save = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Save);
			return cb_save;
		}

		static void n_Save (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Save ();
		}
#pragma warning restore 0169

		static IntPtr id_save;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='save' and count(parameter)=0]"
		[Register ("save", "()V", "GetSaveHandler")]
		public virtual unsafe void Save ()
		{
			if (id_save == IntPtr.Zero)
				id_save = JNIEnv.GetMethodID (class_ref, "save", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "()V"));
			} finally {
			}
		}

		static Delegate cb_searchPage_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSearchPage_ILjava_lang_String_Handler ()
		{
			if (cb_searchPage_ILjava_lang_String_ == null)
				cb_searchPage_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SearchPage_ILjava_lang_String_);
			return cb_searchPage_ILjava_lang_String_;
		}

		static IntPtr n_SearchPage_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.SearchPage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_searchPage_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='searchPage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("searchPage", "(ILjava/lang/String;)[Landroid/graphics/RectF;", "GetSearchPage_ILjava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.RectF[] SearchPage (int p0, string p1)
		{
			if (id_searchPage_ILjava_lang_String_ == IntPtr.Zero)
				id_searchPage_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "searchPage", "(ILjava/lang/String;)[Landroid/graphics/RectF;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Android.Graphics.RectF[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (global::Android.Graphics.RectF[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_searchPage_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Graphics.RectF));
				else
					__ret = (global::Android.Graphics.RectF[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "searchPage", "(ILjava/lang/String;)[Landroid/graphics/RectF;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Graphics.RectF));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setFocusedWidgetChoiceSelected_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFocusedWidgetChoiceSelected_arrayLjava_lang_String_Handler ()
		{
			if (cb_setFocusedWidgetChoiceSelected_arrayLjava_lang_String_ == null)
				cb_setFocusedWidgetChoiceSelected_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFocusedWidgetChoiceSelected_arrayLjava_lang_String_);
			return cb_setFocusedWidgetChoiceSelected_arrayLjava_lang_String_;
		}

		static void n_SetFocusedWidgetChoiceSelected_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetFocusedWidgetChoiceSelected (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFocusedWidgetChoiceSelected_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='setFocusedWidgetChoiceSelected' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setFocusedWidgetChoiceSelected", "([Ljava/lang/String;)V", "GetSetFocusedWidgetChoiceSelected_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetFocusedWidgetChoiceSelected (string[] p0)
		{
			if (id_setFocusedWidgetChoiceSelected_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setFocusedWidgetChoiceSelected_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFocusedWidgetChoiceSelected", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFocusedWidgetChoiceSelected_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFocusedWidgetChoiceSelected", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setFocusedWidgetText_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFocusedWidgetText_ILjava_lang_String_Handler ()
		{
			if (cb_setFocusedWidgetText_ILjava_lang_String_ == null)
				cb_setFocusedWidgetText_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_SetFocusedWidgetText_ILjava_lang_String_);
			return cb_setFocusedWidgetText_ILjava_lang_String_;
		}

		static bool n_SetFocusedWidgetText_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetFocusedWidgetText (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setFocusedWidgetText_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='setFocusedWidgetText' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("setFocusedWidgetText", "(ILjava/lang/String;)Z", "GetSetFocusedWidgetText_ILjava_lang_String_Handler")]
		public virtual unsafe bool SetFocusedWidgetText (int p0, string p1)
		{
			if (id_setFocusedWidgetText_ILjava_lang_String_ == IntPtr.Zero)
				id_setFocusedWidgetText_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFocusedWidgetText", "(ILjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setFocusedWidgetText_ILjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFocusedWidgetText", "(ILjava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_signFocusedSignature_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSignFocusedSignature_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_signFocusedSignature_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_signFocusedSignature_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SignFocusedSignature_Ljava_lang_String_Ljava_lang_String_);
			return cb_signFocusedSignature_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_SignFocusedSignature_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SignFocusedSignature (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_signFocusedSignature_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='signFocusedSignature' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("signFocusedSignature", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetSignFocusedSignature_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool SignFocusedSignature (string p0, string p1)
		{
			if (id_signFocusedSignature_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_signFocusedSignature_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "signFocusedSignature", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_signFocusedSignature_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "signFocusedSignature", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_startAlerts;
#pragma warning disable 0169
		static Delegate GetStartAlertsHandler ()
		{
			if (cb_startAlerts == null)
				cb_startAlerts = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartAlerts);
			return cb_startAlerts;
		}

		static void n_StartAlerts (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartAlerts ();
		}
#pragma warning restore 0169

		static IntPtr id_startAlerts;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='startAlerts' and count(parameter)=0]"
		[Register ("startAlerts", "()V", "GetStartAlertsHandler")]
		public virtual unsafe void StartAlerts ()
		{
			if (id_startAlerts == IntPtr.Zero)
				id_startAlerts = JNIEnv.GetMethodID (class_ref, "startAlerts", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startAlerts);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startAlerts", "()V"));
			} finally {
			}
		}

		static Delegate cb_startProof_I;
#pragma warning disable 0169
		static Delegate GetStartProof_IHandler ()
		{
			if (cb_startProof_I == null)
				cb_startProof_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_StartProof_I);
			return cb_startProof_I;
		}

		static IntPtr n_StartProof_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StartProof (p0));
		}
#pragma warning restore 0169

		static IntPtr id_startProof_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='startProof' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("startProof", "(I)Ljava/lang/String;", "GetStartProof_IHandler")]
		public virtual unsafe string StartProof (int p0)
		{
			if (id_startProof_I == IntPtr.Zero)
				id_startProof_I = JNIEnv.GetMethodID (class_ref, "startProof", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startProof_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startProof", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_stopAlerts;
#pragma warning disable 0169
		static Delegate GetStopAlertsHandler ()
		{
			if (cb_stopAlerts == null)
				cb_stopAlerts = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAlerts);
			return cb_stopAlerts;
		}

		static void n_StopAlerts (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAlerts ();
		}
#pragma warning restore 0169

		static IntPtr id_stopAlerts;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='stopAlerts' and count(parameter)=0]"
		[Register ("stopAlerts", "()V", "GetStopAlertsHandler")]
		public virtual unsafe void StopAlerts ()
		{
			if (id_stopAlerts == IntPtr.Zero)
				id_stopAlerts = JNIEnv.GetMethodID (class_ref, "stopAlerts", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopAlerts);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopAlerts", "()V"));
			} finally {
			}
		}

		static Delegate cb_textLines_I;
#pragma warning disable 0169
		static Delegate GetTextLines_IHandler ()
		{
			if (cb_textLines_I == null)
				cb_textLines_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_TextLines_I);
			return cb_textLines_I;
		}

		static IntPtr n_TextLines_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.TextLines (p0));
		}
#pragma warning restore 0169

		static IntPtr id_textLines_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='textLines' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("textLines", "(I)[[Lcom/artifex/mupdfdemo/TextWord;", "GetTextLines_IHandler")]
		public virtual unsafe global::Artifex.MuPdf.TextWord[][] TextLines (int p0)
		{
			if (id_textLines_I == IntPtr.Zero)
				id_textLines_I = JNIEnv.GetMethodID (class_ref, "textLines", "(I)[[Lcom/artifex/mupdfdemo/TextWord;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return (global::Artifex.MuPdf.TextWord[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_textLines_I, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.TextWord[]));
				else
					return (global::Artifex.MuPdf.TextWord[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "textLines", "(I)[[Lcom/artifex/mupdfdemo/TextWord;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.TextWord[]));
			} finally {
			}
		}

		static Delegate cb_updatePage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_;
#pragma warning disable 0169
		static Delegate GetUpdatePage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_Handler ()
		{
			if (cb_updatePage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_ == null)
				cb_updatePage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, int, IntPtr>) n_UpdatePage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_);
			return cb_updatePage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_;
		}

		static void n_UpdatePage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, IntPtr native_p8)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Artifex.MuPdf.MuPDFCore.Cookie p8 = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore.Cookie> (native_p8, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePage (p0, p1, p2, p3, p4, p5, p6, p7, p8);
		}
#pragma warning restore 0169

		static IntPtr id_updatePage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='updatePage' and count(parameter)=9 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='com.artifex.mupdfdemo.MuPDFCore.Cookie']]"
		[Register ("updatePage", "(Landroid/graphics/Bitmap;IIIIIIILcom/artifex/mupdfdemo/MuPDFCore$Cookie;)V", "GetUpdatePage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_Handler")]
		public virtual unsafe void UpdatePage (global::Android.Graphics.Bitmap p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, global::Artifex.MuPdf.MuPDFCore.Cookie p8)
		{
			if (id_updatePage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_ == IntPtr.Zero)
				id_updatePage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_ = JNIEnv.GetMethodID (class_ref, "updatePage", "(Landroid/graphics/Bitmap;IIIIIIILcom/artifex/mupdfdemo/MuPDFCore$Cookie;)V");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePage_Landroid_graphics_Bitmap_IIIIIIILcom_artifex_mupdfdemo_MuPDFCore_Cookie_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePage", "(Landroid/graphics/Bitmap;IIIIIIILcom/artifex/mupdfdemo/MuPDFCore$Cookie;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_waitForAlert;
#pragma warning disable 0169
		static Delegate GetWaitForAlertHandler ()
		{
			if (cb_waitForAlert == null)
				cb_waitForAlert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_WaitForAlert);
			return cb_waitForAlert;
		}

		static IntPtr n_WaitForAlert (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WaitForAlert ());
		}
#pragma warning restore 0169

		static IntPtr id_waitForAlert;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='waitForAlert' and count(parameter)=0]"
		[Register ("waitForAlert", "()Lcom/artifex/mupdfdemo/MuPDFAlert;", "GetWaitForAlertHandler")]
		public virtual unsafe global::Artifex.MuPdf.MuPDFAlert WaitForAlert ()
		{
			if (id_waitForAlert == IntPtr.Zero)
				id_waitForAlert = JNIEnv.GetMethodID (class_ref, "waitForAlert", "()Lcom/artifex/mupdfdemo/MuPDFAlert;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_waitForAlert), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFAlert> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "waitForAlert", "()Lcom/artifex/mupdfdemo/MuPDFAlert;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_wasOpenedFromBuffer;
#pragma warning disable 0169
		static Delegate GetWasOpenedFromBufferHandler ()
		{
			if (cb_wasOpenedFromBuffer == null)
				cb_wasOpenedFromBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_WasOpenedFromBuffer);
			return cb_wasOpenedFromBuffer;
		}

		static bool n_WasOpenedFromBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.MuPDFCore __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.MuPDFCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WasOpenedFromBuffer ();
		}
#pragma warning restore 0169

		static IntPtr id_wasOpenedFromBuffer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='MuPDFCore']/method[@name='wasOpenedFromBuffer' and count(parameter)=0]"
		[Register ("wasOpenedFromBuffer", "()Z", "GetWasOpenedFromBufferHandler")]
		public virtual unsafe bool WasOpenedFromBuffer ()
		{
			if (id_wasOpenedFromBuffer == IntPtr.Zero)
				id_wasOpenedFromBuffer = JNIEnv.GetMethodID (class_ref, "wasOpenedFromBuffer", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_wasOpenedFromBuffer);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wasOpenedFromBuffer", "()Z"));
			} finally {
			}
		}

	}
}
