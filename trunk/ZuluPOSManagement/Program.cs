using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zulu.BusinessService;
using Zulu.BusinessService.Configuration;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Infrastructure;
using ZuluPOSManagement.Main;
using ZuluPOSManagement.Users;

namespace ZuluPOSManagement
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			ZuluConfig.Init();
			IoC.InitializeWith(new DependencyResolverFactory());

			ZuluContext.Current.ProductVariants = new List<ProductVariant>();
			ZuluContext.Current.Products = new List<Product>();
			ZuluContext.Current.Categories = new List<Category>();
			ZuluContext.Current.Suppliers = new List<Supplier>();


			Application.Run(new Form1());
		}
	}
}
