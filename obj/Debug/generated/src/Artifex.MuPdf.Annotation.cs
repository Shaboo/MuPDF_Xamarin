using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/Annotation", DoNotGenerateAcw=true)]
	public partial class Annotation : global::Android.Graphics.RectF {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/Annotation$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr A3D_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='A3D']"
			[Register ("A3D")]
			public static global::Artifex.MuPdf.Annotation.Type A3d {
				get {
					if (A3D_jfieldId == IntPtr.Zero)
						A3D_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "A3D", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, A3D_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CARET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='CARET']"
			[Register ("CARET")]
			public static global::Artifex.MuPdf.Annotation.Type Caret {
				get {
					if (CARET_jfieldId == IntPtr.Zero)
						CARET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CARET", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CARET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CIRCLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='CIRCLE']"
			[Register ("CIRCLE")]
			public static global::Artifex.MuPdf.Annotation.Type Circle {
				get {
					if (CIRCLE_jfieldId == IntPtr.Zero)
						CIRCLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CIRCLE", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CIRCLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FILEATTACHMENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='FILEATTACHMENT']"
			[Register ("FILEATTACHMENT")]
			public static global::Artifex.MuPdf.Annotation.Type Fileattachment {
				get {
					if (FILEATTACHMENT_jfieldId == IntPtr.Zero)
						FILEATTACHMENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILEATTACHMENT", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FILEATTACHMENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FREETEXT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='FREETEXT']"
			[Register ("FREETEXT")]
			public static global::Artifex.MuPdf.Annotation.Type Freetext {
				get {
					if (FREETEXT_jfieldId == IntPtr.Zero)
						FREETEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FREETEXT", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FREETEXT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HIGHLIGHT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='HIGHLIGHT']"
			[Register ("HIGHLIGHT")]
			public static global::Artifex.MuPdf.Annotation.Type Highlight {
				get {
					if (HIGHLIGHT_jfieldId == IntPtr.Zero)
						HIGHLIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIGHLIGHT", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIGHLIGHT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='INK']"
			[Register ("INK")]
			public static global::Artifex.MuPdf.Annotation.Type Ink {
				get {
					if (INK_jfieldId == IntPtr.Zero)
						INK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INK", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LINE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='LINE']"
			[Register ("LINE")]
			public static global::Artifex.MuPdf.Annotation.Type Line {
				get {
					if (LINE_jfieldId == IntPtr.Zero)
						LINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINE", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LINE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LINK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='LINK']"
			[Register ("LINK")]
			public static global::Artifex.MuPdf.Annotation.Type Link {
				get {
					if (LINK_jfieldId == IntPtr.Zero)
						LINK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINK", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LINK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MOVIE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='MOVIE']"
			[Register ("MOVIE")]
			public static global::Artifex.MuPdf.Annotation.Type Movie {
				get {
					if (MOVIE_jfieldId == IntPtr.Zero)
						MOVIE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOVIE", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOVIE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr POLYGON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='POLYGON']"
			[Register ("POLYGON")]
			public static global::Artifex.MuPdf.Annotation.Type Polygon {
				get {
					if (POLYGON_jfieldId == IntPtr.Zero)
						POLYGON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POLYGON", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POLYGON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr POLYLINE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='POLYLINE']"
			[Register ("POLYLINE")]
			public static global::Artifex.MuPdf.Annotation.Type Polyline {
				get {
					if (POLYLINE_jfieldId == IntPtr.Zero)
						POLYLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POLYLINE", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POLYLINE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr POPUP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='POPUP']"
			[Register ("POPUP")]
			public static global::Artifex.MuPdf.Annotation.Type Popup {
				get {
					if (POPUP_jfieldId == IntPtr.Zero)
						POPUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POPUP", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POPUP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PRINTERMARK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='PRINTERMARK']"
			[Register ("PRINTERMARK")]
			public static global::Artifex.MuPdf.Annotation.Type Printermark {
				get {
					if (PRINTERMARK_jfieldId == IntPtr.Zero)
						PRINTERMARK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRINTERMARK", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRINTERMARK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SCREEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='SCREEN']"
			[Register ("SCREEN")]
			public static global::Artifex.MuPdf.Annotation.Type Screen {
				get {
					if (SCREEN_jfieldId == IntPtr.Zero)
						SCREEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCREEN", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCREEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='SOUND']"
			[Register ("SOUND")]
			public static global::Artifex.MuPdf.Annotation.Type Sound {
				get {
					if (SOUND_jfieldId == IntPtr.Zero)
						SOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOUND", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SQUARE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='SQUARE']"
			[Register ("SQUARE")]
			public static global::Artifex.MuPdf.Annotation.Type Square {
				get {
					if (SQUARE_jfieldId == IntPtr.Zero)
						SQUARE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SQUARE", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SQUARE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SQUIGGLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='SQUIGGLY']"
			[Register ("SQUIGGLY")]
			public static global::Artifex.MuPdf.Annotation.Type Squiggly {
				get {
					if (SQUIGGLY_jfieldId == IntPtr.Zero)
						SQUIGGLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SQUIGGLY", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SQUIGGLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STAMP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='STAMP']"
			[Register ("STAMP")]
			public static global::Artifex.MuPdf.Annotation.Type Stamp {
				get {
					if (STAMP_jfieldId == IntPtr.Zero)
						STAMP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STAMP", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STAMP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STRIKEOUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='STRIKEOUT']"
			[Register ("STRIKEOUT")]
			public static global::Artifex.MuPdf.Annotation.Type Strikeout {
				get {
					if (STRIKEOUT_jfieldId == IntPtr.Zero)
						STRIKEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRIKEOUT", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRIKEOUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TEXT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='TEXT']"
			[Register ("TEXT")]
			public static global::Artifex.MuPdf.Annotation.Type Text {
				get {
					if (TEXT_jfieldId == IntPtr.Zero)
						TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRAPNET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='TRAPNET']"
			[Register ("TRAPNET")]
			public static global::Artifex.MuPdf.Annotation.Type Trapnet {
				get {
					if (TRAPNET_jfieldId == IntPtr.Zero)
						TRAPNET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRAPNET", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRAPNET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNDERLINE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='UNDERLINE']"
			[Register ("UNDERLINE")]
			public static global::Artifex.MuPdf.Annotation.Type Underline {
				get {
					if (UNDERLINE_jfieldId == IntPtr.Zero)
						UNDERLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNDERLINE", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNDERLINE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Artifex.MuPdf.Annotation.Type Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WATERMARK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='WATERMARK']"
			[Register ("WATERMARK")]
			public static global::Artifex.MuPdf.Annotation.Type Watermark {
				get {
					if (WATERMARK_jfieldId == IntPtr.Zero)
						WATERMARK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WATERMARK", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WATERMARK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WIDGET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation.Type']/field[@name='WIDGET']"
			[Register ("WIDGET")]
			public static global::Artifex.MuPdf.Annotation.Type Widget {
				get {
					if (WIDGET_jfieldId == IntPtr.Zero)
						WIDGET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIDGET", "Lcom/artifex/mupdfdemo/Annotation$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIDGET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.Annotation.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/Annotation$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/Annotation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Annotation); }
		}

		protected Annotation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFFFI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='Annotation']/constructor[@name='Annotation' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int']]"
		[Register (".ctor", "(FFFFI)V", "")]
		public unsafe Annotation (float p0, float p1, float p2, float p3, int p4)
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
				if (((object) this).GetType () != typeof (Annotation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(FFFFI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFFFI)V", __args);
					return;
				}

				if (id_ctor_FFFFI == IntPtr.Zero)
					id_ctor_FFFFI = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFFI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFFI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFFFI, __args);
			} finally {
			}
		}

	}
}
