using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;
using Zulu.BusinessService.Util;

namespace Zulu.BusinessService.BulkProductImport
{
	public class InvoiceProductImporter
	{

		public static void StartImport()
		{
			CsvFileDescription inputFileDescription = new CsvFileDescription
			{
				SeparatorChar = ',',
				FirstLineHasColumnNames = true
			};

			CsvContext cc = new CsvContext();

			StreamReader srInvoiceProduct = new StreamReader(ZuluHelper.ApplicationPath + "Book1.csv");
			//List<RunningCost> runningCosts = new List<RunningCost>();

			IEnumerable<InvoiceProduct> invoiceProducts = cc.Read<InvoiceProduct>(srInvoiceProduct, inputFileDescription);

			var allRunningCosts = (from p in invoiceProducts
								   select p).ToList();

			//using (FnDataContext db = new FnDataContext())
			//{
			//	db.ExecuteCommand(string.Format(backupTable, System.DateTime.Now.ToShortDateString().Replace("/", "") + System.DateTime.Now.ToShortTimeString().Replace("/", "").Replace(":", "").Replace(".", "")));
			//	db.ExecuteCommand("DELETE FROM FleetNews_RunningCosts");
			//	db.ExecuteCommand("DBCC CHECKIDENT (FleetNews_RunningCosts, RESEED, 0)");
			//}

			////int count = productsByName.Count;
			//int i = 0;

			//foreach (var item in allRunningCosts)
			//{
			//	try
			//	{
			//		RunningCost runningCost = new RunningCost
			//		{
			//			Months = ConvertStringToInt(item.Month),
			//			Miles = ConvertStringToInt(item.Miles),
			//			CAPId = ConvertStringToInt(item.CAPId),
			//			Manufacture = item.Supplier,
			//			Model = item.Model,
			//			Derivative = item.Derivative.Replace("?", "€"),
			//			MilesPerAnnum = ConvertStringToInt(item.MilesPerAnnum),
			//			OperatingCycle = ConvertStringToInt(item.OperatingCycle),
			//			GraduateVED = ConvertStringToInt(item.GraduatedVED),
			//			DEP_PPM = ConvertStringToDecimal(item.DepPPM),
			//			SMR_PPM = ConvertStringToDecimal(item.SMRPPM),
			//			Fuel_PPM = ConvertStringToDecimal(item.FuelPPM),
			//			PPM = ConvertStringToDecimal(item.PPM),
			//			MonitorRV = ConvertStringToInt(item.MonitorRV),
			//			BIKPrice = ConvertStringToInt(item.BIKPrice),
			//			CO2 = ConvertStringToInt(item.CO2),
			//			BIKPercentage = ConvertStringToPercentage(item.BIKPercentage),
			//			InsuranceGroup = ConvertStringToInt(item.InsuranceGroup),
			//			CombinedMPG = ConvertStringToDecimal(item.CombinedMPG),
			//			CC = ConvertStringToInt(item.CC),
			//			FuelType = FuelTypeConverter(item.FuelType),
			//			StandardVED = ConvertStringToInt(item.standardVED),
			//			WarrantyMonths = ConvertStringToInt(item.WarrantyMonths),
			//			WarrantyMilage = ConvertStringToWarrantyMilage(item.WarrantyMilage),
			//			NCAPAdult = ConvertStringToInt(item.NCAPAdult),
			//			NCAPChild = ConvertStringToInt(item.NCAPChild),
			//			NCAPOverAll = ConvertStringToInt(item.NCAPOverall),
			//			NCAPPedstrian = ConvertStringToInt(item.NCAPPedestrian),
			//			NCAPSafety = ConvertStringToInt(item.NCAPSafety)
			//		};
			//		i++;
			//		runningCosts.Add(runningCost);
			//	}

			//	catch (Exception ex)
			//	{
			//		string test = ex.ToString();
			//		int testcount = i;
			//	}


			//}

			//CarRunningCostManager.DestoryAndReloadSerializedObject(runningCosts);

			//using (var db = new FnDataContext())
			//{
			//	db.RunningCosts.InsertAllOnSubmit(runningCosts);
			//	db.SubmitChanges();
			//}

			//return "Operation Successful " + i + " Records have been added";
		}
	}
}
