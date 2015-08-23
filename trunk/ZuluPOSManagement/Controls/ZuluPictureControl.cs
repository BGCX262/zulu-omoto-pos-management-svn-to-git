using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Net.Mime;
using Zulu.BusinessService.Util;
using Zulu.BusinessService.Data;

namespace ZuluPOSManagement.Controls
{
	public partial class ZuluPictureControl : BaseZuluUserControl
	{
		string imageLocation = string.Empty;
		byte[] imageBinary;
		int _pictureID;

		public ZuluPictureControl()
		{
			InitializeComponent();
		}

		private void txtPicturePath_Click(object sender, EventArgs e)
		{
			OpenFileDialogue();
		}

		private void cmdBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialogue();
		}

		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Bindable(true)]
		public override string Text
		{
			set { lblDescription.Text = value; }
			get { return lblDescription.Text; }
		}

		private void OpenFileDialogue()
		{
			OpenFileDialog ofDImageBrowser = new OpenFileDialog();

			ofDImageBrowser.Filter = "Image files (*.jpg, *.jpeg, *.tiff, *.png, *.gif) | *.jpg; *.jpeg; *.tiff; *.png; *.gif";
			ofDImageBrowser.FilterIndex = 1;
			ofDImageBrowser.ShowDialog();

			imageLocation = ofDImageBrowser.FileName;
			txtPicturePath.Text = imageLocation;

			if(!string.IsNullOrEmpty(imageLocation))
			{
				 picBox.Image = MediaService.LoadImage(imageLocation, 102, out imageBinary);
			}
		}

		public int SavePicture()
		{
			if (!string.IsNullOrEmpty(imageLocation))
			{
				FileInfo filename = new FileInfo(imageLocation);
				Media media = MediaService.InsertMedia(imageBinary, ZuluHelper.GetContentType(filename.Extension), true);
				txtPicturePath.Text = string.Empty;
				imageLocation = string.Empty;
				imageBinary = null;

				return media.MediaID;
			}
			if (_pictureID > 0)
				return _pictureID;
			return 0;
		}

		public void LoadPicture(int pictureID)
		{
            string imageLocation = MediaService.GetMediaUrl(pictureID, 102);
            Bitmap bitmap = new Bitmap(imageLocation);
            picBox.Image = bitmap;
            _pictureID = pictureID;
		}

		public void ClearPicture()
		{
			picBox.Image = null;
			_pictureID = 0;
		}
	}
}
