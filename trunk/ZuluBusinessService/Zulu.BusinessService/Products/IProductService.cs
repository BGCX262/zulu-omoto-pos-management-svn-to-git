using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.Products
{
	/// <summary>
	/// Product Service Interface
	/// </summary>
	public partial interface IProductService
	{
		#region ProductVariant

		/// <summary>
		/// Get Product Variant By ID. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		/// <returns>ProductVariant</returns>
		ProductVariant GetProductVariantByID(int productVariantID);

		/// <summary>
		/// Get Product Variant By barcode. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		/// <returns>ProductVariant</returns>
		ProductVariant GetProductVariantByBarCode(string barCode);

 		/// <summary>
		/// Get Product Variant By ProductID. 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		/// <returns>ProductVariants</returns>
		List<ProductVariant> GetProductVariantsByProductID(int productID);

		/// <summary>
		/// Get all product variants 
		/// </summary>
		/// <returns>ProductVariants</returns>
		List<ProductVariant> GetAllProductVariants();

		/// <summary>
		/// Save Product Variant use for both Insert and Update 
		/// </summary>
		/// <param name="productVariant">The product variant</param>>
		void SaveProductVariant(ProductVariant productVariant);

		/// <summary>
		/// Delete Product Variant By ProductID. 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		void DeleteProductVariant(int productVariantID);

		/// <summary>
		/// Delete Product Variant By Product ID. 
		/// </summary>
		/// <param name="productID">The product identifier</param>
		void DeactivateProductVariant(int productVariantID);

		/// <summary>
		/// Activate (IsActive = false) Product Variants By Product ID. 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		void ActivateProductVariantByProductID(int productID);

		/// <summary>
		/// Deactivate Product Variant By Product Variant ID. 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		void DeleteProductVariantsByProductID(int productID);

		/// <summary>
		/// Deactivate (IsActive = false) Product Variants By Product ID. 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		void DeactivateProductVariantByProductID(int productID);

		/// <summary>
		/// Get the products variant by supplier identifier. 
		/// </summary>
		/// <param name="SupplierID">The supplier identifier</param>
		/// <returns>ProductVariants</returns>
		List<ProductVariant> GetProductVariantsBySupplier(int supplierID);

		#endregion

		#region Product

		/// <summary>
		/// Get Product By ID. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="productID">The product identifier</param>
		/// <returns>Product</returns>
		Product GetProductByID(int productID);

		/// <summary>
		/// Get All product from the database
		/// </summary>
		/// <returns>Products</returns>
		List<Product> GetAllProducts();

		/// <summary>
		/// Get All products from the database with limited amount
		/// </summary>
		/// <param name="rowIndex">Start row.</param>
		/// <param name="rowSize">How many rows.</param>
		/// <returns>Products</returns>
		List<Product> GetAllProducts(int rowIndex, int rowSize);

		/// <summary>
		/// Save Products use for both Insert and Update 
		/// </summary>
		/// <param name="productVariant">The product variant</param>
		void SaveProduct(Product product);

		/// <summary>
		/// Delete product by ID
		/// </summary>
		/// <param name="productID">The product identifier</param>
		void DeleteProduct(int productID);

		/// <summary>
		/// Deactivate Deactivate (IsActive = false) Product By Product ID. 
		/// </summary>
		/// <param name="productID">The product identifier</param>
		void DeactivateProduct(int productID);

		/// <summary>
		/// Activate Deactivate (IsActive = true) Product By Product ID. 
		/// </summary>
		/// <param name="productID">The product identifier</param>
		void ActivateProduct(int productID);

		///// <summary>
		///// Activate (IsActive = true) Product Variants By Product ID. 
		///// </summary>
		///// <param name="productVariantID">The product variant identifier</param>
		//void ActivateProductVariantByProductID(int productID);

		/// <summary>
		/// Get the products by Category Identifier. 
		/// </summary>
		/// <param name="CategoryID">The category identifier</param>
		/// <returns>Products</returns>
		List<Product> GetProductsByCategoryID(int categoryID);

		#endregion

		#region Category

		/// <summary>
		/// Get Category By ID. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="categoryID">The category identifier</param>
		/// <returns>Category</returns>
		Category GetCategoryByID(int categoryID);

		/// <summary>
		/// Get Category By category Name.
		/// </summary>
		/// <param name="categoryName">The category name</param>
		/// <returns>Category</returns>
		Category GetCategoryByName(string categoryName);

		/// <summary>
		/// Get All Categories from the database
		/// </summary>
		/// <returns>Categories</returns>
		List<Category> GetAllCategories();

		/// <summary>
		/// Get All Categories from the database
		/// </summary>
		/// <param name="isActive">Is Active</param>
		/// <returns>Categories</returns>
		List<Category> GetAllCategories(bool isActive);

		/// <summary>
		/// Save Category use for both Insert and Update 
		/// </summary>
		/// <param name="Category">The category</param>
		bool SaveCategory(Category category);

		/// <summary>
		/// Delete Category by Category ID 
		/// </summary>
		/// <param name="CategoryID">The Category identifier</param>
		void DeleteCategory(int categoryID);

		/// <summary>
		/// Deactivate (IsActive = false) Category by Category ID 
		/// </summary>
		/// <param name="CategoryID">The Category identifier</param>
		void DeactivateCategory(int categoryID);

		/// <summary>
		/// Activate (IsActive = true) Category by Category ID 
		/// </summary>
		/// <param name="CategoryID">The Category identifier</param>
		void ActivateCategory(int categoryID);

		#endregion

		#region Supplier

		/// <summary>
		/// Get Supplier By ID. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="supplierID">The supplier identifier</param>
		/// <returns>Supplier</returns>
		Supplier GetSupplierByID(int supplierID);

		/// <summary>
		/// Get Supplier By name. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="supplierName">The supplier name</param>
		/// <returns>Supplier</returns>
		Supplier GetSupplierByName(string supplierName);

		/// <summary>
		/// Get All suppliers from the database
		/// </summary>
		/// <returns>Suppliers</returns>
		List<Supplier> GetAllSuppliers();

		/// <summary>
		/// Save Suppliers use for both Insert and Update 
		/// </summary>
		/// <param name="Supplier">The supplier.</param>
		bool SaveSupplier(Supplier supplier);

		/// <summary>
		/// Delete supplier by ID
		/// </summary>
		/// <param name="supplierID">The supplier identifier</param>
		void DeleteSupplier(int supplierID);

		#endregion
	}
}
