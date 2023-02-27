using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3FunctionalPort COM object
    /// </summary>
    public interface IFunctionalPort : IProxyProvider<E3FunctionalPortProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal
    {
    }
}