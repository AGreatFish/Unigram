// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLRPCAnswerUnknown : TLRPCDropAnswerBase 
	{
		public TLRPCAnswerUnknown() { }
		public TLRPCAnswerUnknown(TLBinaryReader from, TLType type = TLType.RPCAnswerUnknown)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.RPCAnswerUnknown; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.RPCAnswerUnknown)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x5E2AD36E);
		}
	}
}