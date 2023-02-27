using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary>
    /// <remarks>This interface is not documented in E3 Scripting Reference Documentation
    /// </remarks>

    public class E3StateProxy : E3ProxyBase
    {
        public E3StateProxy(object comObject) : base(comObject)
        {
        }
        public int GetAttributeIds(out object ids, string name)
        {
            return ComObject.GetAttributeIds(out ids, name);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
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

        public int GetOwnerId()
        {
            return ComObject.GetOwnerId();
        }

        public int GetOwnerIds(out object ids)
        {
            return ComObject.GetOwnerIds(out ids);
        }

        public int GetOwnerType()
        {
            return ComObject.GetOwnerType();
        }

        public int GetStateType()
        {
            return ComObject.GetStateType();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int SetGID(string gid)
        {
            return ComObject.SetGID(gid);
        }

        public int SetGUID(string guid)
        {
            return ComObject.SetGUID(guid);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }
    }
}