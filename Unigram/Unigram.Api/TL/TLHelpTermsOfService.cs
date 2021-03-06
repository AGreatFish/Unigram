// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLHelpTermsOfService : TLObject 
	{
		public String Text { get; set; }

		public TLHelpTermsOfService() { }
		public TLHelpTermsOfService(TLBinaryReader from, TLType type = TLType.HelpTermsOfService)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.HelpTermsOfService; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.HelpTermsOfService)
		{
			Text = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF1EE3E90);
			to.Write(Text);
		}
	}
}