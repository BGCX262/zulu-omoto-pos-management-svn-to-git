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
	/// Represents a product
	/// </summary>
	public partial class Product
	{
		#region Custom Properties

		/// <summary>
		/// List of all productvariants by the product
		/// </summary>
		public List<ProductVariant> ProductVariants
		{
			get
			{
				int productID = 0;
				int.TryParse(this.ProductID.ToString(), out productID);

				if (productID == 0)
					return null;

				return IoC.Resolve<IProductService>().GetProductVariantsByProductID(productID);
			}
		}

		/// <summary>
		/// The Categoryname that mapped with the product
		/// </summary>
		public string CategoryName
		{
			get 
			{
				return Category.Name;
			}
		}

		/// <summary>
		/// Collection object of Category
		/// </summary>
		public Category Category
		{
			get
			{
				int categoryID = 0;
				int.TryParse(this.CategoryID.ToString(), out categoryID);

				if (categoryID == 0)
					return null;

				return IoC.Resolve<IProductService>().GetCategoryByID(categoryID);
			}
		}

		#endregion
	}
}
