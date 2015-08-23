using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zulu.BusinessService.Data
{
	public static class Extensions
	{
		// Determines whether record is attached
		/// </summary>
		/// <param name="context">Context</param>
		/// <param name="entity">Entity</param>
		/// <returns>Result</returns>
		public static bool IsAttached(this ObjectContext context, object entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException("entity");
			}
			ObjectStateEntry entry;
			try
			{
				entry = context.ObjectStateManager.GetObjectStateEntry(entity);
				return (entry.State != EntityState.Detached);
			}
			catch (Exception exc)
			{
				Debug.WriteLine(exc.ToString());
			}
			return false;
		}
	}
}
