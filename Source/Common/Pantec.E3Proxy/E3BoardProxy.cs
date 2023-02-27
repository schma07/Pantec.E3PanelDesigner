using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3BoardProxy : E3ProxyBase
    {
        public E3BoardProxy(object comObject) : base(comObject)
        {
        }

        public int Create(string name)
        {
            return ComObject.Create(name);
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetLayerIds(ref object ids)
        {
            return ComObject.GetLayerIds(ref ids);
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetOutlineId()
        {
            return ComObject.GetOutlineId();
        }

        public int GetSheetIds(ref object ids)
        {
            return ComObject.GetSheetIds(ref ids);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }     
    }
}