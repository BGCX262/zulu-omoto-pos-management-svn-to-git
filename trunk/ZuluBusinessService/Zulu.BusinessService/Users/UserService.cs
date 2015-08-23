using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Infrastructure;

namespace Zulu.BusinessService.Users
{
	/// <summary>
	/// User Service
	/// </summary>
	public partial class UserService : IUserService
	{
		#region Fields

		/// <summary>
		/// Object context
		/// </summary>
		private readonly ZuluDataContext _context;

		#endregion

		#region Ctor

		/// <summary>
		/// Ctor
		/// </summary>
		/// <param name="context">Object context</param>
		public UserService(ZuluDataContext context)
		{
			this._context = context;
		}

		#endregion

		#region User

		/// <summary>
		/// Get user by user identifier
		/// </summary>
		/// <param name="userID">User Identifier</param>
		/// <returns>user</returns>
		public User GetUserByID(int userID)
		{
			return _context.Users.FirstOrDefault(c => c.UserID == userID);
		}

		/// <summary>
		/// Get user by user globally unique identifier
		/// </summary>
		/// <param name="userGUID">User globally unique identifier</param>
		/// <returns>user</returns>
		public User GetUserByGUID(string userGUID)
		{
			Guid UserGUID = Guid.NewGuid();

			return _context.Users.FirstOrDefault(c => c.UserGUID == UserGUID);
		}

		/// <summary>
		/// Get All User 
		/// </summary>
		/// <param name="username">Username</param>
		/// <returns>User</returns>
		public User GetUserByUserName(string UserName)
		{
			return _context.Users.FirstOrDefault(c => c.Username == UserName);
		}

		/// <summary>
		/// Get all user 
		/// </summary>
		/// <returns>User</returns>
		public List<User> GetAllUsers()
		{
			return _context.Users.ToList();
		}

		/// <summary>
		/// Save user for both Insert and Update purpose 
		/// </summary>
		/// <param name="user">User</param>
		public bool SaveUser(User user)
		{
			string saltKey = CreateSalt(7);
			user.Salt = saltKey;
			user.PasswordHash = GetSHA1HashData(user.Password, saltKey);

			User existingData = new User();
			existingData = GetUserByUserName(user.Username);

			if (existingData != null && existingData.UserID != user.UserID)
			{
				if (existingData.UserID != 0)
					return false;
			}

			existingData = GetUserByID(user.UserID);

			if (existingData == null)
			{
				user.UserGUID = Guid.NewGuid();
				user.CreatedOn = System.DateTime.Now;
				user.UpdatedOn = System.DateTime.Now;

				_context.Users.AddObject(user);
			}
			else
			{
				existingData.UserGUID = Guid.NewGuid();
				existingData.UserRoleID = user.UserRoleID;
				existingData.PictureID = user.PictureID;
				existingData.FullName = user.FullName;
				existingData.Gender = user.Gender;
				existingData.NRCNumber = user.NRCNumber;
				existingData.Username = user.Username;
				existingData.PasswordHash = user.PasswordHash;
				existingData.Salt = user.Salt;
				existingData.AddressID = user.AddressID;
				existingData.IsActive = user.IsActive;
				existingData.CreatedOn = user.CreatedOn;
				existingData.UpdatedOn = System.DateTime.Now;

				if (!_context.IsAttached(existingData))
					_context.Users.Attach(existingData);
			}
			_context.SaveChanges();

			return true;
		}

		/// <summary>
		/// Get all active user 
		/// </summary>
		/// <returns>User</returns>
		public List<User> GetAllActiveUser()
		{
			return _context.Users.Where(c => c.IsActive == true).ToList();
		}

		/// <summary>
		/// Get all users 
		/// </summary>
		/// <param name="isActive">Is Active</param>
		/// <returns>User</returns>
		public List<User> GetAllUsers(bool isActive)
		{
			return _context.Users.Where(c => c.IsActive == isActive).ToList();
		}

		/// <summary>
		/// Get verification of User 
		/// </summary>
		/// <param name="username">Username</param>
		/// <param name="password">Password</param>
		/// <returns>boolean</returns>
		public bool VerifyUser(string userName, string password)
		{
			User user = GetUserByUserName(userName);

			if (user == null)
				user = GetUserByGUID(userName);

			if (user == null || user.IsActive == false)
				return false;

			string passwordHash = GetSHA1HashData(password, user.Salt);
			bool validate = passwordHash == user.PasswordHash;

			if (validate)
				ZuluContext.Current.CurrentUser = user;

			return validate;
		}

		/// <summary>
		/// Change password 
		/// </summary>
		/// <param name="username">Username</param>
		/// <param name="oldpassword">Old Password</param>
		/// <param name="newpassword">New Password</param>
		/// <returns>boolean</returns>
		public bool ChangePassword(int userID, string oldPassword, string newPassword)
		{
			User user = GetUserByID(userID);

			if (user == null)
				return false;

			string passwordHash = GetSHA1HashData(oldPassword, user.Salt);
			bool validate = passwordHash == user.PasswordHash;

			if (validate)
			{
				string saltKey = CreateSalt(7);

				//Getting Encrypted password
				user.Salt = saltKey;
				user.PasswordHash = GetSHA1HashData(newPassword, saltKey);

				if (!_context.IsAttached(user))
					_context.Users.Attach(user);

				_context.SaveChanges();
				return true;
			}

			return false;
		}

		/// <summary>
		/// Reset password 
		/// </summary>
		/// <param name="userGUID">User GUID</param>
		/// <param name="newpassword">New Password</param>
		/// <returns>boolean</returns>
		public bool ResetPassword(int userID, string newPassword)
		{
			User user = GetUserByID(userID);

			if (user == null)
				return false;

			try
			{
				string saltKey = CreateSalt(7);

				user.Salt = saltKey;
				user.PasswordHash = GetSHA1HashData(newPassword, saltKey);
				if (!_context.IsAttached(user))
					_context.Users.Attach(user);

				_context.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				Log log = new Log();
				return false;
			}
		}

		/// <summary>
		/// Deactivate Product Variant By Product Variant ID. 
		/// </summary>
		/// <param name="productVariantID">The product variant identifier</param>
		public void DeactivateUser(int userID)
		{
			if (userID == 0)
				return;

			User user = GetUserByID(userID);
			if (user == null && (bool)!user.IsActive)
				return;

			user.IsActive = false;
			user.UpdatedOn = DateTime.Now;

			SaveUser(user);
		}

		/// <summary>
		/// Activate Product Variant By Product Variant ID. 
		/// </summary>
		/// <param name="userID">The product variant identifier</param>
		public void ActivateUser(int userID)
		{
			if (userID == 0)
				return;

			User user = GetUserByID(userID);
			if (user == null && (bool)user.IsActive)
				return;

			user.IsActive = true;
			user.UpdatedOn = DateTime.Now;

			SaveUser(user);
		}

		/// <summary>
		/// Get All User by User Role ID 
		/// </summary>
		/// <param name="userRoleID">User Role Identifier</param>
		/// <returns>Users</returns>
		public List<User> GetAllUserByUserRoleID(int userRoleID)
		{
			return _context.Users.Where(c => c.UserRoleID == userRoleID).ToList();
		}

		#endregion

		#region UserRole

		/// <summary>
		/// Get User Role by User Role ID 
		/// </summary>
		/// <param name="userRoleID">User Role Identifier</param>
		/// <returns>UserRole</returns>
		public UserRole GetUserRoleByID(int userRoleID)
		{
			return _context.UserRoles.FirstOrDefault(c => c.UserRoleID == userRoleID);
		}

		/// <summary>
		/// Get User Role by User Role Name 
		/// </summary>
		/// <param name="userRoleName">User Role Name</param>
		/// <returns>UserRole</returns>
		public UserRole GetUserRoleByID(string userRoleName)
		{
			return _context.UserRoles.FirstOrDefault(c => c.Name == userRoleName);
		}

		/// <summary>
		/// Get User Role by User Role ID 
		/// </summary>
		/// <returns>UserRoles</returns>
		public List<UserRole> GetAllUserRoles()
		{
			return _context.UserRoles.ToList();
		}

		/// <summary>
		/// Get All User Roles
		/// </summary>
		/// <returns>UserRoles</returns>
		public List<UserRole> GetAllUserRoles(bool isActive)
		{
			return _context.UserRoles.Where(c => c.IsActive == isActive).ToList();
		}

		/// <summary>
		/// Get all Active User Role 
		/// </summary>
		/// <returns>UserRoles</returns>
		public List<UserRole> GetAllActiveUserRoles()
		{
			return _context.UserRoles.Where(c => c.IsActive == true).ToList();
		}

		/// <summary>
		/// Save user role 
		/// </summary>
		/// <param name="user">User</param>
		public bool SaveUserRole(UserRole userRole)
		{
			UserRole existingData = new UserRole();

			if (existingData != null && existingData.UserRoleID != userRole.UserRoleID)
			{
				if (existingData.UserRoleID != 0)
					return false;
			}

			existingData = GetUserRoleByID(userRole.UserRoleID);

			if (existingData == null)
			{
				userRole.CreatedOn = System.DateTime.Now;
				userRole.UpdatedOn = System.DateTime.Now;
				_context.UserRoles.AddObject(userRole);
			}
			else
			{
				existingData.Name = userRole.Name;
				existingData.IsActive = userRole.IsActive;
				existingData.CreatedOn = userRole.CreatedOn;
				existingData.UpdatedOn = System.DateTime.Now;

				if (!_context.IsAttached(existingData))
					_context.UserRoles.Attach(existingData);
			}
			_context.SaveChanges();

			return true;
		}

		#endregion

		#region Custom Methods

		/// <summary>
		/// Get SHA1 Encripted Data
		/// </summary>
		/// <param name="password">Password</param>
		/// <param name="Salt">Salt</param>
		/// <returns>string</returns>
		private string GetSHA1HashData(string password, string salt)
		{
			string dataToHash = password + salt;

			SHA1 sha1 = SHA1.Create();
			byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(dataToHash));
			StringBuilder returnValue = new StringBuilder();

			for (int i = 0; i < hashData.Length; i++)
			{
				returnValue.Append(hashData[i].ToString());
			}

			return returnValue.ToString();
		}

		/// <summary>
		/// Get Password Salt
		/// </summary>
		/// <param name="size">Size</param>
		/// <returns>string</returns>
		private string CreateSalt(int size)
		{
			var provider = new RNGCryptoServiceProvider();
			byte[] data = new byte[size];
			provider.GetBytes(data);
			return Convert.ToBase64String(data);
		}

		#endregion

		#region UserAttribute

		/// <summary>
		/// Get User Attribute By identifier
		/// </summary>
		/// <param name="userAttributeID">User Attribute Identifier</param>
		/// <returns>UserAttribute</returns>
		public UserAttribute GetUserAttributeByID(int userAttributeID)
		{
			return _context.UserAttributes.FirstOrDefault(c => c.UserAttributeID == userAttributeID);
		}

		/// <summary>
		/// Get User Attribute by User Idntifier and Key
		/// </summary>
		/// <param name="userID">User Identifier</param>
		/// <param name="key">Key</param>
		/// <returns>UserAttribute</returns>
		public UserAttribute GetUserAttributeByUserIDAndKey(int userID, string key)
		{
			return _context.UserAttributes.FirstOrDefault(c => c.UserID == userID && c.AttributeKey == key);
		}

		/// <summary>
		/// Get User Attributes by User Identifier
		/// </summary>
		/// <param name="userID">User Identifier</param>
		/// <returns>UserAttributes</returns>
		public List<UserAttribute> GetAllUserAttributes(int userID)
		{
			return _context.UserAttributes.Where(c => c.UserID == userID).ToList();
		}

		/// <summary>
		/// Save User Attributes
		/// </summary>
		/// <param name="userAttribute">User Attribute Object</param>
		public void SaveUserAttributes(UserAttribute userAttribute)
		{
			int useID = 0;
			int.TryParse(userAttribute.UserID.ToString(), out useID);

			UserAttribute existingData = GetUserAttributeByUserIDAndKey(useID, userAttribute.AttributeKey);

			if (existingData == null)
				_context.UserAttributes.AddObject(userAttribute);
			else
			{
				existingData.Value = userAttribute.Value;

				if (!_context.IsAttached(existingData))
					_context.UserAttributes.Attach(existingData);
			}

			_context.SaveChanges();
		}

		#endregion

		#region UserRole Attribute

		/// <summary>
		/// Get User Role Attribute by User Role Attribute Identifier
		/// </summary>
		/// <param name="userRoleAttributeID">User Role Attribute Identifier</param>
		/// <returns>userRoleAttribute</returns>
		public UserRoleAttribute GetUserRoleAttributeByID(int userRoleAttributeID)
		{
			return _context.UserRoleAttributes.FirstOrDefault(c => c.UserRoleAttributeID == userRoleAttributeID);
		}

		/// <summary>
		/// Get User Role Attribute By User ID and Key
		/// </summary>
		/// <param name="userRoleID">User Role Identifier</param>
		/// <param name="key">Key</param>
		/// <returns>User Role Attribute</returns>
		public UserRoleAttribute GetUserRoleAttributeByUserIDAndKey(int userRoleID, string key)
		{
			return _context.UserRoleAttributes.FirstOrDefault(c => c.UserRoleID == userRoleID && c.AttributeKey == key);
		}

		/// <summary>
		/// Get All user Role Attributes by User Role Identifier
		/// </summary>
		/// <param name="userRoleID">User Role Identifier</param>
		/// <returns>UserRoleAttribute</returns>
		public List<UserRoleAttribute> GetAllUserRoleAttributesByUserRoleID(int userRoleID)
		{
			return _context.UserRoleAttributes.Where(c => c.UserRoleID == userRoleID).ToList();
		}

		/// <summary>
		/// Save User Role Attribute
		/// </summary>
		/// <param name="userRoleAttribute">User Role Attribute Object</param>
		public void SaveUserRoleAttributes(UserRoleAttribute userRoleAttribute)
		{
			int useID = 0;
			int.TryParse(userRoleAttribute.UserRoleID.ToString(), out useID);

			UserRoleAttribute existingData = GetUserRoleAttributeByUserIDAndKey(useID, userRoleAttribute.AttributeKey);

			if (existingData == null)
				_context.UserRoleAttributes.AddObject(userRoleAttribute);
			else
			{
				existingData.Value = userRoleAttribute.Value;

				if (!_context.IsAttached(existingData))
					_context.UserRoleAttributes.Attach(existingData);
			}

			_context.SaveChanges();
		}
		#endregion
	}
}
