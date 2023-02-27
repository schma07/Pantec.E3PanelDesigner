using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary>
	public sealed class E3SlotProxy : E3ProxyBase
    {

        public E3SlotProxy(object comObject) : base(comObject)
        {
        }


        public int GetDefinedDirection(out object x, out object y, out object z)
        {
            return ComObject.GetDefinedDirection(out x, out y, out z);
        }

        public int GetDirection(out object x, out object y, out object z)
        {
            return ComObject.GetDirection(out x, out y, out z);
        }

        public int GetFixType()
        {
            return ComObject.GetFixType();
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetMountedDeviceIds(ref object ids)
        {
            return ComObject.GetMountedDeviceIds(ref ids);
        }

        public string GetMountType()
        {
            return ComObject.GetMountType();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetPosition(int point, ref object x, ref object y, ref object z)
        {
            return ComObject.GetPosition(point, ref x, ref y, ref z);
        }

        public int GetRotation(out object angle)
        {
            return ComObject.GetRotation(out angle);
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