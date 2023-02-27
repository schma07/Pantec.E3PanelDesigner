using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Apllication COM object
    /// </summary>
    public interface IApplication : IProxyProvider<E3ApplicationProxy>,
        IE3NamedReadonly
    {
        /// <summary>
        /// Check for successful connect to E3.series COM
        /// </summary>
        /// <returns></returns>
        bool IsApplicationRunning();

        /// <summary>
        /// Check for opened project
        /// </summary>
        /// <returns></returns>
        bool IsProjectOpened();

        /// <summary>
        /// Create wrapper for e3Job COM object
        /// </summary>
        /// <returns></returns>
        IJob CreateJobObject();

        /// <summary>
        /// Check for E3.series application running with /multiuser modifier
        /// </summary>
        /// <returns></returns>
        bool IsMultiuser();
    }
}
