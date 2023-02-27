using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3ClipboardProxy : E3ProxyBase
    {

        public E3ClipboardProxy(object comObject) : base(comObject)
        {
        }

        public int CommitToProject(int flags, int viewnumber = 0)
        {
            return ComObject.CommitToProject(flags, viewnumber);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteForced()
        {
            return ComObject.DelForced();
        }

        public int GetAnyIds(int flags, ref object ids)
        {
            return GetAnyIds(flags, ref ids);
        }

        public int GetCollidingIds(int flags, ref object ids)
        {
            return GetCollidingIds(flags, ref ids);
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
    }
}