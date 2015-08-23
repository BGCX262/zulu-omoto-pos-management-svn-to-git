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

namespace ZuluPOSManagement.Users
{
	public partial class frmUser : BaseZuluFormControl
	{
		string UserID;
		
		public frmUser()
		{
			InitializeComponent();

			//pnlUsers.Height = Screen.PrimaryScreen.WorkingArea.Height;
			pnlUsers.Width = 1024;
			int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            lblHeader.Left = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Width - lblHeader.Width) / 2);
            
			if (DeltaWidth > 0)
			{
				pnlUsers.Left = Convert.ToInt32(DeltaWidth / 2);
			}
			else
			{
				pnlUsers.Left = 0;
			}
		}

		private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			if (txtUserID.Text.Length > 0)
			{
                if (txtFullName.Text.Length > 0)
                {
                    User user = new User();

                    //for Edit Data
                    if (UserID.Length > 0)
                    {
                        user.UserID = int.Parse(UserID);
                        user.CreatedOn = Convert.ToDateTime(txtUserID.Tag.ToString());
                    }
                    user.Username = txtUserID.Text.ToString();
                    user.FullName = txtFullName.Text.ToString();
                    user.Password = "password";
                    user.IsActive = Convert.ToBoolean(chkIsActive.EditValue);
                    user.UpdatedOn = DateTime.Now;
                    user.PictureID = zpcUserImage.SavePicture();

                    //for New Data
                    if (UserID.Length < 0)
                    {
                        user.CreatedOn = DateTime.Now;
                    }


                    bool dublicatUser = UserService.SaveUser(user);

                    if (dublicatUser == false)
                    {
                        MessageBox.Show("Login Name is already exit. Please, change the user id up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserID.Focus();
                    }
                    grdUsers.DataSource = UserService.GetAllUsers();

                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Please, fill the full name up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullName.Focus();
                }
			}
			else
			{
				MessageBox.Show("Please, fill the product name up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtUserID.Focus();
			}
		}

		private void frmUser_Load(object sender, EventArgs e)
		{
			grdUsers.DataSource = UserService.GetAllUsers();

			if (grdUsersView.DataRowCount > 0)
			{
				grdUsersView.MoveFirst();

				var firstRow = grdUsersView.GetRow(grdUsersView.FocusedRowHandle) as User;

				UserID = firstRow.UserID.ToString();
				txtUserID.Text = firstRow.Username.ToString();
				txtFullName.Text = firstRow.FullName.ToString();
				txtUserID.Tag = firstRow.CreatedOn.ToString();
				chkIsActive.EditValue = bool.Parse(firstRow.IsActive.ToString());
				zpcUserImage.LoadPicture(int.Parse(firstRow.PictureID.ToString()));

                ClearForm();
			}
			else
			{
				txtUserID.Enabled = false;
				txtFullName.Enabled = false;
				chkIsActive.Enabled = false;

				zpcUserImage.Enabled = false;
			}
		}

		private void cmdNew_Click(object sender, EventArgs e)
		{
            ClearForm();		
		}

        private void ClearForm()
        {
            if (grdUsersView.DataRowCount < 1)
            {
                txtUserID.Enabled = true;
                txtFullName.Enabled = true;
                chkIsActive.Enabled = true;

                zpcUserImage.Enabled = true;
            }

            UserID = string.Empty;
            txtFullName.Text = string.Empty;
            txtUserID.Text = string.Empty;
            txtUserID.Tag = string.Empty;
            txtUserID.Enabled = true;
            chkIsActive.Checked = true;
            zpcUserImage.ClearPicture();

            txtUserID.Focus();
        }

		private void grdView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			if (grdUsersView.DataRowCount > 0)
			{
				var urRow = grdUsersView.GetRow(grdUsersView.FocusedRowHandle) as User;

				UserID = urRow.UserID.ToString();
				txtUserID.Text = urRow.Username.ToString();
                txtUserID.Enabled = false;
				txtFullName.Text = urRow.FullName.ToString();
				txtUserID.Tag = urRow.CreatedOn.ToString();
				zpcUserImage.LoadPicture(int.Parse(urRow.PictureID.ToString()));
				chkIsActive.EditValue = bool.Parse(urRow.IsActive.ToString());
			}
		}

		private void cmdResetPassword_Click(object sender, EventArgs e)
		{
			Users.frmPasswordReset PasswordResetForm = new Users.frmPasswordReset();

			PasswordResetForm.CurUserID = UserID;
			PasswordResetForm.ShowDialog();
		} 		
	}
}
