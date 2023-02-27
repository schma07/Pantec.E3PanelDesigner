using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Symbol COM object
    /// </summary>
    public interface ISymbol : IProxyProvider<E3SymbolProxy>,
        IE3Identificated,
        IE3Named,
        IE3IdentificatedGlobal,
        IE3Attributed,
        IE3SchemaLocation
    {
    }
}