using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZuluPOSManagement.Controls;

namespace ZuluPOSManagement.OrdersPurchases
{
    public partial class frmPurchaseVoucher : BaseZuluFormControl
    {
        public frmPurchaseVoucher()
        {
            InitializeComponent();

            //pnlProduct.Height = Screen.PrimaryScreen.WorkingArea.Height;
            pnlPurchaseVoucher.Width = 1024;
            int DeltaWidth = Screen.PrimaryScreen.WorkingArea.Width - 1024;

            lblHeader.Left = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Width - lblHeader.Width) / 2);

            if (DeltaWidth > 0)
            {
                pnlPurchaseVoucher.Left = Convert.ToInt32(DeltaWidth / 2);
            }
            else
            {
                pnlPurchaseVoucher.Left = 0;
            }
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmPurchaseVoucher_Load(object sender, EventArgs e)
        {

        }
    }
}
