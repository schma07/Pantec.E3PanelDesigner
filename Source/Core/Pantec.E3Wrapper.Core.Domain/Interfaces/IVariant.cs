using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Variant COM object
    /// </summary>
    public interface IVariant : IProxyProvider<E3VariantProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal
    {
    }
}