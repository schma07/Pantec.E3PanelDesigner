using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3ConnectLine COM object
    /// </summary>
    public interface IConnectLine : IProxyProvider<E3ConnectLineProxy>,
        IE3Identificated, IE3IdentificatedGlobal
    {
    }
}