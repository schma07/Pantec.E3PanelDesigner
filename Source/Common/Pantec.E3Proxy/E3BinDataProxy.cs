using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3BinDataProxy : E3ProxyBase
    {
        public E3BinDataProxy(object comObject) : base(comObject)
        {
        }

        public int GetData(string name, ref object data, int maxlen)
        {
            return ComObject.GetData(name, ref data, maxlen);
        }

        public int SetData(string name, ref object data, int maxlen)
        {
            return ComObject.SetData(name, ref data, maxlen);
        }
    }
}