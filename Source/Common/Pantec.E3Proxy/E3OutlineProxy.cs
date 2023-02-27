using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 
    public sealed class E3OutlineProxy : E3ProxyBase
    {
        public E3OutlineProxy(object comObject) : base(comObject)
        {
        }
        public int CreateBoardOutline(int brdi, int pnts, ref object x, ref object y)
        {
            return ComObject.CreateBoardOutline(brdi, pnts, ref x, ref y);
        }

        public string GetGID()
        {
            return ComObject.GetGID();
        }

        public double GetHeight()
        {
            return ComObject.GetHeight();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public int GetPath(ref object xarr, ref object yarr)
        {
            return ComObject.GetPath(ref xarr, ref yarr);
        }

        public int GetPathEx(ref object xarr, ref object yarr, ref object zarr)
        {
            return ComObject.GetPathEx(ref xarr, ref yarr, ref zarr);
        }

        public int GetPosition(ref object x, ref object y, ref object z)
        {
            return ComObject.GetPosition(ref x, ref y, ref z);
        }

        public double GetRadius()
        {
            return ComObject.GetRadius();
        }

        public int GetSymbolCount()
        {
            return ComObject.GetSymbolCount();
        }

        public int GetSymbolIds(ref object ids)
        {
            return ComObject.GetSymbolIds(ref ids);
        }

        public int GetType()
        {
            return ComObject.GetType();
        }

        public int GetTypeId()
        {
            return ComObject.GetTypeId();
        }

        public int IsThreadedHole()
        {
            return ComObject.IsThreadedHole();
        }

        public string SetGID(string gid)
        {
            return ComObject.SetGID(gid);
        }

        public int SetId(int id)
        {
            return ComObject.SetId(id);
        }

        public int SetUseCutOutGraphic(int set)
        {
            return ComObject.SetUseCutOutGraphic(set);
        }

        public int SetUseInE3CutOut(int set)
        {
            return ComObject.SetUseInE3CutOut(set);
        }

        public int UseCutOutGraphic()
        {
            return ComObject.UseCutOutGraphic();
        }

        public int UseInE3CutOut()
        {
            return ComObject.UseInE3CutOut();
        }
    }
}