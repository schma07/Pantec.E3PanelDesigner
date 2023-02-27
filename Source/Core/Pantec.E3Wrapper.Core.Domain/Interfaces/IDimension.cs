using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Dimension COM object
    /// </summary>
    public interface IDimension : IProxyProvider<E3DimensionProxy>,
        IE3Identificated, IE3IdentificatedGlobal, IE3Attributed
    {
    }
}