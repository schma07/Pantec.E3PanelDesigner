using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Graph COM object
    /// </summary>
    public interface IGraph : IProxyProvider<E3GraphProxy>,
        IE3Identificated, IE3IdentificatedGlobal, IE3Attributed
    {
    }
}