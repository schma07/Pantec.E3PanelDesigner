using Pantec.E3Proxy;
using Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3BinData COM object
    /// </summary>
    public interface IBinData : IProxyProvider<E3BinDataProxy>
    {
    }
}