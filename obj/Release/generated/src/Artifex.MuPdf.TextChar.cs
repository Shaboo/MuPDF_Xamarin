using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='TextChar']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/TextChar", DoNotGenerateAcw=true)]
	public partial class TextChar : global::Android.Graphics.RectF {


		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='TextChar']/field[@name='c']"
		[Register ("c")]
		public char C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "C");
				return JNIEnv.GetCharField (((global::Java.Lang.Object) this).Handle, c_jfieldId);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "C");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, c_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/TextChar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextChar); }
		}

		protected TextChar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFFFC;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='TextChar']/constructor[@name='TextChar' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='char']]"
		[Register (".ctor", "(FFFFC)V", "")]
		public unsafe TextChar (float p0, float p1, float p2, float p3, char p4)
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
				if (((object) this).GetType () != typeof (TextChar)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(FFFFC)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFFFC)V", __args);
					return;
				}

				if (id_ctor_FFFFC == IntPtr.Zero)
					id_ctor_FFFFC = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFFC)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFFC, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFFFC, __args);
			} finally {
			}
		}

	}
}
