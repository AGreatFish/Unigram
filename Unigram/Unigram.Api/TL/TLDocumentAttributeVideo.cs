// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLDocumentAttributeVideo : TLDocumentAttributeBase 
	{

		public TLDocumentAttributeVideo() { }
		public TLDocumentAttributeVideo(TLBinaryReader from, TLType type = TLType.DocumentAttributeVideo)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.DocumentAttributeVideo; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.DocumentAttributeVideo)
		{
			Duration = from.ReadInt32();
			W = from.ReadInt32();
			H = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x5910CCCB);
			to.Write(Duration);
			to.Write(W);
			to.Write(H);
		}
	}
}