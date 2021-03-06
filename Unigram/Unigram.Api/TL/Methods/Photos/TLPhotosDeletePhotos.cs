// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Photos
{
	/// <summary>
	/// RCP method photos.deletePhotos
	/// </summary>
	public partial class TLPhotosDeletePhotos : TLObject
	{
		public TLVector<TLInputPhotoBase> Id { get; set; }

		public TLPhotosDeletePhotos() { }
		public TLPhotosDeletePhotos(TLBinaryReader from, TLType type = TLType.PhotosDeletePhotos)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.PhotosDeletePhotos; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.PhotosDeletePhotos)
		{
			Id = TLFactory.Read<TLVector<TLInputPhotoBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x87CF7F2F);
			to.WriteObject(Id);
		}
	}
}