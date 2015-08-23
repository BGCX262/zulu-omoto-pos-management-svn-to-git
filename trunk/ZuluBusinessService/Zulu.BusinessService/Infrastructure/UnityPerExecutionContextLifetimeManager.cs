using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Zulu.BusinessService.Infrastructure
{
	public partial class UnityPerExecutionContextLifetimeManager : LifetimeManager
	{
		#region Nested

		/// <summary>
		/// Custom extension for OperationContext scope
		/// </summary>
		class ContainerExtension : IExtension<OperationContext>
		{
			#region Members

			/// <summary>
			/// Value
			/// </summary>
			public object Value { get; set; }

			#endregion

			#region IExtension<OperationContext> Members

			/// <summary>
			/// Attach
			/// </summary>
			/// <param name="owner">Operation context</param>
			public void Attach(OperationContext owner)
			{

			}

			/// <summary>
			/// Detach
			/// </summary>
			/// <param name="owner">Operation context</param>
			public void Detach(OperationContext owner)
			{

			}

			#endregion
		}
		#endregion

		#region Members

		Guid _key;

		#endregion

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public UnityPerExecutionContextLifetimeManager() : this(Guid.NewGuid()) { }

		/// <summary>
		///  Constructor
		/// </summary>
		/// <param name="key">A key for this lifetimemanager resolver</param>
		UnityPerExecutionContextLifetimeManager(Guid key)
		{
			if (key == Guid.Empty)
				throw new ArgumentException("Key cannot be empty");

			_key = key;
		}
		#endregion

		#region ILifetimeManager Members

		/// <summary>
		/// <see cref="M:Microsoft.Practices.Unity.LifetimeManager.GetValue"/>
		/// </summary>
		/// <returns><see cref="M:Microsoft.Practices.Unity.LifetimeManager.GetValue"/></returns>
		public override object GetValue()
		{
			object result = null;

			if (OperationContext.Current != null)
			{
				//WCF without HttpContext environment
				ContainerExtension containerExtension = OperationContext.Current.Extensions.Find<ContainerExtension>();
				if (containerExtension != null)
				{
					result = containerExtension.Value;
				}
			}

			return result;
		}
		/// <summary>
		/// <see cref="M:Microsoft.Practices.Unity.LifetimeManager.RemoveValue"/>
		/// </summary>
		public override void RemoveValue()
		{
			if (OperationContext.Current != null)
			{
				//WCF without HttpContext environment
				ContainerExtension containerExtension = OperationContext.Current.Extensions.Find<ContainerExtension>();
				if (containerExtension != null)
					OperationContext.Current.Extensions.Remove(containerExtension);

			}
		}

		/// <summary>
		/// <see cref="M:Microsoft.Practices.Unity.LifetimeManager.SetValue"/>
		/// </summary>
		/// <param name="newValue"><see cref="M:Microsoft.Practices.Unity.LifetimeManager.SetValue"/></param>
		public override void SetValue(object newValue)
		{

			if (OperationContext.Current != null)
			{
				//WCF without HttpContext environment
				ContainerExtension containerExtension = OperationContext.Current.Extensions.Find<ContainerExtension>();
				if (containerExtension == null)
				{
					containerExtension = new ContainerExtension()
					{
						Value = newValue
					};

					OperationContext.Current.Extensions.Add(containerExtension);
				}
			}

		}

		#endregion
	}
}
