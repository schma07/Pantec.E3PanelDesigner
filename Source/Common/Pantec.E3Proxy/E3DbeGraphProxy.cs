using E3Series.Proxy.Abstract;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pantec.E3Proxy
{
    public class E3DbeGraphProxy : E3ProxyBase
    {
        [MethodImpl(4096, MethodCodeType = 3)]
        public E3DbeGraphProxy(object comObject) : base(comObject)
        {
        }

        [DispId(1610743815)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int CreateArc( int symbolid,  double x,  double y,  double radius,  double start,  double end);

        [DispId(1610743823)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int CreateBlob( int symbolid,  string filename);

        [DispId(1610743816)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int CreateCircle( int symbolid,  double x,  double y,  double radius);

        [DispId(1610743822)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int CreateCloud( int symbolid,  int pnts,  ref object x,  ref object y);

        [DispId(1610743821)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int CreateCurve( int symbolid,  int pnts,  ref object x,  ref object y);

        [DispId(1610743820)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int CreateImage( int symbolid,  double xpos,  double ypos,  double xsize,  double ysize,  string filename,  int embed = 1);

        [DispId(1610743819)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int CreateLine( int symbolid,  double x1,  double y1,  double x2,  double y2);

        [DispId(1610743817)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int CreatePolygon( int symbolid,  int pnts,  ref object x,  ref object y);

        [DispId(1610743818)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int CreateRectangle( int symbolid,  double x1,  double y1,  double x2,  double y2);

        [DispId(1610743826)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int Delete();

        [DispId(1610743828)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetArc( ref object xm,  ref object ym,  ref object rad,  ref object startang,  ref object endang);

        [DispId(1610743829)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetCircle( ref object xm,  ref object ym,  ref object rad);

        [DispId(1610743834)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetCloud( ref object npnts,  ref object xarr,  ref object yarr);

        [DispId(1610743810)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetColour();

        [DispId(1610743833)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetCurve( ref object npnts,  ref object xarr,  ref object yarr);

        [DispId(1610743842)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetHatchColour();

        [DispId(1610743847)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public double GetHatchLineDistance();

        [DispId(1610743845)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetHatchLineStyle();

        [DispId(1610743843)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public double GetHatchLineWidth();

        [DispId(1610743849)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetHatchPattern(out object angle1, out object angle2);

        [DispId(1610743808)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetId();

        [DispId(1610743851)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetImageInfo( ref object xpos,  ref object ypos,  ref object xsize,  ref object ysize,  ref object filename,  ref object embed);

        [DispId(1610874880)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetInsideGraphIds(out object ids,  int flags = 0);

        [DispId(1610743812)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetLevel();

        [DispId(1610743830)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetLine( ref object x1,  ref object y1,  ref object x2,  ref object y2);

        [DispId(1610743835)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetLineColour();

        [DispId(1610743839)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetLineStyle();

        [DispId(1610743837)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public double GetLineWidth();

        [DispId(1610743831)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetPolygon( ref object npnts,  ref object xarr,  ref object yarr);

        [DispId(1610743832)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetRectangle( ref object x1,  ref object y1,  ref object x2,  ref object y2);

        [DispId(1610743827)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetTypeId();

        public  int OptimizeGraphicObjects( ref object ids,  int mode,  int angle);

        [DispId(1610743825)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int Place( double x,  double y);

        [DispId(1610743824)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SaveBlob( string filename);

        [DispId(1610743814)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetBlobInfo( string filename);

        [DispId(1610743811)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetColour( int newcol);

        [DispId(1610743841)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetHatchColour( int newcol);

        [DispId(1610743848)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  double SetHatchLineDistance( double newdist);

        [DispId(1610743846)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetHatchLineStyle( int newstyle);

        [DispId(1610743844)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  double SetHatchLineWidth( double newwid);

        [DispId(1610743850)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetHatchPattern( int newpat,  double angle1,  double angle2);

        [DispId(1610743809)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetId( int id);

        [DispId(1610743852)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetImageInfo( double xpos,  double ypos,  double xsize,  double ysize,  string filename = default(string),  int embed = -1);

        [DispId(1610743813)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetLevel( int newlev);

        [DispId(1610743836)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetLineColour( int newcol);

        [DispId(1610743840)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetLineStyle( int newstyle);

        [DispId(1610743838)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  double SetLineWidth( double newwid);
    }
}