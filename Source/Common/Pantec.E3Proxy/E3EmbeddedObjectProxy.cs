using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3EmbeddedObjectProxy : E3ProxyBase
    {
        public E3EmbeddedObjectProxy(object comObject) : base(comObject)
        {
        }

        public int Create(string filename, int shti, double x, double y)
        {
            return ComObject.Create(filename, shti, x, y);
        }

        public int Delete()
        {
            return ComObject.Delete();
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int Move(int shti, double x, double y)
        {
            return ComObject.Move(shti, x, y);
        }

        public int Open()
        {
            return ComObject.Open();
        }

        public int Resize(double width, double height)
        {
            return ComObject.Resize(width, height);
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