using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3NetSegment COM object
    /// </summary>
    public interface INetSegment : IProxyProvider<E3NetSegmentProxy>,
        IE3Identificated,
        IE3NamedReadonly,
        IE3IdentificatedGlobal,
        IE3Attributed
    {
        /// <summary>
        /// Returns iterator of nodes
        /// </summary>
        /// <param name="iterator">IPin iterator</param>
        /// <returns></returns>
        IEnumerable<IPin> GetNodes(IPin iterator);
    }
}