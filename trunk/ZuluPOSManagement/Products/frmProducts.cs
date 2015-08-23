using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZuluPOSManagement.Controls;
using Zulu.BusinessService;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Util;

namespace ZuluPOSManagement.Products
{
	public partial class frmProducts : ZuluPOSManagement.Controls.BaseZuluFormControl
	{
		string _ProductID;

        public string ProductID
        {
            get
            { return _ProductID; }
            set { _ProductID = value; }
        }
		
		public frmProducts()
		{
			InitializeComponent();

			//pnlProduct.Height = Screen.PrimaryScreen.WorkingArea.Height;
			pnlProduct.Width = 1024;
			int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            lblHeader.Left = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Width - lblHeader.Width) / 2);

			if (DeltaWidth > 0)
			{
				pnlProduct.Left = Convert.ToInt32(DeltaWidth / 2);
			}
			else
			{
				pnlProduct.Left = 0;
			}
		}

		private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void cmdNew_Click(object sender, EventArgs e)
		{
            ClearForm();
		}

        private void ClearForm()
        {
            if (grdProductView.DataRowCount < 1)
            {
                txtProduct.Enabled = true;
                lueProductUnit.Enabled = true;
                lueCategory.Enabled = true;
                chkIsActive.Enabled = true;

                cmdVarient.Enabled = true;
            }

            ProductID = string.Empty;
            txtProduct.Text = string.Empty;
            txtProduct.Tag = string.Empty;
            //lueProductUnit.EditValue = 0;
            //lueCategory.EditValue = 0;
            chkIsActive.Checked = true;

            txtProduct.Focus();
        }

		private void frmProducts_Load(object sender, EventArgs e)
		{
           	grdProduct.DataSource = ProductService.GetAllProducts(0, 16);

			lueCategory.Properties.DataSource = ProductService.GetAllCategories(true);

			if (grdProductView.DataRowCount > 0)
			{
				grdProductView.MoveFirst();

				var firstRow = grdProductView.GetRow(grdProductView.FocusedRowHandle) as Product;

				ProductID = firstRow.ProductID.ToString();
				txtProduct.Text = firstRow.Name.ToString();
				txtProduct.Tag = firstRow.CreatedOn.ToString();
				lueCategory.EditValue = firstRow.CategoryID;
				chkIsActive.EditValue = bool.Parse(firstRow.IsActive.ToString());

                ClearForm();
			}
			else
			{
				txtProduct.Enabled = false;
				lueProductUnit.Enabled = false;
				lueCategory.Enabled = false;
				chkIsActive.Enabled = false;

				cmdVarient.Enabled = false;
			}
		}

		private void cmdDelete_Click(object sender, EventArgs e)
		{
			if (DialogResult.Yes == MessageBox.Show("Are you sure? Do you want to Delete this Product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
				if (ProductID.Length > 0)
				{
					ProductService.DeleteProduct(int.Parse(ProductID));

					grdProduct.DataSource = ProductService.GetAllProducts(0, 16);
				}
			}
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			if (txtProduct.Text.Length > 0)
			{
				Product product = new Product();

				//for Edit Data
				if (ProductID.Length > 0)
				{
					product.ProductID = int.Parse(ProductID);
					product.CreatedOn = Convert.ToDateTime(txtProduct.Tag.ToString());
				}
				product.Name = txtProduct.Text.ToString();
				product.Description = txtProduct.Text.ToString();
				//product.ProductUnitID = int.Parse(lueProductUnit.EditValue.ToString());
				product.CategoryID = int.Parse(lueCategory.EditValue.ToString());
				product.IsActive = Convert.ToBoolean(chkIsActive.EditValue);
				product.UpdatedOn = DateTime.Now;

				//for New Data
				if (ProductID.Length < 0)
				{
					product.CreatedOn = DateTime.Now;
				}

				ProductService.SaveProduct(product);

                ProductID = product.ProductID.ToString();

				grdProduct.DataSource = ProductService.GetAllProducts(0, 16);

                LoadVarient();

                ClearForm();
			}
			else
			{
				MessageBox.Show("Please, fill the product name up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtProduct.Focus();
			}
		}

		private void grdProductView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			if (grdProductView.DataRowCount > 0)
			{
				var urRow = grdProductView.GetRow(grdProductView.FocusedRowHandle) as Product;

             	ProductID = urRow.ProductID.ToString();
				txtProduct.Text = urRow.Name.ToString();
				txtProduct.Tag = urRow.CreatedOn.ToString();
                //lueProductUnit.EditValue = ZuluHelper.GetIntValue(urRow.ProductUnitID.ToString());
                lueCategory.EditValue = ZuluHelper.GetIntValue(urRow.CategoryID.ToString());
				chkIsActive.EditValue = bool.Parse(urRow.IsActive.ToString());
			}
		}

		private void cmdVarient_Click(object sender, EventArgs e)
		{
            LoadVarient();
		}

        private void LoadVarient()
        {
            int productID = 0;
            int.TryParse(ProductID.ToString(), out productID);

            if (productID != 0)
            {
                Products.frmProductVarient ProductVariantForm = new Products.frmProductVarient();

                ProductVariantForm.CurProductID = int.Parse(ProductID);
                ProductVariantForm.ShowDialog();
            }
        }
	}
}
