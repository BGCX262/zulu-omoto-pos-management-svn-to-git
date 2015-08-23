namespace ZuluPOSManagement.Main
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.cmdLogin = new DevExpress.XtraEditors.SimpleButton();
			this.cmdExit = new DevExpress.XtraEditors.SimpleButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pnlLogin = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new DevExpress.XtraEditors.TextEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUserID = new DevExpress.XtraEditors.TextEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.pnlLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdLogin
			// 
			this.cmdLogin.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdLogin.Appearance.BorderColor = System.Drawing.Color.LightBlue;
			this.cmdLogin.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdLogin.Appearance.Options.UseBackColor = true;
			this.cmdLogin.Appearance.Options.UseBorderColor = true;
			this.cmdLogin.Appearance.Options.UseFont = true;
			this.cmdLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdLogin.Image = ((System.Drawing.Image)(resources.GetObject("cmdLogin.Image")));
			this.cmdLogin.Location = new System.Drawing.Point(330, 206);
			this.cmdLogin.LookAndFeel.SkinName = "Metropolis";
			this.cmdLogin.Name = "cmdLogin";
			this.cmdLogin.Size = new System.Drawing.Size(97, 36);
			this.cmdLogin.TabIndex = 3;
			this.cmdLogin.Text = "Login";
			this.cmdLogin.ToolTip = "Login";
			this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
			// 
			// cmdExit
			// 
			this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExit.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdExit.Appearance.BorderColor = System.Drawing.Color.Orange;
			this.cmdExit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdExit.Appearance.ForeColor = System.Drawing.Color.Red;
			this.cmdExit.Appearance.Options.UseBackColor = true;
			this.cmdExit.Appearance.Options.UseBorderColor = true;
			this.cmdExit.Appearance.Options.UseFont = true;
			this.cmdExit.Appearance.Options.UseForeColor = true;
			this.cmdExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdExit.Image = ((System.Drawing.Image)(resources.GetObject("cmdExit.Image")));
			this.cmdExit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
			this.cmdExit.Location = new System.Drawing.Point(1419, 3);
			this.cmdExit.LookAndFeel.SkinName = "Metropolis";
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(154, 46);
			this.cmdExit.TabIndex = 1;
			this.cmdExit.Text = "Application E&xit";
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(12, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(69, 68);
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// pnlLogin
			// 
			this.pnlLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.pnlLogin.Controls.Add(this.cmdLogin);
			this.pnlLogin.Controls.Add(this.label3);
			this.pnlLogin.Controls.Add(this.txtPassword);
			this.pnlLogin.Controls.Add(this.label2);
			this.pnlLogin.Controls.Add(this.txtUserID);
			this.pnlLogin.Controls.Add(this.label1);
			this.pnlLogin.Controls.Add(this.pictureBox1);
			this.pnlLogin.Location = new System.Drawing.Point(107, 132);
			this.pnlLogin.Name = "pnlLogin";
			this.pnlLogin.Size = new System.Drawing.Size(449, 261);
			this.pnlLogin.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(205, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(207, 159);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Properties.Appearance.Options.UseFont = true;
			this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.txtPassword.Properties.PasswordChar = '•';
			this.txtPassword.Properties.UseSystemPasswordChar = true;
			this.txtPassword.Size = new System.Drawing.Size(222, 28);
			this.txtPassword.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(205, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "GUID or User ID";
			// 
			// txtUserID
			// 
			this.txtUserID.Location = new System.Drawing.Point(207, 100);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserID.Properties.Appearance.Options.UseFont = true;
			this.txtUserID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.txtUserID.Size = new System.Drawing.Size(222, 28);
			this.txtUserID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Myriad Web Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkGreen;
			this.label1.Location = new System.Drawing.Point(201, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "User Login";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(18, 23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(177, 167);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cmdExit);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 815);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1600, 85);
			this.panel1.TabIndex = 8;
			// 
			// frmLogin
			// 
			this.AcceptButton = this.cmdLogin;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.CancelButton = this.cmdExit;
			this.ClientSize = new System.Drawing.Size(1600, 900);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pnlLogin);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.pnlLogin.ResumeLayout(false);
			this.pnlLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton cmdExit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnlLogin;
		private DevExpress.XtraEditors.SimpleButton cmdLogin;
		private System.Windows.Forms.Label label3;
		private DevExpress.XtraEditors.TextEdit txtPassword;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.TextEdit txtUserID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}
