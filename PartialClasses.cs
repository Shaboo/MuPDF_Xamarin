using System;
using Android.Runtime;


namespace Artifex.MuPdf
{
    partial class ReaderView
    {
        // We use GetAdapter(...) / SetAdapter created in Metadata.xml
        // instead of the missing Adapter { get; set; }
        protected override Java.Lang.Object RawAdapter
        {
            get => GetAdapter().JavaCast<Java.Lang.Object>();
            set
            {
                using (var adapter = value.JavaCast<global::Android.Widget.IAdapter>())
                {
                    SetAdapter(adapter);
                }
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.artifex.mupdfdemo']/class[@name='ReaderView']/method[@name='getAdapter' and count(parameter)=0]"
        static IntPtr id_getAdapter;
        [Register("getAdapter", "()Landroid/widget/Adapter;", "GetGetAdapterHandler")]
        public unsafe global::Android.Widget.IAdapter GetAdapter()
        {
            if (id_getAdapter == IntPtr.Zero)
                id_getAdapter = JNIEnv.GetMethodID(class_ref, "getAdapter", "()Landroid/widget/Adapter;");
            try
            {

                if (((object)this).GetType() == ThresholdType)
                    return global::Java.Lang.Object.GetObject<global::Android.Widget.IAdapter>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getAdapter), JniHandleOwnership.TransferLocalRef);
                else
                    return global::Java.Lang.Object.GetObject<global::Android.Widget.IAdapter>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getAdapter", "()Landroid/widget/Adapter;")), JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }
}