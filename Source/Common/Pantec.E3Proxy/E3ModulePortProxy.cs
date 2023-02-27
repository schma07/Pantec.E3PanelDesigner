using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{

    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3ModulePortProxy : E3ProxyBase
    {
        public E3ModulePortProxy(object comObject) : base(comObject)
        {
        }

        public string GetBusName()
        {
            return ComObject.GetBusName();
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

        public int GetModuleId()
        {
            return ComObject.GetModuleId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetSignalId()
        {
            return ComObject.GetSignalId();
        }

        public int GetSignalIds(ref object ids)
        {
            return ComObject.GetSignalIds(ref ids);
        }

        public int GetSymbolIds(ref object OnBlockId, ref object OnSheetId)
        {
            return ComObject.GetSymbolIds(ref OnBlockId, ref OnSheetId);
        }

        public int IsBus()
        {
            return ComObject.IsBus();
        }

        public int SetBusName(string name)
        {
            return ComObject.SetBusName(name);
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