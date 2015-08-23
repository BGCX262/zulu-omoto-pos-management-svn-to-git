using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zulu.BusinessService.Data;

namespace Zulu.BusinessService.Logs
{
	/// <summary>
	/// Log Service
	/// </summary>
	public partial class LogService : ILogService
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
		public LogService(ZuluDataContext context)
		{
			this._context = context;
		}

		#endregion

		#region Log

		/// <summary>
		/// Insert the log not editing
		/// </summary>
		/// <param name="log">Encapusulate Log Object</param>
		public void InsertLog(Log log)
		{
			Log existingData = GetLogByID(log.LogID);

			if (existingData == null)
				_context.Logs.AddObject(log);

			_context.SaveChanges();
		}

		/// <summary>
		/// Get the log by ID
		/// </summary>
		/// <param name="logID">Log ID</param>
		public Log GetLogByID(int logID)
		{
			return _context.Logs.FirstOrDefault(c => c.LogID == logID);
		}

		/// <summary>
		/// Get the logs by severity
		/// </summary>
		/// <param name="severity">Severity</param>
		public List<Log> GetLogBySeverity(int severity)
		{
			return _context.Logs.Where(c => c.Severity == severity).ToList();
		}

		/// <summary>
		/// Get the logs between start date and end date
		/// Please check that after adding some logs
		/// </summary>
		/// <param name="startDate">Start Date</param>
		/// <param name="endDate">End Date</param>
		public List<Log> getLogByDate(DateTime startDate, DateTime endDate)
		{
			return _context.Logs.Where(c => c.CreatedOn >= startDate && c.CreatedOn <= endDate).ToList();
		}

		#endregion
	}
}
