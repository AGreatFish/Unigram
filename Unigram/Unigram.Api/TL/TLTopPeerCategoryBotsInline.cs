// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLTopPeerCategoryBotsInline : TLTopPeerCategoryBase 
	{
		public TLTopPeerCategoryBotsInline() { }
		public TLTopPeerCategoryBotsInline(TLBinaryReader from, TLType type = TLType.TopPeerCategoryBotsInline)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.TopPeerCategoryBotsInline; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.TopPeerCategoryBotsInline)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x148677E2);
		}
	}
}