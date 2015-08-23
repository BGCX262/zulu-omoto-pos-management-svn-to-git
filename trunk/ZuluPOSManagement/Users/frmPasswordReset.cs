using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zulu.BusinessService;
using Zulu.BusinessService.Data;
using ZuluPOSManagement.Controls;

namespace ZuluPOSManagement.Users
{
	public partial class frmPasswordReset : BaseZuluFormControl
	{
		public string CurUserID;
		
		public frmPasswordReset()
		{
			InitializeComponent();
		}

		private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void cmdResetPassword_Click(object sender, EventArgs e)
		{
			if (CurUserID.Length > 0)
			{
				if (txtNewPassword.Text == txtreenterpass.Text)
				{
					UserService.ResetPassword(int.Parse(CurUserID), txtNewPassword.Text);

                    var user = UserService.GetUserByID(int.Parse(CurUserID));

                    MessageBox.Show("Successfull reset password of " + user.FullName + ".", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPassword.Focus();
				}
				else
				{
					MessageBox.Show("Not same your password.", "Information");
				}
			}
		}

		private void frmPasswordReset_Load(object sender, EventArgs e)
		{
			txtNewPassword.Focus();
		}
	}
}
