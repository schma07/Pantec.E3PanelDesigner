using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3InfoApplicationProxy : E3ProxyBase
    {

        public E3InfoApplicationProxy(object comObject) : base(comObject)
        {
        }

        public string GetWindowPos(double x, double y, string text)
        {
            return ComObject.GetWindowPos(x, y, text);
        }
    }
}