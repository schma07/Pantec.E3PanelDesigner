using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3ModulePort COM object
    /// </summary>
    public interface IModulePort : IProxyProvider<E3ModulePortProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal
    {
    }
}