﻿using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Html {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class MimeTypeArray {
		internal MimeTypeArray() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public MimeType this[string name] {
			get {
				return default(MimeType);
			}
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public MimeType this[uint index] {
			get {
				return default(MimeType);
			}
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<MimeType> GetEnumerator() {
			return null;
		}

		public MimeType Item(uint index) {
			return default(MimeType);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		public MimeType NamedItem(string name) {
			return default(MimeType);
		}
	}
}