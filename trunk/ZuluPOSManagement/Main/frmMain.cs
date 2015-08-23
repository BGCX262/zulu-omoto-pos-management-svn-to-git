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
using Zulu.BusinessService.Logs;
using Zulu.BusinessService.Settings;

namespace ZuluPOSManagement.Main
{
	public partial class frmMain : ZuluPOSManagement.Controls.BaseZuluFormControl
	{
		public frmMain()
		{
			InitializeComponent();

			//pnlMain.Height = Screen.PrimaryScreen.WorkingArea.Height;
			pnlMain.Width = 1024;
			int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

			if (DeltaWidth > 0)
			{
				pnlMain.Left = Convert.ToInt32(DeltaWidth / 2);
			}
			else
			{
				pnlMain.Left = 0;
			}
		}

		private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Exit();
		}

		private void timerClock_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("hh : mm : ss tt");
			lblDate.Text = DateTime.Now.ToString("D");
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			frmLogin LoginForm = new frmLogin();

			if (LoginForm.ShowDialog() != DialogResult.OK)
			{
				Application.Exit();
			}
			else
			{
				this.TopMost = false; 

				string imageLocation = MediaService.GetMediaUrl(int.Parse(ZuluContext.Current.CurrentUser.PictureID.ToString()), 102);
				Bitmap bitmap = new Bitmap(imageLocation);

				picUser.Image = bitmap;
				lblCurrentUserName.Text = ZuluContext.Current.CurrentUser.FullName;

				ApplicationSetting AppSetting = new ApplicationSetting();
				lblBrandID.Text = AppSetting.ComapanyName;
				lblAddress1.Text = AppSetting.Address1;
				lblAddress2.Text = AppSetting.Address2;
				lblPhone.Text = AppSetting.Phone;
				lblEmail.Text = AppSetting.Email;
			}
		}

		private void cmdCategory_Click(object sender, EventArgs e)
		{
			Products.frmCategory CategoryForm = new Products.frmCategory();
			CategoryForm.ShowDialog();
		}

		private void cmdUser_Click(object sender, EventArgs e)
		{
			Users.frmUser UsersForm = new Users.frmUser();
			UsersForm.ShowDialog();
		}

		private void cmdUserRoles_Click(object sender, EventArgs e)
		{
			Users.frmUserRoles UserRolesForm = new Users.frmUserRoles();
			UserRolesForm.ShowDialog();
		}

		private void cmdSupplier_Click(object sender, EventArgs e)
		{
			Products.frmSupplier SupplierForm = new Products.frmSupplier();
			SupplierForm.ShowDialog();
		}

		private void cmdProductUnits_Click(object sender, EventArgs e)
		{
			Products.frmUnits ProductUnits = new Products.frmUnits();
			ProductUnits.ShowDialog();
		}

		private void cmdProducts_Click(object sender, EventArgs e)
		{
			Products.frmProducts ProductsForm = new Products.frmProducts();
			ProductsForm.ShowDialog();
		}

        private void cmdPurchases_Click(object sender, EventArgs e)
        {
            //OrdersPurchases.frmPurchaseList PurchasesForm = new OrdersPurchases.frmPurchaseList();
            //PurchasesForm.ShowDialog();
        }
	}
}
