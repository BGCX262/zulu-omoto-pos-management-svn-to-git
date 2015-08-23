using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zulu.BusinessService.Util
{
	public partial class ZuluHelper
	{
		public static string ApplicationPath
		{
			get 
			{
				return System.AppDomain.CurrentDomain.BaseDirectory.ToString();
			}
		}

		/// <summary>
		/// Ensure that a string is not null
		/// </summary>
		/// <param name="str">Input string</param>
		/// <returns>Result</returns>
		public static string EnsureNotNull(string str)
		{
			if (str == null)
				return string.Empty;

			return str;
		}

		/// <summary>
		/// Ensure that a string doesn't exceed maximum allowed length
		/// </summary>
		/// <param name="str">Input string</param>
		/// <param name="maxLength">Maximum length</param>
		/// <returns>Input string if its lengh is OK; otherwise, truncated input string</returns>
		public static string EnsureMaximumLength(string str, int maxLength)
		{
			if (String.IsNullOrEmpty(str))
				return str;

			if (str.Length > maxLength)
				return str.Substring(0, maxLength);
			else
				return str;
		}

        /// <summary>
        /// Returns the intenger value
        /// </summary>
        public static int GetIntValue(string ChangeString)
        {
            int IntValue = 0;
            int.TryParse(ChangeString, out IntValue);
            return IntValue;        
        }

		/// <summary>
		/// Returns the content type based on the given file extension
		/// </summary>
		public static string GetContentType(string fileExtension)
		{
			var mimeTypes = new Dictionary<String, String>
            {
                {".bmp", "image/bmp"},
                {".gif", "image/gif"},
                {".jpeg", "image/jpeg"},
                {".jpg", "image/jpeg"},
                {".png", "image/png"},
                {".tif", "image/tiff"},
                {".tiff", "image/tiff"},
                {".doc", "application/msword"},
                {".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"},
                {".pdf", "application/pdf"},
                {".ppt", "application/vnd.ms-powerpoint"},
                {".pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".xls", "application/vnd.ms-excel"},
                {".csv", "text/csv"},
                {".xml", "text/xml"},
                {".txt", "text/plain"},
                {".zip", "application/zip"},
                {".ogg", "application/ogg"},
                {".mp3", "audio/mpeg"},
                {".wma", "audio/x-ms-wma"},
                {".wav", "audio/x-wav"},
                {".wmv", "audio/x-ms-wmv"},
                {".swf", "application/x-shockwave-flash"},
                {".avi", "video/avi"},
                {".mp4", "video/mp4"},
                {".mpeg", "video/mpeg"},
                {".mpg", "video/mpeg"},
                {".qt", "video/quicktime"}
            };

			// if the file type is not recognized, return "application/octet-stream" so the browser will simply download it
			return mimeTypes.ContainsKey(fileExtension) ? mimeTypes[fileExtension] : "application/octet-stream";
		}
	}
}
