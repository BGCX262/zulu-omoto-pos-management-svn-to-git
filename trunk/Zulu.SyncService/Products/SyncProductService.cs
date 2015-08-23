using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoCross.Utilities.Serialization;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Util;
using Zulu.SyncModel.Products;

namespace Zulu.SyncService.Products
{
	public partial class SyncProductService
	{
		public static void MapSyncProduct(List<Product> products, string fileLocation)
		{

			List<SyncProduct> syncProducts = new List<SyncProduct>();

			foreach (var product in products)
			{
				SyncProduct syncProduct = new SyncProduct();

				syncProduct.Name = product.Name;
				syncProduct.Description = product.Description;
				syncProduct.IsActive = (bool) product.IsActive;
				syncProduct.CreatedOn = (DateTime) product.CreatedOn;
				syncProduct.UpdatedOn = (DateTime) product.UpdatedOn;

				syncProducts.Add(syncProduct);
			}

			string key = SyncKey;
			byte[] salt = Convert.FromBase64String(SyncSalt);

			ZuluSyncContext syncContext = new ZuluSyncContext();
			syncContext.SyncProducts = syncProducts;
			
			ISerializer<ZuluSyncContext> serializer = SerializerFactory.Create<ZuluSyncContext>();
			serializer.SerializeObjectToFile(syncContext, fileLocation, key, salt);

			var prod1 = serializer.DeserializeObjectFromFile(fileLocation, key, salt);
		}

		#region Properties
		/// <summary>
		/// Get the Sync Salt from the configuration file
		/// </summary>
		protected static string SyncSalt
		{
			get
			{
				return ConfigurationManager.AppSettings["SyncSalt"];
			}
		}

		/// <summary>
		/// Get the Sync key from the configuration file
		/// </summary>
		protected static string SyncKey
		{
			get
			{
				return ConfigurationManager.AppSettings["SyncKey"];
			}
		}

		#endregion
	}
}
