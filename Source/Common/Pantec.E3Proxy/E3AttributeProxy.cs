using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3AttributeProxy : E3ProxyBase
    {
        public E3AttributeProxy(object comObject) : base(comObject)
        {
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public int DisplayAttribute(int id = 0)
        {
            return ComObject.DisplayAttribute(id);
        }

        public int DisplayValueAt(int sheetid, double x, double y, int bindid = 0)
        {
            return ComObject.DisplayValueAt(sheetid, x, y, bindid);
        }

        public string FormatValue(string name, string value)
        {
            return ComObject.FormatValue(name, value);
        }

        public string GetFormattedValue()
        {
            return ComObject.GetFormattedValue();
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetInternalName()
        {
            return ComObject.GetInternalName();
        }

        public string GetInternalValue()
        {
            return ComObject.GetInternalValue();
        }

        public int GetLockChangeable()
        {
            return ComObject.GetLockChangeable();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetOwnerId()
        {
            return ComObject.GetOwnerId();
        }

        public int GetTextCount()
        {
            return ComObject.GetTextCount();
        }

        public int GetTextIds(ref object ids, int txttyp = default(int), string search_string = "")
        {
            return ComObject.GetTextIds(ref ids, txttyp, search_string);
        }

        public string GetValue()
        {
            return ComObject.GetValue();
        }

        public int IsLockChangeable()
        {
            return ComObject.IsLockChangeable();
        }

        public string SetGID(string gid)
        {
            return ComObject.SetGID(gid);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetLockChangeable(int lockchangeable)
        {
            return ComObject.SetLockChangeable(lockchangeable);
        }

        public int SetValue(string value)
        {
            return ComObject.SetValue(value);
        }


    }
}