namespace ZuluPOSManagement.Users
{
	partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.zpcUserImage = new ZuluPOSManagement.Controls.ZuluPictureControl();
            this.grdUsers = new DevExpress.XtraGrid.GridControl();
            this.grdUsersView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColGUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemHyperLinkEditUserRoles = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.cmdResetPassword = new DevExpress.XtraEditors.SimpleButton();
            this.cmdUserRolesSetting = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.txtUserID = new DevExpress.XtraEditors.TextEdit();
            this.repositoryItemChkIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEditUserRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.panel1.TabIndex = 4;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblHeader.Location = new System.Drawing.Point(473, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(99, 26);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "User Setup";
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
            // pnlUsers
            // 
            this.pnlUsers.Controls.Add(this.zpcUserImage);
            this.pnlUsers.Controls.Add(this.grdUsers);
            this.pnlUsers.Controls.Add(this.panel2);
            this.pnlUsers.Controls.Add(this.chkIsActive);
            this.pnlUsers.Controls.Add(this.label3);
            this.pnlUsers.Controls.Add(this.label2);
            this.pnlUsers.Controls.Add(this.txtFullName);
            this.pnlUsers.Controls.Add(this.txtUserID);
            this.pnlUsers.Location = new System.Drawing.Point(0, 33);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(1024, 729);
            this.pnlUsers.TabIndex = 5;
            // 
            // zpcUserImage
            // 
            this.zpcUserImage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.zpcUserImage.Location = new System.Drawing.Point(470, 41);
            this.zpcUserImage.Name = "zpcUserImage";
            this.zpcUserImage.Size = new System.Drawing.Size(451, 135);
            this.zpcUserImage.TabIndex = 4;
            this.zpcUserImage.Text = "User Image";
            // 
            // grdUsers
            // 
            this.grdUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsers.Location = new System.Drawing.Point(11, 184);
            this.grdUsers.MainView = this.grdUsersView;
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemHyperLinkEditUserRoles,
            this.repositoryItemTextEdit1});
            this.grdUsers.Size = new System.Drawing.Size(1003, 489);
            this.grdUsers.TabIndex = 5;
            this.grdUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdUsersView});
            // 
            // grdUsersView
            // 
            this.grdUsersView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.grdUsersView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.grdUsersView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Zawgyi-One", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdUsersView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Silver;
            this.grdUsersView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdUsersView.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdUsersView.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdUsersView.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdUsersView.Appearance.VertLine.BorderColor = System.Drawing.Color.Silver;
            this.grdUsersView.Appearance.VertLine.Options.UseBorderColor = true;
            this.grdUsersView.BestFitMaxRowCount = 6;
            this.grdUsersView.ColumnPanelRowHeight = 35;
            this.grdUsersView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColUserID,
            this.gridColGUID,
            this.gridColUserName,
            this.gridColFullName,
            this.gridColIsActive});
            this.grdUsersView.FixedLineWidth = 1;
            this.grdUsersView.GridControl = this.grdUsers;
            this.grdUsersView.Name = "grdUsersView";
            this.grdUsersView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdUsersView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdUsersView.OptionsBehavior.AutoPopulateColumns = false;
            this.grdUsersView.OptionsBehavior.AutoSelectAllInEditor = false;
            this.grdUsersView.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.grdUsersView.OptionsBehavior.Editable = false;
            this.grdUsersView.OptionsCustomization.AllowColumnMoving = false;
            this.grdUsersView.OptionsCustomization.AllowColumnResizing = false;
            this.grdUsersView.OptionsCustomization.AllowGroup = false;
            this.grdUsersView.OptionsCustomization.AllowQuickHideColumns = false;
            this.grdUsersView.OptionsDetail.EnableMasterViewMode = false;
            this.grdUsersView.OptionsMenu.EnableColumnMenu = false;
            this.grdUsersView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdUsersView.OptionsView.EnableAppearanceEvenRow = true;
            this.grdUsersView.OptionsView.ShowGroupPanel = false;
            this.grdUsersView.PaintStyleName = "UltraFlat";
            this.grdUsersView.RowHeight = 28;
            this.grdUsersView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grdView_RowCellClick);
            // 
            // gridColUserID
            // 
            this.gridColUserID.Caption = "UserID";
            this.gridColUserID.FieldName = "UserID";
            this.gridColUserID.Name = "gridColUserID";
            // 
            // gridColGUID
            // 
            this.gridColGUID.Caption = "User GUID";
            this.gridColGUID.FieldName = "UserGUID";
            this.gridColGUID.Name = "gridColGUID";
            this.gridColGUID.OptionsColumn.AllowEdit = false;
            this.gridColGUID.OptionsColumn.AllowFocus = false;
            this.gridColGUID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColGUID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColGUID.OptionsColumn.AllowMove = false;
            this.gridColGUID.OptionsColumn.AllowShowHide = false;
            this.gridColGUID.OptionsColumn.AllowSize = false;
            this.gridColGUID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.gridColGUID.OptionsColumn.ReadOnly = true;
            this.gridColGUID.OptionsColumn.ShowInCustomizationForm = false;
            this.gridColGUID.OptionsColumn.ShowInExpressionEditor = false;
            this.gridColGUID.OptionsColumn.TabStop = false;
            this.gridColGUID.OptionsFilter.AllowAutoFilter = false;
            this.gridColGUID.OptionsFilter.AllowFilter = false;
            this.gridColGUID.Width = 185;
            // 
            // gridColUserName
            // 
            this.gridColUserName.Caption = "Login Name";
            this.gridColUserName.FieldName = "Username";
            this.gridColUserName.Name = "gridColUserName";
            this.gridColUserName.OptionsColumn.AllowEdit = false;
            this.gridColUserName.OptionsColumn.AllowFocus = false;
            this.gridColUserName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColUserName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColUserName.OptionsColumn.AllowMove = false;
            this.gridColUserName.OptionsColumn.AllowShowHide = false;
            this.gridColUserName.OptionsColumn.AllowSize = false;
            this.gridColUserName.OptionsColumn.ShowInCustomizationForm = false;
            this.gridColUserName.OptionsColumn.ShowInExpressionEditor = false;
            this.gridColUserName.OptionsFilter.AllowAutoFilter = false;
            this.gridColUserName.OptionsFilter.AllowFilter = false;
            this.gridColUserName.Visible = true;
            this.gridColUserName.VisibleIndex = 0;
            this.gridColUserName.Width = 161;
            // 
            // gridColFullName
            // 
            this.gridColFullName.Caption = "Full Name";
            this.gridColFullName.FieldName = "FullName";
            this.gridColFullName.Name = "gridColFullName";
            this.gridColFullName.OptionsColumn.AllowEdit = false;
            this.gridColFullName.OptionsColumn.AllowFocus = false;
            this.gridColFullName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColFullName.OptionsColumn.AllowIncrementalSearch = false;
            this.gridColFullName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColFullName.OptionsColumn.AllowMove = false;
            this.gridColFullName.OptionsColumn.AllowShowHide = false;
            this.gridColFullName.OptionsColumn.AllowSize = false;
            this.gridColFullName.OptionsFilter.AllowAutoFilter = false;
            this.gridColFullName.OptionsFilter.AllowFilter = false;
            this.gridColFullName.Visible = true;
            this.gridColFullName.VisibleIndex = 1;
            this.gridColFullName.Width = 300;
            // 
            // gridColIsActive
            // 
            this.gridColIsActive.Caption = "Is Active";
            this.gridColIsActive.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gridColIsActive.FieldName = "IsActive";
            this.gridColIsActive.Name = "gridColIsActive";
            this.gridColIsActive.OptionsColumn.AllowEdit = false;
            this.gridColIsActive.OptionsColumn.AllowMove = false;
            this.gridColIsActive.Visible = true;
            this.gridColIsActive.VisibleIndex = 2;
            this.gridColIsActive.Width = 125;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemHyperLinkEditUserRoles
            // 
            this.repositoryItemHyperLinkEditUserRoles.AutoHeight = false;
            this.repositoryItemHyperLinkEditUserRoles.Name = "repositoryItemHyperLinkEditUserRoles";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdNew);
            this.panel2.Controls.Add(this.cmdResetPassword);
            this.panel2.Controls.Add(this.cmdUserRolesSetting);
            this.panel2.Controls.Add(this.cmdSave);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 684);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 45);
            this.panel2.TabIndex = 28;
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
            this.cmdNew.Location = new System.Drawing.Point(590, 5);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(111, 35);
            this.cmdNew.TabIndex = 6;
            this.cmdNew.TabStop = false;
            this.cmdNew.Text = "New";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
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
            this.cmdResetPassword.Location = new System.Drawing.Point(11, 5);
            this.cmdResetPassword.Name = "cmdResetPassword";
            this.cmdResetPassword.Size = new System.Drawing.Size(164, 35);
            this.cmdResetPassword.TabIndex = 9;
            this.cmdResetPassword.Text = "Reset Password";
            this.cmdResetPassword.Click += new System.EventHandler(this.cmdResetPassword_Click);
            // 
            // cmdUserRolesSetting
            // 
            this.cmdUserRolesSetting.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdUserRolesSetting.Appearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.cmdUserRolesSetting.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUserRolesSetting.Appearance.Options.UseBackColor = true;
            this.cmdUserRolesSetting.Appearance.Options.UseBorderColor = true;
            this.cmdUserRolesSetting.Appearance.Options.UseFont = true;
            this.cmdUserRolesSetting.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmdUserRolesSetting.Image = ((System.Drawing.Image)(resources.GetObject("cmdUserRolesSetting.Image")));
            this.cmdUserRolesSetting.Location = new System.Drawing.Point(824, 5);
            this.cmdUserRolesSetting.Name = "cmdUserRolesSetting";
            this.cmdUserRolesSetting.Size = new System.Drawing.Size(188, 35);
            this.cmdUserRolesSetting.TabIndex = 8;
            this.cmdUserRolesSetting.Text = "User Roles Setting";
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
            this.cmdSave.Location = new System.Drawing.Point(707, 5);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(111, 35);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(186, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Default Password is password.";
            // 
            // chkIsActive
            // 
            this.chkIsActive.Location = new System.Drawing.Point(131, 135);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Properties.Appearance.Options.UseFont = true;
            this.chkIsActive.Properties.Caption = "IsActive";
            this.chkIsActive.Size = new System.Drawing.Size(75, 21);
            this.chkIsActive.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Login Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(133, 89);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Properties.Appearance.Options.UseFont = true;
            this.txtFullName.Size = new System.Drawing.Size(250, 28);
            this.txtFullName.TabIndex = 2;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(133, 44);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Properties.Appearance.Options.UseFont = true;
            this.txtUserID.Size = new System.Drawing.Size(250, 28);
            this.txtUserID.TabIndex = 1;
            // 
            // repositoryItemChkIsActive
            // 
            this.repositoryItemChkIsActive.AutoHeight = false;
            this.repositoryItemChkIsActive.Name = "repositoryItemChkIsActive";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // frmUser
            // 
            this.AcceptButton = this.cmdSave;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelButton = this.lblExit;
            this.ClientSize = new System.Drawing.Size(1044, 788);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEditUserRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemChkIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.LinkLabel lblExit;
		private System.Windows.Forms.Panel pnlUsers;
		private System.Windows.Forms.Panel panel2;
		private DevExpress.XtraEditors.SimpleButton cmdResetPassword;
		private DevExpress.XtraEditors.SimpleButton cmdSave;
		private System.Windows.Forms.Label label4;
		private DevExpress.XtraEditors.CheckEdit chkIsActive;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.TextEdit txtFullName;
		private DevExpress.XtraEditors.TextEdit txtUserID;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemChkIsActive;
		private DevExpress.XtraGrid.GridControl grdUsers;
		private DevExpress.XtraGrid.Views.Grid.GridView grdUsersView;
		private DevExpress.XtraGrid.Columns.GridColumn gridColUserID;
		private DevExpress.XtraGrid.Columns.GridColumn gridColGUID;
		private DevExpress.XtraGrid.Columns.GridColumn gridColUserName;
		private DevExpress.XtraGrid.Columns.GridColumn gridColFullName;
		private DevExpress.XtraGrid.Columns.GridColumn gridColIsActive;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
		private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEditUserRoles;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
		private DevExpress.XtraEditors.SimpleButton cmdUserRolesSetting;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
		private DevExpress.XtraEditors.SimpleButton cmdNew;
		private Controls.ZuluPictureControl zpcUserImage;
	}
}
