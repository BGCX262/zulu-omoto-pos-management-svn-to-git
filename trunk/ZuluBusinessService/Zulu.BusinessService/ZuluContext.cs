using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService
{
	public partial class ZuluContext
	{
		#region Ctor
		/// <summary>
		/// Creates a new instance of the ZuluContext class
		/// </summary>
		private ZuluContext()
		{
		}
		#endregion

		#region Properties
		/// <summary>
		/// Gets an instance of the ZuluContext, which can be used to retrieve information about current context.
		/// </summary>
		public static ZuluContext Current
		{
			get
			{
				object data = Thread.GetData(Thread.GetNamedDataSlot("ZuluContext"));
				if (data != null)
				{
					return (ZuluContext)data;
				}
				ZuluContext context = new ZuluContext();
				Thread.SetData(Thread.GetNamedDataSlot("ZuluContext"), context);
				return context;
			}
		}
		#endregion

		#region Methods

		/// <summary>
		/// Get Product Variant By ID. Firstly 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		/// <returns>ProductVariant</returns>
		public static void ClearCache()
		{
			Thread.SetData(Thread.GetNamedDataSlot("ZuluContext"), null);
		}
		#endregion

		#region Cache Properties

		/// <summary>
		/// Product Varaint Collection Cache Value
		/// </summary>
		public List<ProductVariant> ProductVariants { get; set; }

		/// <summary>
		/// Product Collection Cache Value
		/// </summary>
		public List<Product> Products { get; set; }

		/// <summary>
		/// Category Collection Cache Value
		/// </summary>
		public List<Category> Categories { get; set; }

		/// <summary>
		/// Supplier Collection Cache Value
		/// </summary>
		public List<Supplier> Suppliers { get; set; }

		/// <summary>
		/// Form Control Collection Cache Value
		/// </summary>
		public List<FormControl> FormControls { get; set; }

		/// <summary>
		/// Button Control Collection Cache Value
		/// </summary>
		public List<ButtonControl> ButtonControls { get; set; }

		/// <summary>
		/// Current User Cache Value
		/// </summary>
		public User CurrentUser { get; set; }

		#endregion
	}
}
