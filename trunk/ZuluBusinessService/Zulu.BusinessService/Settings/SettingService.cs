using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;
using Zulu.BusinessService.Util;

namespace Zulu.BusinessService.Settings
{
	/// <summary>
	/// Setting Service
	/// </summary>
	public partial class SettingService : ISettingService
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
		public SettingService(ZuluDataContext context)
		{
			this._context = context;
		}

		/// <summary>
		/// Ctor
		/// </summary>
		public SettingService()
		{

		}

		#endregion

		#region Method

		/// <summary>
		/// Gets a setting
		/// </summary>
		/// <param name="settingId">Setting identifer</param>
		/// <returns>Setting</returns>
		public Setting GetSettingById(int settingId)
		{
			if (settingId == 0)
				return null;

			var query = from s in _context.Settings
						where s.SettingID == settingId
						select s;
			var setting = query.SingleOrDefault();
			return setting;
		}

		/// <summary>
		/// Deletes a setting
		/// </summary>
		/// <param name="settingId">Setting identifer</param>
		public void DeleteSetting(int settingId)
		{
			var setting = GetSettingById(settingId);
			if (setting == null)
				return;

			if (!_context.IsAttached(setting))
				_context.Settings.Attach(setting);
			_context.DeleteObject(setting);
			_context.SaveChanges();
		}

		/// <summary>
		/// Gets all settings
		/// </summary>
		/// <returns>Setting collection</returns>
		public List<Setting> GetAllSettings()
		{

			var query = from s in _context.Settings
						orderby s.Name
						select s;
			var settings = query.ToList();

			return settings;
		}

		// <summary>
		/// Inserts/updates a param
		/// </summary>
		/// <param name="name">The name</param>
		/// <param name="value">The value</param>
		/// <returns>Setting</returns>
		public Setting SetParam(string name, string value)
		{
			var setting = GetSettingByName(name);
			if (setting != null)
				return SetParam(name, value, setting.Description);
			else
				return SetParam(name, value, string.Empty);
		}

		/// <summary>
		/// Inserts/updates a param
		/// </summary>
		/// <param name="name">The name</param>
		/// <param name="value">The value</param>
		/// <param name="description">The description</param>
		/// <returns>Setting</returns>
		public Setting SetParam(string name, string value, string description)
		{
			var setting = GetSettingByName(name);
			if (setting != null)
			{
				if (setting.Name != name || setting.Value != value || setting.Description != description)
					setting = UpdateSetting(setting.SettingID, name, value, description);
			}
			else
				setting = AddSetting(name, value, description);

			return setting;
		}

		/// <summary>
		/// Inserts/updates a param in US locale
		/// </summary>
		/// <param name="name">The name</param>
		/// <param name="value">The value</param>
		/// <returns>Setting</returns>
		public Setting SetParamNative(string name, decimal value)
		{
			return SetParamNative(name, value, string.Empty);
		}

		/// <summary>
		/// Inserts/updates a param in US locale
		/// </summary>
		/// <param name="name">The name</param>
		/// <param name="value">The value</param>
		/// <param name="description">The description</param>
		/// <returns>Setting</returns>
		public Setting SetParamNative(string name, decimal value, string description)
		{
			string valueStr = value.ToString(new CultureInfo("en-US"));
			return SetParam(name, valueStr, description);
		}

		/// <summary>
		/// Adds a setting
		/// </summary>
		/// <param name="name">The name</param>
		/// <param name="value">The value</param>
		/// <param name="description">The description</param>
		/// <returns>Setting</returns>
		public Setting AddSetting(string name, string value, string description)
		{
			name = ZuluHelper.EnsureNotNull(name);
			name = ZuluHelper.EnsureMaximumLength(name, 200);
			value = ZuluHelper.EnsureNotNull(value);
			value = ZuluHelper.EnsureMaximumLength(value, 2000);
			description = ZuluHelper.EnsureNotNull(description);
			
			var setting = _context.Settings.CreateObject();
			setting.Name = name;
			setting.Value = value;
			setting.Description = description;

			_context.Settings.AddObject(setting);
			_context.SaveChanges();

			return setting;
		}

		/// <summary>
		/// Updates a setting
		/// </summary>
		/// <param name="settingId">Setting identifier</param>
		/// <param name="name">The name</param>
		/// <param name="value">The value</param>
		/// <param name="description">The description</param>
		/// <returns>Setting</returns>
		public Setting UpdateSetting(int settingId, string name, string value, string description)
		{
			name = ZuluHelper.EnsureNotNull(name);
			name = ZuluHelper.EnsureMaximumLength(name, 200);
			value = ZuluHelper.EnsureNotNull(value);
			value = ZuluHelper.EnsureMaximumLength(value, 2000);
			description = ZuluHelper.EnsureNotNull(description);

			var setting = GetSettingById(settingId);
			if (setting == null)
				return null;

			if (!_context.IsAttached(setting))
				_context.Settings.Attach(setting);

			setting.Name = name;
			setting.Value = value;
			setting.Description = description;
			_context.SaveChanges();

			return setting;
		}

		/// <summary>
		/// Gets a boolean value of a setting
		/// </summary>
		/// <param name="name">The setting name</param>
		/// <returns>The setting value</returns>
		public bool GetSettingValueBoolean(string name)
		{
			return GetSettingValueBoolean(name, false);
		}

		/// <summary>
		/// Gets a boolean value of a setting
		/// </summary>
		/// <param name="name">The setting name</param>
		/// <param name="defaultValue">The default value</param>
		/// <returns>The setting value</returns>
		public bool GetSettingValueBoolean(string name, bool defaultValue)
		{
			string value = GetSettingValue(name);
			if (!String.IsNullOrEmpty(value))
			{
				return bool.Parse(value);
			}
			return defaultValue;
		}

		/// <summary>
		/// Gets an integer value of a setting
		/// </summary>
		/// <param name="name">The setting name</param>
		/// <returns>The setting value</returns>
		public int GetSettingValueInteger(string name)
		{
			return GetSettingValueInteger(name, 0);
		}

		/// <summary>
		/// Gets an integer value of a setting
		/// </summary>
		/// <param name="name">The setting name</param>
		/// <param name="defaultValue">The default value</param>
		/// <returns>The setting value</returns>
		public int GetSettingValueInteger(string name, int defaultValue)
		{
			string value = GetSettingValue(name);
			if (!String.IsNullOrEmpty(value))
			{
				return int.Parse(value);
			}
			return defaultValue;
		}

		/// <summary>
		/// Gets a long value of a setting
		/// </summary>
		/// <param name="name">The setting name</param>
		/// <returns>The setting value</returns>
		public long GetSettingValueLong(string name)
		{
			return GetSettingValueLong(name, 0);
		}

		/// <summary>
		///  Gets a long value of a setting
		/// </summary>
		/// <param name="name">The setting name</param>
		/// <param name="defaultValue">The default value</param>
		/// <returns>The setting value</returns>
		public long GetSettingValueLong(string name, int defaultValue)
		{
			string value = GetSettingValue(name);
			if (!String.IsNullOrEmpty(value))
			{
				return long.Parse(value);
			}
			return defaultValue;
		}

		/// <summary>
		/// Gets a decimal value of a setting in US locale
		/// </summary>
		/// <param name="name">The setting name</param>
		/// <returns>The setting value</returns>
		public decimal GetSettingValueDecimalNative(string name)
		{
			return GetSettingValueDecimalNative(name, decimal.Zero);
		}

		/// <summary>
		/// Gets a decimal value of a setting in US locale
		/// </summary>
		/// <param name="name">The setting name</param>
		/// <param name="defaultValue">The default value</param>
		/// <returns>The setting value</returns>
		public decimal GetSettingValueDecimalNative(string name, decimal defaultValue)
		{
			string value = GetSettingValue(name);
			if (!String.IsNullOrEmpty(value))
			{
				return decimal.Parse(value, new CultureInfo("en-US"));
			}
			return defaultValue;
		}

		/// <summary>
		/// Gets a setting value
		/// </summary>
		/// <param name="name">The setting name</param>
		/// <returns>The setting value</returns>
		public string GetSettingValue(string name)
		{
			var setting = GetSettingByName(name);
			if (setting != null)
				return setting.Value;
			return string.Empty;
		}

		/// <summary>
		/// Gets a setting value
		/// </summary>
		/// <param name="name">The setting name</param>
		/// <param name="defaultValue">The default value</param>
		/// <returns>The setting value</returns>
		public string GetSettingValue(string name, string defaultValue)
		{
			string value = GetSettingValue(name);
			if (!String.IsNullOrEmpty(value))
			{
				return value;
			}
			return defaultValue;
		}

		/// <summary>
		/// Get a setting by name
		/// </summary>
		/// <param name="name">The setting name</param>
		/// <returns>Setting instance</returns>
		public Setting GetSettingByName(string name)
		{
			if (String.IsNullOrEmpty(name))
				return null;

			return _context.Settings.FirstOrDefault(c => c.Name == name);
		}

		#endregion
	}
}
