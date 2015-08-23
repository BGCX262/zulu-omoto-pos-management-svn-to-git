using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Util;
using ZuluPOSManagement.Controls;
using MonoCross.Utilities.Serialization;
using Zulu.BusinessService.BulkProductImport;
using MonoCross.Utilities;
using Zulu.SyncService.Products;
using Zulu.BusinessService;

namespace ZuluPOSManagement
{
	public partial class Form1 : BaseZuluFormControl
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			var product = ProductService.GetProductByID(5);
			ISerializer<Product> serializer;

			//List<Product> products = ProductService.GetAllProducts(0,10);
			//List<SyncProduct> syncProducts = new List<SyncProduct>();

			//foreach (var product in products)
			//{
			//	SyncProduct syncProduct = new SyncProduct();

			//	syncProduct.ProductID = product.ProductID;
			//	syncProduct.ProductName = product.Name;
			//	syncProduct.Description = product.Description;
			//	syncProduct.ProductUnitName = product.ProductUnitName;
			//	syncProduct.CaretoryName = product.CategoryName;
			//	syncProduct.IsActive = (bool)product.IsActive;
			//	syncProduct.CreatedOn = (DateTime)product.CreatedOn;
			//	syncProduct.UpdatedOn = (DateTime)product.UpdatedOn;

			//	syncProducts.Add(syncProduct);
			//}

			//DESCryptoServiceProvider key = new DESCryptoServiceProvider();

			//ZuluSyncService.EncryptAndSerialize(syncProducts, key);
			//var deobj = ZuluSyncService.DecryptAndDeserialize(key);

			//var p = ProductService.GetAllProducts();
			//DataContractSerializer dcs = new DataContractSerializer(typeof(List<Product>));

			//FileStream fs1 = new FileStream(ZuluHelper.ApplicationPath + "test.dat", FileMode.OpenOrCreate);

			//XmlDictionaryWriter xdw = XmlDictionaryWriter.CreateTextWriter(fs1, Encoding.UTF8);
			//dcs.WriteObject(xdw, p);

			//DESCryptoServiceProvider key = new DESCryptoServiceProvider();

			//using (FileStream fs = File.Open(ZuluHelper.ApplicationPath + "test1.dat", FileMode.OpenOrCreate))
			//{
			//	using (CryptoStream cs = new CryptoStream(fs, key.CreateEncryptor(), CryptoStreamMode.Write))
			//	{
			//		XmlSerializer xmlser = new XmlSerializer(typeof(List<Product>));
			//		xmlser.Serialize(cs, p);
			//	}
			//}

			//using (FileStream fs = File.Open(ZuluHelper.ApplicationPath + "test1.dat", FileMode.Open))
			//{
			//	using (CryptoStream cs = new CryptoStream(fs, key.CreateDecryptor(), CryptoStreamMode.Read))
			//	{
			//		XmlSerializer xmlser = new XmlSerializer(typeof(List<Product>));
			//		var Products = (List<Product>)xmlser.Deserialize(cs);

			//		MessageBox.Show(Products.FirstOrDefault().ProductID.ToString());
			//	}
			//}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "XML files (*.xml)|*.xml";
			saveFileDialog.RestoreDirectory = true;

			if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);
				fs.Close();
			}

			SyncProductService.MapSyncProduct(ProductService.GetAllProducts(), saveFileDialog.FileName);


			//string key = "kjWkslr4qw4UT28LAfKJsYIdy9m+/vHry3fYDuydGk2=";
			//byte[] salt = Convert.FromBase64String( "lRG7r+BNLTqVcKq6pTsMfi==" );
			//List<Product> prods = ProductService.GetAllProducts();
			//string fileEnc = ZuluHelper.ApplicationPath + "SerializeSpecificEncryption.xml" ;
			
			//// create a product serializer. Serializer defaults to XML.
			//ISerializer<List<Product>> serializer = SerializerFactory.Create<List<Product>>();
			
			//// Serialize object to a file, using Specific Encryption settings.
			//serializer.SerializeObjectToFile(prods, fileEnc, key, salt);
			//// deserialize the file into a product, using Specific Encryption settings.
			//var prod1 = serializer.DeserializeObjectFromFile(fileEnc, key, salt );





			//int pictureID = 0;
			
			//pictureID = zpcTesting.SavePicture();

			//Category category = new Category();

			//category = ProductService.GetCategoryByID(1);

			//List<Product> products = category.Products;

			//foreach (var product in products)
			//{
			//	List<ProductVariant> productVariants = product.ProductVariants;

			//}
		}
	}
}
