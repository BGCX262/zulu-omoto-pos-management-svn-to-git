namespace ZuluPOSManagement.Main
{
	partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdPurchases = new DevExpress.XtraEditors.SimpleButton();
            this.cmdProductUnits = new DevExpress.XtraEditors.SimpleButton();
            this.cmdProducts = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCategory = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdUserRoles = new DevExpress.XtraEditors.SimpleButton();
            this.cmdUser = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label15 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBrandID = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.lblCurrentUserName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 32);
            this.panel1.TabIndex = 3;
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
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Orange;
            this.lblExit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblExit.LinkColor = System.Drawing.Color.Orange;
            this.lblExit.Location = new System.Drawing.Point(1004, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(32, 18);
            this.lblExit.TabIndex = 1;
            this.lblExit.TabStop = true;
            this.lblExit.Text = "E&xit";
            this.lblExit.VisitedLinkColor = System.Drawing.Color.Orange;
            this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.lblPhone);
            this.pnlMain.Controls.Add(this.lblBrandID);
            this.pnlMain.Controls.Add(this.lblAddress2);
            this.pnlMain.Controls.Add(this.lblAddress1);
            this.pnlMain.Controls.Add(this.lblDate);
            this.pnlMain.Controls.Add(this.lblUserLevel);
            this.pnlMain.Controls.Add(this.lblCurrentUserName);
            this.pnlMain.Controls.Add(this.lblTime);
            this.pnlMain.Controls.Add(this.picUser);
            this.pnlMain.Location = new System.Drawing.Point(0, 33);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1024, 729);
            this.pnlMain.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdPurchases);
            this.panel2.Controls.Add(this.cmdProductUnits);
            this.panel2.Controls.Add(this.cmdProducts);
            this.panel2.Controls.Add(this.cmdSupplier);
            this.panel2.Controls.Add(this.cmdCategory);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 534);
            this.panel2.TabIndex = 11;
            // 
            // cmdPurchases
            // 
            this.cmdPurchases.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdPurchases.Appearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdPurchases.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPurchases.Appearance.Options.UseBackColor = true;
            this.cmdPurchases.Appearance.Options.UseBorderColor = true;
            this.cmdPurchases.Appearance.Options.UseFont = true;
            this.cmdPurchases.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdPurchases.Image = ((System.Drawing.Image)(resources.GetObject("cmdPurchases.Image")));
            this.cmdPurchases.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.cmdPurchases.Location = new System.Drawing.Point(528, 52);
            this.cmdPurchases.Name = "cmdPurchases";
            this.cmdPurchases.Size = new System.Drawing.Size(111, 61);
            this.cmdPurchases.TabIndex = 8;
            this.cmdPurchases.Text = "Purchases";
            this.cmdPurchases.Click += new System.EventHandler(this.cmdPurchases_Click);
            // 
            // cmdProductUnits
            // 
            this.cmdProductUnits.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdProductUnits.Appearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdProductUnits.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProductUnits.Appearance.Options.UseBackColor = true;
            this.cmdProductUnits.Appearance.Options.UseBorderColor = true;
            this.cmdProductUnits.Appearance.Options.UseFont = true;
            this.cmdProductUnits.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdProductUnits.Image = ((System.Drawing.Image)(resources.GetObject("cmdProductUnits.Image")));
            this.cmdProductUnits.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.cmdProductUnits.Location = new System.Drawing.Point(276, 52);
            this.cmdProductUnits.Name = "cmdProductUnits";
            this.cmdProductUnits.Size = new System.Drawing.Size(111, 61);
            this.cmdProductUnits.TabIndex = 8;
            this.cmdProductUnits.Text = "Product Units";
            this.cmdProductUnits.Click += new System.EventHandler(this.cmdProductUnits_Click);
            // 
            // cmdProducts
            // 
            this.cmdProducts.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdProducts.Appearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdProducts.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProducts.Appearance.Options.UseBackColor = true;
            this.cmdProducts.Appearance.Options.UseBorderColor = true;
            this.cmdProducts.Appearance.Options.UseFont = true;
            this.cmdProducts.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdProducts.Image = ((System.Drawing.Image)(resources.GetObject("cmdProducts.Image")));
            this.cmdProducts.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.cmdProducts.Location = new System.Drawing.Point(402, 52);
            this.cmdProducts.Name = "cmdProducts";
            this.cmdProducts.Size = new System.Drawing.Size(111, 61);
            this.cmdProducts.TabIndex = 8;
            this.cmdProducts.Text = "Products";
            this.cmdProducts.Click += new System.EventHandler(this.cmdProducts_Click);
            // 
            // cmdSupplier
            // 
            this.cmdSupplier.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdSupplier.Appearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdSupplier.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSupplier.Appearance.Options.UseBackColor = true;
            this.cmdSupplier.Appearance.Options.UseBorderColor = true;
            this.cmdSupplier.Appearance.Options.UseFont = true;
            this.cmdSupplier.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSupplier.Image = ((System.Drawing.Image)(resources.GetObject("cmdSupplier.Image")));
            this.cmdSupplier.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.cmdSupplier.Location = new System.Drawing.Point(150, 52);
            this.cmdSupplier.Name = "cmdSupplier";
            this.cmdSupplier.Size = new System.Drawing.Size(111, 61);
            this.cmdSupplier.TabIndex = 8;
            this.cmdSupplier.Text = "Manufcturer";
            this.cmdSupplier.Click += new System.EventHandler(this.cmdSupplier_Click);
            // 
            // cmdCategory
            // 
            this.cmdCategory.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdCategory.Appearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdCategory.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCategory.Appearance.Options.UseBackColor = true;
            this.cmdCategory.Appearance.Options.UseBorderColor = true;
            this.cmdCategory.Appearance.Options.UseFont = true;
            this.cmdCategory.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdCategory.Image = ((System.Drawing.Image)(resources.GetObject("cmdCategory.Image")));
            this.cmdCategory.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.cmdCategory.Location = new System.Drawing.Point(25, 52);
            this.cmdCategory.Name = "cmdCategory";
            this.cmdCategory.Size = new System.Drawing.Size(111, 61);
            this.cmdCategory.TabIndex = 8;
            this.cmdCategory.Text = "Category";
            this.cmdCategory.Click += new System.EventHandler(this.cmdCategory_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdUserRoles);
            this.panel3.Controls.Add(this.cmdUser);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.shapeContainer2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 130);
            this.panel3.TabIndex = 12;
            // 
            // cmdUserRoles
            // 
            this.cmdUserRoles.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdUserRoles.Appearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdUserRoles.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUserRoles.Appearance.Options.UseBackColor = true;
            this.cmdUserRoles.Appearance.Options.UseBorderColor = true;
            this.cmdUserRoles.Appearance.Options.UseFont = true;
            this.cmdUserRoles.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdUserRoles.Image = ((System.Drawing.Image)(resources.GetObject("cmdUserRoles.Image")));
            this.cmdUserRoles.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.cmdUserRoles.Location = new System.Drawing.Point(151, 51);
            this.cmdUserRoles.Name = "cmdUserRoles";
            this.cmdUserRoles.Size = new System.Drawing.Size(111, 61);
            this.cmdUserRoles.TabIndex = 8;
            this.cmdUserRoles.Text = "User Roles";
            this.cmdUserRoles.Click += new System.EventHandler(this.cmdUserRoles_Click);
            // 
            // cmdUser
            // 
            this.cmdUser.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdUser.Appearance.BorderColor = System.Drawing.Color.LightBlue;
            this.cmdUser.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUser.Appearance.Options.UseBackColor = true;
            this.cmdUser.Appearance.Options.UseBorderColor = true;
            this.cmdUser.Appearance.Options.UseFont = true;
            this.cmdUser.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdUser.Image = ((System.Drawing.Image)(resources.GetObject("cmdUser.Image")));
            this.cmdUser.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.cmdUser.Location = new System.Drawing.Point(26, 51);
            this.cmdUser.Name = "cmdUser";
            this.cmdUser.Size = new System.Drawing.Size(111, 61);
            this.cmdUser.TabIndex = 8;
            this.cmdUser.Text = "Users";
            this.cmdUser.Click += new System.EventHandler(this.cmdUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Administrator Pannel";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(1024, 130);
            this.shapeContainer2.TabIndex = 6;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.rectangleShape2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape2.Location = new System.Drawing.Point(1, 3);
            this.rectangleShape2.Name = "rectangleShape1";
            this.rectangleShape2.Size = new System.Drawing.Size(1022, 30);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.label15.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label15.Location = new System.Drawing.Point(10, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(251, 25);
            this.label15.TabIndex = 5;
            this.label15.Text = "Inventory && POS Control Center";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1024, 534);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.rectangleShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(1, 3);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(1022, 30);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
            this.lblEmail.Location = new System.Drawing.Point(454, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(549, 25);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail : ymn@mail.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
            this.lblPhone.Location = new System.Drawing.Point(493, 134);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(510, 25);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "PH : 01-229900";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBrandID
            // 
            this.lblBrandID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrandID.Font = new System.Drawing.Font("Zawgyi-One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
            this.lblBrandID.Location = new System.Drawing.Point(668, 35);
            this.lblBrandID.Name = "lblBrandID";
            this.lblBrandID.Size = new System.Drawing.Size(338, 40);
            this.lblBrandID.TabIndex = 8;
            this.lblBrandID.Text = "Company Name";
            this.lblBrandID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress2
            // 
            this.lblAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
            this.lblAddress2.Location = new System.Drawing.Point(509, 112);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(494, 25);
            this.lblAddress2.TabIndex = 7;
            this.lblAddress2.Text = "Lanmadaw Township, Yangon";
            this.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress1
            // 
            this.lblAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
            this.lblAddress1.Location = new System.Drawing.Point(504, 88);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(499, 25);
            this.lblAddress1.TabIndex = 6;
            this.lblAddress1.Text = "No. 77, Wardan Street, Middle Block";
            this.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
            this.lblDate.Location = new System.Drawing.Point(14, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(350, 25);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Monday, 12 March 2013";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.AutoSize = true;
            this.lblUserLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
            this.lblUserLevel.Location = new System.Drawing.Point(148, 165);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(58, 13);
            this.lblUserLevel.TabIndex = 4;
            this.lblUserLevel.Text = "User Level";
            // 
            // lblCurrentUserName
            // 
            this.lblCurrentUserName.AutoSize = true;
            this.lblCurrentUserName.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
            this.lblCurrentUserName.Location = new System.Drawing.Point(145, 136);
            this.lblCurrentUserName.Name = "lblCurrentUserName";
            this.lblCurrentUserName.Size = new System.Drawing.Size(165, 26);
            this.lblCurrentUserName.TabIndex = 3;
            this.lblCurrentUserName.Text = "Current User Name";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(93)))), ((int)(((byte)(48)))));
            this.lblTime.Location = new System.Drawing.Point(3, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(374, 62);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "10 : 10 : 11 PM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(26, 84);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(105, 105);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1044, 788);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Label lblBrandID;
		private System.Windows.Forms.Label lblAddress2;
		private System.Windows.Forms.Label lblAddress1;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label lblUserLevel;
		private System.Windows.Forms.Label lblCurrentUserName;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label label15;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
		private System.Windows.Forms.Timer timerClock;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
		private DevExpress.XtraEditors.SimpleButton cmdUserRoles;
		private DevExpress.XtraEditors.SimpleButton cmdUser;
		private DevExpress.XtraEditors.SimpleButton cmdSupplier;
		private DevExpress.XtraEditors.SimpleButton cmdCategory;
		private DevExpress.XtraEditors.SimpleButton cmdProducts;
		private System.Windows.Forms.PictureBox picUser;
		private DevExpress.XtraEditors.SimpleButton cmdProductUnits;
        private DevExpress.XtraEditors.SimpleButton cmdPurchases;
	}
}
