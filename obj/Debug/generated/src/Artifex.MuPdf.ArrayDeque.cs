using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/ArrayDeque", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
	public partial class ArrayDeque : global::Java.Util.AbstractCollection, global::Artifex.MuPdf.IDeque, global::Java.IO.ISerializable, global::Java.Lang.ICloneable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/ArrayDeque", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArrayDeque); }
		}

		protected ArrayDeque (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/constructor[@name='ArrayDeque' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ArrayDeque ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ArrayDeque)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/constructor[@name='ArrayDeque' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ArrayDeque (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ArrayDeque)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_util_Collection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/constructor[@name='ArrayDeque' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends E&gt;']]"
		[Register (".ctor", "(Ljava/util/Collection;)V", "")]
		public unsafe ArrayDeque (global::System.Collections.ICollection p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (ArrayDeque)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Collection;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Collection;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Collection_ == IntPtr.Zero)
					id_ctor_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Collection;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Collection_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Collection_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getFirst;
#pragma warning disable 0169
		static Delegate GetGetFirstHandler ()
		{
			if (cb_getFirst == null)
				cb_getFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirst);
			return cb_getFirst;
		}

		static IntPtr n_GetFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.First);
		}
#pragma warning restore 0169

		static IntPtr id_getFirst;
		public virtual unsafe global::Java.Lang.Object First {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='getFirst' and count(parameter)=0]"
			[Register ("getFirst", "()Ljava/lang/Object;", "GetGetFirstHandler")]
			get {
				if (id_getFirst == IntPtr.Zero)
					id_getFirst = JNIEnv.GetMethodID (class_ref, "getFirst", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirst), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirst", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLast;
#pragma warning disable 0169
		static Delegate GetGetLastHandler ()
		{
			if (cb_getLast == null)
				cb_getLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLast);
			return cb_getLast;
		}

		static IntPtr n_GetLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Last);
		}
#pragma warning restore 0169

		static IntPtr id_getLast;
		public virtual unsafe global::Java.Lang.Object Last {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='getLast' and count(parameter)=0]"
			[Register ("getLast", "()Ljava/lang/Object;", "GetGetLastHandler")]
			get {
				if (id_getLast == IntPtr.Zero)
					id_getLast = JNIEnv.GetMethodID (class_ref, "getLast", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLast), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLast", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addFirst_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddFirst_Ljava_lang_Object_Handler ()
		{
			if (cb_addFirst_Ljava_lang_Object_ == null)
				cb_addFirst_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFirst_Ljava_lang_Object_);
			return cb_addFirst_Ljava_lang_Object_;
		}

		static void n_AddFirst_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddFirst (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addFirst_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='addFirst' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("addFirst", "(Ljava/lang/Object;)V", "GetAddFirst_Ljava_lang_Object_Handler")]
		public virtual unsafe void AddFirst (global::Java.Lang.Object p0)
		{
			if (id_addFirst_Ljava_lang_Object_ == IntPtr.Zero)
				id_addFirst_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addFirst", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFirst_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFirst", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addLast_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddLast_Ljava_lang_Object_Handler ()
		{
			if (cb_addLast_Ljava_lang_Object_ == null)
				cb_addLast_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddLast_Ljava_lang_Object_);
			return cb_addLast_Ljava_lang_Object_;
		}

		static void n_AddLast_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddLast (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addLast_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='addLast' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("addLast", "(Ljava/lang/Object;)V", "GetAddLast_Ljava_lang_Object_Handler")]
		public virtual unsafe void AddLast (global::Java.Lang.Object p0)
		{
			if (id_addLast_Ljava_lang_Object_ == IntPtr.Zero)
				id_addLast_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addLast", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addLast_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLast", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/artifex/mupdfdemo/ArrayDeque;", "GetCloneHandler")]
		public virtual unsafe global::Artifex.MuPdf.ArrayDeque Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lcom/artifex/mupdfdemo/ArrayDeque;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lcom/artifex/mupdfdemo/ArrayDeque;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_descendingIterator;
#pragma warning disable 0169
		static Delegate GetDescendingIteratorHandler ()
		{
			if (cb_descendingIterator == null)
				cb_descendingIterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DescendingIterator);
			return cb_descendingIterator;
		}

		static IntPtr n_DescendingIterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DescendingIterator ());
		}
#pragma warning restore 0169

		static IntPtr id_descendingIterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='descendingIterator' and count(parameter)=0]"
		[Register ("descendingIterator", "()Ljava/util/Iterator;", "GetDescendingIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator DescendingIterator ()
		{
			if (id_descendingIterator == IntPtr.Zero)
				id_descendingIterator = JNIEnv.GetMethodID (class_ref, "descendingIterator", "()Ljava/util/Iterator;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_descendingIterator), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "descendingIterator", "()Ljava/util/Iterator;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_element;
#pragma warning disable 0169
		static Delegate GetElementHandler ()
		{
			if (cb_element == null)
				cb_element = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Element);
			return cb_element;
		}

		static IntPtr n_Element (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Element ());
		}
#pragma warning restore 0169

		static IntPtr id_element;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='element' and count(parameter)=0]"
		[Register ("element", "()Ljava/lang/Object;", "GetElementHandler")]
		public virtual unsafe global::Java.Lang.Object Element ()
		{
			if (id_element == IntPtr.Zero)
				id_element = JNIEnv.GetMethodID (class_ref, "element", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_element), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "element", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public override unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iterator", "()Ljava/util/Iterator;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_offer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOffer_Ljava_lang_Object_Handler ()
		{
			if (cb_offer_Ljava_lang_Object_ == null)
				cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Offer_Ljava_lang_Object_);
			return cb_offer_Ljava_lang_Object_;
		}

		static bool n_Offer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Offer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_offer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='offer' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("offer", "(Ljava/lang/Object;)Z", "GetOffer_Ljava_lang_Object_Handler")]
		public virtual unsafe bool Offer (global::Java.Lang.Object p0)
		{
			if (id_offer_Ljava_lang_Object_ == IntPtr.Zero)
				id_offer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offer", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offer_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "offer", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_offerFirst_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOfferFirst_Ljava_lang_Object_Handler ()
		{
			if (cb_offerFirst_Ljava_lang_Object_ == null)
				cb_offerFirst_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OfferFirst_Ljava_lang_Object_);
			return cb_offerFirst_Ljava_lang_Object_;
		}

		static bool n_OfferFirst_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OfferFirst (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_offerFirst_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='offerFirst' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("offerFirst", "(Ljava/lang/Object;)Z", "GetOfferFirst_Ljava_lang_Object_Handler")]
		public virtual unsafe bool OfferFirst (global::Java.Lang.Object p0)
		{
			if (id_offerFirst_Ljava_lang_Object_ == IntPtr.Zero)
				id_offerFirst_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offerFirst", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offerFirst_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "offerFirst", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_offerLast_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOfferLast_Ljava_lang_Object_Handler ()
		{
			if (cb_offerLast_Ljava_lang_Object_ == null)
				cb_offerLast_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OfferLast_Ljava_lang_Object_);
			return cb_offerLast_Ljava_lang_Object_;
		}

		static bool n_OfferLast_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OfferLast (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_offerLast_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='offerLast' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("offerLast", "(Ljava/lang/Object;)Z", "GetOfferLast_Ljava_lang_Object_Handler")]
		public virtual unsafe bool OfferLast (global::Java.Lang.Object p0)
		{
			if (id_offerLast_Ljava_lang_Object_ == IntPtr.Zero)
				id_offerLast_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "offerLast", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_offerLast_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "offerLast", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_peek;
#pragma warning disable 0169
		static Delegate GetPeekHandler ()
		{
			if (cb_peek == null)
				cb_peek = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Peek);
			return cb_peek;
		}

		static IntPtr n_Peek (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Peek ());
		}
#pragma warning restore 0169

		static IntPtr id_peek;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='peek' and count(parameter)=0]"
		[Register ("peek", "()Ljava/lang/Object;", "GetPeekHandler")]
		public virtual unsafe global::Java.Lang.Object Peek ()
		{
			if (id_peek == IntPtr.Zero)
				id_peek = JNIEnv.GetMethodID (class_ref, "peek", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_peek), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peek", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peekFirst;
#pragma warning disable 0169
		static Delegate GetPeekFirstHandler ()
		{
			if (cb_peekFirst == null)
				cb_peekFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PeekFirst);
			return cb_peekFirst;
		}

		static IntPtr n_PeekFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekFirst ());
		}
#pragma warning restore 0169

		static IntPtr id_peekFirst;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='peekFirst' and count(parameter)=0]"
		[Register ("peekFirst", "()Ljava/lang/Object;", "GetPeekFirstHandler")]
		public virtual unsafe global::Java.Lang.Object PeekFirst ()
		{
			if (id_peekFirst == IntPtr.Zero)
				id_peekFirst = JNIEnv.GetMethodID (class_ref, "peekFirst", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_peekFirst), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekFirst", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peekLast;
#pragma warning disable 0169
		static Delegate GetPeekLastHandler ()
		{
			if (cb_peekLast == null)
				cb_peekLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PeekLast);
			return cb_peekLast;
		}

		static IntPtr n_PeekLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekLast ());
		}
#pragma warning restore 0169

		static IntPtr id_peekLast;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='peekLast' and count(parameter)=0]"
		[Register ("peekLast", "()Ljava/lang/Object;", "GetPeekLastHandler")]
		public virtual unsafe global::Java.Lang.Object PeekLast ()
		{
			if (id_peekLast == IntPtr.Zero)
				id_peekLast = JNIEnv.GetMethodID (class_ref, "peekLast", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_peekLast), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekLast", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_poll;
#pragma warning disable 0169
		static Delegate GetPollHandler ()
		{
			if (cb_poll == null)
				cb_poll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Poll);
			return cb_poll;
		}

		static IntPtr n_Poll (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Poll ());
		}
#pragma warning restore 0169

		static IntPtr id_poll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='poll' and count(parameter)=0]"
		[Register ("poll", "()Ljava/lang/Object;", "GetPollHandler")]
		public virtual unsafe global::Java.Lang.Object Poll ()
		{
			if (id_poll == IntPtr.Zero)
				id_poll = JNIEnv.GetMethodID (class_ref, "poll", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_poll), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "poll", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pollFirst;
#pragma warning disable 0169
		static Delegate GetPollFirstHandler ()
		{
			if (cb_pollFirst == null)
				cb_pollFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PollFirst);
			return cb_pollFirst;
		}

		static IntPtr n_PollFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PollFirst ());
		}
#pragma warning restore 0169

		static IntPtr id_pollFirst;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='pollFirst' and count(parameter)=0]"
		[Register ("pollFirst", "()Ljava/lang/Object;", "GetPollFirstHandler")]
		public virtual unsafe global::Java.Lang.Object PollFirst ()
		{
			if (id_pollFirst == IntPtr.Zero)
				id_pollFirst = JNIEnv.GetMethodID (class_ref, "pollFirst", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pollFirst), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pollFirst", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pollLast;
#pragma warning disable 0169
		static Delegate GetPollLastHandler ()
		{
			if (cb_pollLast == null)
				cb_pollLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PollLast);
			return cb_pollLast;
		}

		static IntPtr n_PollLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PollLast ());
		}
#pragma warning restore 0169

		static IntPtr id_pollLast;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='pollLast' and count(parameter)=0]"
		[Register ("pollLast", "()Ljava/lang/Object;", "GetPollLastHandler")]
		public virtual unsafe global::Java.Lang.Object PollLast ()
		{
			if (id_pollLast == IntPtr.Zero)
				id_pollLast = JNIEnv.GetMethodID (class_ref, "pollLast", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pollLast), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pollLast", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pop;
#pragma warning disable 0169
		static Delegate GetPopHandler ()
		{
			if (cb_pop == null)
				cb_pop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Pop);
			return cb_pop;
		}

		static IntPtr n_Pop (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pop ());
		}
#pragma warning restore 0169

		static IntPtr id_pop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='pop' and count(parameter)=0]"
		[Register ("pop", "()Ljava/lang/Object;", "GetPopHandler")]
		public virtual unsafe global::Java.Lang.Object Pop ()
		{
			if (id_pop == IntPtr.Zero)
				id_pop = JNIEnv.GetMethodID (class_ref, "pop", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pop), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pop", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_push_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPush_Ljava_lang_Object_Handler ()
		{
			if (cb_push_Ljava_lang_Object_ == null)
				cb_push_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Push_Ljava_lang_Object_);
			return cb_push_Ljava_lang_Object_;
		}

		static void n_Push_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Push (p0);
		}
#pragma warning restore 0169

		static IntPtr id_push_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='push' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("push", "(Ljava/lang/Object;)V", "GetPush_Ljava_lang_Object_Handler")]
		public virtual unsafe void Push (global::Java.Lang.Object p0)
		{
			if (id_push_Ljava_lang_Object_ == IntPtr.Zero)
				id_push_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "push", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_push_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "push", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static IntPtr n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Remove ());
		}
#pragma warning restore 0169

		static IntPtr id_remove;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()Ljava/lang/Object;", "GetRemoveHandler")]
		public virtual unsafe global::Java.Lang.Object Remove ()
		{
			if (id_remove == IntPtr.Zero)
				id_remove = JNIEnv.GetMethodID (class_ref, "remove", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_remove), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeFirst;
#pragma warning disable 0169
		static Delegate GetRemoveFirstHandler ()
		{
			if (cb_removeFirst == null)
				cb_removeFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveFirst);
			return cb_removeFirst;
		}

		static IntPtr n_RemoveFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveFirst ());
		}
#pragma warning restore 0169

		static IntPtr id_removeFirst;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='removeFirst' and count(parameter)=0]"
		[Register ("removeFirst", "()Ljava/lang/Object;", "GetRemoveFirstHandler")]
		public virtual unsafe global::Java.Lang.Object RemoveFirst ()
		{
			if (id_removeFirst == IntPtr.Zero)
				id_removeFirst = JNIEnv.GetMethodID (class_ref, "removeFirst", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeFirst), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeFirst", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeFirstOccurrence_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveFirstOccurrence_Ljava_lang_Object_Handler ()
		{
			if (cb_removeFirstOccurrence_Ljava_lang_Object_ == null)
				cb_removeFirstOccurrence_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveFirstOccurrence_Ljava_lang_Object_);
			return cb_removeFirstOccurrence_Ljava_lang_Object_;
		}

		static bool n_RemoveFirstOccurrence_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveFirstOccurrence (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeFirstOccurrence_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='removeFirstOccurrence' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeFirstOccurrence", "(Ljava/lang/Object;)Z", "GetRemoveFirstOccurrence_Ljava_lang_Object_Handler")]
		public virtual unsafe bool RemoveFirstOccurrence (global::Java.Lang.Object p0)
		{
			if (id_removeFirstOccurrence_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeFirstOccurrence_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeFirstOccurrence", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeFirstOccurrence_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeFirstOccurrence", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_removeLast;
#pragma warning disable 0169
		static Delegate GetRemoveLastHandler ()
		{
			if (cb_removeLast == null)
				cb_removeLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RemoveLast);
			return cb_removeLast;
		}

		static IntPtr n_RemoveLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveLast ());
		}
#pragma warning restore 0169

		static IntPtr id_removeLast;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='removeLast' and count(parameter)=0]"
		[Register ("removeLast", "()Ljava/lang/Object;", "GetRemoveLastHandler")]
		public virtual unsafe global::Java.Lang.Object RemoveLast ()
		{
			if (id_removeLast == IntPtr.Zero)
				id_removeLast = JNIEnv.GetMethodID (class_ref, "removeLast", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeLast), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLast", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeLastOccurrence_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveLastOccurrence_Ljava_lang_Object_Handler ()
		{
			if (cb_removeLastOccurrence_Ljava_lang_Object_ == null)
				cb_removeLastOccurrence_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveLastOccurrence_Ljava_lang_Object_);
			return cb_removeLastOccurrence_Ljava_lang_Object_;
		}

		static bool n_RemoveLastOccurrence_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveLastOccurrence (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeLastOccurrence_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='removeLastOccurrence' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeLastOccurrence", "(Ljava/lang/Object;)Z", "GetRemoveLastOccurrence_Ljava_lang_Object_Handler")]
		public virtual unsafe bool RemoveLastOccurrence (global::Java.Lang.Object p0)
		{
			if (id_removeLastOccurrence_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeLastOccurrence_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeLastOccurrence", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeLastOccurrence_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLastOccurrence", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.ArrayDeque __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.ArrayDeque> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ArrayDeque']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public override unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

	}
}
