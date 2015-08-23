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
	/// Represents a category
	/// </summary>
	public partial class Category
	{
		#region Custom Properties

		/// <summary>
		/// List of products mapped by the category
		/// </summary>
		public List<Product> Products
		{
			get
			{
				int categoryID = 0;
				int.TryParse(this.CategoryID.ToString(), out categoryID);

				if (categoryID == 0)
					return null;

				return IoC.Resolve<IProductService>().GetProductsByCategoryID(categoryID);	
			}
		}

		#endregion
	}
}
