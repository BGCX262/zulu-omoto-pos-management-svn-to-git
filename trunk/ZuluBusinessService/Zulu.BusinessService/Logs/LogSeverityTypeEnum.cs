using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zulu.BusinessService.Logs
{
	/// <summary>
	/// Log Type Enum
	/// </summary>
	public enum LogSeverityTypeEnum : int
	{
		/// <summary>
		/// Unknown
		/// </summary>
		Unknown = 1,

		/// <summary>
		/// User update
		/// </summary>
		UserUpdate = 2,

		/// <summary>
		/// User Error
		/// </summary>
		UserError = 3,

		/// <summary>
		/// System Crash
		/// </summary>
		SystemCrash = 4
	}
}
