using Pantec.E3Wrapper.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pantec.E3Wrapper.Core.Application.Interfaces
{
    // <summary>
    /// Interface for all connectors
    /// </summary>
    public interface IConnector
    {
        /// <summary>
        /// Connect to E3.series process
        /// </summary>
        /// <returns>Wrapped e3Application COM object</returns>
        IApplication Connect();

        /// <summary>
        /// Connect to E3.series process
        /// </summary>
        /// <param name="processId">E3.series application process id</param>
        /// <returns>Wrapped e3Application COM object</returns>
        IApplication Connect(int processId);
    }
}
