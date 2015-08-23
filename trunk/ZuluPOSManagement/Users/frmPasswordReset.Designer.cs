namespace ZuluPOSManagement.Users
{
	partial class frmPasswordReset
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordReset));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblExit = new System.Windows.Forms.LinkLabel();
			this.pnl = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmdResetPassword = new DevExpress.XtraEditors.SimpleButton();
			this.txtreenterpass = new DevExpress.XtraEditors.TextEdit();
			this.txtNewPassword = new DevExpress.XtraEditors.TextEdit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.pnl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtreenterpass.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.lblExit);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(469, 32);
			this.panel1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
			this.label1.Location = new System.Drawing.Point(160, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 26);
			this.label1.TabIndex = 8;
			this.label1.Text = "Reset Password";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(6, 6);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// lblExit
			// 
			this.lblExit.ActiveLinkColor = System.Drawing.Color.Crimson;
			this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblExit.AutoSize = true;
			this.lblExit.Font = new System.Drawing.Font("Myriad Web Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExit.ForeColor = System.Drawing.Color.Orange;
			this.lblExit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.lblExit.LinkColor = System.Drawing.Color.Orange;
			this.lblExit.Location = new System.Drawing.Point(429, 9);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(32, 17);
			this.lblExit.TabIndex = 1;
			this.lblExit.TabStop = true;
			this.lblExit.Text = "E&xit";
			this.lblExit.VisitedLinkColor = System.Drawing.Color.Orange;
			this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
			// 
			// pnl
			// 
			this.pnl.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.pnl.Controls.Add(this.label12);
			this.pnl.Controls.Add(this.label2);
			this.pnl.Controls.Add(this.cmdResetPassword);
			this.pnl.Controls.Add(this.txtreenterpass);
			this.pnl.Controls.Add(this.txtNewPassword);
			this.pnl.Location = new System.Drawing.Point(2, 32);
			this.pnl.Name = "pnl";
			this.pnl.Size = new System.Drawing.Size(465, 197);
			this.pnl.TabIndex = 0;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(32, 90);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(112, 15);
			this.label12.TabIndex = 35;
			this.label12.Text = "Re-enter Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 15);
			this.label2.TabIndex = 36;
			this.label2.Text = "New Password";
			// 
			// cmdResetPassword
			// 
			this.cmdResetPassword.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdResetPassword.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
			this.cmdResetPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdResetPassword.Appearance.Options.UseBackColor = true;
			this.cmdResetPassword.Appearance.Options.UseBorderColor = true;
			this.cmdResetPassword.Appearance.Options.UseFont = true;
			this.cmdResetPassword.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdResetPassword.Image = ((System.Drawing.Image)(resources.GetObject("cmdResetPassword.Image")));
			this.cmdResetPassword.Location = new System.Drawing.Point(263, 137);
			this.cmdResetPassword.Name = "cmdResetPassword";
			this.cmdResetPassword.Size = new System.Drawing.Size(164, 35);
			this.cmdResetPassword.TabIndex = 2;
			this.cmdResetPassword.Text = "Reset Password";
			this.cmdResetPassword.Click += new System.EventHandler(this.cmdResetPassword_Click);
			// 
			// txtreenterpass
			// 
			this.txtreenterpass.Location = new System.Drawing.Point(163, 85);
			this.txtreenterpass.Name = "txtreenterpass";
			this.txtreenterpass.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
			this.txtreenterpass.Properties.Appearance.Options.UseFont = true;
			this.txtreenterpass.Properties.PasswordChar = '•';
			this.txtreenterpass.Properties.UseSystemPasswordChar = true;
			this.txtreenterpass.Size = new System.Drawing.Size(267, 28);
			this.txtreenterpass.TabIndex = 1;
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Location = new System.Drawing.Point(163, 38);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
			this.txtNewPassword.Properties.Appearance.Options.UseFont = true;
			this.txtNewPassword.Properties.PasswordChar = '•';
			this.txtNewPassword.Properties.UseSystemPasswordChar = true;
			this.txtNewPassword.Size = new System.Drawing.Size(267, 28);
			this.txtNewPassword.TabIndex = 0;
			// 
			// frmPasswordReset
			// 
			this.AcceptButton = this.cmdResetPassword;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.CancelButton = this.lblExit;
			this.ClientSize = new System.Drawing.Size(469, 231);
			this.Controls.Add(this.pnl);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "frmPasswordReset";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.frmPasswordReset_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.pnl.ResumeLayout(false);
			this.pnl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtreenterpass.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.Panel pnl;
		private DevExpress.XtraEditors.TextEdit txtNewPassword;
		private DevExpress.XtraEditors.SimpleButton cmdResetPassword;
		private DevExpress.XtraEditors.TextEdit txtreenterpass;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label2;
	}
}
