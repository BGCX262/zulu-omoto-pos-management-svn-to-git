using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Infrastructure;
using Zulu.BusinessService.Users;

namespace Zulu.BusinessService.Data
{
	/// <summary>
	/// Partial Class of Log
	/// </summary>
	public partial class Log
	{
		#region Custom Properties

		/// <summary>
		/// The whole user object which created the Log
		/// </summary>
		public User User
		{
			get
			{
				int userID = 0;
				int.TryParse(this.UserID.ToString(), out userID);

				return IoC.Resolve<IUserService>().GetUserByID(userID);
			}
		}

		#endregion
	}
}
