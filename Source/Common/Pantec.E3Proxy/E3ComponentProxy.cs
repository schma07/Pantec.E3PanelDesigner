using Pantec.E3Proxy.Interfaces;
using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3ComponentProxy : E3ProxyBase, IAttributed
    {

        public E3ComponentProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int GetAttributeCount()
        {
            return ComObject.GetAttributeCount();
        }

        public int GetAttributeIds(ref object ids, string attnam = default(string))
        {
            return ComObject.GetAttributeIds(ref ids, attnam);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        public int GetComponentType()
        {
            return ComObject.GetComponentType();
        }

        public int GetFormboardSymbolIds(ref object ids)
        {
            return ComObject.GetFormboardSymbolIds(ref ids);
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetModelName()
        {
            return ComObject.GetModelName();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetPinIds(ref object ids)
        {
            return ComObject.GetPinIds(ref ids);
        }

        public int GetStateIds(ref object ids)
        {
            return ComObject.GetStateIds(ref ids);
        }

        public int GetSubType()
        {
            return ComObject.GetSubType();
        }

        public int GetSupplyPinIds(ref object ids)
        {
            return ComObject.GetSupplyPinIds(ref ids);
        }

        public int GetValidModelCharacteristics(ref object characteristics)
        {
            return ComObject.GetValidModelCharacteristics(ref characteristics);
        }

        public string GetVersion()
        {
            return ComObject.GetVersion();
        }

        public int GetViewDefinitions(ref object viewDefinitions)
        {
            return ComObject.GetViewDefinitions(ref viewDefinitions);
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int Rename(string name, string version)
        {
            return ComObject.Rename(name, version);
        }

        public int Search(string name, string version)
        {
            return ComObject.Search(name, version);
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
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