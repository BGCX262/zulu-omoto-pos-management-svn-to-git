using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Users;

namespace Zulu.BusinessService.Data
{
	public partial class User
	{
		#region Custom Properties

		public string Password { get; set; }

		private List<UserAttribute> UserAttributes
		{
			get
			{
				return IoC.Resolve<IUserService>().GetAllUserAttributes(this.UserID);
			}
		}

		public string RestrictedButtons
		{
			get
			{
				var userAttributes = this.UserAttributes;

				UserAttribute restrictedForm = userAttributes.Where(c => c.UserID == this.UserID && c.AttributeKey == "restrictedbuttons").FirstOrDefault();

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

				UserAttribute userAttribute = new UserAttribute();

				userAttribute.UserID = this.UserID;
				userAttribute.AttributeKey = "restrictedbuttons";
				userAttribute.Value = value;

				IoC.Resolve<IUserService>().SaveUserAttributes(userAttribute);
			}
		}

		public string RestrictedForms
		{
			get
			{
				var userAttributes = this.UserAttributes;

				UserAttribute restrictedForm = userAttributes.Where(c => c.UserID == this.UserID && c.AttributeKey == "restrictedforms").FirstOrDefault();

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

				UserAttribute userAttribute = new UserAttribute();

				userAttribute.UserID = this.UserID;
				userAttribute.AttributeKey = "restrictedforms";
				userAttribute.Value = value;

				IoC.Resolve<IUserService>().SaveUserAttributes(userAttribute);
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
					
					if (AllFormControls == null)
						break;

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

				if (AllButtonControls != null)
				{
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
				return null;
			}
		}

		#endregion
	}
}
