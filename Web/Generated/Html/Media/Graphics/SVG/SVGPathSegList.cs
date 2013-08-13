﻿using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics.SVG {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class SVGPathSegList {
		internal SVGPathSegList() {
		}

		[IndexerName("__Item"), IntrinsicProperty]
		public SVGPathSeg this[uint index] {
			get {
				return default(SVGPathSeg);
			}
		}

		public SVGPathSeg AppendItem(SVGPathSeg newItem) {
			return default(SVGPathSeg);
		}

		public void Clear() {
		}

		[EnumerateAsArray, InlineCode("new {$System.ArrayEnumerator}({this})")]
		public IEnumerator<SVGPathSeg> GetEnumerator() {
			return null;
		}

		public SVGPathSeg GetItem(uint index) {
			return default(SVGPathSeg);
		}

		public SVGPathSeg Initialize(SVGPathSeg newItem) {
			return default(SVGPathSeg);
		}

		public SVGPathSeg InsertItemBefore(SVGPathSeg newItem, uint index) {
			return default(SVGPathSeg);
		}

		[IntrinsicProperty]
		public uint Length {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public uint NumberOfItems {
			get {
				return 0;
			}
		}

		public SVGPathSeg RemoveItem(uint index) {
			return default(SVGPathSeg);
		}

		public SVGPathSeg ReplaceItem(SVGPathSeg newItem, uint index) {
			return default(SVGPathSeg);
		}
	}
}