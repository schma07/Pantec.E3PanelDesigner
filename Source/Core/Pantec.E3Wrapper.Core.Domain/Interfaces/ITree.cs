using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Tree COM object
    /// </summary>
    public interface ITree : IProxyProvider<E3TreeProxy>,
        IE3Identificated, IE3Named, IE3IdentificatedGlobal
    {
        /// <summary>
        /// Returns iterator of all selected terminals in project tree
        /// </summary>
        /// <param name="iterator">IDevice iterator</param>
        /// <returns></returns>
        IEnumerable<IDevice> GetSelectedTerminals(IDevice iterator);
    }
}