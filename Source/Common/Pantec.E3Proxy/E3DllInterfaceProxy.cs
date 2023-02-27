using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3DllInterfaceProxy : E3ProxyBase
    {

        public E3DllInterfaceProxy(object comObject) : base(comObject)
        {
        }

        public int Call(string method, string item1 = "-353353", string item2 = "-353353", string item3 = "-353353", string item4 = "-353353", string item5 = "-353353")
        {
            return ComObject.Call(method, item1, item2, item3, item4, item5);
        }

        public int Load(string name)
        {
            return ComObject.Load(name);
        }

        public int Unload()
        {
            return ComObject.Unload();
        }
    }
}