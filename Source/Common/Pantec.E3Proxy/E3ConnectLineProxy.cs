using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3ConnectLineProxy : E3ProxyBase
    {
        public E3ConnectLineProxy(object comObject) : base(comObject)
        {
        }

        public int AddProtectionSymbolId(int id)
        {
            return ComObject.AddProtectionSymbolId(id);
        }

        public int GetCoordinates(ref object xarr, ref object yarr, ref object zarr, ref object PointTypArr)
        {
            return ComObject.GetCoordinates(ref xarr, ref yarr, ref zarr, ref PointTypArr);
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetProtectionSymbolIds(ref object ids)
        {
            return ComObject.GetProtectionSymbolIds(ref ids);
        }

        public string SetGID(string gid)
        {
            return ComObject.SetGID(gid);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }
    }
}