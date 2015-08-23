using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZuluPOSManagement.Controls
{
	public partial class TestPictureControl : BaseZuluUserControl
	{
		public TestPictureControl()
		{
			InitializeComponent();
		}

		public string LoadPicture(int pictureID)
		{
			picBoxTest.Load(MediaService.GetMediaUrl(pictureID,250));

			return MediaService.GetMediaUrl(pictureID);
		}
	}
}
