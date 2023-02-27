using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    public class E3LayerProxy : E3ProxyBase
    {
        public E3LayerProxy(object comObject) : base(comObject)
        {
        }

        public int Create(string name, int type, int copper, int layer_id, int before)
        {
            return ComObject.Create(name, type, copper, layer_id, before);
        }

        public int GetBoardLayerIds(ref object ids)
        {
            return ComObject.GetBoardLayerIds(ref ids);
        }

        public int GetId()
        {
            return ComObject.GetObjectId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int IsGlobalLayer()
        {
            return ComObject.IsGlobalLayer();
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }
    }
}