using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary>
	public sealed class E3SupplyProxy : E3ProxyBase
    {

        public E3SupplyProxy(object comObject) : base(comObject)
        {
        }

        public int Create(int devid, string name)
        {
            return ComObject.Create(devid, name);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int GetBlockId()
        {
            return ComObject.GetBlockId();
        }

        public int GetComponentIds(ref object ids)
        {
            return ComObject.GetComponentIds(ref ids);
        }

        public int GetDevCompIds(ref object ids)
        {
            return ComObject.GetDevCompIds(ref ids);
        }

        public int GetDeviceIds(ref object ids)
        {
            return ComObject.GetDeviceIds(ref ids);
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public string GetOwnerName()
        {
            return ComObject.GetOwnerName();
        }

        public int GetPinIds(ref object ids)
        {
            return ComObject.GetPinIds(ref ids);
        }

        public int GetSignalIds(ref object ids)
        {
            return ComObject.GetSignalIds(ref ids);
        }

        public string GetSignalTypeName(int which)
        {
            return ComObject.GetSignalTypeName(which);
        }

        public int Search(int devid, string name)
        {
            return ComObject.Search(devid, name);
        }

        public string SetGID(string gid)
        {
            return ComObject.SetGID(gid);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }

        public int SetSignalIds(ref object ids)
        {
            return ComObject.SetSignalIds(ref ids);
        }
    }
}