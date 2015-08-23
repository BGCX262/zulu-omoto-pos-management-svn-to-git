namespace ZuluPOSManagement.Controls
{
	partial class TestPictureControl
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
			this.picBoxTest = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBoxTest)).BeginInit();
			this.SuspendLayout();
			// 
			// picBoxTest
			// 
			this.picBoxTest.Location = new System.Drawing.Point(0, 0);
			this.picBoxTest.Name = "picBoxTest";
			this.picBoxTest.Size = new System.Drawing.Size(147, 150);
			this.picBoxTest.TabIndex = 0;
			this.picBoxTest.TabStop = false;
			// 
			// TestPictureControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.picBoxTest);
			this.Name = "TestPictureControl";
			((System.ComponentModel.ISupportInitialize)(this.picBoxTest)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picBoxTest;
	}
}
