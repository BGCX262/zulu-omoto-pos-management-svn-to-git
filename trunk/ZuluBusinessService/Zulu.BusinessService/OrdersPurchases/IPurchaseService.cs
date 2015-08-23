using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.OrdersPurchases
{
	public interface IPurchaseService
	{
		#region Purchase
		/// <summary>
		/// Get purchase By purchase Identifier.
		/// </summary>
		/// <param name="purchaseID">The purchase identifier</param>
		/// <returns>Purchase</returns>
		Purchase GetPurchaseByID(int purchaseID);

		/// <summary>
		/// Get All Purchases from the database
		/// </summary>
		/// <returns>List of Purchases</returns>
		List<Purchase> GetAllPurchases();

		/// <summary>
		/// Get All Purchases from the database	using startDate and endDate
		/// </summary>
		/// <returns>List of Purchases</returns>
		List<Purchase> GetAllPurchases(DateTime startDate, DateTime endDate);

	    /// <summary>
		/// Save Purchase use for both Insert and Update 
		/// </summary>
		/// <param name="purchase">The purchase.</param>
		void SavePurchase(Purchase purchase);
		#endregion

		#region Purchase Product Variant

		/// <summary>
		/// Get purchase product variant by purchase product variant identifier 
		/// </summary>
		/// <param name="purchaseProductVariantID">The purchase product variant identifier</param>
		/// <returns>PurchaseProductVariant</returns>
		PurchaseProductVariant GetPurchaseProductVariantByID(int purchaseProductVariantID);

		/// <summary>
		/// Get All Purchase Product Variants
		/// </summary>
		/// <returns>List of PurchaseProductVariants</returns>
		List<PurchaseProductVariant> GetAllPurchaseProductVariants();

		/// <summary>
		/// Get purchase product variant by purchase identifier
		/// </summary>
		/// <returns>PurchaseProductVariant</returns>
		List<PurchaseProductVariant> GetAllPurchaseProductVariants(int purchaseID);

		/// <summary>
		/// Save Purchase use for both Insert and Update 
		/// </summary>
		/// <param name="purchase">The purchase.</param>
		void SavePurchaseProductVariant(PurchaseProductVariant purchaseProductVariant);
		#endregion
	}
}
