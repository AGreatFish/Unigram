// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessagesSentEncryptedMessage : TLMessagesSentEncryptedMessageBase 
	{

		public TLMessagesSentEncryptedMessage() { }
		public TLMessagesSentEncryptedMessage(TLBinaryReader from, TLType type = TLType.MessagesSentEncryptedMessage)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MessagesSentEncryptedMessage; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MessagesSentEncryptedMessage)
		{
			Date = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x560F8935);
			to.Write(Date);
		}
	}
}