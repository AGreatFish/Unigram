// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.leaveChannel
	/// </summary>
	public partial class TLChannelsLeaveChannel : TLObject
	{
		public TLInputChannelBase Channel { get; set; }

		public TLChannelsLeaveChannel() { }
		public TLChannelsLeaveChannel(TLBinaryReader from, TLType type = TLType.ChannelsLeaveChannel)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ChannelsLeaveChannel; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ChannelsLeaveChannel)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF836AA95);
			to.WriteObject(Channel);
		}
	}
}