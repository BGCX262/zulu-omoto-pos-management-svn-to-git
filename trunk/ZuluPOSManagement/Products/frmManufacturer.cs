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

namespace ZuluPOSManagement.Products
{
	public partial class frmSupplier : BaseZuluFormControl
	{
		string SupplierID;
		
		public frmSupplier()
		{
			InitializeComponent();
			
			//pnlSupplier.Height = Screen.PrimaryScreen.WorkingArea.Height;
			pnlSupplier.Width = 1024;
			int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            lblHeader.Left = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Width - lblHeader.Width) / 2); 

			if (DeltaWidth > 0)
			{
				pnlSupplier.Left = Convert.ToInt32(DeltaWidth / 2);
			}
			else
			{
				pnlSupplier.Left = 0;
			}
		}

		private void frmSupplier_Load(object sender, EventArgs e)
		{
			grdManufacture.DataSource = ProductService.GetAllSuppliers();

			if (grdManufactureView.DataRowCount > 0)
			{
				grdManufactureView.MoveFirst();

				var firstRow = grdManufactureView.GetRow(grdManufactureView.FocusedRowHandle) as Supplier;

				SupplierID = firstRow.SupplierID.ToString();
				txtManufacture.Text = firstRow.Name.ToString();
				//txtManufacture.Tag = firstRow.CreatedOn.ToString();
				//chkIsActive.EditValue = bool.Parse(firstRow.IsActive.ToString());

				txtManufacture.Focus();

                ClearForm();
			}
			else
			{
				txtManufacture.Enabled = false;
				chkIsActive.Enabled = false;
			}
		}

		private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			if (txtManufacture.Text.Length > 0)
			{
				Supplier supplier = new Supplier();

				//for Edit Data
				if (SupplierID.Length > 0)
				{
					supplier.SupplierID = int.Parse(SupplierID);
					//supplier.CreatedOn = Convert.ToDateTime(txtManufacture.Tag.ToString());
				}
				supplier.Name = txtManufacture.Text.ToString();
				//supplier.IsActive = Convert.ToBoolean(chkIsActive.EditValue);
				//supplier.UpdatedOn = DateTime.Now;

				//for New Data
				if (SupplierID.Length < 0)
				{
					//supplier.CreatedOn = DateTime.Now;
				}

				ProductService.SaveSupplier(supplier);

				grdManufacture.DataSource = ProductService.GetAllSuppliers();

                ClearForm();
			}
			else
			{
				MessageBox.Show("Please, fill the supplier name up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtManufacture.Focus();
			}
		}

		private void cmdNew_Click(object sender, EventArgs e)
		{
            ClearForm();
		}

        private void ClearForm()
        {
            if (grdManufactureView.DataRowCount < 1)
            {
                txtManufacture.Enabled = true;
                chkIsActive.Enabled = true;
            }

            SupplierID = string.Empty;
            txtManufacture.Text = string.Empty;
            txtManufacture.Tag = string.Empty;
            chkIsActive.Checked = true;

            txtManufacture.Focus();
        }

		private void cmdDelete_Click(object sender, EventArgs e)
		{
			if (DialogResult.Yes == MessageBox.Show("Are you sure? Do you want to Delete this category?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
				if (SupplierID.Length > 0)
				{
					ProductService.DeleteSupplier(int.Parse(SupplierID));

					grdManufacture.DataSource = ProductService.GetAllSuppliers();
				}
			}
		}

		private void grdManufactureView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			if (grdManufactureView.DataRowCount > 0)
			{
				var urRow = grdManufactureView.GetRow(grdManufactureView.FocusedRowHandle) as Supplier;

				SupplierID = urRow.SupplierID.ToString();
				txtManufacture.Text = urRow.Name.ToString();
				//txtManufacture.Tag = urRow.CreatedOn.ToString();
				//chkIsActive.EditValue = bool.Parse(urRow.IsActive.ToString());
			}
		}
	}
}
