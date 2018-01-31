using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/artifex/mupdfdemo",
					},
					new Converter<string, Type>[]{
						lookup_com_artifex_mupdfdemo_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_artifex_mupdfdemo_mappings;
		static Type lookup_com_artifex_mupdfdemo_package (string klass)
		{
			if (package_com_artifex_mupdfdemo_mappings == null) {
				package_com_artifex_mupdfdemo_mappings = new string[]{
					"com/artifex/mupdfdemo/Annotation:Artifex.MuPdf.Annotation",
					"com/artifex/mupdfdemo/Annotation$Type:Artifex.MuPdf.Annotation/Type",
					"com/artifex/mupdfdemo/ArrayDeque:Artifex.MuPdf.ArrayDeque",
					"com/artifex/mupdfdemo/AsyncTask:Artifex.MuPdf.AsyncTask",
					"com/artifex/mupdfdemo/AsyncTask$AsyncTaskResult:Artifex.MuPdf.AsyncTask/AsyncTaskResult",
					"com/artifex/mupdfdemo/AsyncTask$InternalHandler:Artifex.MuPdf.AsyncTask/InternalHandler",
					"com/artifex/mupdfdemo/AsyncTask$SerialExecutor:Artifex.MuPdf.AsyncTask/SerialExecutor",
					"com/artifex/mupdfdemo/AsyncTask$Status:Artifex.MuPdf.AsyncTask/Status",
					"com/artifex/mupdfdemo/AsyncTask$WorkerRunnable:Artifex.MuPdf.AsyncTask/WorkerRunnable",
					"com/artifex/mupdfdemo/BuildConfig:Artifex.MuPdf.BuildConfig",
					"com/artifex/mupdfdemo/CancellableAsyncTask:Artifex.MuPdf.CancellableAsyncTask",
					"com/artifex/mupdfdemo/ChoosePDFActivity:Artifex.MuPdf.ChoosePDFActivity",
					"com/artifex/mupdfdemo/ChoosePDFAdapter:Artifex.MuPdf.ChoosePDFAdapter",
					"com/artifex/mupdfdemo/ChoosePDFItem:Artifex.MuPdf.ChoosePDFItem",
					"com/artifex/mupdfdemo/ChoosePDFItem$Type:Artifex.MuPdf.ChoosePDFItem/Type",
					"com/artifex/mupdfdemo/FilePicker:Artifex.MuPdf.FilePicker",
					"com/artifex/mupdfdemo/LinkInfo:Artifex.MuPdf.LinkInfo",
					"com/artifex/mupdfdemo/LinkInfoExternal:Artifex.MuPdf.LinkInfoExternal",
					"com/artifex/mupdfdemo/LinkInfoInternal:Artifex.MuPdf.LinkInfoInternal",
					"com/artifex/mupdfdemo/LinkInfoRemote:Artifex.MuPdf.LinkInfoRemote",
					"com/artifex/mupdfdemo/LinkInfoVisitor:Artifex.MuPdf.LinkInfoVisitor",
					"com/artifex/mupdfdemo/MuPDFActivity:Artifex.MuPdf.MuPDFActivity",
					"com/artifex/mupdfdemo/MuPDFActivity$AcceptMode:Artifex.MuPdf.MuPDFActivity/AcceptMode",
					"com/artifex/mupdfdemo/MuPDFActivity$TopBarMode:Artifex.MuPdf.MuPDFActivity/TopBarMode",
					"com/artifex/mupdfdemo/MuPDFAlert:Artifex.MuPdf.MuPDFAlert",
					"com/artifex/mupdfdemo/MuPDFAlert$ButtonGroupType:Artifex.MuPdf.MuPDFAlert/ButtonGroupType",
					"com/artifex/mupdfdemo/MuPDFAlert$ButtonPressed:Artifex.MuPdf.MuPDFAlert/ButtonPressed",
					"com/artifex/mupdfdemo/MuPDFAlert$IconType:Artifex.MuPdf.MuPDFAlert/IconType",
					"com/artifex/mupdfdemo/MuPDFAlertInternal:Artifex.MuPdf.MuPDFAlertInternal",
					"com/artifex/mupdfdemo/MuPDFCancellableTaskDefinition:Artifex.MuPdf.MuPDFCancellableTaskDefinition",
					"com/artifex/mupdfdemo/MuPDFCore:Artifex.MuPdf.MuPDFCore",
					"com/artifex/mupdfdemo/MuPDFCore$Cookie:Artifex.MuPdf.MuPDFCore/Cookie",
					"com/artifex/mupdfdemo/MuPDFPageAdapter:Artifex.MuPdf.MuPDFPageAdapter",
					"com/artifex/mupdfdemo/MuPDFPageView:Artifex.MuPdf.MuPDFPageView",
					"com/artifex/mupdfdemo/MuPDFReaderView:Artifex.MuPdf.MuPDFReaderView",
					"com/artifex/mupdfdemo/MuPDFReaderView$Mode:Artifex.MuPdf.MuPDFReaderView/Mode",
					"com/artifex/mupdfdemo/MuPDFReflowAdapter:Artifex.MuPdf.MuPDFReflowAdapter",
					"com/artifex/mupdfdemo/MuPDFReflowView:Artifex.MuPdf.MuPDFReflowView",
					"com/artifex/mupdfdemo/OutlineActivity:Artifex.MuPdf.OutlineActivity",
					"com/artifex/mupdfdemo/OutlineActivityData:Artifex.MuPdf.OutlineActivityData",
					"com/artifex/mupdfdemo/OutlineAdapter:Artifex.MuPdf.OutlineAdapter",
					"com/artifex/mupdfdemo/OutlineItem:Artifex.MuPdf.OutlineItem",
					"com/artifex/mupdfdemo/PageView:Artifex.MuPdf.PageView",
					"com/artifex/mupdfdemo/PrintDialogActivity:Artifex.MuPdf.PrintDialogActivity",
					"com/artifex/mupdfdemo/PrintDialogActivity$PrintDialogJavaScriptInterface:Artifex.MuPdf.PrintDialogActivity/PrintDialogJavaScriptInterface",
					"com/artifex/mupdfdemo/PrintDialogActivity$PrintDialogWebClient:Artifex.MuPdf.PrintDialogActivity/PrintDialogWebClient",
					"com/artifex/mupdfdemo/ReaderView:Artifex.MuPdf.ReaderView",
					"com/artifex/mupdfdemo/ReaderView$ViewMapper:Artifex.MuPdf.ReaderView/ViewMapper",
					"com/artifex/mupdfdemo/SafeAnimatorInflater:Artifex.MuPdf.SafeAnimatorInflater",
					"com/artifex/mupdfdemo/SearchTask:Artifex.MuPdf.SearchTask",
					"com/artifex/mupdfdemo/SearchTaskResult:Artifex.MuPdf.SearchTaskResult",
					"com/artifex/mupdfdemo/Separation:Artifex.MuPdf.Separation",
					"com/artifex/mupdfdemo/Stepper:Artifex.MuPdf.Stepper",
					"com/artifex/mupdfdemo/TextChar:Artifex.MuPdf.TextChar",
					"com/artifex/mupdfdemo/TextWord:Artifex.MuPdf.TextWord",
					"com/artifex/mupdfdemo/WidgetType:Artifex.MuPdf.WidgetType",
				};
			}

			return Lookup (package_com_artifex_mupdfdemo_mappings, klass);
		}
	}
}
