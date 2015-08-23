using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Infrastructure;

namespace Zulu.BusinessService.Medias
{
	public static class Extension
	{
		///// <summary>
		///// Gets the download binary array
		///// </summary>
		///// <param name="postedFile">Posted file</param>
		///// <returns>Download binary array</returns>
		//public static byte[] GetDownloadBits(this HttpPostedFile postedFile)
		//{
		//	Stream fs = postedFile.InputStream;
		//	int size = postedFile.ContentLength;
		//	byte[] binary = new byte[size];
		//	fs.Read(binary, 0, size);
		//	return binary;
		//}

		///// <summary>
		///// Gets the picture binary array
		///// </summary>
		///// <param name="postedFile">Posted file</param>
		///// <returns>Media binary array</returns>
		//public static byte[] GetMediaBits(this HttpPostedFile postedFile)
		//{
		//	Stream fs = postedFile.InputStream;
		//	int size = postedFile.ContentLength;
		//	byte[] img = new byte[size];
		//	fs.Read(img, 0, size);
		//	return img;
		//}

		/// <summary>
		/// Gets the loaded picture binary depending on picture storage settings
		/// </summary>
		/// <param name="picture">Media</param>
		/// <param name="fromDb">Load from database; otherwise, from file system</param>
		/// <returns>Media binary</returns>
		public static byte[] LoadMediaBinary(this Media picture, bool fromDb)
		{
			byte[] result = null;
			if (fromDb)
			{
				result = picture.PictureBinary;
			}
			else
			{
				result = IoC.Resolve<IMediaService>().LoadMediaFromFile(picture.MediaID, picture.MimeType);
			}
			return result;
		}

		/// <summary>
		/// Gets the loaded picture binary depending on picture storage settings
		/// </summary>
		/// <param name="picture">Media</param>
		/// <returns>Media binary</returns>
		public static byte[] LoadMediaBinary(this Media picture)
		{
			return LoadMediaBinary(picture, true);
		}
	}
}
