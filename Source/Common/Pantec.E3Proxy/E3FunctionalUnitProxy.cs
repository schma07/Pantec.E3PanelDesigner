using Pantec.E3Proxy.Interfaces;
using Pantec.E3Proxy.Abstract;
using Pantec.E3Proxy.Extensions;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
	public sealed class E3FunctionalUnitProxy : E3ProxyBase, IAttributed
    {
        public E3FunctionalUnitProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int Create(int fdbID, string name, string symnam, string symver)
        {
            return ComObject.Create(fdbID, name, symnam, symver);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int GetAttributeCount()
        {
            object attIds = null;
            GetAttributeIds(ref attIds);
            return attIds.ToIEnumerable().Count();
        }

        public int GetAttributeIds(ref object ids, string attnam = default(string))
        {
            return ComObject.GetAttributeIds(ref ids, attnam);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        public int GetDeviceId()
        {
            return ComObject.GetDeviceId();
        }

        public int GetFunctionalPortIds(ref object ids)
        {
            return ComObject.GetFunctionalPortIds(ref ids);
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

        public int GetSchemaSymbolId()
        {
            return ComObject.GetSchemaSymbolId();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int IsDynamic()
        {
            return ComObject.IsDynamic();
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

        public int SetName(string name)
        {
            return ComObject.SetName(name);
        }
    }
}