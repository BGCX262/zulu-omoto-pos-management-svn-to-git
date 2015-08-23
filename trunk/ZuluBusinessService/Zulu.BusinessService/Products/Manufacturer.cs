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
	/// Represents a supplier
	/// </summary>
	public partial class Supplier
	{
		#region Custom Properties

		/// <summary>
		/// List of product variants by the supplier
		/// </summary>
		public List<ProductVariant> Suppliers
		{
			get
			{
				int supplierID = 0;
				int.TryParse(this.SupplierID.ToString(), out supplierID);

				if (supplierID == 0)
					return null;

				return IoC.Resolve<IProductService>().GetProductVariantsBySupplier(supplierID);
			}
		}

		#endregion
	}
}
