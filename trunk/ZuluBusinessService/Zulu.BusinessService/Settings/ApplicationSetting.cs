using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Infrastructure;

namespace Zulu.BusinessService.Settings
{
	/// <summary>
	/// Represents ApplicationSetting
	/// </summary>
	public partial class ApplicationSetting
	{
		public string ComapanyName
		{
			get
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.CompanyName");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.CompanyName", "Company Name", "Company Name");

				return setting.Value;
			}
			set
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.CompanyName");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.CompanyName", value, value);

				IoC.Resolve<ISettingService>().UpdateSetting(setting.SettingID, "AppSetting.CompanyName", value, value);
			}
		}

		public string Address1
		{
			get
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Address1");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Address1", "Address1", "Address1");

				return setting.Value;
			}
			set
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Address1");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Address1", value, value);

				IoC.Resolve<ISettingService>().UpdateSetting(setting.SettingID, "AppSetting.Address1", value, value);
			}
		}

		public string Address2
		{
			get
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Address2");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Address2", "Address2", "Address2");

				return setting.Value;
			}
			set
			{
				Setting setting = new Setting();

				setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Address2");

				if (setting == null || setting.SettingID == 0)
					setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Address2", value, value);

				IoC.Resolve<ISettingService>().UpdateSetting(setting.SettingID, "AppSetting.Address2", value, value);
			}
		}

		 public string Phone
		 {
			 get
			 {
				 Setting setting = new Setting();

				 setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Phone");

				 if (setting == null || setting.SettingID == 0)
					 setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Phone", "Phone", "Phone");

				 return setting.Value;
			 }
			 set
			 {
				 Setting setting = new Setting();

				 setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Phone");

				 if (setting == null || setting.SettingID == 0)
					 setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Phone", value, value);

				 IoC.Resolve<ISettingService>().UpdateSetting(setting.SettingID, "AppSetting.Phone", value, value);
			 }
		 }

		 public string Email
		 {
			 get
			 {
				 Setting setting = new Setting();

				 setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Email");

				 if (setting == null || setting.SettingID == 0)
					 setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Email", "Email", "Email");

				 return setting.Value;
			 }
			 set
			 {
				 Setting setting = new Setting();

				 setting = IoC.Resolve<ISettingService>().GetSettingByName("AppSetting.Email");

				 if (setting == null || setting.SettingID == 0)
					 setting = IoC.Resolve<ISettingService>().AddSetting("AppSetting.Email", value, value);

				 IoC.Resolve<ISettingService>().UpdateSetting(setting.SettingID, "AppSetting.Email", value, value);
			 }
		 }
	}
}
