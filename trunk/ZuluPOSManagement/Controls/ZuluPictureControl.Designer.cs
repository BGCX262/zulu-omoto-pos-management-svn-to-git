namespace ZuluPOSManagement.Controls
{
	partial class ZuluPictureControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtPicturePath = new DevExpress.XtraEditors.TextEdit();
			this.cmdBrowse = new DevExpress.XtraEditors.SimpleButton();
			this.picBox = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)(this.txtPicturePath.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
			this.lblDescription.Location = new System.Drawing.Point(17, 6);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(0, 21);
			this.lblDescription.TabIndex = 63;
			// 
			// txtPicturePath
			// 
			this.txtPicturePath.Location = new System.Drawing.Point(154, 2);
			this.txtPicturePath.Name = "txtPicturePath";
			this.txtPicturePath.Properties.Appearance.Font = new System.Drawing.Font("Zawgyi-One", 9.75F);
			this.txtPicturePath.Properties.Appearance.Options.UseFont = true;
			this.txtPicturePath.Size = new System.Drawing.Size(249, 28);
			this.txtPicturePath.TabIndex = 64;
			this.txtPicturePath.Click += new System.EventHandler(this.txtPicturePath_Click);
			// 
			// cmdBrowse
			// 
			this.cmdBrowse.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.cmdBrowse.Appearance.Options.UseFont = true;
			this.cmdBrowse.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
			this.cmdBrowse.Location = new System.Drawing.Point(404, 2);
			this.cmdBrowse.Name = "cmdBrowse";
			this.cmdBrowse.Size = new System.Drawing.Size(31, 29);
			this.cmdBrowse.TabIndex = 65;
			this.cmdBrowse.Text = "...";
			this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
			// 
			// picBox
			// 
			this.picBox.Location = new System.Drawing.Point(154, 37);
			this.picBox.Name = "picBox";
			this.picBox.Size = new System.Drawing.Size(102, 91);
			this.picBox.TabIndex = 66;
			// 
			// ZuluPictureControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.Controls.Add(this.picBox);
			this.Controls.Add(this.cmdBrowse);
			this.Controls.Add(this.txtPicturePath);
			this.Controls.Add(this.lblDescription);
			this.Name = "ZuluPictureControl";
			this.Size = new System.Drawing.Size(451, 132);
			((System.ComponentModel.ISupportInitialize)(this.txtPicturePath.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDescription;
		private DevExpress.XtraEditors.TextEdit txtPicturePath;
		private DevExpress.XtraEditors.SimpleButton cmdBrowse;
		private DevExpress.XtraEditors.PictureEdit picBox;
	}
}
