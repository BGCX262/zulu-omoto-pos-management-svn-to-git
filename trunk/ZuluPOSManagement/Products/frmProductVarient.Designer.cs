namespace ZuluPOSManagement.Products
{
	partial class frmProductVarient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductVarient));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.pnlProductVariant = new System.Windows.Forms.Panel();
            this.lueSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.lueProductName = new DevExpress.XtraEditors.LookUpEdit();
            this.pnlSearchFilter = new System.Windows.Forms.Panel();
            this.cmdSearch = new DevExpress.XtraEditors.SimpleButton();
            this.cboSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearchKey = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zpcProductImage = new ZuluPOSManagement.Controls.ZuluPictureControl();
            this.grdProductVariant = new DevExpress.XtraGrid.GridControl();
            this.grdProductVariantView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColProductVariantID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColVariant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemChkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grdColUnder18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditUnder18 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEditPrice = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEditMinQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEditDisQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEditQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.chkUnder18 = new DevExpress.XtraEditors.CheckEdit();
            this.chkIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.txtVariant = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdClear = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlProductVariant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductName.Properties)).BeginInit();
            this.pnlSearchFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductVariant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductVariantView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditUnder18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditMinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditDisQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUnder18.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVariant.Properties)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel1.TabIndex = 12;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeader.Location = new System.Drawing.Point(454, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(136, 26);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Product Variant";
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
            this.lblExit.Location = new System.Drawing.Point(1002, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(32, 18);
            this.lblExit.TabIndex = 1;
            this.lblExit.TabStop = true;
            this.lblExit.Text = "E&xit";
            this.lblExit.VisitedLinkColor = System.Drawing.Color.Orange;
            this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
            // 
            // pnlProductVariant
            // 
            this.pnlProductVariant.Controls.Add(this.lueSupplier);
            this.pnlProductVariant.Controls.Add(this.lueProductName);
            this.pnlProductVariant.Controls.Add(this.pnlSearchFilter);
            this.pnlProductVariant.Controls.Add(this.zpcProductImage);
            this.pnlProductVariant.Controls.Add(this.grdProductVariant);
            this.pnlProductVariant.Controls.Add(this.chkUnder18);
            this.pnlProductVariant.Controls.Add(this.chkIsActive);
            this.pnlProductVariant.Controls.Add(this.label6);
            this.pnlProductVariant.Controls.Add(this.label12);
            this.pnlProductVariant.Controls.Add(this.label3);
            this.pnlProductVariant.Controls.Add(this.label2);
            this.pnlProductVariant.Controls.Add(this.txtBarcode);
            this.pnlProductVariant.Controls.Add(this.txtVariant);
            this.pnlProductVariant.Controls.Add(this.panel3);
            this.pnlProductVariant.Location = new System.Drawing.Point(0, 33);
            this.pnlProductVariant.Name = "pnlProductVariant";
            this.pnlProductVariant.Size = new System.Drawing.Size(1024, 729);
            this.pnlProductVariant.TabIndex = 1;
            // 
            // lueSupplier
            // 
            this.lueSupplier.Location = new System.Drawing.Point(169, 61);
            this.lueSupplier.Name = "lueSupplier";
            this.lueSupplier.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.lueSupplier.Properties.Appearance.Options.UseFont = true;
            this.lueSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lueSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Unit"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lueSupplier.Properties.DisplayMember = "Name";
            this.lueSupplier.Properties.NullText = "";
            this.lueSupplier.Properties.ShowFooter = false;
            this.lueSupplier.Properties.ShowHeader = false;
            this.lueSupplier.Properties.ShowLines = false;
            this.lueSupplier.Properties.ValueMember = "SupplierID";
            this.lueSupplier.Size = new System.Drawing.Size(337, 28);
            this.lueSupplier.TabIndex = 2;
            // 
            // lueProductName
            // 
            this.lueProductName.Location = new System.Drawing.Point(169, 27);
            this.lueProductName.Name = "lueProductName";
            this.lueProductName.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.lueProductName.Properties.Appearance.Options.UseFont = true;
            this.lueProductName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lueProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProductName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Unit"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lueProductName.Properties.DisplayMember = "Name";
            this.lueProductName.Properties.NullText = "";
            this.lueProductName.Properties.ShowFooter = false;
            this.lueProductName.Properties.ShowHeader = false;
            this.lueProductName.Properties.ShowLines = false;
            this.lueProductName.Properties.ValueMember = "ProductID";
            this.lueProductName.Size = new System.Drawing.Size(337, 28);
            this.lueProductName.TabIndex = 1;
            // 
            // pnlSearchFilter
            // 
            this.pnlSearchFilter.Controls.Add(this.cmdSearch);
            this.pnlSearchFilter.Controls.Add(this.cboSearchBy);
            this.pnlSearchFilter.Controls.Add(this.txtSearchKey);
            this.pnlSearchFilter.Controls.Add(this.label7);
            this.pnlSearchFilter.Controls.Add(this.label5);
            this.pnlSearchFilter.Location = new System.Drawing.Point(12, 201);
            this.pnlSearchFilter.Name = "pnlSearchFilter";
            this.pnlSearchFilter.Size = new System.Drawing.Size(1001, 67);
            this.pnlSearchFilter.TabIndex = 60;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdSearch.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.cmdSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.Appearance.Options.UseBackColor = true;
            this.cmdSearch.Appearance.Options.UseBorderColor = true;
            this.cmdSearch.Appearance.Options.UseFont = true;
            this.cmdSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmdSearch.Image = ((System.Drawing.Image)(resources.GetObject("cmdSearch.Image")));
            this.cmdSearch.Location = new System.Drawing.Point(875, 24);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(33, 29);
            this.cmdSearch.TabIndex = 6;
            this.cmdSearch.TabStop = false;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cboSearchBy
            // 
            this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBy.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
            this.cboSearchBy.FormattingEnabled = true;
            this.cboSearchBy.Items.AddRange(new object[] {
            "Variant",
            "Product Name",
            "Supplier Name",
            "Category Name",
            "Barcode"});
            this.cboSearchBy.Location = new System.Drawing.Point(157, 24);
            this.cboSearchBy.Name = "cboSearchBy";
            this.cboSearchBy.Size = new System.Drawing.Size(304, 29);
            this.cboSearchBy.TabIndex = 34;
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(595, 24);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKey.Properties.Appearance.Options.UseFont = true;
            this.txtSearchKey.Size = new System.Drawing.Size(265, 28);
            this.txtSearchKey.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(39, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Search By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(493, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Search Key";
            // 
            // zpcProductImage
            // 
            this.zpcProductImage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.zpcProductImage.Location = new System.Drawing.Point(537, 25);
            this.zpcProductImage.Name = "zpcProductImage";
            this.zpcProductImage.Size = new System.Drawing.Size(451, 129);
            this.zpcProductImage.TabIndex = 6;
            this.zpcProductImage.Text = "Product Image";
            // 
            // grdProductVariant
            // 
            this.grdProductVariant.Location = new System.Drawing.Point(12, 270);
            this.grdProductVariant.MainView = this.grdProductVariantView;
            this.grdProductVariant.Name = "grdProductVariant";
            this.grdProductVariant.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemChkIsActive,
            this.repositoryItemSpinEditPrice,
            this.repositoryItemSpinEditMinQty,
            this.repositoryItemSpinEditDisQty,
            this.repositoryItemSpinEditQty,
            this.repositoryItemCheckEditUnder18});
            this.grdProductVariant.Size = new System.Drawing.Size(1001, 402);
            this.grdProductVariant.TabIndex = 8;
            this.grdProductVariant.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdProductVariantView});
            // 
            // grdProductVariantView
            // 
            this.grdProductVariantView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.grdProductVariantView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.grdProductVariantView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdProductVariantView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.grdProductVariantView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdProductVariantView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdProductVariantView.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdProductVariantView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdProductVariantView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColProductVariantID,
            this.gridColBarcode,
            this.grdColName,
            this.gridColSupplier,
            this.grdColVariant,
            this.grdColIsActive,
            this.grdColUnder18,
            this.gridColDescription});
            this.grdProductVariantView.GridControl = this.grdProductVariant;
            this.grdProductVariantView.Name = "grdProductVariantView";
            this.grdProductVariantView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdProductVariantView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdProductVariantView.OptionsCustomization.AllowColumnMoving = false;
            this.grdProductVariantView.OptionsCustomization.AllowColumnResizing = false;
            this.grdProductVariantView.OptionsDetail.EnableMasterViewMode = false;
            this.grdProductVariantView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdProductVariantView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdProductVariantView.OptionsView.ShowGroupPanel = false;
            this.grdProductVariantView.PaintStyleName = "UltraFlat";
            this.grdProductVariantView.RowHeight = 28;
            this.grdProductVariantView.ViewCaptionHeight = 38;
            this.grdProductVariantView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grdProductVariantView_RowCellClick);
            // 
            // grdColProductVariantID
            // 
            this.grdColProductVariantID.Caption = "ProductVariantID";
            this.grdColProductVariantID.FieldName = "ProductVariantID";
            this.grdColProductVariantID.Name = "grdColProductVariantID";
            // 
            // gridColBarcode
            // 
            this.gridColBarcode.Caption = "Barcode";
            this.gridColBarcode.FieldName = "BarCode";
            this.gridColBarcode.Name = "gridColBarcode";
            this.gridColBarcode.OptionsColumn.AllowEdit = false;
            this.gridColBarcode.OptionsColumn.ReadOnly = true;
            this.gridColBarcode.Visible = true;
            this.gridColBarcode.VisibleIndex = 0;
            this.gridColBarcode.Width = 171;
            // 
            // grdColName
            // 
            this.grdColName.Caption = "Product Name";
            this.grdColName.FieldName = "Product.Name";
            this.grdColName.Name = "grdColName";
            this.grdColName.OptionsColumn.AllowEdit = false;
            this.grdColName.OptionsColumn.ReadOnly = true;
            this.grdColName.Visible = true;
            this.grdColName.VisibleIndex = 1;
            this.grdColName.Width = 178;
            // 
            // gridColSupplier
            // 
            this.gridColSupplier.Caption = "Supplier";
            this.gridColSupplier.FieldName = "Supplier.Name";
            this.gridColSupplier.Name = "gridColSupplier";
            this.gridColSupplier.OptionsColumn.AllowEdit = false;
            this.gridColSupplier.OptionsColumn.ReadOnly = true;
            this.gridColSupplier.Visible = true;
            this.gridColSupplier.VisibleIndex = 3;
            this.gridColSupplier.Width = 171;
            // 
            // grdColVariant
            // 
            this.grdColVariant.Caption = "Variant";
            this.grdColVariant.FieldName = "Name";
            this.grdColVariant.Name = "grdColVariant";
            this.grdColVariant.OptionsColumn.AllowEdit = false;
            this.grdColVariant.OptionsColumn.ReadOnly = true;
            this.grdColVariant.Visible = true;
            this.grdColVariant.VisibleIndex = 2;
            this.grdColVariant.Width = 207;
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
            this.grdColIsActive.VisibleIndex = 4;
            // 
            // repositoryItemChkIsActive
            // 
            this.repositoryItemChkIsActive.AutoHeight = false;
            this.repositoryItemChkIsActive.Name = "repositoryItemChkIsActive";
            // 
            // grdColUnder18
            // 
            this.grdColUnder18.Caption = "Under18";
            this.grdColUnder18.ColumnEdit = this.repositoryItemCheckEditUnder18;
            this.grdColUnder18.FieldName = "RestrictedUnder18";
            this.grdColUnder18.Name = "grdColUnder18";
            this.grdColUnder18.OptionsColumn.AllowEdit = false;
            this.grdColUnder18.OptionsColumn.ReadOnly = true;
            this.grdColUnder18.Visible = true;
            this.grdColUnder18.VisibleIndex = 5;
            // 
            // repositoryItemCheckEditUnder18
            // 
            this.repositoryItemCheckEditUnder18.AutoHeight = false;
            this.repositoryItemCheckEditUnder18.Name = "repositoryItemCheckEditUnder18";
            // 
            // gridColDescription
            // 
            this.gridColDescription.Caption = "Description";
            this.gridColDescription.FieldName = "Description";
            this.gridColDescription.Name = "gridColDescription";
            // 
            // repositoryItemSpinEditPrice
            // 
            this.repositoryItemSpinEditPrice.AutoHeight = false;
            this.repositoryItemSpinEditPrice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemSpinEditPrice.EditFormat.FormatString = "n0";
            this.repositoryItemSpinEditPrice.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEditPrice.Name = "repositoryItemSpinEditPrice";
            // 
            // repositoryItemSpinEditMinQty
            // 
            this.repositoryItemSpinEditMinQty.AutoHeight = false;
            this.repositoryItemSpinEditMinQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemSpinEditMinQty.DisplayFormat.FormatString = "n0";
            this.repositoryItemSpinEditMinQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEditMinQty.EditFormat.FormatString = "n0";
            this.repositoryItemSpinEditMinQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEditMinQty.Name = "repositoryItemSpinEditMinQty";
            // 
            // repositoryItemSpinEditDisQty
            // 
            this.repositoryItemSpinEditDisQty.AutoHeight = false;
            this.repositoryItemSpinEditDisQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.repositoryItemSpinEditDisQty.DisplayFormat.FormatString = "n0";
            this.repositoryItemSpinEditDisQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEditDisQty.EditFormat.FormatString = "n0";
            this.repositoryItemSpinEditDisQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEditDisQty.Name = "repositoryItemSpinEditDisQty";
            // 
            // repositoryItemSpinEditQty
            // 
            this.repositoryItemSpinEditQty.AutoHeight = false;
            this.repositoryItemSpinEditQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.repositoryItemSpinEditQty.DisplayFormat.FormatString = "n0";
            this.repositoryItemSpinEditQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEditQty.EditFormat.FormatString = "n0";
            this.repositoryItemSpinEditQty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEditQty.Name = "repositoryItemSpinEditQty";
            // 
            // chkUnder18
            // 
            this.chkUnder18.Location = new System.Drawing.Point(167, 168);
            this.chkUnder18.Name = "chkUnder18";
            this.chkUnder18.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnder18.Properties.Appearance.Options.UseFont = true;
            this.chkUnder18.Properties.Caption = "Restricted Under 18";
            this.chkUnder18.Size = new System.Drawing.Size(146, 21);
            this.chkUnder18.TabIndex = 5;
            this.chkUnder18.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.chkUnder18_PreviewKeyDown);
            // 
            // chkIsActive
            // 
            this.chkIsActive.Location = new System.Drawing.Point(689, 168);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Properties.Appearance.Options.UseFont = true;
            this.chkIsActive.Properties.Caption = "IsActive";
            this.chkIsActive.Size = new System.Drawing.Size(75, 21);
            this.chkIsActive.TabIndex = 7;
            this.chkIsActive.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.chkIsActive_PreviewKeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Variant";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Product Name";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(169, 102);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Properties.Appearance.Options.UseFont = true;
            this.txtBarcode.Size = new System.Drawing.Size(337, 28);
            this.txtBarcode.TabIndex = 3;
            // 
            // txtVariant
            // 
            this.txtVariant.Location = new System.Drawing.Point(169, 134);
            this.txtVariant.Name = "txtVariant";
            this.txtVariant.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariant.Properties.Appearance.Options.UseFont = true;
            this.txtVariant.Size = new System.Drawing.Size(337, 28);
            this.txtVariant.TabIndex = 4;
            this.txtVariant.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtVariant_PreviewKeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdClear);
            this.panel3.Controls.Add(this.cmdSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 684);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 45);
            this.panel3.TabIndex = 5;
            // 
            // cmdClear
            // 
            this.cmdClear.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdClear.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.cmdClear.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Appearance.Options.UseBackColor = true;
            this.cmdClear.Appearance.Options.UseBorderColor = true;
            this.cmdClear.Appearance.Options.UseFont = true;
            this.cmdClear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdClear.Image = ((System.Drawing.Image)(resources.GetObject("cmdClear.Image")));
            this.cmdClear.Location = new System.Drawing.Point(12, 5);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(111, 35);
            this.cmdClear.TabIndex = 10;
            this.cmdClear.TabStop = false;
            this.cmdClear.Text = "&Clear";
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
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
            this.cmdSave.Location = new System.Drawing.Point(902, 5);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(111, 35);
            this.cmdSave.TabIndex = 9;
            this.cmdSave.TabStop = false;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // frmProductVarient
            // 
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelButton = this.lblExit;
            this.ClientSize = new System.Drawing.Size(1044, 788);
            this.Controls.Add(this.pnlProductVariant);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductVarient";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProductVarient_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmProductVarient_PreviewKeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlProductVariant.ResumeLayout(false);
            this.pnlProductVariant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductName.Properties)).EndInit();
            this.pnlSearchFilter.ResumeLayout(false);
            this.pnlSearchFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductVariant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductVariantView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditUnder18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditMinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditDisQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUnder18.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVariant.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.Panel pnlProductVariant;
		private DevExpress.XtraGrid.GridControl grdProductVariant;
		private DevExpress.XtraGrid.Views.Grid.GridView grdProductVariantView;
		private DevExpress.XtraGrid.Columns.GridColumn grdColProductVariantID;
		private DevExpress.XtraGrid.Columns.GridColumn gridColBarcode;
		private DevExpress.XtraGrid.Columns.GridColumn grdColName;
		private DevExpress.XtraGrid.Columns.GridColumn gridColSupplier;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditMinQty;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditDisQty;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditQty;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditPrice;
		private DevExpress.XtraGrid.Columns.GridColumn grdColIsActive;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemChkIsActive;
		private DevExpress.XtraGrid.Columns.GridColumn gridColDescription;
		private DevExpress.XtraEditors.CheckEdit chkIsActive;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.TextEdit txtBarcode;
		private DevExpress.XtraEditors.TextEdit txtVariant;
		private System.Windows.Forms.Panel panel3;
		private DevExpress.XtraEditors.SimpleButton cmdSave;
		private Controls.ZuluPictureControl zpcProductImage;
		private System.Windows.Forms.Panel pnlSearchFilter;
		private DevExpress.XtraGrid.Columns.GridColumn grdColVariant;
		private DevExpress.XtraEditors.LookUpEdit lueSupplier;
		private DevExpress.XtraEditors.LookUpEdit lueProductName;
		private DevExpress.XtraEditors.CheckEdit chkUnder18;
		private DevExpress.XtraEditors.SimpleButton cmdSearch;
		private System.Windows.Forms.ComboBox cboSearchBy;
		private DevExpress.XtraEditors.TextEdit txtSearchKey;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private DevExpress.XtraGrid.Columns.GridColumn grdColUnder18;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditUnder18;
		private DevExpress.XtraEditors.SimpleButton cmdClear;
	}
}
