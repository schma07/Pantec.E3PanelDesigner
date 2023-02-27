using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Attribute COM object
    /// </summary>
    public interface IAttribute : IProxyProvider<E3AttributeProxy>, 
        IE3Identificated, IE3NamedReadonly, IE3IdentificatedGlobal
    {
        /// <summary>
        /// Get internal (system) name of attribute
        /// </summary>
        /// <returns></returns>
        string GetInternalName();

        /// <summary>
        /// Check attribute has name or internal name similar to parameter
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool CheckName(string name);
    }
}