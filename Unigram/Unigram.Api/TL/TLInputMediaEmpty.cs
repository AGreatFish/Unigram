// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputMediaEmpty : TLInputMediaBase 
	{
		public TLInputMediaEmpty() { }
		public TLInputMediaEmpty(TLBinaryReader from, TLType type = TLType.InputMediaEmpty)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.InputMediaEmpty; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.InputMediaEmpty)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9664F57F);
		}
	}
}