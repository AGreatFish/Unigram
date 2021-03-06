// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateNewAuthorization : TLUpdateBase 
	{
		public Int64 AuthKeyId { get; set; }
		public String Device { get; set; }
		public String Location { get; set; }

		public TLUpdateNewAuthorization() { }
		public TLUpdateNewAuthorization(TLBinaryReader from, TLType type = TLType.UpdateNewAuthorization)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateNewAuthorization; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateNewAuthorization)
		{
			AuthKeyId = from.ReadInt64();
			Date = from.ReadInt32();
			Device = from.ReadString();
			Location = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x8F06529A);
			to.Write(AuthKeyId);
			to.Write(Date);
			to.Write(Device);
			to.Write(Location);
		}
	}
}