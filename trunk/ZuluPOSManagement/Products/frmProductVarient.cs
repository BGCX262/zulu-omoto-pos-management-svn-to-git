using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService;
using Zulu.BusinessService.Data;
using ZuluPOSManagement.Controls;

namespace ZuluPOSManagement.Products
{
	public partial class frmProductVarient : BaseZuluFormControl
	{
		public int CurProductID;
		string VariantID;
		int ProductImageID;

		public frmProductVarient()
		{
			InitializeComponent();

			//pnlProduct.Height = Screen.PrimaryScreen.WorkingArea.Height;
			pnlProductVariant.Width = 1024;
			int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            lblHeader.Left = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Width - lblHeader.Width) / 2);

			if (DeltaWidth > 0)
			{
				pnlProductVariant.Left = Convert.ToInt32(DeltaWidth / 2);
			}
			else
			{
				pnlProductVariant.Left = 0;
			}
		}

		private void ClearForm()
		{

			VariantID = string.Empty;
			txtVariant.Text = string.Empty;
			txtBarcode.Text = string.Empty;
			lueProductName.EditValue = CurProductID;
			lueSupplier.EditValue = -1;
			chkIsActive.Checked = true;
			chkUnder18.Checked = false;
			ProductImageID = 0;
			zpcProductImage.ClearPicture();

			lueProductName.Focus();
			zpcProductImage.ClearPicture();
		}


		private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void frmProductVarient_Load(object sender, EventArgs e)
		{
			ClearForm();

			lueProductName.Properties.DataSource = ProductService.GetAllProducts();
			lueSupplier.Properties.DataSource = ProductService.GetAllSuppliers();

			if (CurProductID > 0)
			{
				grdProductVariant.DataSource = ProductService.GetProductVariantsByProductID(CurProductID);
				lueProductName.EditValue = CurProductID;
			}
			else
				grdProductVariant.DataSource = ProductService.GetAllProductVariants();

			cboSearchBy.SelectedText = "Variant";
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			if (txtBarcode.Text.Length > 0)
			{
				ProductVariant productvariant = ProductService.GetProductVariantByBarCode(txtBarcode.Text);

				if (productvariant == null || productvariant.ProductVariantID == 0)
				{
					productvariant = new ProductVariant();

					//for Edit Data
					if (VariantID.Length > 0)
					{
						productvariant.ProductVariantID = int.Parse(VariantID);
						productvariant.CreatedOn = Convert.ToDateTime(txtVariant.Tag.ToString());
					}

					productvariant.Name = txtVariant.Text.ToString();
					productvariant.BarCode = txtBarcode.Text.ToString();
					productvariant.SupplierID = int.Parse(lueSupplier.EditValue.ToString());
					productvariant.ProductID = int.Parse(lueProductName.EditValue.ToString());
					productvariant.IsActive = Convert.ToBoolean(chkIsActive.EditValue);
					productvariant.RestrictedUnder18 = Convert.ToBoolean(chkUnder18.EditValue);

					ProductImageID = zpcProductImage.SavePicture();
					productvariant.PictureID = ProductImageID;

					productvariant.UpdatedOn = DateTime.Now;

					//for New Data
					if (VariantID.Length < 0)
					{
						productvariant.CreatedOn = DateTime.Now;
					}

					ProductService.SaveProductVariant(productvariant);

					grdProductVariant.DataSource = ProductService.GetProductVariantsByProductID(int.Parse(lueProductName.EditValue.ToString()));

					ClearForm();
				}
				else
				{
					MessageBox.Show("Existing product variant has the same barcode. Please Check!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Please, fill the barcode up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtBarcode.Focus();
			}

		}

		private void cmdSearch_Click(object sender, EventArgs e)
		{

		}

		private void grdProductVariantView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			if (grdProductVariantView.DataRowCount > 0)
			{
				var urRow = grdProductVariantView.GetRow(grdProductVariantView.FocusedRowHandle) as ProductVariant;
				CurProductID = int.Parse(urRow.ProductID.ToString());
				VariantID = urRow.ProductVariantID.ToString();
				lueProductName.EditValue = int.Parse(urRow.ProductID.ToString());
				lueSupplier.EditValue = int.Parse(urRow.SupplierID.ToString());

				txtVariant.Text = urRow.Name.ToString();
				txtVariant.Tag = urRow.CreatedOn.ToString();
				txtBarcode.Text = urRow.BarCode.ToString();
				zpcProductImage.LoadPicture(int.Parse(urRow.PictureID.ToString()));

				chkUnder18.EditValue = bool.Parse(urRow.RestrictedUnder18.ToString());
				chkIsActive.EditValue = bool.Parse(urRow.IsActive.ToString());
			}
		}

		private void cmdClear_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		private void chkUnder18_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				Save();
		}

		private void frmProductVarient_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				Save();
		}

		private void txtVariant_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				Save();
		}

		private void chkIsActive_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				Save();
		}
	}
}
