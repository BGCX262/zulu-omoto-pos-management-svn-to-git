using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Settings;
using Zulu.BusinessService.Util;

namespace Zulu.BusinessService.Medias
{
	public partial class MediaService : IMediaService
	{
		#region Fields

		private static readonly object s_lock = new object();

		/// <summary>
		/// Object context
		/// </summary>
		private readonly ZuluDataContext _context;

		#endregion

		#region Ctor

		/// <summary>
		/// Ctor
		/// </summary>
		/// <param name="context">Object context</param>
		public MediaService(ZuluDataContext context)
		{
			this._context = context;
		}

		public MediaService()
		{

		}
		#endregion

		#region Utilities

		/// <summary>
		/// Returns the first ImageCodecInfo instance with the specified mime type.
		/// </summary>
		/// <param name="mimeType">Mime type</param>
		/// <returns>ImageCodecInfo</returns>
		private ImageCodecInfo GetImageCodecInfoFromMimeType(string mimeType)
		{
			var info = ImageCodecInfo.GetImageEncoders();
			foreach (var ici in info)
				if (ici.MimeType.Equals(mimeType, StringComparison.OrdinalIgnoreCase))
					return ici;
			return null;
		}

		/// <summary>
		/// Returns the first ImageCodecInfo instance with the specified extension.
		/// </summary>
		/// <param name="fileExt">File extension</param>
		/// <returns>ImageCodecInfo</returns>
		private ImageCodecInfo GetImageCodecInfoFromExtension(string fileExt)
		{
			fileExt = fileExt.TrimStart(".".ToCharArray()).ToLower().Trim();
			switch (fileExt)
			{
				case "jpg":
				case "jpeg":
					return GetImageCodecInfoFromMimeType("image/jpeg");
				case "png":
					return GetImageCodecInfoFromMimeType("image/png");
				case "gif":
					//use png codec for gif to preserve transparency
					//return GetImageCodecInfoFromMimeType("image/gif");
					return GetImageCodecInfoFromMimeType("image/png");
				default:
					return GetImageCodecInfoFromMimeType("image/jpeg");
			}
		}

		/// <summary>
		/// Save media on file system
		/// </summary>
		/// <param name="mediaId">Media identifier</param>
		/// <param name="mediaBinary">Media binary</param>
		/// <param name="mimeType">MIME type</param>
		private void SaveMediaInFile(int mediaId, byte[] mediaBinary, string mimeType)
		{
			string[] parts = mimeType.Split('/');
			string lastPart = parts[parts.Length - 1];
			switch (lastPart)
			{
				case "pjpeg":
					lastPart = "jpg";
					break;
				case "x-png":
					lastPart = "png";
					break;
				case "x-icon":
					lastPart = "ico";
					break;
			}
			string localFilename = string.Format("{0}_0.{1}", mediaId.ToString("0000000"), lastPart);
			File.WriteAllBytes(Path.Combine(LocalImagePath, localFilename), mediaBinary);
		}

		/// <summary>
		/// Delete a media on file system
		/// </summary>
		/// <param name="media">Media</param>
		private void DeleteMediaOnFileSystem(Media media)
		{
			if (media == null)
				throw new ArgumentNullException("media");

			string[] parts = media.MimeType.Split('/');
			string lastPart = parts[parts.Length - 1];
			switch (lastPart)
			{
				case "pjpeg":
					lastPart = "jpg";
					break;
				case "x-png":
					lastPart = "png";
					break;
				case "x-icon":
					lastPart = "ico";
					break;
			}
			string localFilename = string.Format("{0}_0.{1}", media.MediaID.ToString("0000000"), lastPart);
			string localFilepath = Path.Combine(LocalImagePath, localFilename);
			if (File.Exists(localFilepath))
			{
				File.Delete(localFilepath);
			}
		}

		/// <summary>
		/// Calculates media dimensions whilst maintaining aspect
		/// </summary>
		/// <param name="originalSize">The original media size</param>
		/// <param name="targetSize">The target media size (longest side)</param>
		/// <returns></returns>
		private Size CalculateDimensions(Size originalSize, int targetSize)
		{
			var newSize = new Size();
			if (originalSize.Height > originalSize.Width) // portrait 
			{
				newSize.Width = (int)(originalSize.Width * (float)(targetSize / (float)originalSize.Height));
				newSize.Height = targetSize;
			}
			else // landscape or square
			{
				newSize.Height = (int)(originalSize.Height * (float)(targetSize / (float)originalSize.Width));
				newSize.Width = targetSize;
			}
			return newSize;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Gets the default media URL
		/// </summary>
		/// <param name="targetSize">The target media size (longest side)</param>
		/// <returns></returns>
		public string GetDefaultMediaUrl(int targetSize)
		{
			return GetDefaultMediaUrl(PictureTypeEnum.Entity, targetSize);
		}

		/// <summary>
		/// Gets the default media URL
		/// </summary>
		/// <param name="defaultMediaType">Default media type</param>
		/// <param name="targetSize">The target media size (longest side)</param>
		/// <returns></returns>
		public string GetDefaultMediaUrl(PictureTypeEnum defaultMediaType,
			int targetSize)
		{
			string defaultImageName = string.Empty;
			switch (defaultMediaType)
			{
				case PictureTypeEnum.Entity:
					defaultImageName = IoC.Resolve<ISettingService>().GetSettingValue("Media.DefaultImageName");
					break;
				case PictureTypeEnum.Avatar:
					defaultImageName = IoC.Resolve<ISettingService>().GetSettingValue("Media.Customer.DefaultAvatarImageName");
					break;
				default:
					defaultImageName = IoC.Resolve<ISettingService>().GetSettingValue("Media.DefaultImageName");
					break;
			}


			string relPath = ZuluHelper.ApplicationPath + "images/" + defaultImageName;
			if (targetSize == 0)
				return relPath;
			else
			{
				string filePath = Path.Combine(LocalImagePath, defaultImageName);
				if (File.Exists(filePath))
				{
					string fileExtension = Path.GetExtension(filePath);
					string fname = string.Format("{0}_{1}{2}",
						Path.GetFileNameWithoutExtension(filePath),
						targetSize,
						fileExtension);
					if (!File.Exists(Path.Combine(LocalThumbImagePath, fname)))
					{
						var b = new Bitmap(filePath);

						var newSize = CalculateDimensions(b.Size, targetSize);

						if (newSize.Width < 1)
							newSize.Width = 1;
						if (newSize.Height < 1)
							newSize.Height = 1;

						var newBitMap = new Bitmap(newSize.Width, newSize.Height);
						var g = Graphics.FromImage(newBitMap);
						g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
						g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
						g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
						g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
						g.DrawImage(b, 0, 0, newSize.Width, newSize.Height);
						var ep = new EncoderParameters();
						ep.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, this.ImageQuality);
						ImageCodecInfo ici = GetImageCodecInfoFromExtension(fileExtension);
						if (ici == null)
							ici = GetImageCodecInfoFromMimeType("image/jpeg");
						newBitMap.Save(Path.Combine(LocalThumbImagePath, fname), ici, ep);
						newBitMap.Dispose();
						b.Dispose();
					}
					return ZuluHelper.ApplicationPath + "images/thumbs/" + fname;
				}
				return relPath;
			}
		}

		/// <summary>
		/// Loads a cpiture from file
		/// </summary>
		/// <param name="mediaId">Media identifier</param>
		/// <param name="mimeType">MIME type</param>
		/// <returns>Media binary</returns>
		public byte[] LoadMediaFromFile(int mediaId, string mimeType)
		{
			string[] parts = mimeType.Split('/');
			string lastPart = parts[parts.Length - 1];
			switch (lastPart)
			{
				case "pjpeg":
					lastPart = "jpg";
					break;
				case "x-png":
					lastPart = "png";
					break;
				case "x-icon":
					lastPart = "ico";
					break;
			}
			string localFilename = string.Empty;
			localFilename = string.Format("{0}_0.{1}", mediaId.ToString("0000000"), lastPart);
			if (!File.Exists(Path.Combine(LocalImagePath, localFilename)))
			{
				return new byte[0];
			}
			return File.ReadAllBytes(Path.Combine(LocalImagePath, localFilename));
		}

		/// <summary>
		/// Get a media URL
		/// </summary>
		/// <param name="imageId">Media identifier</param>
		/// <returns>Media URL</returns>
		public string GetMediaUrl(int imageId)
		{
			Media media = GetMediaById(imageId);
			return GetMediaUrl(media);
		}

		/// <summary>
		/// Get a media URL
		/// </summary>
		/// <param name="media">Media instance</param>
		/// <returns>Media URL</returns>
		public string GetMediaUrl(Media media)
		{
			return GetMediaUrl(media, 0);
		}

		/// <summary>
		/// Get a media URL
		/// </summary>
		/// <param name="imageId">Media identifier</param>
		/// <param name="targetSize">The target media size (longest side)</param>
		/// <returns>Media URL</returns>
		public string GetMediaUrl(int imageId, int targetSize)
		{
			var media = GetMediaById(imageId);
			return GetMediaUrl(media, targetSize);
		}

		/// <summary>
		/// Get a media URL
		/// </summary>
		/// <param name="media">Media instance</param>
		/// <param name="targetSize">The target media size (longest side)</param>
		/// <returns>Media URL</returns>
		public string GetMediaUrl(Media media, int targetSize)
		{
			return GetMediaUrl(media, targetSize, true);
		}

		/// <summary>
		/// Get a media URL
		/// </summary>
		/// <param name="imageId">Media identifier</param>
		/// <param name="targetSize">The target media size (longest side)</param>
		/// <param name="showDefaultMedia">A value indicating whether the default media is shown</param>
		/// <returns></returns>
		public string GetMediaUrl(int imageId, int targetSize,
			bool showDefaultMedia)
		{
			var media = GetMediaById(imageId);
			return GetMediaUrl(media, targetSize, showDefaultMedia);
		}

		/// <summary>
		/// Gets all media urls as a string array
		/// </summary>
		/// <param name="mediaId">Id of media</param>
		/// <returns>Array containing urls for a media in all sizes avaliable</returns>
		public List<String> GetMediaUrls(int mediaId)
		{
			string filter = string.Format("*{0}*.*", mediaId.ToString("0000000"));

			List<String> urls = new List<string>();

			string orginalUrl = GetMediaUrl(mediaId);

			string[] currentFiles = System.IO.Directory.GetFiles(this.LocalThumbImagePath, filter);

			foreach (string currentFileName in currentFiles)
			{
				string url = ZuluHelper.ApplicationPath + "images/thumbs/" + Path.GetFileName(currentFileName);

				if (url != orginalUrl)
					urls.Add(url);
			}

			//add original media to array
			urls.Add(orginalUrl);

			if (urls.Count > 0)
			{
				//reverse sort order (this way the biggest media usally comes first..)
				urls.Reverse();
			}

			return urls;
		}

		/// <summary>
		/// Get a media URL
		/// </summary>
		/// <param name="media">Media instance</param>
		/// <param name="targetSize">The target media size (longest side)</param>
		/// <param name="showDefaultMedia">A value indicating whether the default media is shown</param>
		/// <returns></returns>
		public string GetMediaUrl(Media media, int targetSize,
			bool showDefaultMedia)
		{
			string url = string.Empty;
			if (media == null || media.LoadMediaBinary().Length == 0)
			{
				if (showDefaultMedia)
				{
					url = GetDefaultMediaUrl(targetSize);
				}
				return url;
			}

			string[] parts = media.MimeType.Split('/');
			string lastPart = parts[parts.Length - 1];
			switch (lastPart)
			{
				case "pjpeg":
					lastPart = "jpg";
					break;
				case "x-png":
					lastPart = "png";
					break;
				case "x-icon":
					lastPart = "ico";
					break;
			}

			string localFilename = string.Empty;
			if ( (bool) media.IsNew)
			{
				string filter = string.Format("{0}*.*", media.MediaID.ToString("0000000"));
				string[] currentFiles = System.IO.Directory.GetFiles(this.LocalThumbImagePath, filter);
				foreach (string currentFileName in currentFiles)
					File.Delete(Path.Combine(this.LocalThumbImagePath, currentFileName));

				media = UpdateMedia(media.MediaID, media.LoadMediaBinary(), media.MimeType, false);
			}
			lock (s_lock)
			{
				if (targetSize == 0)
				{
					localFilename = string.Format("{0}.{1}", media.MediaID.ToString("0000000"), lastPart);
					if (!File.Exists(Path.Combine(this.LocalThumbImagePath, localFilename)))
					{
						if (!System.IO.Directory.Exists(this.LocalThumbImagePath))
						{
							System.IO.Directory.CreateDirectory(this.LocalThumbImagePath);
						}
						File.WriteAllBytes(Path.Combine(this.LocalThumbImagePath, localFilename), media.LoadMediaBinary());
					}
				}
				else
				{
					localFilename = string.Format("{0}_{1}.{2}", media.MediaID.ToString("0000000"), targetSize, lastPart);
					if (!File.Exists(Path.Combine(this.LocalThumbImagePath, localFilename)))
					{
						if (!System.IO.Directory.Exists(this.LocalThumbImagePath))
						{
							System.IO.Directory.CreateDirectory(this.LocalThumbImagePath);
						}
						using (MemoryStream stream = new MemoryStream(media.LoadMediaBinary()))
						{
							var b = new Bitmap(stream);

							var newSize = CalculateDimensions(b.Size, targetSize);

							if (newSize.Width < 1)
								newSize.Width = 1;
							if (newSize.Height < 1)
								newSize.Height = 1;

							var newBitMap = new Bitmap(newSize.Width, newSize.Height);
							var g = Graphics.FromImage(newBitMap);
							g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
							g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
							g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
							g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
							g.DrawImage(b, 0, 0, newSize.Width, newSize.Height);
							var ep = new EncoderParameters();
							ep.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, this.ImageQuality);
							ImageCodecInfo ici = GetImageCodecInfoFromExtension(lastPart);
							if (ici == null)
								ici = GetImageCodecInfoFromMimeType("image/jpeg");
							newBitMap.Save(Path.Combine(this.LocalThumbImagePath, localFilename), ici, ep);
							newBitMap.Dispose();
							b.Dispose();
						}
					}
				}
			}
			url = ZuluHelper.ApplicationPath + @"images\thumbs\" + localFilename;
			return url;
		}

		/// <summary>
		/// Get a media local path
		/// </summary>
		/// <param name="media">Media instance</param>
		/// <param name="targetSize">The target media size (longest side)</param>
		/// <param name="showDefaultMedia">A value indicating whether the default media is shown</param>
		/// <returns></returns>
		public string GetMediaLocalPath(Media media, int targetSize, bool showDefaultMedia)
		{
			string url = GetMediaUrl(media, targetSize, showDefaultMedia);
			if (String.IsNullOrEmpty(url))
			{
				return String.Empty;
			}
			else
			{
				return Path.Combine(this.LocalThumbImagePath, Path.GetFileName(url));
			}
		}

		/// <summary>
		/// Gets a media
		/// </summary>
		/// <param name="mediaId">Media identifier</param>
		/// <returns>Media</returns>
		public Media GetMediaById(int mediaId)
		{
			if (mediaId == 0)
				return null;


			var query = from p in _context.Media
						where p.MediaID == mediaId
						select p;
			var media = query.SingleOrDefault();

			return media;
		}

		/// <summary>
		/// Deletes a media
		/// </summary>
		/// <param name="mediaId">Media identifier</param>
		public void DeleteMedia(int mediaId)
		{
			var media = GetMediaById(mediaId);
			if (media == null)
				return;

			//delete thumbs
			string filter = string.Format("{0}*.*", mediaId.ToString("0000000"));
			string[] currentFiles = System.IO.Directory.GetFiles(this.LocalThumbImagePath, filter);
			foreach (string currentFileName in currentFiles)
				File.Delete(Path.Combine(this.LocalThumbImagePath, currentFileName));

			//delete from file system

			DeleteMediaOnFileSystem(media);


			//delete from database

			if (!_context.IsAttached(media))
				_context.Media.Attach(media);
			_context.DeleteObject(media);
			_context.SaveChanges();
		}

		/// <summary>
		/// Updates the picture
		/// </summary>
		/// <param name="imageLocation">The phisical path location of Image</param>
		/// <param name="width">The width of the Image.</param>
		/// <param name="height">The height of the Image</param>
		/// <param name="imageBinary">The Image binary to save in the database.</param>
		/// <returns>Bigmap Image</returns>
		public Bitmap LoadImage(string imageLocation, int size, out byte[] imageBinary)
		{
			Bitmap bitmap = new Bitmap(imageLocation);
			var newSize = CalculateDimensions(bitmap.Size, size);

			if (newSize.Width < 1)
				newSize.Width = 1;
			if (newSize.Height < 1)
				newSize.Height = 1;
			
			Image originalImage = bitmap;
			Bitmap tempBmp = new Bitmap(newSize.Width, newSize.Height);
			Graphics g = Graphics.FromImage(tempBmp);
			g.DrawImage(originalImage, 0, 0, newSize.Width, newSize.Height);
			g.Dispose();
			
			using (MemoryStream ms = new MemoryStream())
			{
				originalImage.Save(ms, ImageFormat.Jpeg);
				imageBinary = ms.ToArray();
			}

			originalImage.Dispose();

			return tempBmp;
		}

		/// <summary>
		/// Validates input media dimensions
		/// </summary>
		/// <param name="mediaBinary">Media binary</param>
		/// <param name="mimeType">MIME type</param>
		/// <returns>Media binary or throws an exception</returns>
		public byte[] ValidateMedia(byte[] mediaBinary, string mimeType)
		{
			using (MemoryStream stream = new MemoryStream(mediaBinary))
			{
				var b = new Bitmap(stream);
				int maxSize = IoC.Resolve<ISettingService>().GetSettingValueInteger("Media.MaximumImageSize", 1280);

				if ((b.Height > maxSize) || (b.Width > maxSize))
				{
					var newSize = CalculateDimensions(b.Size, maxSize);
					var newBitMap = new Bitmap(newSize.Width, newSize.Height);
					var g = Graphics.FromImage(newBitMap);
					g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
					g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
					g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
					g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
					g.DrawImage(b, 0, 0, newSize.Width, newSize.Height);

					var m = new MemoryStream();
					var ep = new EncoderParameters();
					ep.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, this.ImageQuality);
					ImageCodecInfo ici = GetImageCodecInfoFromMimeType(mimeType);
					if (ici == null)
						ici = GetImageCodecInfoFromMimeType("image/jpeg");
					newBitMap.Save(m, ici, ep);
					newBitMap.Dispose();
					b.Dispose();

					return m.GetBuffer();
				}
				else
				{
					b.Dispose();
					return mediaBinary;
				}
			}
		}

		/// <summary>
		/// Updates the media
		/// </summary>
		/// <param name="pictureId">The picture identifier</param>
		/// <param name="pictureBinary">The picture binary</param>
		/// <param name="mimeType">The picture MIME type</param>
		/// <param name="isNew">A value indicating whether the picture is new</param>
		/// <returns>Media</returns>
		public Media UpdateMedia(int pictureId, byte[] pictureBinary, string mimeType, bool isNew)
		{
			ValidateMedia(pictureBinary, mimeType);

			var picture = GetMediaById(pictureId);
			if (picture == null)
				return null;


			if (!_context.IsAttached(picture))
				_context.Media.Attach(picture);

			picture.PictureBinary = pictureBinary;
			picture.MimeType = mimeType;
			picture.IsNew = isNew;
			_context.SaveChanges();

			return picture;
		}

		#endregion
		
		#region Properties
		/// <summary>
		/// Gets an image quality
		/// </summary>
		public long ImageQuality
		{
			get
			{
				return 100L;
			}
		}

		/// <summary>
		/// Gets a local thumb image path
		/// </summary>
		public string LocalThumbImagePath
		{
			get
			{
				string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "images\\thumbs";
				return path;
			}
		}

		/// <summary>
		/// Gets the local image path
		/// </summary>
		public string LocalImagePath
		{
			get
			{
				string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "images";
				return path;
			}
		}
		#endregion



		public List<Media> GetMediasByProductId(int productId)
		{
			throw new NotImplementedException();
		}

		public List<Media> GetMediasByProductId(int productId, int recordsToReturn)
		{
			throw new NotImplementedException();
		}

		public Media InsertMedia(byte[] pictureBinary, string mimeType, bool isNew)
		{
			mimeType = ZuluHelper.EnsureNotNull(mimeType);
			mimeType = ZuluHelper.EnsureMaximumLength(mimeType, 20);
			//pictureBinary = ValidateMedia(pictureBinary, mimeType);

			var media = _context.Media.CreateObject();

			media.PictureBinary = pictureBinary;
			media.MimeType = mimeType;
			media.IsNew = isNew;

			_context.Media.AddObject(media);
			_context.SaveChanges();
			
			return media;
		}


	}
}
