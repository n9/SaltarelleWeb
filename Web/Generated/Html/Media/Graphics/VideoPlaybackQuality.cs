﻿using System.Runtime.CompilerServices;

namespace System.Html.Media.Graphics {
	[IgnoreNamespace, Imported(ObeysTypeSystem = true)]
	public partial class VideoPlaybackQuality {
		internal VideoPlaybackQuality() {
		}

		[IntrinsicProperty]
		public int CorruptedVideoFrames {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public double CreationTime {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int DroppedVideoFrames {
			get {
				return 0;
			}
		}

		[IntrinsicProperty]
		public int TotalVideoFrames {
			get {
				return 0;
			}
		}
	}
}
