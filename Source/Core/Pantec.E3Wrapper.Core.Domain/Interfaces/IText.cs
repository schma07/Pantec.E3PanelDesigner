using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Text COM object
    /// </summary>
    public interface IText : IProxyProvider<E3NetProxy>,
        IE3Identificated,
        IE3IdentificatedGlobal,
        IE3Attributed,
        IE3SchemaLocation
    {
    }
}