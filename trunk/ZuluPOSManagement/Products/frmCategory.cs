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
	public partial class frmCategory : BaseZuluFormControl
	{
		string CategoryID;

		public frmCategory()
		{
			InitializeComponent();

			//pnlCategory.Height = Screen.PrimaryScreen.WorkingArea.Height;
			pnlCategory.Width = 1024;
			int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            lblHeader.Left = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Width - lblHeader.Width) / 2);
             
			if (DeltaWidth > 0)
			{
				pnlCategory.Left = Convert.ToInt32(DeltaWidth / 2);
			}
			else
			{
				pnlCategory.Left = 0;
			}
		}

		private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void frmCategory_Load(object sender, EventArgs e)
		{
			grdCategory.DataSource = ProductService.GetAllCategories();

			if (grdCategoryView.DataRowCount > 0)
			{
				grdCategoryView.MoveFirst();

				var firstRow = grdCategoryView.GetRow(grdCategoryView.FocusedRowHandle) as Category;

				CategoryID = firstRow.CategoryID.ToString();
				txtCategory.Text = firstRow.Name.ToString();
				txtCategory.Tag = firstRow.CreatedOn.ToString();
				chkIsActive.EditValue = bool.Parse(firstRow.IsActive.ToString());

				txtCategory.Focus();

                ClearForm();
			}
			else
			{
				txtCategory.Enabled = false;
				chkIsActive.Enabled = false;
			}
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			if (txtCategory.Text.Length > 0)
			{
				Category Category = new Category();

				//for Edit Data
				if (CategoryID.Length > 0)
				{
					Category.CategoryID = int.Parse(CategoryID);
					Category.CreatedOn = Convert.ToDateTime(txtCategory.Tag.ToString());
				}

				Category.Name = txtCategory.Text.ToString();
				Category.IsActive = Convert.ToBoolean(chkIsActive.EditValue); 
				Category.UpdatedOn = DateTime.Now;

				//for New Data
				if (CategoryID.Length < 0)
				{
					Category.CreatedOn = DateTime.Now;
				}

				bool dublicateCategory = ProductService.SaveCategory(Category);

                if (dublicateCategory == false)
                {
                    MessageBox.Show("Your Category Name is already exit. Please, change your Category Name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategory.Focus();
                }

				grdCategory.DataSource = ProductService.GetAllCategories();

                ClearForm();
			}
			else
			{
				MessageBox.Show("Please, fill the Category Name up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtCategory.Focus();
			}
		}

		private void grdCategoryView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			if (grdCategoryView.DataRowCount > 0)
			{
				var urRow = grdCategoryView.GetRow(grdCategoryView.FocusedRowHandle) as Category;

				CategoryID = urRow.CategoryID.ToString();
				txtCategory.Text = urRow.Name.ToString();
				txtCategory.Tag = urRow.CreatedOn.ToString();
				chkIsActive.EditValue = bool.Parse(urRow.IsActive.ToString());
			}
		}

		private void cmdDelete_Click_1(object sender, EventArgs e)
		{
			if (DialogResult.Yes == MessageBox.Show("Are you sure? Do you want to Delete this category?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
			{
				if (CategoryID.Length > 0)
				{
					ProductService.DeleteCategory(int.Parse(CategoryID));

					

					grdCategory.DataSource = ProductService.GetAllCategories();
				}
			} 
		}

		private void cmdNew_Click(object sender, EventArgs e)
		{
            ClearForm();	
		}

        private void ClearForm()
        {
            if (grdCategoryView.DataRowCount < 1)
            {
                txtCategory.Enabled = true;
                chkIsActive.Enabled = true;
            }

            CategoryID = string.Empty;
            txtCategory.Text = string.Empty;
            txtCategory.Tag = string.Empty;
            chkIsActive.Checked = true;

            txtCategory.Focus();
        }
	}
}
