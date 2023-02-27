using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Wrapper.Core.Domain.Interfaces.Proxy
{
    /// <inheritdoc />
    /// <summary>
    /// Generic interface for all class-wrappers with readonly access to proxy object
    /// </summary>
    public interface IProxyProvider<out T> : IDisposable where T : E3ProxyBase
    {
        /// <summary>
        /// Proxy for E3series COM object
        /// </summary>
        T Proxy { get; }
    }
}
