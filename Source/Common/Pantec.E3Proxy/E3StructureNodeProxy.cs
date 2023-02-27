using Pantec.E3Proxy.Interfaces;
using Pantec.E3Proxy.Abstract;
using Pantec.E3Proxy.Extensions;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary>
	public sealed class E3StructureNodeProxy : E3ProxyBase, IAttributed
    {
        public E3StructureNodeProxy(object comObject) : base(comObject)
        {
        }


        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int Create(string name, string typname, int parentid, int afterid)
        {
            return ComObject.Create(name, typname, parentid, afterid);
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

        public int DeleteForced()
        {
            return ComObject.DeleteForced();
        }

        public int GetAllDeviceIds(ref object ids)
        {
            return ComObject.GetAllDeviceIds(ref ids);
        }

        public int GetAllSignalIds(ref object ids)
        {
            return ComObject.GetAllSignalIds(ref ids);
        }

        public int GetAttributeIds(ref object ids, string attnam = default(string))
        {
            return ComObject.GetAttributeIds(ref ids, attnam);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        public int GetExternalDocumentIds(ref object ids)
        {
            return ComObject.GetExternalDocumentIds(ref ids);
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

        public string GetInternalName()
        {
            return ComObject.GetInternalName();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetParentID()
        {
            return ComObject.GetParentID();
        }

        public int GetSheetAndExternalDocumentIds(ref object ids)
        {
            return ComObject.GetSheetAndExternalDocumentIds(ref ids);
        }

        public int GetSheetIds(ref object ids)
        {
            return ComObject.GetSheetIds(ref ids);
        }

        public int GetStructureNodeIds(ref object ids)
        {
            return ComObject.GetStructureNodeIds(ref ids);
        }

        public string GetTypeName()
        {
            return ComObject.GetTypeName();
        }

        public int HasAttribute(string name)
        {
            return ComObject.HasAttribute(name);
        }

        public int Highlight(int colour, double width)
        {
            return ComObject.Highlight(colour, width);
        }

        public int IsLocked()
        {
            return ComObject.IsLocked();
        }

        public int IsLockedByAccessControl()
        {
            return ComObject.IsLockedByAccessControl();
        }

        public int IsObjectTypeAllowed(int sheets, int devices)
        {
            return ComObject.IsObjectTypeAllowed(sheets, devices);
        }

        public int LockObject()
        {
            return ComObject.LockObject();
        }

        public int MoveTo(int parentid, int afterid = 0)
        {
            return ComObject.MoveTo(parentid, afterid);
        }

        public int ResetHighlight()
        {
            return ComObject.ResetHighlight();
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetExternalDocumentIds(ref object ids)
        {
            return ComObject.SetExternalDocumentIds(ref ids);
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

        public int SetSheetIds(ref object ids)
        {
            return ComObject.SetSheetIds(ref ids);
        }

        public int SetStructureNodeIds(ref object ids)
        {
            return ComObject.SetStructureNodeIds(ref ids);
        }

        public int UnlockObject(string password)
        {
            return ComObject.UnlockObject(password);
        }
    }
}