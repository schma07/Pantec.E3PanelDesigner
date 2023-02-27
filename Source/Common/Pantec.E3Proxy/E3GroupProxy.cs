using Pantec.E3Proxy.Interfaces;
using Pantec.E3Proxy.Abstract;
using Pantec.E3Proxy.Extensions;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3GroupProxy : E3ProxyBase, IAttributed
    {
        public E3GroupProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(name, value);
        }

        public int AddItems(ref object ids)
        {
            return ComObject.AddItems(ref ids);
        }

        public int Create(ref object ids, string name = default(string))
        {
            return ComObject.Create(ref ids, name);
        }

        public int Delete(ref object ids)
        {
            return ComObject.Delete(ref ids);
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public int DeleteContents()
        {
            return ComObject.DeleteContents();
        }

        public int DeleteUnplaced()
        {
            return ComObject.DeleteUnplaced();
        }

        public int GetAnyIds(uint flags, out object anyids)
        {
            return ComObject.GetAnyIds(flags, out anyids);
        }

        public int GetAttributeIds(ref object ids, string name = default(string))
        {
            return ComObject.GetAttributeIds(ref ids, name);
        }

        public int GetAttributeCount()
        {
            object attIds = null;
            GetAttributeIds(ref attIds);
            return attIds.ToIEnumerable().Count();
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        [Obsolete("No support for HasAttribute method", true)]
        public int HasAttribute(string name)
        {
            throw new System.NotSupportedException("This method is not supported with the E3 GroupInterface");
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public int GetGroupId(int id)
        {
            return ComObject.GetGroupId(id);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetItems(ref object ids)
        {
            return ComObject.GetItems(ref ids);
        }

        public int GetLocation(ref object x, ref object y, ref object z, ref object grid, ref object column_value, ref object row_value)
        {
            return ComObject.GetLocation(ref x, ref y, ref z, ref grid, ref column_value, ref row_value);
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public string GetPartName()
        {
            return ComObject.GetPartName();
        }

        public int IsPart()
        {
            return ComObject.IsPart();
        }

        public int IsSubCircuit()
        {
            return ComObject.IsSubCircuit();
        }

        public int IsUnplaced()
        {
            return ComObject.IsUnplaced();
        }

        public int Place(int shtId, double x, double y, double z, double rotation)
        {
            return ComObject.Place(shtId, x, y, z, rotation);
        }

        public int PlaceInteractively()
        {
            return ComObject.PlaceInteractively();
        }

        public int RemoveItems(ref object ids)
        {
            return ComObject.RemoveItems(ref ids);
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

        public int SetPartName(string name)
        {
            return ComObject.SetPartName(name);
        }

        public int Unplace()
        {
            return ComObject.Unplace();
        }

        public int UpdateDrawingForProjectGeneration(uint flags, ref object substitutes, ref object allowedTexttypes, ref object allowedAttributenames, ref object resultArray)
        {
            return ComObject.UpdateDrawingForProjectGeneration(flags, ref substitutes, ref allowedTexttypes, ref allowedAttributenames, ref resultArray);
        }

        public int UpdatePart()
        {
            return ComObject.UpdatePart();
        }
    }
}