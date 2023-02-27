using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Supply COM object
    /// </summary>
    public interface ISupply : IProxyProvider<E3SupplyProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal
    {
    }
}