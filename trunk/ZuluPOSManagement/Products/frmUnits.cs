using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService.Data;
using Zulu.BusinessService;
using ZuluPOSManagement.Controls;

namespace ZuluPOSManagement.Products
{
	public partial class frmUnits : BaseZuluFormControl
	{
		string ProductUnitID;

		public frmUnits()
		{
			InitializeComponent();

			//pnlProductUnit.Height = Screen.PrimaryScreen.WorkingArea.Height;
			pnlProductUnit.Width = 1024;
			int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            lblHeader.Left = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Width - lblHeader.Width) / 2); 

			if (DeltaWidth > 0)
			{
				pnlProductUnit.Left = Convert.ToInt32(DeltaWidth / 2);
			}
			else
			{
				pnlProductUnit.Left = 0;
			}
		}

		private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void frmUnits_Load(object sender, EventArgs e)
		{
			//grdProductUnit.DataSource =	ProductService.GetAllProductUnits();

			//if (grdProductUnitView.DataRowCount > 0)
			//{
			//    grdProductUnitView.MoveFirst();

			//    var firstRow = grdProductUnitView.GetRow(grdProductUnitView.FocusedRowHandle) as ProductUnit;

			//    ProductUnitID = firstRow.ProductUnitID.ToString();
			//    txtProductUnit.Text = firstRow.Name.ToString();
			//    mmeDescription.Text = firstRow.Description.ToString();
			//    chkIsActive.EditValue = bool.Parse(firstRow.IsActive.ToString());

			//    ClearForm();
			//}
			//else
			//{
			//    txtProductUnit.Enabled = false;
			//    mmeDescription.Enabled = false;

			//    chkIsActive.Enabled = false;
			//}
		}

		private void grdProductUnitView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			if (grdProductUnitView.DataRowCount > 0)
			{
				//var puRow = grdProductUnitView.GetRow(grdProductUnitView.FocusedRowHandle) as ProductUnit;

				//ProductUnitID = puRow.ProductUnitID.ToString();
				//txtProductUnit.Text = puRow.Name.ToString();
				//mmeDescription.Text = puRow.Description.ToString();
				//chkIsActive.EditValue = bool.Parse(puRow.IsActive.ToString());
			}
		}

		private void cmdNew_Click(object sender, EventArgs e)
		{
            ClearForm();
		}

        private void ClearForm()
        {
            if (grdProductUnitView.DataRowCount < 1)
            {
                txtProductUnit.Enabled = true;
                mmeDescription.Enabled = true;

                chkIsActive.Enabled = true;
            }

            ProductUnitID = string.Empty;
            txtProductUnit.Text = string.Empty;
            mmeDescription.Text = string.Empty;
            chkIsActive.Checked = true;

            txtProductUnit.Focus();
        }

		private void cmdSave_Click(object sender, EventArgs e)
		{
			if (txtProductUnit.Text.Length > 0)
			{
				////ProductUnit productunit = new ProductUnit();

				////for Edit Data
				//if (ProductUnitID.Length > 0)
				//{
				//    productunit.ProductUnitID = int.Parse(ProductUnitID);
				//    //productunit.CreatedOn = Convert.ToDateTime(txtProductUnit.Tag.ToString());
				//}
				//productunit.Name = txtProductUnit.Text.ToString();
				//productunit.Description = mmeDescription.Text.ToString();
				//productunit.IsActive = Convert.ToBoolean(chkIsActive.EditValue);
				////productunit.UpdatedOn = DateTime.Now;

				////for New Data
				////if (ProductUnitID.Length < 0)
				////{
				////	productunit.CreatedOn = DateTime.Now;
				////}

				//ProductService.SaveProductUnit(productunit);

				//grdProductUnit.DataSource = ProductService.GetAllProductUnits();

				//ClearForm();
			}
			else
			{
				MessageBox.Show("Please, fill the product name up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtProductUnit.Focus();
			}
		}
	}
}
