// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputMessagesFilterMusic : TLMessagesFilterBase 
	{
		public TLInputMessagesFilterMusic() { }
		public TLInputMessagesFilterMusic(TLBinaryReader from, TLType type = TLType.InputMessagesFilterMusic)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.InputMessagesFilterMusic; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.InputMessagesFilterMusic)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3751B49E);
		}
	}
}