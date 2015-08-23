using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Users;

namespace Zulu.BusinessService.Data
{
	public partial class UserRole
	{
		#region Custom Properties

		public List<User> Users
		{
			get
			{
				return IoC.Resolve<IUserService>().GetAllUserByUserRoleID(this.UserRoleID);
			}
		}

		public List<UserRoleAttribute> UserRoleAttributes
		{
			get
			{
				return IoC.Resolve<IUserService>().GetAllUserRoleAttributesByUserRoleID(this.UserRoleID);
			}
		}

		public string RestrictedButtons
		{
			get
			{
				var userRoleAttributes = this.UserRoleAttributes;

				UserRoleAttribute restrictedForm = userRoleAttributes.Where(c => c.UserRoleID == this.UserRoleID && c.AttributeKey == "restrictedbuttons").FirstOrDefault();

				if (restrictedForm != null)
					return restrictedForm.Value;
				else
					return string.Empty;
			}
			set
			{
				if (value == null)
					value = string.Empty;
				value = value.Trim();

				UserRoleAttribute userRoleAttribute = new UserRoleAttribute();

				userRoleAttribute.UserRoleID = this.UserRoleID;
				userRoleAttribute.AttributeKey = "restrictedbuttons";
				userRoleAttribute.Value = value;

				IoC.Resolve<IUserService>().SaveUserRoleAttributes(userRoleAttribute);
			}
		}

		public string RestrictedForms
		{
			get
			{
				var userRoleAttributes = this.UserRoleAttributes;

				UserRoleAttribute restrictedForm = userRoleAttributes.Where(c => c.UserRoleID == this.UserRoleID && c.AttributeKey == "restrictedforms").FirstOrDefault();

				if (restrictedForm != null)
					return restrictedForm.Value;
				else
					return string.Empty;
			}
			set
			{
				if (value == null)
					value = string.Empty;
				value = value.Trim();

				UserRoleAttribute userRoleAttribute = new UserRoleAttribute();

				userRoleAttribute.UserRoleID = this.UserRoleID;
				userRoleAttribute.AttributeKey = "restrictedforms";
				userRoleAttribute.Value = value;

				IoC.Resolve<IUserService>().SaveUserRoleAttributes(userRoleAttribute);
			}
		}

		public List<FormControl> RestrictedFormControls
		{
			get
			{
				List<FormControl> AllFormControls = ZuluContext.Current.FormControls;
				List<FormControl> RestrictedFormControls = new List<FormControl>();

				List<string> RestrictedFormList = RestrictedForms.Split(',').ToList();

				foreach (string RestrictedFormString in RestrictedFormList)
				{
					int restrictedFormID = 0;
					int.TryParse(RestrictedFormString, out restrictedFormID);

					FormControl formControl = AllFormControls.FirstOrDefault(c => c.FormID == restrictedFormID);

					if (formControl != null)
						RestrictedFormControls.Add(formControl);
				}
				return RestrictedFormControls;
			}
		}

		public List<ButtonControl> RestrictedButtonControls
		{
			get
			{
				List<ButtonControl> AllButtonControls = ZuluContext.Current.ButtonControls;
				List<ButtonControl> RestrictedButtonControls = new List<ButtonControl>();

				List<string> RestrictedButtonList = RestrictedButtons.Split(',').ToList();

				foreach (string RestrictedButtonString in RestrictedButtonList)
				{
					int restrictedButtonID = 0;
					int.TryParse(RestrictedButtonString, out restrictedButtonID);

					ButtonControl buttonControl = AllButtonControls.FirstOrDefault(c => c.ButtonID == restrictedButtonID);

					if (buttonControl != null)
						RestrictedButtonControls.Add(buttonControl);
				}
				return RestrictedButtonControls;
			}
		}

		#endregion
	}
}
