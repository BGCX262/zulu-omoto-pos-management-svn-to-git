using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Medias;

namespace Zulu.BusinessService.Medias
{
	/// <summary>
	/// Media service interface
	/// </summary>
	public partial interface IMediaService
	{
		/// <summary>
		/// Gets the default picture URL
		/// </summary>
		/// <param name="targetSize">The target picture size (longest side)</param>
		/// <returns></returns>
		string GetDefaultMediaUrl(int targetSize);

		/// <summary>
		/// Gets the default picture URL
		/// </summary>
		/// <param name="defaultMediaType">Default picture type</param>
		/// <param name="targetSize">The target picture size (longest side)</param>
		/// <returns></returns>
		string GetDefaultMediaUrl(PictureTypeEnum defaultMediaType,
			int targetSize);

		/// <summary>
		/// Loads a cpiture from file
		/// </summary>
		/// <param name="pictureId">Media identifier</param>
		/// <param name="mimeType">MIME type</param>
		/// <returns>Media binary</returns>
		byte[] LoadMediaFromFile(int pictureId, string mimeType);

		/// <summary>
		/// Get a picture URL
		/// </summary>
		/// <param name="imageId">Media identifier</param>
		/// <returns>Media URL</returns>
		string GetMediaUrl(int imageId);

		/// <summary>
		/// Get a picture URL
		/// </summary>
		/// <param name="picture">Media instance</param>
		/// <returns>Media URL</returns>
		string GetMediaUrl(Media picture);

		/// <summary>
		/// Get a picture URL
		/// </summary>
		/// <param name="imageId">Media identifier</param>
		/// <param name="targetSize">The target picture size (longest side)</param>
		/// <returns>Media URL</returns>
		string GetMediaUrl(int imageId, int targetSize);

		/// <summary>
		/// Get a picture URL
		/// </summary>
		/// <param name="picture">Media instance</param>
		/// <param name="targetSize">The target picture size (longest side)</param>
		/// <returns>Media URL</returns>
		string GetMediaUrl(Media picture, int targetSize);

		/// <summary>
		/// Get a picture URL
		/// </summary>
		/// <param name="imageId">Media identifier</param>
		/// <param name="targetSize">The target picture size (longest side)</param>
		/// <param name="showDefaultMedia">A value indicating whether the default picture is shown</param>
		/// <returns></returns>
		string GetMediaUrl(int imageId, int targetSize,
			bool showDefaultMedia);

		/// <summary>
		/// Gets all picture urls as a string array
		/// </summary>
		/// <param name="pictureId">Id of picture</param>
		/// <returns>Array containing urls for a picture in all sizes avaliable</returns>
		List<String> GetMediaUrls(int pictureId);

		/// <summary>
		/// Get a picture URL
		/// </summary>
		/// <param name="picture">Media instance</param>
		/// <param name="targetSize">The target picture size (longest side)</param>
		/// <param name="showDefaultMedia">A value indicating whether the default picture is shown</param>
		/// <returns></returns>
		string GetMediaUrl(Media picture, int targetSize,
			bool showDefaultMedia);

		/// <summary>
		/// Get a picture local path
		/// </summary>
		/// <param name="picture">Media instance</param>
		/// <param name="targetSize">The target picture size (longest side)</param>
		/// <param name="showDefaultMedia">A value indicating whether the default picture is shown</param>
		/// <returns></returns>
		string GetMediaLocalPath(Media picture, int targetSize, bool showDefaultMedia);

		/// <summary>
		/// Gets a picture
		/// </summary>
		/// <param name="pictureId">Media identifier</param>
		/// <returns>Media</returns>
		Media GetMediaById(int pictureId);

		/// <summary>
		/// Deletes a picture
		/// </summary>
		/// <param name="pictureId">Media identifier</param>
		void DeleteMedia(int pictureId);

		/// <summary>
		/// Validates input picture dimensions
		/// </summary>
		/// <param name="pictureBinary">Media binary</param>
		/// <param name="mimeType">MIME type</param>
		/// <returns>Media binary or throws an exception</returns>
		byte[] ValidateMedia(byte[] pictureBinary, string mimeType);


		/// <summary>
		/// Inserts a picture
		/// </summary>
		/// <param name="pictureBinary">The picture binary</param>
		/// <param name="mimeType">The picture MIME type</param>
		/// <param name="isNew">A value indicating whether the picture is new</param>
		/// <returns>Media</returns>
		Media InsertMedia(byte[] pictureBinary, string mimeType, bool isNew);

		/// <summary>
		/// Updates the picture
		/// </summary>
		/// <param name="pictureId">The picture identifier</param>
		/// <param name="pictureBinary">The picture binary</param>
		/// <param name="mimeType">The picture MIME type</param>
		/// <param name="isNew">A value indicating whether the picture is new</param>
		/// <returns>Media</returns>
		Media UpdateMedia(int pictureId, byte[] pictureBinary,
			string mimeType, bool isNew);

		/// <summary>
		/// Updates the picture
		/// </summary>
		/// <param name="imageLocation">The phisical path location of Image</param>
		/// <param name="width">The width of the Image.</param>
		/// <param name="height">The height of the Image</param>
		/// <param name="imageBinary">The Image binary to save in the database.</param>
		/// <returns>Bigmap Image</returns>
		Bitmap LoadImage(string imageLocation, int size, out byte[] imageBinary);

	}
}
