using Pantec.E3Proxy.Interfaces;
using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{

    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3ModuleProxy : E3ProxyBase, IAttributed
    {

        public E3ModuleProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            int result = ComObject.AddAttributeValue(name, value);
            return result;
        }

        public int DeleteAttribute(string name)
        {
            int result = ComObject.DeleteAttribute(name);
            return result;
        }

        public int GetAttributeCount()
        {
            int result = ComObject.GetAttributeCount();
            return result;
        }

        public int GetAttributeIds(ref object ids, string attnam = default(string))
        {
            int result = ComObject.GetAttributeIds(ref ids, attnam);
            return result;
        }

        public string GetAttributeValue(string name)
        {
            string result = ComObject.GetAttributeValue(name);
            return result;
        }

        public string GetFileName()
        {
            string result = ComObject.GetFileName();
            return result;
        }

        public string GetGID()
        {
            string result = ComObject.GetGID();
            return result;
        }

        public int GetId()
        {
            int result = ComObject.GetId();
            return result;
        }

        public int GetLevel()
        {
            int result = ComObject.GetLevel();
            return result;
        }

        public int GetModuleIds(ref object ids)
        {
            int result = ComObject.GetModuleIds(ref ids);
            return result;
        }

        public string GetName()
        {
            string result = ComObject.GetName();
            return result;
        }

        public int GetParentModuleId()
        {
            int result = ComObject.GetParentModuleId();
            return result;
        }

        public int GetParentSheetId()
        {
            int result = ComObject.GetParentSheetId();
            return result;
        }

        public int GetPortCount()
        {
            int result = ComObject.GetPortCount();
            return result;
        }

        public int GetPortIds(ref object ids)
        {
            int result = ComObject.GetPortIds(ref ids);
            return result;
        }

        public int GetSheetIds(ref object ids)
        {
            int result = ComObject.GetSheetIds(ref ids);
            return result;
        }

        public string GetTypeName()
        {
            string result = ComObject.GetTypeName();
            return result;
        }

        public int HasAttribute(string name)
        {
            int result = ComObject.HasAttribute(name);
            return result;
        }

        public int IsTypeLoadable()
        {
            int result = ComObject.IsTypeLoadable();
            return result;
        }

        public int Search(string name)
        {
            int result = ComObject.Search(name);
            return result;
        }

        public int SetAttributeValue(string name, string value)
        {
            int result = ComObject.SetAttributeValue(name, value);
            return result;
        }

        public string SetGID(string gid)
        {
            string result = ComObject.SetGID(gid);
            return result;
        }

        public int SetId(int id)
        {
            int result = ComObject.SetId(id);
            return result;
        }

        public int SetName(string name)
        {
            int result = ComObject.SetName(name);
            return result;
        }
    }
}