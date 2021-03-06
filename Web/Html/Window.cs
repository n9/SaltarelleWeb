using System.Xml;
using System.Runtime.CompilerServices;

namespace System.Html {
	public partial class Window {
		public static void AddEventListener(string type, Action listener) {}
		public static void AddEventListener(string type, Action listener, bool capture) {}
		public static void AddEventListener(string type, Action listener, bool capture, bool? wantsUntrusted) {}

		public static void RemoveEventListener(string type, Action listener) {}
		public static void RemoveEventListener(string type, Action listener, bool capture) {}


		public static void AddEventListener(string type, HtmlEventHandler listener) {}
		public static void AddEventListener(string type, HtmlEventHandler listener, bool capture) {}
		public static void AddEventListener(string type, HtmlEventHandler listener, bool capture, bool? wantsUntrusted) {}

		public static void RemoveEventListener(string type, HtmlEventHandler listener) {}
		public static void RemoveEventListener(string type, HtmlEventHandler listener, bool capture) {}

		[IntrinsicProperty]
		public static object DialogArguments { get { return null; } }

		[IntrinsicProperty]
		public static object ReturnValue { get; set; }

		public static object ShowModalDialog(string url) { return null; }

		[IntrinsicProperty]
		public static DocumentInstance Document { get { return null; } }

		public static int SetTimeout(Action handler) { return 0; }
		public static int SetTimeout(Action handler, int timeout) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetTimeout<T1>(Action<T1> handler, int timeout, T1 arg1) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetTimeout<T1, T2>(Action<T1> handler, int timeout, T1 arg1, T2 arg2) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetTimeout<T1, T2, T3>(Action<T1, T2, T3> handler, int timeout, T1 arg1, T2 arg2, T3 arg3) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetTimeout<T1, T2, T3, T4>(Action<T1, T2, T3, T4> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetTimeout<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetTimeout<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetTimeout<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetTimeout<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { return 0; }
		[ExpandParams]
		public static int SetTimeout(Delegate handler, int timeout, params object[] arguments) { return 0; }
		public static int SetTimeout(string handler) { return 0; }
		public static int SetTimeout(string handler, int timeout) { return 0; }

		public static int SetInterval(Action handler) { return 0; }
		public static int SetInterval(Action handler, int timeout) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetInterval<T1>(Action<T1> handler, int timeout, T1 arg1) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetInterval<T1, T2>(Action<T1> handler, int timeout, T1 arg1, T2 arg2) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetInterval<T1, T2, T3>(Action<T1, T2, T3> handler, int timeout, T1 arg1, T2 arg2, T3 arg3) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetInterval<T1, T2, T3, T4>(Action<T1, T2, T3, T4> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetInterval<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetInterval<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetInterval<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { return 0; }
		[IncludeGenericArguments(false)]
		public static int SetInterval<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> handler, int timeout, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { return 0; }
		[ExpandParams]
		public static int SetInterval(Delegate handler, int timeout, params object[] arguments) { return 0; }
		public static int SetInterval(string handler) { return 0; }
		public static int SetInterval(string handler, int timeout) { return 0; }

		public static void ClearInterval(int handle) {}

		public static void ClearTimeout(int handle) {}
		
		public static System.Data.Sql.SqlDatabase OpenDatabase(string name, string version, string displayName, int estimatedSize)
        {
            return null;
        }
	}
}
