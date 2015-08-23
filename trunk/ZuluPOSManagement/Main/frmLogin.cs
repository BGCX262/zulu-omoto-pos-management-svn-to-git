using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZuluPOSManagement.Controls;

namespace ZuluPOSManagement.Main
{
	public partial class frmLogin : BaseZuluFormControl
	{
		public frmLogin()
		{
			InitializeComponent();

			pnlLogin.Height = Screen.PrimaryScreen.WorkingArea.Height - 400;
			pnlLogin.Width = 478;
			int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 478;
			int DeltaHeight = Screen.PrimaryScreen.WorkingArea.Height - 400;

			if (DeltaWidth > 0)
			{
				pnlLogin.Left = Convert.ToInt32(DeltaWidth / 2);
				pnlLogin.Top = Convert.ToInt32(DeltaHeight / 2);
			}
			else
			{
				pnlLogin.Left = 0;
			}			
		}

		private void cmdExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void cmdLogin_Click(object sender, EventArgs e)
		{
			if (UserService.VerifyUser(txtUserID.Text, txtPassword.Text))
			{
				this.TopMost = false;
				DialogResult = DialogResult.OK;
			}
			else
			{
				DialogResult = DialogResult.None;
				txtPassword.SelectionStart = 0;
				txtPassword.SelectionLength = txtPassword.Text.Length;
				MessageBox.Show("Log in failed for user " + txtUserID.Text, "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			txtUserID.Focus();
		}
	}
}
