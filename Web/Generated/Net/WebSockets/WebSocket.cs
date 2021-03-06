﻿using System.Collections.TypedArrays;
using System.Html;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Net.WebSockets {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class WebSocket : EventTarget {
		internal WebSocket() {
		}

		public WebSocket(string url) {
		}

		public WebSocket(string url, string protocols) {
		}

		public WebSocket(string url, string[] protocols) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<WebSocket> listener) {
		}

		public void AddEventListener(string type, HtmlEventHandlerWithTarget<WebSocket> listener, bool capture) {
		}

		public void AddEventListener(WebSocketEvents type, Action listener) {
		}

		public void AddEventListener(WebSocketEvents type, Action listener, bool capture) {
		}

		public void AddEventListener(WebSocketEvents type, HtmlEventHandler listener) {
		}

		public void AddEventListener(WebSocketEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void AddEventListener(WebSocketEvents type, HtmlEventHandlerWithTarget<WebSocket> listener) {
		}

		public void AddEventListener(WebSocketEvents type, HtmlEventHandlerWithTarget<WebSocket> listener, bool capture) {
		}

		public void AddEventListener(WebSocketEvents type, IEventListener listener) {
		}

		public void AddEventListener(WebSocketEvents type, IEventListener listener, bool capture) {
		}

		[IntrinsicProperty]
		public BinaryType BinaryType {
			get {
				return default(BinaryType);
			}
			set {
			}
		}

		[IntrinsicProperty]
		public int BufferedAmount {
			get {
				return 0;
			}
		}

		public void Close() {
		}

		public void Close(ushort code) {
		}

		public void Close(ushort code, string reason) {
		}

		public const ushort CLOSED = 3;

		public const ushort CLOSING = 2;

		public const ushort CONNECTING = 0;

		[IntrinsicProperty]
		public string Extensions {
			get {
				return null;
			}
		}

		[IntrinsicProperty, ScriptName("onclose")]
		public HtmlEventHandler OnClose {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onerror")]
		public HtmlEventHandler OnError {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onmessage")]
		public HtmlEventHandler OnMessage {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		[IntrinsicProperty, ScriptName("onopen")]
		public HtmlEventHandler OnOpen {
			get {
				return default(HtmlEventHandler);
			}
			set {
			}
		}

		public const ushort OPEN = 1;

		[IntrinsicProperty]
		public string Protocol {
			get {
				return null;
			}
		}

		[IntrinsicProperty]
		public ReadyState ReadyState {
			get {
				return default(ReadyState);
			}
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WebSocket> listener) {
		}

		public void RemoveEventListener(string type, HtmlEventHandlerWithTarget<WebSocket> listener, bool capture) {
		}

		public void RemoveEventListener(WebSocketEvents type, Action listener) {
		}

		public void RemoveEventListener(WebSocketEvents type, Action listener, bool capture) {
		}

		public void RemoveEventListener(WebSocketEvents type, HtmlEventHandler listener) {
		}

		public void RemoveEventListener(WebSocketEvents type, HtmlEventHandler listener, bool capture) {
		}

		public void RemoveEventListener(WebSocketEvents type, HtmlEventHandlerWithTarget<WebSocket> listener) {
		}

		public void RemoveEventListener(WebSocketEvents type, HtmlEventHandlerWithTarget<WebSocket> listener, bool capture) {
		}

		public void RemoveEventListener(WebSocketEvents type, IEventListener listener) {
		}

		public void RemoveEventListener(WebSocketEvents type, IEventListener listener, bool capture) {
		}

		public void Send(ArrayBuffer data) {
		}

		public void Send(ArrayBufferView data) {
		}

		public void Send(Blob data) {
		}

		public void Send(string data) {
		}

		[IntrinsicProperty]
		public string Url {
			get {
				return null;
			}
		}
	}
}
