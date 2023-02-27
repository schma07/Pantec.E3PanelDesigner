using E3Series.Proxy.Abstract;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pantec.E3Proxy
{
    public class E3DbeModelProxy : E3ProxyBase
    {
        [MethodImpl(4096, MethodCodeType = 3)]
        public E3DbeModelProxy(object comObject) : base(comObject)
        {
        }

        [DispId(1610743817)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int ActivateModelView( int modelview);

        [DispId(1610743813)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int FitSpaceRequirement();

        [DispId(1610743811)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetCharacteristic();

        [DispId(1610743814)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetDXFSize( string filename,  string font, 
            ref object dx,  ref object dy,  ref object scale);

        [DispId(1610940416)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetGraphicIds( ref object ids);

        [DispId(1610743808)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetId();

        [DispId(1610743810)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetName();

        [DispId(1610809344)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetPinIds( ref object ids);

        public  int ImportDXF( string filename,  double scale,  double x,  double y,  int rot,  string font, int flags);

        [DispId(1610940417)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int ImportStep( string filename,  int flags = 0);

        [DispId(1610874880)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int PlaceSymbol( string symname,  string version,  double x,  double y,  string rot,  int flags = 0);

        [DispId(1610743816)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int Remove( int save_changes = 0);

        [DispId(1610743815)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int Save();

        [DispId(1610743809)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetId( int id);
    }
}