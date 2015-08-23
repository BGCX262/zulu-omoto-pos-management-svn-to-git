using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Products;

namespace Zulu.BusinessService.Data
{
	/// <summary>
	/// Represents a product variant
	/// </summary>
	public partial class ProductVariant
	{
		#region Custom Properties

		/// <summary>
		/// List of all products by the product
		/// </summary>
		public Product Product
		{
			get
			{
				int productID = 0;
				int.TryParse(this.ProductID.ToString(), out productID);

				if (productID == 0)
					return null;

				return IoC.Resolve<IProductService>().GetProductByID(productID);
			}
		}

		/// <summary>
		/// List of all suppliers by the product
		/// </summary>
		public Supplier Supplier
		{
			get
			{
				int supplierID = 0;
				int.TryParse(this.SupplierID.ToString(), out supplierID);

				if (supplierID == 0)
					return null;

				return IoC.Resolve<IProductService>().GetSupplierByID(supplierID);
			}
		}

		/// <summary>
		/// Product Name Custom Properties
		/// </summary>
		public string ProductName
		{
 		  get
			{
				return Product.Name;
			}
		}

		/// <summary>
		/// Product Name Custom Properties
		/// </summary>
		public string SupplierName
		{
			get
			{
				return Supplier.Name;
			}
		}

		/// <summary>
		/// Product Name Custom Properties
		/// </summary>
		public Category Category
		{
			get
			{
				return Product.Category;
			}
		}
		#endregion
	}
}
