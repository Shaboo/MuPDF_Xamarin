using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Artifex.MuPdf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']"
	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/AsyncTask", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Params", "Progress", "Result"})]
	public abstract partial class AsyncTask : global::Java.Lang.Object {


		static IntPtr THREAD_POOL_EXECUTOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/field[@name='THREAD_POOL_EXECUTOR']"
		[Register ("THREAD_POOL_EXECUTOR")]
		public static global::Java.Util.Concurrent.IExecutor ThreadPoolExecutor {
			get {
				if (THREAD_POOL_EXECUTOR_jfieldId == IntPtr.Zero)
					THREAD_POOL_EXECUTOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREAD_POOL_EXECUTOR", "Ljava/util/concurrent/Executor;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THREAD_POOL_EXECUTOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask.AsyncTaskResult']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/AsyncTask$AsyncTaskResult", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Data"})]
		public partial class AsyncTaskResult : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/AsyncTask$AsyncTaskResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AsyncTaskResult); }
			}

			protected AsyncTaskResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask.InternalHandler']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/AsyncTask$InternalHandler", DoNotGenerateAcw=true)]
		public partial class InternalHandler : global::Android.OS.Handler {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/AsyncTask$InternalHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InternalHandler); }
			}

			protected InternalHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask.SerialExecutor']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/AsyncTask$SerialExecutor", DoNotGenerateAcw=true)]
		public partial class SerialExecutor : global::Java.Lang.Object, global::Java.Util.Concurrent.IExecutor {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/AsyncTask$SerialExecutor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SerialExecutor); }
			}

			protected SerialExecutor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_execute_Ljava_lang_Runnable_;
#pragma warning disable 0169
			static Delegate GetExecute_Ljava_lang_Runnable_Handler ()
			{
				if (cb_execute_Ljava_lang_Runnable_ == null)
					cb_execute_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Execute_Ljava_lang_Runnable_);
				return cb_execute_Ljava_lang_Runnable_;
			}

			static void n_Execute_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Artifex.MuPdf.AsyncTask.SerialExecutor __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask.SerialExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Execute (p0);
			}
#pragma warning restore 0169

			static IntPtr id_execute_Ljava_lang_Runnable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask.SerialExecutor']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("execute", "(Ljava/lang/Runnable;)V", "GetExecute_Ljava_lang_Runnable_Handler")]
			public virtual unsafe void Execute (global::Java.Lang.IRunnable p0)
			{
				if (id_execute_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_execute_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "execute", "(Ljava/lang/Runnable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute_Ljava_lang_Runnable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "(Ljava/lang/Runnable;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_scheduleNext;
#pragma warning disable 0169
			static Delegate GetScheduleNextHandler ()
			{
				if (cb_scheduleNext == null)
					cb_scheduleNext = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ScheduleNext);
				return cb_scheduleNext;
			}

			static void n_ScheduleNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Artifex.MuPdf.AsyncTask.SerialExecutor __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask.SerialExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ScheduleNext ();
			}
#pragma warning restore 0169

			static IntPtr id_scheduleNext;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask.SerialExecutor']/method[@name='scheduleNext' and count(parameter)=0]"
			[Register ("scheduleNext", "()V", "GetScheduleNextHandler")]
			protected virtual unsafe void ScheduleNext ()
			{
				if (id_scheduleNext == IntPtr.Zero)
					id_scheduleNext = JNIEnv.GetMethodID (class_ref, "scheduleNext", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scheduleNext);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scheduleNext", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask.Status']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/AsyncTask$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr FINISHED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask.Status']/field[@name='FINISHED']"
			[Register ("FINISHED")]
			public static global::Artifex.MuPdf.AsyncTask.Status Finished {
				get {
					if (FINISHED_jfieldId == IntPtr.Zero)
						FINISHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FINISHED", "Lcom/artifex/mupdfdemo/AsyncTask$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FINISHED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PENDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask.Status']/field[@name='PENDING']"
			[Register ("PENDING")]
			public static global::Artifex.MuPdf.AsyncTask.Status Pending {
				get {
					if (PENDING_jfieldId == IntPtr.Zero)
						PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/artifex/mupdfdemo/AsyncTask$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PENDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RUNNING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask.Status']/field[@name='RUNNING']"
			[Register ("RUNNING")]
			public static global::Artifex.MuPdf.AsyncTask.Status Running {
				get {
					if (RUNNING_jfieldId == IntPtr.Zero)
						RUNNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RUNNING", "Lcom/artifex/mupdfdemo/AsyncTask$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RUNNING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/AsyncTask$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/artifex/mupdfdemo/AsyncTask$Status;", "")]
			public static unsafe global::Artifex.MuPdf.AsyncTask.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/artifex/mupdfdemo/AsyncTask$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Artifex.MuPdf.AsyncTask.Status __ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/artifex/mupdfdemo/AsyncTask$Status;", "")]
			public static unsafe global::Artifex.MuPdf.AsyncTask.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/artifex/mupdfdemo/AsyncTask$Status;");
				try {
					return (global::Artifex.MuPdf.AsyncTask.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Artifex.MuPdf.AsyncTask.Status));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask.WorkerRunnable']"
		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/AsyncTask$WorkerRunnable", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"Params", "Result"})]
		public abstract partial class WorkerRunnable : global::Java.Lang.Object, global::Java.Util.Concurrent.ICallable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/artifex/mupdfdemo/AsyncTask$WorkerRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WorkerRunnable); }
			}

			protected WorkerRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_call;
#pragma warning disable 0169
			static Delegate GetCallHandler ()
			{
				if (cb_call == null)
					cb_call = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Call);
				return cb_call;
			}

			static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
			{
				global::Artifex.MuPdf.AsyncTask.WorkerRunnable __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask.WorkerRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Call ());
			}
#pragma warning restore 0169

			[Register ("call", "()Ljava/lang/Object;", "GetCallHandler")]
			public abstract global::Java.Lang.Object Call ();

		}

		[global::Android.Runtime.Register ("com/artifex/mupdfdemo/AsyncTask$WorkerRunnable", DoNotGenerateAcw=true)]
		internal partial class WorkerRunnableInvoker : WorkerRunnable {

			public WorkerRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (WorkerRunnableInvoker); }
			}

			static IntPtr id_call;
			[Register ("call", "()Ljava/lang/Object;", "GetCallHandler")]
			public override unsafe global::Java.Lang.Object Call ()
			{
				if (id_call == IntPtr.Zero)
					id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/lang/Object;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/artifex/mupdfdemo/AsyncTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncTask); }
		}

		protected AsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/constructor[@name='AsyncTask' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncTask ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AsyncTask)) {
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

		static IntPtr id_isCancelled;
		public unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler")]
			get {
				if (id_isCancelled == IntPtr.Zero)
					id_isCancelled = JNIEnv.GetMethodID (class_ref, "isCancelled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCancelled);
				} finally {
				}
			}
		}

		static IntPtr id_cancel_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("cancel", "(Z)Z", "")]
		public unsafe bool Cancel (bool p0)
		{
			if (id_cancel_Z == IntPtr.Zero)
				id_cancel_Z = JNIEnv.GetMethodID (class_ref, "cancel", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Z, __args);
			} finally {
			}
		}

		static Delegate cb_doInBackground_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler ()
		{
			if (cb_doInBackground_arrayLjava_lang_Object_ == null)
				cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Object_);
			return cb_doInBackground_arrayLjava_lang_Object_;
		}

		static IntPtr n_DoInBackground_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.AsyncTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='Params...']]"
		[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
		protected abstract global::Java.Lang.Object DoInBackground (params global:: Java.Lang.Object[] p0);

		static IntPtr id_execute_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='Params...']]"
		[Register ("execute", "([Ljava/lang/Object;)Lcom/artifex/mupdfdemo/AsyncTask;", "")]
		public unsafe global::Artifex.MuPdf.AsyncTask Execute (params global:: Java.Lang.Object[] p0)
		{
			if (id_execute_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_execute_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "execute", "([Ljava/lang/Object;)Lcom/artifex/mupdfdemo/AsyncTask;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Artifex.MuPdf.AsyncTask __ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_execute_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("execute", "(Ljava/lang/Runnable;)V", "")]
		public static unsafe void Execute (global::Java.Lang.IRunnable p0)
		{
			if (id_execute_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_execute_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "execute", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_execute_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_executeOnExecutor_Ljava_util_concurrent_Executor_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='executeOnExecutor' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Executor'] and parameter[2][@type='Params...']]"
		[Register ("executeOnExecutor", "(Ljava/util/concurrent/Executor;[Ljava/lang/Object;)Lcom/artifex/mupdfdemo/AsyncTask;", "")]
		public unsafe global::Artifex.MuPdf.AsyncTask ExecuteOnExecutor (global::Java.Util.Concurrent.IExecutor p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_executeOnExecutor_Ljava_util_concurrent_Executor_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_executeOnExecutor_Ljava_util_concurrent_Executor_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "executeOnExecutor", "(Ljava/util/concurrent/Executor;[Ljava/lang/Object;)Lcom/artifex/mupdfdemo/AsyncTask;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Artifex.MuPdf.AsyncTask __ret = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_executeOnExecutor_Ljava_util_concurrent_Executor_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_get_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='get' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Get (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			if (id_get_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_get_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()Lcom/artifex/mupdfdemo/AsyncTask$Status;", "")]
		public unsafe global::Artifex.MuPdf.AsyncTask.Status GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/artifex/mupdfdemo/AsyncTask$Status;");
			try {
				return global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask.Status> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "")]
		public static unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetStaticMethodID (class_ref, "init", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init);
			} finally {
			}
		}

		static Delegate cb_onCancelled;
#pragma warning disable 0169
		static Delegate GetOnCancelledHandler ()
		{
			if (cb_onCancelled == null)
				cb_onCancelled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancelled);
			return cb_onCancelled;
		}

		static void n_OnCancelled (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.AsyncTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelled ();
		}
#pragma warning restore 0169

		static IntPtr id_onCancelled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='onCancelled' and count(parameter)=0]"
		[Register ("onCancelled", "()V", "GetOnCancelledHandler")]
		protected virtual unsafe void OnCancelled ()
		{
			if (id_onCancelled == IntPtr.Zero)
				id_onCancelled = JNIEnv.GetMethodID (class_ref, "onCancelled", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancelled);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancelled", "()V"));
			} finally {
			}
		}

		static Delegate cb_onCancelled_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnCancelled_Ljava_lang_Object_Handler ()
		{
			if (cb_onCancelled_Ljava_lang_Object_ == null)
				cb_onCancelled_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancelled_Ljava_lang_Object_);
			return cb_onCancelled_Ljava_lang_Object_;
		}

		static void n_OnCancelled_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.AsyncTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCancelled_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='onCancelled' and count(parameter)=1 and parameter[1][@type='Result']]"
		[Register ("onCancelled", "(Ljava/lang/Object;)V", "GetOnCancelled_Ljava_lang_Object_Handler")]
		protected virtual unsafe void OnCancelled (global::Java.Lang.Object p0)
		{
			if (id_onCancelled_Ljava_lang_Object_ == IntPtr.Zero)
				id_onCancelled_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onCancelled", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancelled_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancelled", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onPostExecute_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnPostExecute_Ljava_lang_Object_Handler ()
		{
			if (cb_onPostExecute_Ljava_lang_Object_ == null)
				cb_onPostExecute_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Object_);
			return cb_onPostExecute_Ljava_lang_Object_;
		}

		static void n_OnPostExecute_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.AsyncTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='Result']]"
		[Register ("onPostExecute", "(Ljava/lang/Object;)V", "GetOnPostExecute_Ljava_lang_Object_Handler")]
		protected virtual unsafe void OnPostExecute (global::Java.Lang.Object p0)
		{
			if (id_onPostExecute_Ljava_lang_Object_ == IntPtr.Zero)
				id_onPostExecute_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPostExecute_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onPreExecute;
#pragma warning disable 0169
		static Delegate GetOnPreExecuteHandler ()
		{
			if (cb_onPreExecute == null)
				cb_onPreExecute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPreExecute);
			return cb_onPreExecute;
		}

		static void n_OnPreExecute (IntPtr jnienv, IntPtr native__this)
		{
			global::Artifex.MuPdf.AsyncTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPreExecute ();
		}
#pragma warning restore 0169

		static IntPtr id_onPreExecute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='onPreExecute' and count(parameter)=0]"
		[Register ("onPreExecute", "()V", "GetOnPreExecuteHandler")]
		protected virtual unsafe void OnPreExecute ()
		{
			if (id_onPreExecute == IntPtr.Zero)
				id_onPreExecute = JNIEnv.GetMethodID (class_ref, "onPreExecute", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPreExecute);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreExecute", "()V"));
			} finally {
			}
		}

		static Delegate cb_onProgressUpdate_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnProgressUpdate_arrayLjava_lang_Object_Handler ()
		{
			if (cb_onProgressUpdate_arrayLjava_lang_Object_ == null)
				cb_onProgressUpdate_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProgressUpdate_arrayLjava_lang_Object_);
			return cb_onProgressUpdate_arrayLjava_lang_Object_;
		}

		static void n_OnProgressUpdate_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Artifex.MuPdf.AsyncTask __this = global::Java.Lang.Object.GetObject<global::Artifex.MuPdf.AsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.OnProgressUpdate (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_onProgressUpdate_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='onProgressUpdate' and count(parameter)=1 and parameter[1][@type='Progress...']]"
		[Register ("onProgressUpdate", "([Ljava/lang/Object;)V", "GetOnProgressUpdate_arrayLjava_lang_Object_Handler")]
		protected virtual unsafe void OnProgressUpdate (params global:: Java.Lang.Object[] p0)
		{
			if (id_onProgressUpdate_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_onProgressUpdate_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onProgressUpdate", "([Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgressUpdate_arrayLjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProgressUpdate", "([Ljava/lang/Object;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_publishProgress_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='publishProgress' and count(parameter)=1 and parameter[1][@type='Progress...']]"
		[Register ("publishProgress", "([Ljava/lang/Object;)V", "")]
		protected unsafe void PublishProgress (params global:: Java.Lang.Object[] p0)
		{
			if (id_publishProgress_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_publishProgress_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "publishProgress", "([Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_publishProgress_arrayLjava_lang_Object_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_setDefaultExecutor_Ljava_util_concurrent_Executor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='setDefaultExecutor' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Executor']]"
		[Register ("setDefaultExecutor", "(Ljava/util/concurrent/Executor;)V", "")]
		public static unsafe void SetDefaultExecutor (global::Java.Util.Concurrent.IExecutor p0)
		{
			if (id_setDefaultExecutor_Ljava_util_concurrent_Executor_ == IntPtr.Zero)
				id_setDefaultExecutor_Ljava_util_concurrent_Executor_ = JNIEnv.GetStaticMethodID (class_ref, "setDefaultExecutor", "(Ljava/util/concurrent/Executor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDefaultExecutor_Ljava_util_concurrent_Executor_, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/artifex/mupdfdemo/AsyncTask", DoNotGenerateAcw=true)]
	internal partial class AsyncTaskInvoker : AsyncTask {

		public AsyncTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AsyncTaskInvoker); }
		}

		static IntPtr id_doInBackground_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='AsyncTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='Params...']]"
		[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
		protected override unsafe global::Java.Lang.Object DoInBackground (params global:: Java.Lang.Object[] p0)
		{
			if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

}
