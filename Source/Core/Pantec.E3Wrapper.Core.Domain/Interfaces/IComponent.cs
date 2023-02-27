using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Component COM object
    /// </summary>
    public interface IComponent : IProxyProvider<E3ComponentProxy>,
        IE3Identificated, IE3NamedReadonly, IE3IdentificatedGlobal, IE3Attributed
    {
    }
}