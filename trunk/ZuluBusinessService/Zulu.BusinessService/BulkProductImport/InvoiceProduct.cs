using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace Zulu.BusinessService.BulkProductImport
{
	public class InvoiceProduct
	{
		[CsvColumn(Name = "Qtys", FieldIndex = 0)]
		public string Quantities { get; set; }

		[CsvColumn(Name = "ItemCode", FieldIndex = 1)]
		public string BarCode { get; set; }

		[CsvColumn(Name = "Descriptionofgoods", FieldIndex = 2)]
		public string ProductFullName { get; set; }

		[CsvColumn(Name = "UnitPrice", FieldIndex = 3)]
		public string UnitPrice { get; set; }

		[CsvColumn(Name = "Amount", FieldIndex = 4)]
		public string Amount { get; set; }

		[CsvColumn(Name = "Origin", FieldIndex = 5)]
		public string Origin { get; set; }
	}
}
