using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoCross.Utilities;
using MonoCross.Utilities.Serialization;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Settings;
using Zulu.BusinessService.Util;

namespace Zulu.BusinessService.Products
{
	public partial class ProductService : IProductService
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
		public ProductService(ZuluDataContext context)
		{
			this._context = context;
		}

		public ProductService()
		{

		}
		#endregion

		#region ProductVariant

		/// <summary>
		/// Get Product Variant By ID. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		/// <returns>ProductVariant</returns>
		public ProductVariant GetProductVariantByID(int productVariantID)
		{
			if (productVariantID == 0)
				return null;

			ProductVariant productVariant = new ProductVariant();
			if (CacheProductVariants != null)
				productVariant = CacheProductVariants.FirstOrDefault(c => c.ProductVariantID == productVariantID);

			if (productVariant == null || productVariant.ProductVariantID == 0)
			{
				productVariant = _context.ProductVariants.FirstOrDefault(c => c.ProductVariantID == productVariantID);
				AddProductVariantToCache(productVariant);
				return productVariant;
			}
			return productVariant;
		}

		/// <summary>
		/// Get Product Variant By barcode. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		/// <returns>ProductVariant</returns>
		public ProductVariant GetProductVariantByBarCode(string barCode)
		{
			if (string.IsNullOrEmpty(barCode))
				return null;

			ProductVariant productVariant = new ProductVariant();
			if (CacheProductVariants != null)
				productVariant = CacheProductVariants.FirstOrDefault(c => c.BarCode == barCode);

			if (productVariant == null || productVariant.ProductVariantID == 0)
			{
				productVariant = _context.ProductVariants.FirstOrDefault(c => c.BarCode == barCode);
				AddProductVariantToCache(productVariant);
				return productVariant;
			}
			return productVariant;
		}

		/// <summary>
		/// Get Product Variant By ProductID. 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		/// <returns>ProductVariants</returns>
		public List<ProductVariant> GetProductVariantsByProductID(int productID)
		{
			if (productID == 0)
				return null;

			List<ProductVariant> productVariants = new List<ProductVariant>();
			productVariants = _context.ProductVariants.Where(c => c.ProductID == productID).ToList();

			AddProductVariantsToCache(productVariants);
		
			return productVariants;
		}

		/// <summary>
		/// Get all product variants 
		/// </summary>
		/// <returns>ProductVariants</returns>
		public List<ProductVariant> GetAllProductVariants()
		{
			List<ProductVariant> productVariants = new List<ProductVariant>();
			productVariants = _context.ProductVariants.ToList();
			
			AddProductVariantsToCache(productVariants);

			return productVariants;
		}

		/// <summary>
		/// Save Product Variant use for both Insert and Update 
		/// </summary>
		/// <param name="productVariant">The product variant</param>
		public void SaveProductVariant(ProductVariant productVariant)
		{
			ProductVariant existingData = GetProductVariantByID(productVariant.ProductVariantID);

			RemoveProductVariantFromTheCache(existingData);

			if (existingData == null)
			{
				productVariant.CreatedOn = DateTime.Now;
				productVariant.UpdatedOn = DateTime.Now;
				_context.ProductVariants.AddObject(productVariant);
			}
  			else
			{
				existingData.ProductID = productVariant.ProductID;
				existingData.Name = productVariant.Name;
				existingData.BarCode = productVariant.BarCode;
				existingData.SupplierID = productVariant.SupplierID;
				existingData.RestrictedUnder18 = productVariant.RestrictedUnder18;
				existingData.PictureID = productVariant.PictureID;
				existingData.CreatedOn = existingData.CreatedOn;
				existingData.UpdatedOn = DateTime.Now;
				existingData.IsActive = productVariant.IsActive;

				if (!_context.IsAttached(existingData))
					_context.ProductVariants.Attach(existingData);
			}
			_context.SaveChanges();

			AddProductVariantToCache(existingData);
		}

		/// <summary>
		/// Delete Product Variant By Product Variant ID. 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		public void DeleteProductVariant(int productVariantID)
		{
			if (productVariantID == 0)
				return;

			ProductVariant productVariant = GetProductVariantByID(productVariantID);
			if (productVariant == null)
				return;

			if (!_context.IsAttached(productVariant))
				_context.ProductVariants.Attach(productVariant);

			_context.DeleteObject(productVariant);
			_context.SaveChanges();
			RemoveProductVariantFromTheCache(productVariant);
		}

		/// <summary>
		/// Deactivate Product Variant By Product Variant ID. 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		public void DeactivateProductVariant(int productVariantID)
		{
			if (productVariantID == 0)
				return;

			ProductVariant productVariant = GetProductVariantByID(productVariantID);
			if (productVariant == null && (bool)!productVariant.IsActive)
				return;

			productVariant.IsActive = false;
			productVariant.UpdatedOn = DateTime.Now;

			SaveProductVariant(productVariant);
		}

		/// <summary>
		/// Activate Product Variant By Product Variant ID. 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		public void ActivateProductVariant(int productVariantID)
		{
			if (productVariantID == 0)
				return;

			ProductVariant productVariant = GetProductVariantByID(productVariantID);
			if (productVariant == null && (bool)productVariant.IsActive)
				return;

			productVariant.IsActive = true;
			productVariant.UpdatedOn = DateTime.Now;

			SaveProductVariant(productVariant);
		}

		/// <summary>
		/// Delete Product Variants By Product ID. 
		/// </summary>
		/// <param name="productID">The product identifier</param>
		public void DeleteProductVariantsByProductID(int productID)
		{
			List<ProductVariant> productVariants = GetProductVariantsByProductID(productID);

			foreach (ProductVariant productVariant in productVariants)
			{
				if (!_context.IsAttached(productVariant))
					_context.ProductVariants.Attach(productVariant);

				_context.DeleteObject(productVariant);
				RemoveProductVariantFromTheCache(productVariant);
			}
			_context.SaveChanges();
		}

		/// <summary>
		/// Deactivate (IsActive = false) Product Variants By Product ID. 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		public void DeactivateProductVariantByProductID(int productID)
		{
			List<ProductVariant> productVariants = GetProductVariantsByProductID(productID);

			foreach (ProductVariant productVariant in productVariants)
			{
				if (productVariant == null && (bool)!productVariant.IsActive)
					return;

				productVariant.IsActive = false;
				productVariant.UpdatedOn = DateTime.Now;

				SaveProductVariant(productVariant);
			}
			_context.SaveChanges();
		}

		/// <summary>
		/// Activate (IsActive = true) Product Variants By Product ID. 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		public void ActivateProductVariantByProductID(int productID)
		{
			List<ProductVariant> productVariants = GetProductVariantsByProductID(productID);

			foreach (ProductVariant productVariant in productVariants)
			{
				if (productVariant == null && (bool)productVariant.IsActive)
					return;

				productVariant.IsActive = true;
				productVariant.UpdatedOn = DateTime.Now;

				SaveProductVariant(productVariant);
			}
			_context.SaveChanges();
		}

		/// <summary>
		/// Get the products variant by supplier identifier. 
		/// </summary>
		/// <param name="SupplierID">The supplier identifier</param>
		/// <returns>ProductVariants</returns>
		public List<ProductVariant> GetProductVariantsBySupplier(int supplierID)
		{
			List<ProductVariant> productVariants = new List<ProductVariant>();
			productVariants = _context.ProductVariants.Where(c => c.SupplierID == supplierID).ToList();

			AddProductVariantsToCache(productVariants);
			return productVariants;
		}

		#endregion

		#region Product

		/// <summary>
		/// Get Product By ID. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="productID">The product identifier</param>
		/// <returns>Product</returns>
		public Product GetProductByID(int productID)
		{
			if (productID == 0)
				return null;

			Product product = new Product();
			if (CacheProducts != null)
				product = CacheProducts.FirstOrDefault(c => c.ProductID == productID);

			if (product == null || product.ProductID == 0)
			{
				product = _context.Products.FirstOrDefault(c => c.ProductID == productID);
				AddProductToCache(product);
				return product;
			}
			return product;
		}

		/// <summary>
		/// Get All products from the database
		/// </summary>
		/// <returns>Products</returns>
		public List<Product> GetAllProducts()
		{
			List<Product> products = new List<Product>();
			products = _context.Products.ToList();

			AddProductsToCache(products);

			return products;
		}

		/// <summary>
		/// Get All products from the database with limited amount
		/// </summary>
		/// <param name="rowIndex">Start row.</param>
		/// <param name="rowSize">How many rows.</param>
		/// <returns>Products</returns>
		public List<Product> GetAllProducts(int rowIndex, int rowSize)
		{
			List<Product> products = new List<Product>();
			products = _context.Products.OrderByDescending(c => c.UpdatedOn).Skip(rowIndex).Take(rowSize).ToList();

			AddProductsToCache(products);

			return products;
		}

		/// <summary>
		/// Save Products use for both Insert and Update 
		/// </summary>
		/// <param name="Product">The product.</param>
		public void SaveProduct(Product product)
		{
			Product existingData = GetProductByID(product.ProductID);

			RemoveProductFromTheCache(existingData);

			if (existingData == null)
			{
				product.CreatedOn = DateTime.Now;
				product.UpdatedOn = DateTime.Now;
				_context.Products.AddObject(product);
			}
			else
			{
				existingData.Name = product.Name;
				existingData.Description = product.Description;
				existingData.IsActive = product.IsActive;
				existingData.CreatedOn = existingData.CreatedOn;
				existingData.UpdatedOn = DateTime.Now;
				

				if (!_context.IsAttached(existingData))
					_context.Products.Attach(existingData);
			}
			_context.SaveChanges();

			AddProductToCache(existingData);
		}

		/// <summary>
		/// Delete product by ID
		/// </summary>
		/// <param name="productID">The product identifier</param>
		public void DeleteProduct(int productID)
		{
			if (productID == 0)
				return;

			Product product = GetProductByID(productID);
			if (product == null)
				return;

			if (!_context.IsAttached(product))
				_context.Products.Attach(product);

			_context.DeleteObject(product);
			_context.SaveChanges();
			RemoveProductFromTheCache(product);
		}

		/// <summary>
		/// Deactivate Deactivate (IsActive = false) Product By Product ID. 
		/// </summary>
		/// <param name="productID">The product identifier</param>
		public void DeactivateProduct(int productID)
		{
			if (productID == 0)
				return;

			DeactivateProductVariantByProductID(productID);

			Product product = GetProductByID(productID);
			if (product == null && (bool)!product.IsActive)
				return;

			product.IsActive = false;
			product.UpdatedOn = DateTime.Now;

			SaveProduct(product);
		}

		/// <summary>
		/// Activate Deactivate (IsActive = true) Product By Product ID. 
		/// </summary>
		/// <param name="productID">The product identifier</param>
		public void ActivateProduct(int productID)
		{
			if (productID == 0)
				return;

			ActivateProductVariantByProductID(productID);

			Product product = GetProductByID(productID);
			if (product == null && (bool)product.IsActive)
				return;

			product.IsActive = true;
			product.UpdatedOn = DateTime.Now;

			SaveProduct(product);
		}

		/// <summary>
		/// Get the products by Category Identifier. 
		/// </summary>
		/// <param name="CategoryID">The category identifier</param>
		/// <returns>Products</returns>
		public List<Product> GetProductsByCategoryID(int categoryID)
		{
			var query = from product in _context.Products
						where product.CategoryID == categoryID
						select product;

			List<Product> products = query.ToList();

			AddProductsToCache(products);
			return products;
		}

		#endregion

		#region Category

		/// <summary>
		/// Get Category By ID. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="categoryID">The category identifier</param>
		/// <returns>Category</returns>
		public Category GetCategoryByID(int categoryID)
		{
			if (categoryID == 0)
				return null;

			Category category = new Category();
			if (CacheCategories != null)
				category = CacheCategories.FirstOrDefault(c => c.CategoryID == categoryID);

			if (category == null || category.CategoryID == 0)
			{
				category = _context.Categories.FirstOrDefault(c => c.CategoryID == categoryID);
				AddCategoryToCache(category);
				return category;
			}
			return category;
		}

		/// <summary>
		/// Get Category By category Name.
		/// </summary>
		/// <param name="categoryName">The category name</param>
		/// <returns>Category</returns>
		public Category GetCategoryByName(string categoryName)
		{
			if (string.IsNullOrEmpty(categoryName))
				return null;

			Category category = new Category();
			if (CacheCategories != null)
				category = CacheCategories.FirstOrDefault(c => c.Name == categoryName);

			if (category == null || category.CategoryID == 0)
			{
				category = _context.Categories.FirstOrDefault(c => c.Name == categoryName);
				AddCategoryToCache(category);
				return category;
			}
			return category;
		}

		/// <summary>
		/// Get All Categories from the database
		/// </summary>
		/// <returns>Categories</returns>
		public List<Category> GetAllCategories()
		{
			List<Category> categories = new List<Category>();
			categories = _context.Categories.ToList();

			AddCategoriesToCache(categories);

			return categories;
		}

		/// <summary>
		/// Get All Categories from the database
		/// </summary>
		/// <param name="isActive">Is Active</param>
		/// <returns>Categories</returns>
		public List<Category> GetAllCategories(bool isActive)
		{
			List<Category> categories = new List<Category>();
			categories = _context.Categories.Where( c=> c.IsActive == isActive).ToList();

			AddCategoriesToCache(categories);

			return categories;
		}

		/// <summary>
		/// Get the Category by Product Identifier. 
		/// </summary>
		/// <param name="productID">The product identifier</param>
		/// <returns>Category</returns>
		public List<Category> GetCategoryByProductID(int productID)
		{
			var query = from category in _context.Categories
						join product in _context.Products on
						category.CategoryID equals product.CategoryID
						where product.ProductID == productID
						select category;

			List<Category> products = query.ToList();

			return products;
		}

		/// <summary>
		/// Save Category use for both Insert and Update 
		/// </summary>
		/// <param name="Category">The category</param>
		public bool SaveCategory(Category category)
		{
			Category existingData = new Category();

			existingData = GetCategoryByName(category.Name);

			if (existingData != null && existingData.CategoryID != category.CategoryID)
			{
				if (existingData.CategoryID != 0)
					return false;
			}
				
			existingData = GetCategoryByID(category.CategoryID);

			RemoveCategoryFromTheCache(existingData);

			if (existingData == null)
			{
				category.CreatedOn = DateTime.Now;
				category.UpdatedOn = DateTime.Now;
				_context.Categories.AddObject(category);
			}
			else
			{
				existingData.Name = category.Name;
				existingData.Description = category.Description;
				existingData.IsActive = category.IsActive;
				existingData.CreatedOn = existingData.CreatedOn;
				existingData.UpdatedOn = DateTime.Now;

				if (!_context.IsAttached(existingData))
					_context.Categories.Attach(existingData);
			}
			_context.SaveChanges();

			AddCategoryToCache(existingData);

			return true;
		}

		/// <summary>
		/// Delete Category by Category ID 
		/// </summary>
		/// <param name="CategoryID">The Category identifier</param>
		public void DeleteCategory(int CategoryID)
		{
			if (CategoryID == 0)
				return;

			Category Category = GetCategoryByID(CategoryID);
			if (Category == null)
				return;

			if (!_context.IsAttached(Category))
				_context.Categories.Attach(Category);

			_context.DeleteObject(Category);
			_context.SaveChanges();
			RemoveCategoryFromTheCache(Category);
		}

		/// <summary>
		/// Deactivate Category by Category ID 
		/// </summary>
		/// <param name="CategoryID">The Category identifier</param>
		public void DeactivateCategory(int categoryID)
		{
			if (categoryID == 0)
				return;

			Category category = GetCategoryByID(categoryID);
			if (category == null && (bool)!category.IsActive)
				return;

			category.IsActive = false;
			category.UpdatedOn = DateTime.Now;

			SaveCategory(category);
		}

		/// <summary>
		/// Activate Category by Category ID 
		/// </summary>
		/// <param name="CategoryID">The Category identifier</param>
		public void ActivateCategory(int categoryID)
		{
			if (categoryID == 0)
				return;

			Category category = GetCategoryByID(categoryID);
				
			if (category == null && (bool)category.IsActive)
				return;

			category.IsActive = true;
			category.UpdatedOn = DateTime.Now;

			SaveCategory(category);
		}

		#endregion

		#region Supplier

		/// <summary>
		/// Get Supplier By ID. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="supplierID">The supplier identifier</param>
		/// <returns>Supplier</returns>
		public Supplier GetSupplierByID(int supplierID)
		{
			if (supplierID == 0)
				return null;

			Supplier supplier = new Supplier();
			if (CacheSuppliers != null)
				supplier = CacheSuppliers.FirstOrDefault(c => c.SupplierID == supplierID);

			if (supplier == null || supplier.SupplierID == 0)
			{
				supplier = _context.Suppliers.FirstOrDefault(c => c.SupplierID == supplierID);
				AddSupplierToCache(supplier);
				return supplier;
			}
			return supplier;
		}

		/// <summary>
		/// Get Supplier By name. Firstly look from the project cache and get from the database 
		/// </summary>
		/// <param name="supplierName">The supplier name</param>
		/// <returns>Supplier</returns>
		public Supplier GetSupplierByName(string supplierName)
		{
			if (string.IsNullOrEmpty(supplierName))
				return null;

			Supplier supplier = new Supplier();
			if (CacheSuppliers != null)
				supplier = CacheSuppliers.FirstOrDefault(c => c.Name == supplierName);

			if (supplier == null || supplier.SupplierID == 0)
			{
				supplier = _context.Suppliers.FirstOrDefault(c => c.Name == supplierName);
				AddSupplierToCache(supplier);
				return supplier;
			}
			return supplier;
		}

		/// <summary>
		/// Get All suppliers from the database
		/// </summary>
		/// <returns>Suppliers</returns>
		public List<Supplier> GetAllSuppliers()
		{
			List<Supplier> suppliers = new List<Supplier>();
			suppliers = _context.Suppliers.ToList();

			AddSuppliersToCache(suppliers);

			return suppliers;
		}

		/// <summary>
		/// Save Suppliers use for both Insert and Update 
		/// </summary>
		/// <param name="Supplier">The supplier.</param>
		public bool SaveSupplier(Supplier supplier)
		{
			Supplier existingData = new Supplier();

			existingData = GetSupplierByName(supplier.Name);

			if (existingData != null && existingData.SupplierID != supplier.SupplierID)
			{
				if (existingData.SupplierID != 0)
					return false;
			}

			existingData = GetSupplierByID(supplier.SupplierID);

			RemoveSupplierFromTheCache(existingData);

			if (existingData == null)
				_context.Suppliers.AddObject(supplier);
			else
			{
				existingData.Name = supplier.Name;
				existingData.Description = supplier.Description;
				existingData.AddressID = supplier.AddressID;

				if (!_context.IsAttached(existingData))
					_context.Suppliers.Attach(existingData);
			}
			_context.SaveChanges();

			AddSupplierToCache(existingData);

			return true;
		}

		/// <summary>
		/// Delete supplier by ID
		/// </summary>
		/// <param name="supplierID">The supplier identifier</param>
		public void DeleteSupplier(int supplierID)
		{
			if (supplierID == 0)
				return;

			Supplier supplier = GetSupplierByID(supplierID);
			if (supplier == null)
				return;

			if (!_context.IsAttached(supplier))
				_context.Suppliers.Attach(supplier);

			_context.DeleteObject(supplier);
			_context.SaveChanges();
			RemoveSupplierFromTheCache(supplier);
		}

		#endregion

		#region Cache

		/// <summary>
		/// Add Product Variants to cache 
		/// </summary>
		/// <param name="productVariant">The Product Variant Object</param>
		private void AddProductVariantsToCache(List<ProductVariant> productVariants)
		{
			foreach (ProductVariant productVariant in productVariants)
			{
				AddProductVariantToCache(productVariant);
			}
		}

		/// <summary>
		/// Add Product Variant to cache 
		/// </summary>
		/// <param name="productVariant">The Product Variant Object</param>
		private void AddProductVariantToCache(ProductVariant productVariant)
		{
			if (productVariant != null)
			{
				List<ProductVariant> productVariants = new List<ProductVariant>();

				if (CacheProductVariants != null && CacheProductVariants.Count > 0)
				{
					productVariants = CacheProductVariants;
					ProductVariant cacheProductVariant = new ProductVariant();
					cacheProductVariant = CacheProductVariants.FirstOrDefault(c => c.ProductVariantID == productVariant.ProductVariantID);
				}

				if (CacheProductVariants != null && CacheProductVariants.Count > 0)
				{
					productVariants.Add(productVariant);
					CacheProductVariants = productVariants;
				}
			}
		}

		/// <summary>
		/// Remove Specific Product Variant from the cache 
		/// </summary>
		/// <param name="productVariant">The Product Variant Object</param>
		private void RemoveProductVariantFromTheCache(ProductVariant productVariant)
		{
			if (productVariant != null)
			{
				ProductVariant cacheProductVariant = new ProductVariant();
				if (CacheProductVariants != null)
					cacheProductVariant = CacheProductVariants.FirstOrDefault(c => c.ProductVariantID == productVariant.ProductVariantID);

				if (cacheProductVariant != null)
				{
					List<ProductVariant> productVariants = new List<ProductVariant>();

					if (CacheProductVariants != null && CacheProductVariants.Count > 0)
						productVariants = CacheProductVariants;

					productVariants.Remove(cacheProductVariant);
					CacheProductVariants = productVariants;
				}
			}
		}

		/// <summary>
		/// Add Product to cache 
		/// </summary>
		/// <param name="product">The Product Object</param>
		private void AddProductsToCache(List<Product> products)
		{
			foreach (Product product in products)
			{
				AddProductToCache(product);
			}
		}

		/// <summary>
		/// Add Product to cache 
		/// </summary>
		/// <param name="product">The Product Object</param>
		private void AddProductToCache(Product product)
		{
			if (CacheEnabled && product != null)
			{
				List<Product> products = new List<Product>();

				if (CacheProducts != null)
					if (CacheProducts.Count > 0)
						products = CacheProducts;

				Product cacheProduct = new Product();
				if (CacheProducts != null)
					cacheProduct = CacheProducts.FirstOrDefault(c => c.ProductID == product.ProductID);

				if (CacheProducts != null && CacheProducts.Count > 0)
				{
					products.Add(product);
					CacheProducts = products;
				}
			}
		}

		/// <summary>
		/// Remove Specific Product  from the cache 
		/// </summary>
		/// <param name="product">The Product  Object</param>
		private void RemoveProductFromTheCache(Product product)
		{
			if (CacheEnabled && product != null)
			{
				Product cacheProduct = new Product();
				if (CacheProducts != null)
					cacheProduct = CacheProducts.FirstOrDefault(c => c.ProductID == product.ProductID);

				if (cacheProduct != null)
				{
					List<Product> products = new List<Product>();

					if (CacheProducts != null && CacheProducts.Count > 0)
						products = CacheProducts;

					products.Remove(cacheProduct);
					CacheProducts = products;
				}
			}
		}

		/// <summary>
		/// Add Category to cache 
		/// </summary>
		/// <param name="Category">The Category Object</param>
		private void AddCategoriesToCache(List<Category> Categories)
		{
			foreach (Category Category in Categories)
			{
				AddCategoryToCache(Category);
			}
		}

		/// <summary>
		/// Add Category to cache 
		/// </summary>
		/// <param name="Category">The Category Object</param>
		private void AddCategoryToCache(Category category)
		{
			if (CacheEnabled && category != null)
			{
				List<Category> categories = new List<Category>();

				if (CacheCategories != null && CacheCategories.Count > 0)
					categories = CacheCategories;

				Category cacheCategory = new Category();
				if(CacheCategories != null)
					cacheCategory = CacheCategories.FirstOrDefault(c => c.CategoryID == category.CategoryID);

				if (CacheCategories != null && CacheCategories.Count > 0)
				{
					categories.Add(category);
					CacheCategories = categories;
				}
			}
		}

		/// <summary>
		/// Remove Specific Category  from the cache 
		/// </summary>
		/// <param name="category">The Category  Object</param>
		private void RemoveCategoryFromTheCache(Category category)
		{
			if (CacheEnabled && category != null)
			{
				Category cacheCategory = new Category();
				if (CacheCategories != null)
					cacheCategory = CacheCategories.FirstOrDefault(c => c.CategoryID == category.CategoryID);

				if (cacheCategory != null)
				{
					List<Category> categories = new List<Category>();

					if (CacheCategories != null && CacheCategories.Count > 0)
						categories = CacheCategories;

					categories.Remove(cacheCategory);
					CacheCategories = categories;
				}
			}
		}

		/// <summary>
		/// Add Supplier to cache 
		/// </summary>
		/// <param name="supplier">The Supplier Object</param>
		private void AddSuppliersToCache(List<Supplier> suppliers)
		{
			foreach (Supplier supplier in suppliers)
			{
				AddSupplierToCache(supplier);
			}
		}

		/// <summary>
		/// Add Supplier to cache 
		/// </summary>
		/// <param name="supplier">The Supplier Object</param>
		private void AddSupplierToCache(Supplier supplier)
		{
			if (CacheEnabled && supplier != null)
			{
				List<Supplier> suppliers = new List<Supplier>();

				if (CacheSuppliers != null && CacheSuppliers.Count > 0)
					suppliers = CacheSuppliers;

				Supplier cacheSupplier = new Supplier();
				if (CacheSuppliers != null)
					cacheSupplier = CacheSuppliers.FirstOrDefault(c => c.SupplierID == supplier.SupplierID);

				if (CacheSuppliers != null && CacheSuppliers.Count > 0)
				{
					suppliers.Add(supplier);
					CacheSuppliers = suppliers;
				}
			}
		}

		/// <summary>
		/// Remove Specific Supplier  from the cache 
		/// </summary>
		/// <param name="supplier">The Supplier  Object</param>
		private void RemoveSupplierFromTheCache(Supplier supplier)
		{
			if (CacheEnabled && supplier != null)
			{
				Supplier cacheSupplier = new Supplier();
				if (CacheSuppliers != null)
					cacheSupplier = CacheSuppliers.FirstOrDefault(c => c.SupplierID == supplier.SupplierID);

				if (cacheSupplier != null)
				{
					List<Supplier> suppliers = new List<Supplier>();

					if (CacheSuppliers != null && CacheSuppliers.Count > 0)
						suppliers = CacheSuppliers;

					suppliers.Remove(cacheSupplier);
					CacheSuppliers = suppliers;
				}
			}
		}

		#endregion

		#region Properties

		/// <summary>
		/// Product Varaint Collection Cache Value
		/// </summary>
		private List<ProductVariant> CacheProductVariants
		{
			get
			{
				if(CacheEnabled)
					return ZuluContext.Current.ProductVariants;
				return null;
			}
			set
			{
				if (CacheEnabled)
					ZuluContext.Current.ProductVariants = value;
			}
		}

		/// <summary>
		/// Product Collection Cache Value
		/// </summary>
		private List<Product> CacheProducts
		{
			get
			{
				if (CacheEnabled)
					return ZuluContext.Current.Products;
				return null;
			}
			set
			{
				if (CacheEnabled)
					ZuluContext.Current.Products = value;
			}
		}

		/// <summary>
		/// Categories Cache Value
		/// </summary>
		private List<Category> CacheCategories
		{
			get
			{
				if (CacheEnabled)
					return ZuluContext.Current.Categories;
				return null;
			}
			set
			{
				if (CacheEnabled)
					ZuluContext.Current.Categories = value;
			}
		}

		/// <summary>
		/// Suppliers Cache Value
		/// </summary>
		private List<Supplier> CacheSuppliers
		{
			get
			{
				if (CacheEnabled)
					return ZuluContext.Current.Suppliers;
				return null;
			}
			set
			{
				if (CacheEnabled)
					ZuluContext.Current.Suppliers = value;
			}
		}

		/// <summary>
		/// Application Cache Enability Check
		/// </summary>
		private bool CacheEnabled
		{
			get
			{
				return IoC.Resolve<ISettingService>().GetSettingValueBoolean("Application.CacheEnable");
			}
		}

		#endregion
	}
}
