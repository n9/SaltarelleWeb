﻿using System.Runtime.CompilerServices;

namespace System.Net.WebRTC {
	[Imported, Serializable]
	public partial class RTCOutboundRTPStreamStats : RTCRTPStreamStats {
		public ulong BytesSent {
			get;
			set;
		}

		public uint PacketsSent {
			get;
			set;
		}
	}
}
