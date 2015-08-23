using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.Logs
{
	/// <summary>
	/// Log Service Interface
	/// </summary>
	public partial interface ILogService
	{
		#region Log
		/// <summary>
		/// Insert the log not editing
		/// </summary>
		/// <param name="log">Encapusulate Log Object</param>
		void InsertLog(Log log);

		/// <summary>
		/// Get the log by ID
		/// </summary>
		/// <param name="logID">Log ID</param>
		Log GetLogByID(int logID);

		/// <summary>
		/// Get the logs by severity
		/// </summary>
		/// <param name="severity">Severity</param>
		List<Log> GetLogBySeverity(int severity);

		/// <summary>
		/// Get the logs between start date and end date
		/// Please check that after adding some logs
		/// </summary>
		/// <param name="startDate">Start Date</param>
		/// <param name="endDate">End Date</param>
		List<Log> getLogByDate(DateTime startDate, DateTime endDate);
		#endregion
	}
}
