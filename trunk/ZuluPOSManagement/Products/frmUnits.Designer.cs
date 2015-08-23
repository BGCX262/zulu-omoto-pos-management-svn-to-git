namespace ZuluPOSManagement.Products
{
	partial class frmUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnits));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.pnlProductUnit = new System.Windows.Forms.Panel();
            this.mmeDescription = new DevExpress.XtraEditors.MemoEdit();
            this.grdProductUnit = new DevExpress.XtraGrid.GridControl();
            this.grdProductUnitView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColProductUnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemChkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductUnit = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlProductUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmeDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductUnitView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductUnit.Properties)).BeginInit();
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
            this.panel1.TabIndex = 11;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeader.Location = new System.Drawing.Point(466, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(112, 26);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Product Unit";
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
            // pnlProductUnit
            // 
            this.pnlProductUnit.Controls.Add(this.mmeDescription);
            this.pnlProductUnit.Controls.Add(this.grdProductUnit);
            this.pnlProductUnit.Controls.Add(this.chkIsActive);
            this.pnlProductUnit.Controls.Add(this.label3);
            this.pnlProductUnit.Controls.Add(this.label2);
            this.pnlProductUnit.Controls.Add(this.txtProductUnit);
            this.pnlProductUnit.Controls.Add(this.panel3);
            this.pnlProductUnit.Location = new System.Drawing.Point(0, 33);
            this.pnlProductUnit.Name = "pnlProductUnit";
            this.pnlProductUnit.Size = new System.Drawing.Size(1024, 729);
            this.pnlProductUnit.TabIndex = 0;
            // 
            // mmeDescription
            // 
            this.mmeDescription.Location = new System.Drawing.Point(584, 53);
            this.mmeDescription.Name = "mmeDescription";
            this.mmeDescription.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmeDescription.Properties.Appearance.Options.UseFont = true;
            this.mmeDescription.Size = new System.Drawing.Size(388, 71);
            this.mmeDescription.TabIndex = 3;
            // 
            // grdProductUnit
            // 
            this.grdProductUnit.Location = new System.Drawing.Point(12, 146);
            this.grdProductUnit.MainView = this.grdProductUnitView;
            this.grdProductUnit.Name = "grdProductUnit";
            this.grdProductUnit.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemChkIsActive});
            this.grdProductUnit.Size = new System.Drawing.Size(1001, 527);
            this.grdProductUnit.TabIndex = 4;
            this.grdProductUnit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdProductUnitView});
            // 
            // grdProductUnitView
            // 
            this.grdProductUnitView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.grdProductUnitView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.grdProductUnitView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdProductUnitView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.grdProductUnitView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdProductUnitView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdProductUnitView.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdProductUnitView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdProductUnitView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColProductUnitID,
            this.grdColName,
            this.grdColIsActive,
            this.gridColDescription});
            this.grdProductUnitView.GridControl = this.grdProductUnit;
            this.grdProductUnitView.Name = "grdProductUnitView";
            this.grdProductUnitView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdProductUnitView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdProductUnitView.OptionsCustomization.AllowColumnMoving = false;
            this.grdProductUnitView.OptionsCustomization.AllowColumnResizing = false;
            this.grdProductUnitView.OptionsDetail.EnableMasterViewMode = false;
            this.grdProductUnitView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdProductUnitView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdProductUnitView.OptionsView.ShowGroupPanel = false;
            this.grdProductUnitView.PaintStyleName = "UltraFlat";
            this.grdProductUnitView.RowHeight = 28;
            this.grdProductUnitView.ViewCaptionHeight = 38;
            this.grdProductUnitView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grdProductUnitView_RowCellClick);
            // 
            // grdColProductUnitID
            // 
            this.grdColProductUnitID.Caption = "ProductUnitID";
            this.grdColProductUnitID.FieldName = "ProductUnitID";
            this.grdColProductUnitID.Name = "grdColProductUnitID";
            // 
            // grdColName
            // 
            this.grdColName.Caption = "Product Unit";
            this.grdColName.FieldName = "Name";
            this.grdColName.Name = "grdColName";
            this.grdColName.OptionsColumn.AllowEdit = false;
            this.grdColName.Visible = true;
            this.grdColName.VisibleIndex = 0;
            this.grdColName.Width = 491;
            // 
            // grdColIsActive
            // 
            this.grdColIsActive.Caption = "Is Active";
            this.grdColIsActive.ColumnEdit = this.repositoryItemChkIsActive;
            this.grdColIsActive.FieldName = "IsActive";
            this.grdColIsActive.Name = "grdColIsActive";
            this.grdColIsActive.OptionsColumn.AllowEdit = false;
            this.grdColIsActive.Visible = true;
            this.grdColIsActive.VisibleIndex = 1;
            this.grdColIsActive.Width = 100;
            // 
            // repositoryItemChkIsActive
            // 
            this.repositoryItemChkIsActive.AutoHeight = false;
            this.repositoryItemChkIsActive.Name = "repositoryItemChkIsActive";
            // 
            // gridColDescription
            // 
            this.gridColDescription.Caption = "Description";
            this.gridColDescription.FieldName = "Description";
            this.gridColDescription.Name = "gridColDescription";
            // 
            // chkIsActive
            // 
            this.chkIsActive.Location = new System.Drawing.Point(135, 103);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Properties.Appearance.Options.UseFont = true;
            this.chkIsActive.Properties.Caption = "IsActive";
            this.chkIsActive.Size = new System.Drawing.Size(75, 21);
            this.chkIsActive.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Product Unit";
            // 
            // txtProductUnit
            // 
            this.txtProductUnit.Location = new System.Drawing.Point(137, 53);
            this.txtProductUnit.Name = "txtProductUnit";
            this.txtProductUnit.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductUnit.Properties.Appearance.Options.UseFont = true;
            this.txtProductUnit.Size = new System.Drawing.Size(285, 28);
            this.txtProductUnit.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdNew);
            this.panel3.Controls.Add(this.cmdSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 684);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 45);
            this.panel3.TabIndex = 5;
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
            this.cmdNew.Location = new System.Drawing.Point(785, 5);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(111, 35);
            this.cmdNew.TabIndex = 5;
            this.cmdNew.TabStop = false;
            this.cmdNew.Text = "New";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
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
            this.cmdSave.TabIndex = 6;
            this.cmdSave.TabStop = false;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // frmUnits
            // 
            this.AcceptButton = this.cmdSave;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelButton = this.lblExit;
            this.ClientSize = new System.Drawing.Size(1044, 788);
            this.Controls.Add(this.pnlProductUnit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmUnits";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUnits_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlProductUnit.ResumeLayout(false);
            this.pnlProductUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmeDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductUnitView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductUnit.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.Panel pnlProductUnit;
		private DevExpress.XtraEditors.MemoEdit mmeDescription;
		private DevExpress.XtraGrid.GridControl grdProductUnit;
		private DevExpress.XtraGrid.Views.Grid.GridView grdProductUnitView;
		private DevExpress.XtraGrid.Columns.GridColumn grdColProductUnitID;
		private DevExpress.XtraGrid.Columns.GridColumn grdColName;
		private DevExpress.XtraGrid.Columns.GridColumn grdColIsActive;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemChkIsActive;
		private DevExpress.XtraGrid.Columns.GridColumn gridColDescription;
		private DevExpress.XtraEditors.CheckEdit chkIsActive;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.TextEdit txtProductUnit;
		private System.Windows.Forms.Panel panel3;
		private DevExpress.XtraEditors.SimpleButton cmdSave;
		private DevExpress.XtraEditors.SimpleButton cmdNew;
	}
}
