using Pantec.E3Proxy.Interfaces;
using Pantec.E3Proxy.Abstract;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary>
    public sealed class E3SignalClassProxy : E3ProxyBase, IAttributed
    {
        public E3SignalClassProxy(object comObject) : base(comObject)
        {
        }


        public int AddAttributeValue( string name,  string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int AddSignalId( int id)
        {
            return ComObject.AddSignalId(id);
        }

        public int Create( string name)
        {
            return ComObject.Create(name);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DeleteAttribute( string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int DisplayaAttributeValueAt( string name,  int sheetid,  double x,  double y)
        {
            return ComObject.DisplayaAttributeValueAt(name, sheetid, x, y);
        }

        public int GetAttributeCount()
        {
            return ComObject.GetAttributeCount();
        }

        public int GetAttributeIds( ref object ids,  string attnam = default(string))
        {
            return ComObject.GetAttributeIds(ref ids, attnam);
        }

        public string GetAttributeValue( string name)
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

        public int GetSignalIds( ref object ids)
        {
            return ComObject.GetSignalIds(ref ids);
        }

        public int HasAttribute( string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int RemoveSignalId( int id)
        {
            return ComObject.RemoveSignalId(id);
        }

        public int Search( string name)
        {
            return ComObject.Search(name);
        }

        public int SetAttributeValue( string name,  string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetAttributeVisibility( string name,  int onoff)
        {
            return ComObject.SetAttributeVisibility(name, onoff);
        }

        public string SetGID( string gid)
        {
            return ComObject.SetGID(gid);
        }

        public string SetGUID( string guid)
        {
            return ComObject.SetGUID(guid);
        }

        public int SetId( int id)
        {
            return ComObject.SetId(id);
        }

        public int SetName( string name)
        {
            return ComObject.SetName(name);
        }

    }
}