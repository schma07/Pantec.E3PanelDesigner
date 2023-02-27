using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 

    // Todo: Check if CavityProxy may implement IAttributed (-> on first sight not all Methods are available)
    public sealed class E3CavityPartProxy : E3ProxyBase
    {
        public E3CavityPartProxy(object comObject) : base(comObject)
        {
        }

        public int AddAttributeValue(string name, string value)
        {
            return ComObject.AddAttributeValue(this, name, value);
        }

        public int Create(int pinid, string name, int type)
        {
            return ComObject.Create(pinid, name, type);
        }

        public int DeleteAttribute(string name)
        {
            return ComObject.DeleteAttribute(name);
        }

        public string GetAttributeValue(string name)
        {
            return ComObject.GetAttributeValue(name);
        }

        public int GetCabwirInfos(ref object cabWirs)
        {
            return ComObject.GetCabwirInfos(ref cabWirs);
        }

        public int GetCavityPartType()
        {
            return ComObject.GetCavityPartType();
        }

        public int GetDisableAutomaticSelection()
        {
            return ComObject.GetDisableAutomaticSelection();
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetOwner()
        {
            return ComObject.GetOwner();
        }

        public string GetValue()
        {
            return ComObject.GetValue();
        }

        public int IsActive()
        {
            return ComObject.IsActive();
        }

        public int SetAttributeValue(string name, string value)
        {
            return ComObject.SetAttributeValue(name, value);
        }

        public int SetDisableAutomaticSelection(int DisableAutomaticSelection)
        {
            return ComObject.SetDisableAutomaticSelection(DisableAutomaticSelection);
        }

        public string SetGID(string gid)
        {
            return ComObject.SetGID(gid);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetValue(string value)
        {
            return ComObject.SetValue(value);
        }
    }

}