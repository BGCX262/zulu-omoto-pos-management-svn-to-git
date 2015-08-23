using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.Users
{
	/// <summary>
	/// User Service Interface
	/// </summary>
	public partial interface IUserService
	{
		#region User

		/// <summary>
		/// Get user by user identifier
		/// </summary>
		/// <param name="userID">User Identifier</param>
		/// <returns>User</returns>
		User GetUserByID(int userID);

		/// <summary>
		/// Get user by user globally unique identifier
		/// </summary>
		/// <param name="userGUID">User globally unique identifier</param>
		/// <returns>User</returns>
		User GetUserByGUID(string userGUID);

		/// <summary>
		/// Get user by username 
		/// </summary>
		/// <param name="username">Username</param>
		/// <returns>User</returns>
		User GetUserByUserName(string username);

		/// <summary>
		/// Get all user 
		/// </summary>
		/// <returns>User</returns>
		List<User> GetAllUsers();

		/// <summary>
		/// Save user for both Insert and Update purpose 
		/// </summary>
		/// <param name="user">User</param>
		bool SaveUser(User user);

		/// <summary>
		/// Get all active users 
		/// </summary>
		/// <returns>Users</returns>
		List<User> GetAllActiveUser();

		/// <summary>
		/// Get all users by passing isActive parameter 
		/// </summary>
		/// <param name="isActive">Is Active</param>
		/// <returns>Users</returns>
		List<User> GetAllUsers(bool isActive);

		/// <summary>
		/// Get verification of User 
		/// </summary>
		/// <param name="username">Username</param>
		/// <param name="password">Password</param>
		/// <returns>boolean</returns>
		bool VerifyUser(string username, string password);

		/// <summary>
		/// Change password 
		/// </summary>
		/// <param name="userGUID">User GUID</param>
		/// <param name="oldpassword">Old Password</param>
		/// <param name="newpassword">New Password</param>
		/// <returns>boolean</returns>
		bool ChangePassword(int userID, string oldPassword, string newPassword);

		/// <summary>
		/// Reset password 
		/// </summary>
		/// <param name="userGUID">User GUID</param>
		/// <param name="newpassword">New Password</param>
		/// <returns>boolean</returns>
		bool ResetPassword(int userID, string newPassword);

		/// <summary>
		/// Deactivate user by user idenitifier. 
		/// </summary>
		/// <param name="userID">The user identifier</param>
		void DeactivateUser(int userID);

		/// <summary>
		/// Activate user by user idenitifier. 
		/// </summary>
		/// <param name="userID">The user identifier</param>
		void ActivateUser(int userID);

		/// <summary>
		/// Get All User by User Role ID 
		/// </summary>
		/// <param name="userRoleID">User Role Identifier</param>
		/// <returns>Users</returns>
		List<User> GetAllUserByUserRoleID(int userRoleID);

		#endregion

		#region UserRole

		/// <summary>
		/// Get User Role by User Role ID 
		/// </summary>
		/// <param name="userRoleID">User Role Identifier</param>
		/// <returns>UserRole</returns>
		UserRole GetUserRoleByID(int userRoleID);

		/// <summary>
		/// Get User Role by User Role Name 
		/// </summary>
		/// <param name="userRoleName">User Role Name</param>
		/// <returns>UserRole</returns>
		UserRole GetUserRoleByID(string userRoleName);

		/// <summary>
		/// Get All User Roles
		/// </summary>
		/// <returns>UserRoles</returns>
		List<UserRole> GetAllUserRoles();

		/// <summary>
		/// Get all User Role by active or not
		/// </summary>
		/// <param name="isActive">Is Active</param>
		/// <returns>UserRoles</returns>
		List<UserRole> GetAllUserRoles(bool isActive);

		/// <summary>
		/// Get all Active User Role 
		/// </summary>
		/// <returns>UserRoles</returns>
		List<UserRole> GetAllActiveUserRoles();

		/// <summary>
		/// Save user role 
		/// </summary>
		/// <param name="user">User</param>
		bool SaveUserRole(UserRole userRole);

		#endregion

		#region UserAttribute

		/// <summary>
		/// Get User Attribute By identifier
		/// </summary>
		/// <param name="userAttributeID">User Attribute Identifier</param>
		/// <returns>UserAttribute</returns>
		UserAttribute GetUserAttributeByID(int userAttributeID);

		/// <summary>
		/// Get User Attribute by User Idntifier and Key
		/// </summary>
		/// <param name="userID">User Identifier</param>
		/// <param name="key">Key</param>
		/// <returns>UserAttribute</returns>
		UserAttribute GetUserAttributeByUserIDAndKey(int userID, string key);

		/// <summary>
		/// Get User Attributes by User Identifier
		/// </summary>
		/// <param name="userID">User Identifier</param>
		/// <returns>UserAttributes</returns>
		List<UserAttribute> GetAllUserAttributes(int userID);
		
		/// <summary>
		/// Save User Attributes
		/// </summary>
		/// <param name="userAttribute">User Attribute Object</param>
		void SaveUserAttributes(UserAttribute userAttribute);
		

		#endregion

		#region UserRoleAttribute

		/// <summary>
		/// Get User Role Attribute by User Role Attribute Identifier
		/// </summary>
		/// <param name="userRoleAttributeID">User Role Attribute Identifier</param>
		/// <returns>userRoleAttribute</returns>
		UserRoleAttribute GetUserRoleAttributeByID(int userRoleAttributeID);

		/// <summary>
		/// Get User Role Attribute By User ID and Key
		/// </summary>
		/// <param name="userRoleID">User Role Identifier</param>
		/// <param name="key">Key</param>
		/// <returns>User Role Attribute</returns>
		UserRoleAttribute GetUserRoleAttributeByUserIDAndKey(int userRoleID, string key);

		/// <summary>
		/// Get All user Role Attributes by User Role Identifier
		/// </summary>
		/// <param name="userRoleID">User Role Identifier</param>
		/// <returns>UserRoleAttribute</returns>
		List<UserRoleAttribute> GetAllUserRoleAttributesByUserRoleID(int userRoleID);

		/// <summary>
		/// Save User Role Attribute
		/// </summary>
		/// <param name="userRoleAttribute">User Role Attribute Object</param>
		void SaveUserRoleAttributes(UserRoleAttribute userRoleAttribute);

		#endregion
	}
}
