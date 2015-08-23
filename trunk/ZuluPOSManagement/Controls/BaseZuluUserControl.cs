using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Logs;
using Zulu.BusinessService.Medias;
using Zulu.BusinessService.OrdersPurchases;
using Zulu.BusinessService.Products;
using Zulu.BusinessService.Settings;
using Zulu.BusinessService.Users;

namespace ZuluPOSManagement.Controls
{
	public partial class BaseZuluUserControl : UserControl
	{
		public IProductService ProductService
		{
			get { return IoC.Resolve<IProductService>(); }
		}

		public IMediaService MediaService
		{
			get { return IoC.Resolve<IMediaService>(); }
		}

		public ISettingService SettingService
		{
			get { return IoC.Resolve<ISettingService>(); }
		}

		public IUserService UserService
		{
			get { return IoC.Resolve<IUserService>(); }
		}

		public ILogService LogService
		{
			get { return IoC.Resolve<ILogService>(); }
		}

		public IPurchaseService PurchaseService
		{
			get { return IoC.Resolve<IPurchaseService>(); }
		}

	}
}
