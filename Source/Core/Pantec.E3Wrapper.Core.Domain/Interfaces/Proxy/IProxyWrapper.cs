using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy
{
    /// <summary>
    /// Interface for working with proxy objects
    /// </summary>
    public interface IProxyWrapper : IDisposable
    {
        /// <summary>
        /// Parent object
        /// </summary>
        IProxyWrapper Parent { get; }

        /// <summary>
        /// Register child object
        /// </summary>
        /// <param name="child">Child object</param>
        void RegisterChild(IProxyWrapper child);

        /// <summary>
        /// Unregister child object
        /// </summary>
        /// <param name="child">Child object</param>
        void UnregisterChild(IProxyWrapper child);

        /// <summary>
        /// Check child object already registered
        /// </summary>
        /// <param name="childType">Type of child object</param>
        /// <returns></returns>
        bool HasChild(Type childType);

        /// <summary>
        /// Get child object from list of registered
        /// </summary>
        /// <param name="childType">Type of child object</param>
        /// <returns></returns>
        IProxyWrapper GetChild(Type childType);
    }
}
