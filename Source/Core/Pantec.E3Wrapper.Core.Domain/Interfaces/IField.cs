using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Field COM object
    /// </summary>
    public interface IField : IProxyProvider<E3FieldProxy>,
        IE3Identificated,
        IE3Named,
        IE3IdentificatedGlobal,
        IE3Attributed,
        IE3SchemaLocation
    {
    }
}