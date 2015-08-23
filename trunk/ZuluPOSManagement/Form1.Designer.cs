namespace ZuluPOSManagement
{
	partial class Form1
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
            this.zpcTesting = new ZuluPOSManagement.Controls.ZuluPictureControl();
            this.button1 = new System.Windows.Forms.Button();
            this.customPictureControl = new ZuluPOSManagement.Controls.TestPictureControl();
            this.SuspendLayout();
            // 
            // zpcTesting
            // 
            this.zpcTesting.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.zpcTesting.Location = new System.Drawing.Point(87, 58);
            this.zpcTesting.Name = "zpcTesting";
            this.zpcTesting.Size = new System.Drawing.Size(464, 153);
            this.zpcTesting.TabIndex = 0;
            this.zpcTesting.Text = "Product Image";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customPictureControl
            // 
            this.customPictureControl.Location = new System.Drawing.Point(126, 217);
            this.customPictureControl.Name = "customPictureControl";
            this.customPictureControl.Size = new System.Drawing.Size(141, 146);
            this.customPictureControl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 401);
            this.Controls.Add(this.customPictureControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zpcTesting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private Controls.ZuluPictureControl zpcTesting;
		private System.Windows.Forms.Button button1;
		private Controls.TestPictureControl customPictureControl;

	}
}

