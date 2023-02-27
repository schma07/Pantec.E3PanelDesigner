using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary>
    public sealed class E3VariantProxy : E3ProxyBase
    {
        public E3VariantProxy(object comObject) : base(comObject)
        {
        }

        public int Create(string name)
        {
            return ComObject.Create(name);
        }

        public int Delete(int del)
        {
            return ComObject.Delete(del);
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public string GetGUID()
        {
            return ComObject.GetGUID();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int IsActive()
        {
            return ComObject.IsActive();
        }

        public int Search(string name)
        {
            return ComObject.Search(name);
        }

        public string SetGID(string gid)
        {
            return ComObject.SetGID(gid);
        }

        public string SetGUID(string guid)
        {
            return ComObject.SetGUID(guid);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }

    }
}