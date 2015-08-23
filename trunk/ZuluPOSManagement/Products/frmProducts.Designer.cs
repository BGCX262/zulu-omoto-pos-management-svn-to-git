namespace ZuluPOSManagement.Products
{
	partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.lueCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lueProductUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProduct = new DevExpress.XtraEditors.TextEdit();
            this.grdProduct = new DevExpress.XtraGrid.GridControl();
            this.grdProductView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemChkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grdColProductUnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cmdVarient = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.productUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productUnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 32);
            this.panel1.TabIndex = 11;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeader.Location = new System.Drawing.Point(486, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(73, 26);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Product";
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
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.lueCategory);
            this.pnlProduct.Controls.Add(this.lueProductUnit);
            this.pnlProduct.Controls.Add(this.label3);
            this.pnlProduct.Controls.Add(this.chkIsActive);
            this.pnlProduct.Controls.Add(this.label2);
            this.pnlProduct.Controls.Add(this.label8);
            this.pnlProduct.Controls.Add(this.txtProduct);
            this.pnlProduct.Controls.Add(this.grdProduct);
            this.pnlProduct.Controls.Add(this.panel3);
            this.pnlProduct.Location = new System.Drawing.Point(0, 33);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(1024, 729);
            this.pnlProduct.TabIndex = 0;
            // 
            // lueCategory
            // 
            this.lueCategory.Location = new System.Drawing.Point(179, 86);
            this.lueCategory.Name = "lueCategory";
            this.lueCategory.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.lueCategory.Properties.Appearance.Options.UseFont = true;
            this.lueCategory.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lueCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Category"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lueCategory.Properties.DisplayMember = "Name";
            this.lueCategory.Properties.NullText = "";
            this.lueCategory.Properties.ShowFooter = false;
            this.lueCategory.Properties.ShowHeader = false;
            this.lueCategory.Properties.ShowLines = false;
            this.lueCategory.Properties.ValueMember = "CategoryID";
            this.lueCategory.Size = new System.Drawing.Size(289, 28);
            this.lueCategory.TabIndex = 2;
            // 
            // lueProductUnit
            // 
            this.lueProductUnit.Location = new System.Drawing.Point(685, 53);
            this.lueProductUnit.Name = "lueProductUnit";
            this.lueProductUnit.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.lueProductUnit.Properties.Appearance.Options.UseFont = true;
            this.lueProductUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lueProductUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProductUnit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Unit"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductUnitID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lueProductUnit.Properties.DisplayMember = "Name";
            this.lueProductUnit.Properties.NullText = "";
            this.lueProductUnit.Properties.ShowFooter = false;
            this.lueProductUnit.Properties.ShowHeader = false;
            this.lueProductUnit.Properties.ShowLines = false;
            this.lueProductUnit.Properties.ValueMember = "ProductUnitID";
            this.lueProductUnit.Size = new System.Drawing.Size(236, 28);
            this.lueProductUnit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Category";
            // 
            // chkIsActive
            // 
            this.chkIsActive.Location = new System.Drawing.Point(683, 88);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Properties.Appearance.Options.UseFont = true;
            this.chkIsActive.Properties.Caption = "IsActive";
            this.chkIsActive.Size = new System.Drawing.Size(75, 21);
            this.chkIsActive.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Product Unit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Product";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(179, 48);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Properties.Appearance.Options.UseFont = true;
            this.txtProduct.Size = new System.Drawing.Size(289, 28);
            this.txtProduct.TabIndex = 1;
            // 
            // grdProduct
            // 
            this.grdProduct.EmbeddedNavigator.Buttons.AutoRepeatDelay = 16;
            this.grdProduct.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdProduct.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdProduct.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdProduct.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdProduct.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.grdProduct.Location = new System.Drawing.Point(12, 137);
            this.grdProduct.MainView = this.grdProductView;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemChkIsActive});
            this.grdProduct.Size = new System.Drawing.Size(1001, 534);
            this.grdProduct.TabIndex = 5;
            this.grdProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdProductView});
            // 
            // grdProductView
            // 
            this.grdProductView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.grdProductView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.grdProductView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.grdProductView.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grdProductView.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grdProductView.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grdProductView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.grdProductView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.grdProductView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdProductView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.grdProductView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdProductView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdProductView.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdProductView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdProductView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColProductID,
            this.gridColName,
            this.grdColCategory,
            this.ProductUnitName,
            this.grdColIsActive,
            this.grdColProductUnitID});
            this.grdProductView.FooterPanelHeight = 28;
            this.grdProductView.GridControl = this.grdProduct;
            this.grdProductView.Name = "grdProductView";
            this.grdProductView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdProductView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdProductView.OptionsCustomization.AllowColumnMoving = false;
            this.grdProductView.OptionsCustomization.AllowColumnResizing = false;
            this.grdProductView.OptionsDetail.EnableMasterViewMode = false;
            this.grdProductView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdProductView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdProductView.OptionsView.ShowGroupPanel = false;
            this.grdProductView.PaintStyleName = "UltraFlat";
            this.grdProductView.RowHeight = 28;
            this.grdProductView.ViewCaptionHeight = 38;
            this.grdProductView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grdProductView_RowCellClick);
            // 
            // grdColProductID
            // 
            this.grdColProductID.Caption = "ProductID";
            this.grdColProductID.FieldName = "ProductID";
            this.grdColProductID.Name = "grdColProductID";
            this.grdColProductID.OptionsColumn.AllowEdit = false;
            this.grdColProductID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.grdColProductID.OptionsColumn.AllowMove = false;
            // 
            // gridColName
            // 
            this.gridColName.Caption = "Product";
            this.gridColName.FieldName = "Name";
            this.gridColName.Name = "gridColName";
            this.gridColName.OptionsColumn.AllowEdit = false;
            this.gridColName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColName.OptionsColumn.ReadOnly = true;
            this.gridColName.Visible = true;
            this.gridColName.VisibleIndex = 0;
            this.gridColName.Width = 500;
            // 
            // grdColCategory
            // 
            this.grdColCategory.Caption = "Category";
            this.grdColCategory.FieldName = "CategoryName";
            this.grdColCategory.Name = "grdColCategory";
            this.grdColCategory.Visible = true;
            this.grdColCategory.VisibleIndex = 1;
            this.grdColCategory.Width = 150;
            // 
            // ProductUnitName
            // 
            this.ProductUnitName.Caption = "Product Unit";
            this.ProductUnitName.FieldName = "ProductUnit.Name";
            this.ProductUnitName.Name = "ProductUnitName";
            this.ProductUnitName.OptionsColumn.AllowEdit = false;
            this.ProductUnitName.OptionsColumn.ReadOnly = true;
            this.ProductUnitName.Visible = true;
            this.ProductUnitName.VisibleIndex = 2;
            this.ProductUnitName.Width = 164;
            // 
            // grdColIsActive
            // 
            this.grdColIsActive.Caption = "Is Active";
            this.grdColIsActive.ColumnEdit = this.repositoryItemChkIsActive;
            this.grdColIsActive.FieldName = "IsActive";
            this.grdColIsActive.Name = "grdColIsActive";
            this.grdColIsActive.OptionsColumn.AllowEdit = false;
            this.grdColIsActive.OptionsColumn.ReadOnly = true;
            this.grdColIsActive.Visible = true;
            this.grdColIsActive.VisibleIndex = 3;
            this.grdColIsActive.Width = 172;
            // 
            // repositoryItemChkIsActive
            // 
            this.repositoryItemChkIsActive.AutoHeight = false;
            this.repositoryItemChkIsActive.Name = "repositoryItemChkIsActive";
            // 
            // grdColProductUnitID
            // 
            this.grdColProductUnitID.Caption = "UnitID";
            this.grdColProductUnitID.FieldName = "ProductUnitID";
            this.grdColProductUnitID.Name = "grdColProductUnitID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdNew);
            this.panel3.Controls.Add(this.cmdDelete);
            this.panel3.Controls.Add(this.cmdVarient);
            this.panel3.Controls.Add(this.cmdSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 684);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 45);
            this.panel3.TabIndex = 4;
            // 
            // cmdNew
            // 
            this.cmdNew.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdNew.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseBackColor = true;
            this.cmdNew.Appearance.Options.UseBorderColor = true;
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdNew.Image = ((System.Drawing.Image)(resources.GetObject("cmdNew.Image")));
            this.cmdNew.Location = new System.Drawing.Point(669, 5);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(111, 35);
            this.cmdNew.TabIndex = 6;
            this.cmdNew.TabStop = false;
            this.cmdNew.Text = "New";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdDelete.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.cmdDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Appearance.ForeColor = System.Drawing.Color.Red;
            this.cmdDelete.Appearance.Options.UseBackColor = true;
            this.cmdDelete.Appearance.Options.UseBorderColor = true;
            this.cmdDelete.Appearance.Options.UseFont = true;
            this.cmdDelete.Appearance.Options.UseForeColor = true;
            this.cmdDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelete.Image")));
            this.cmdDelete.Location = new System.Drawing.Point(903, 5);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(111, 35);
            this.cmdDelete.TabIndex = 8;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdVarient
            // 
            this.cmdVarient.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdVarient.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.cmdVarient.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVarient.Appearance.Options.UseBackColor = true;
            this.cmdVarient.Appearance.Options.UseBorderColor = true;
            this.cmdVarient.Appearance.Options.UseFont = true;
            this.cmdVarient.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdVarient.Image = ((System.Drawing.Image)(resources.GetObject("cmdVarient.Image")));
            this.cmdVarient.Location = new System.Drawing.Point(12, 5);
            this.cmdVarient.Name = "cmdVarient";
            this.cmdVarient.Size = new System.Drawing.Size(163, 35);
            this.cmdVarient.TabIndex = 9;
            this.cmdVarient.TabStop = false;
            this.cmdVarient.Text = "Prodcut Varient";
            this.cmdVarient.Click += new System.EventHandler(this.cmdVarient_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdSave.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.cmdSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Appearance.Options.UseBackColor = true;
            this.cmdSave.Appearance.Options.UseBorderColor = true;
            this.cmdSave.Appearance.Options.UseFont = true;
            this.cmdSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.Location = new System.Drawing.Point(786, 5);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(111, 35);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.TabStop = false;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // productUnitBindingSource
            // 
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Zulu.BusinessService.Data.Product);
            // 
            // frmProducts
            // 
            this.AcceptButton = this.cmdSave;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelButton = this.lblExit;
            this.ClientSize = new System.Drawing.Size(1044, 788);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productUnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.Panel pnlProduct;
		private DevExpress.XtraEditors.CheckEdit chkIsActive;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private DevExpress.XtraEditors.TextEdit txtProduct;
		private DevExpress.XtraGrid.GridControl grdProduct;
		private DevExpress.XtraGrid.Views.Grid.GridView grdProductView;
		private DevExpress.XtraGrid.Columns.GridColumn grdColProductID;
		private DevExpress.XtraGrid.Columns.GridColumn gridColName;
		private DevExpress.XtraGrid.Columns.GridColumn ProductUnitName;
		private DevExpress.XtraGrid.Columns.GridColumn grdColIsActive;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemChkIsActive;
		private System.Windows.Forms.Panel panel3;
		private DevExpress.XtraEditors.SimpleButton cmdDelete;
		private DevExpress.XtraEditors.SimpleButton cmdSave;
		private DevExpress.XtraEditors.SimpleButton cmdVarient;
		private DevExpress.XtraEditors.SimpleButton cmdNew;
		private DevExpress.XtraEditors.LookUpEdit lueProductUnit;
		private DevExpress.XtraGrid.Columns.GridColumn grdColProductUnitID;
		private System.Windows.Forms.BindingSource productUnitBindingSource;
		private System.Windows.Forms.BindingSource productBindingSource;
		private DevExpress.XtraEditors.LookUpEdit lueCategory;
		private System.Windows.Forms.Label label3;
		private DevExpress.XtraGrid.Columns.GridColumn grdColCategory;
	}
}
