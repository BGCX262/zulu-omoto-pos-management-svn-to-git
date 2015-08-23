using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.OrdersPurchases
{
	public partial class PurchaseService : IPurchaseService
	{
		#region Fields

		/// <summary>
		/// Object context
		/// </summary>
		private readonly ZuluDataContext _context;

		#endregion

		#region Ctor

		/// <summary>
		/// Ctor
		/// </summary>
		/// <param name="context">Object context</param>
		public PurchaseService(ZuluDataContext context)
		{
			this._context = context;
		}

		public PurchaseService()
		{

		}
		#endregion

		#region Purchase

		/// <summary>
		/// Get purchase By purchase Identifier.
		/// </summary>
		/// <param name="purchaseID">The purchase identifier</param>
		/// <returns>Purchase</returns>
		public Purchase GetPurchaseByID(int purchaseID)
		{
			return _context.Purchases.FirstOrDefault(c => c.PurchaseID == purchaseID);
		}

		/// <summary>
		/// Get All Purchases from the database
		/// </summary>
		/// <returns>List of Purchases</returns>
		public List<Purchase> GetAllPurchases()
		{
			return _context.Purchases.ToList();
		}

		/// <summary>
		/// Get All Purchases from the database	using startDate and endDate
		/// </summary>
		/// <returns>List of Purchases</returns>
		public List<Purchase> GetAllPurchases(DateTime startDate, DateTime endDate)
		{
			return _context.Purchases.Where(c => c.CreatedOn > startDate && c.CreatedOn < endDate).ToList();
		}

		/// <summary>
		/// Save Purchase use for both Insert and Update 
		/// </summary>
		/// <param name="purchase">The purchase.</param>
		public void SavePurchase(Purchase purchase)
		{
			Purchase existingData = GetPurchaseByID(purchase.PurchaseID);


			if (existingData == null)
			{
				purchase.CreatedOn = DateTime.Now;
				_context.Purchases.AddObject(purchase);
			}
			else
			{
				existingData.VoucherNumber = purchase.VoucherNumber;
				existingData.Remark = purchase.Remark;
				existingData.ImportLicenseNumber = purchase.ImportLicenseNumber;
				existingData.CustomDutyAmount = purchase.CustomDutyAmount;
				existingData.CommercialTaxAmunt = purchase.CommercialTaxAmunt;
				existingData.AgentFees = purchase.AgentFees;
				existingData.OtherTax = purchase.OtherTax;
				existingData.CustomReleaseDate = purchase.CustomReleaseDate;

				if (!_context.IsAttached(existingData))
					_context.Purchases.Attach(existingData);
			}
			_context.SaveChanges();
		}

		#endregion

		#region Purchase Product Variant

		/// <summary>
		/// Get purchase product variant by purchase product variant identifier 
		/// </summary>
		/// <param name="purchaseProductVariantID">The purchase product variant identifier</param>
		/// <returns>PurchaseProductVariant</returns>
		public PurchaseProductVariant GetPurchaseProductVariantByID(int purchaseProductVariantID)
		{
			return _context.PurchaseProductVariants.FirstOrDefault(c => c.PurchaseProductVariantID == purchaseProductVariantID);
		}

		/// <summary>
		/// Get All Purchase Product Variants
		/// </summary>
		/// <returns>List of PurchaseProductVariants</returns>
		public List<PurchaseProductVariant> GetAllPurchaseProductVariants()
		{
			return _context.PurchaseProductVariants.ToList();
		}

		/// <summary>
		/// Get purchase product variant by purchase identifier
		/// </summary>
		/// <returns>PurchaseProductVariant</returns>
		public List<PurchaseProductVariant> GetAllPurchaseProductVariants(int purchaseID)
		{
			return _context.PurchaseProductVariants.Where(c => c.PurchaseID == purchaseID).ToList();
		}

		/// <summary>
		/// Save Purchase use for both Insert and Update 
		/// </summary>
		/// <param name="purchase">The purchase.</param>
		public void SavePurchaseProductVariant(PurchaseProductVariant purchaseProductVariant)
		{
			PurchaseProductVariant existingData = GetPurchaseProductVariantByID(purchaseProductVariant.PurchaseProductVariantID);


			if (existingData == null)
			{
				_context.PurchaseProductVariants.AddObject(purchaseProductVariant);
			}
			else
			{
				existingData.PurchaseID = purchaseProductVariant.PurchaseID;
				existingData.PurchasedProductVariantBarcode = purchaseProductVariant.PurchasedProductVariantBarcode;
				existingData.ProductVariantName = purchaseProductVariant.ProductVariantName;
				existingData.Quantity = purchaseProductVariant.Quantity;

				if (!_context.IsAttached(existingData))
					_context.PurchaseProductVariants.Attach(existingData);
			}
			_context.SaveChanges();
		}


		#endregion

	}
}
