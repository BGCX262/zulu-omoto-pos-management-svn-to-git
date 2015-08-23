using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoCross.Utilities.Serialization;
using Zulu.BusinessService.Util;
using MonoCross.Utilities;
using Zulu.SyncModel.Products;
using System.Threading;

namespace Zulu.SyncService
{
	public partial class ZuluSyncContext
	{
		#region Ctor
		/// <summary>
		/// Creates a new instance of the ZuluContext class
		/// </summary>
		public ZuluSyncContext()
		{
		}
		#endregion


		//{
		//	get
		//	{
		//		object data = Thread.GetData(Thread.GetNamedDataSlot("ZuluContext"));
		//		if (data != null)
		//		{
		//			return (ZuluContext)data;
		//		}
		//		ZuluContext context = new ZuluContext();
		//		Thread.SetData(Thread.GetNamedDataSlot("ZuluContext"), context);
		//		return context;

				
		//		List<Product> prods = ProductService.GetAllProducts();
				

		//		// create a product serializer. Serializer defaults to XML.
				

		//		// Serialize object to a file, using Specific Encryption settings.
		//		serializer.SerializeObjectToFile(prods, fileEnc, key, salt);
		//		// deserialize the file into a product, using Specific Encryption settings.
		//		var prod1 = serializer.DeserializeObjectFromFile(fileEnc, key, salt);

		//	}
		//	set 
		//	{
		//		string key = SyncKey;
		//		byte[] salt = Convert.FromBase64String(SyncSalt);

		//		string fileLocation = ZuluHelper.ApplicationPath + "SerializeSpecificEncryption.xml";

		//		List<SyncProduct> prods = new List<SyncProduct>();

		//		ISerializer<ZuluSyncContext> serializer = SerializerFactory.Create<ZuluSyncContext>();
		//		serializer.SerializeObjectToFile(this, fileLocation, key, salt);
		//	}
		//}


		#region Properties

		/// <summary>
		/// Get and set the properties of Sync Product
		/// </summary>
		public List<SyncProduct> SyncProducts{get;set;}
		#endregion
	}
}
