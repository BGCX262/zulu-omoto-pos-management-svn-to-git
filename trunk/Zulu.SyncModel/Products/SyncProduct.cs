using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zulu.SyncModel.Products
{
	[Serializable()]
	public partial class SyncProduct
	{
		/// <summary>
		/// Gets and Set the property of Sysnc Product Name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets and Set the property of Sysnc Product Description
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets and Set the property of Sysnc Product Unit Name
		/// </summary>
		public string ProductUnitName { get; set; }

		/// <summary>
		/// Gets and Set the property of Sysnc Product Category Name
		/// </summary>
		public string CategoryName { get; set; }

		/// <summary>
		/// Gets and Set the property of Sysnc Product is active or not
		/// </summary>
		public bool IsActive { get; set; }

		/// <summary>
		/// Gets and Set the property of Sysnc Product Created Date
		/// </summary>
		public DateTime CreatedOn { get; set; }

		/// <summary>
		/// Gets and Set the property of Sysnc Product Updated Date
		/// </summary>
		public DateTime UpdatedOn { get; set; }
	}
}
