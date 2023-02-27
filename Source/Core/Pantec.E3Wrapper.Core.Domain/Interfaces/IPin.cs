using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;
using Pantec.Wrapper.Entities.Models;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Pin COM object
    /// </summary>
    public interface IPin : IProxyProvider<E3PinProxy>,
        IE3Identificated,
        IE3Named,
        IE3IdentificatedGlobal,
        IE3Attributed,
        IE3SchemaLocation
    {
        /// <summary>
        /// Pin Signal name
        /// </summary>
        string SignalName { get; set; }

        /// <summary>
        /// Get signal name type (not set/system/user)
        /// </summary>
        /// <returns></returns>
        SignalNameType GetSignalNameType();

        /// <summary>
        /// Get Sheet if pin is placed
        /// </summary>
        /// <param name="iterator"></param>
        /// <returns></returns>
        ISheet GetSheet(ISheet iterator);
    }
}