using E3Series.Proxy.Abstract;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pantec.E3Proxy
{
	public class E3DbeTextProxy : E3ProxyBase
	{
		[MethodImpl(4096, MethodCodeType = 3)]
		public E3DbeTextProxy(object comObject) : base(comObject)
		{
		}

		[DispId(1610743810)]
		[MethodImpl(4096, MethodCodeType=3)]
		public int Create( int symbolid,  int texttype,  double x,  double y,  string textvalue = "");

		[DispId(1610743811)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int Delete();

		[DispId(1610743814)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetAlignment();

		[DispId(1610743816)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetBallooning();

		[DispId(1610743812)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetColour();

		[DispId(1610743818)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  string GetFontName();

		[DispId(1610743820)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  double GetHeight();

		[DispId(1610743808)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetId();

		[DispId(1610743822)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetLevel();

		[DispId(1610743824)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetLocking();

		[DispId(1610743826)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetMode();

		[DispId(1610874880)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetPosition(ref object x,  ref object y);

		[DispId(1610743828)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  double GetRotation();

		[DispId(1610743830)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetSingleLine();

		[DispId(1610743832)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetStyle();

		[DispId(1610743834)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  string GetText();

		[DispId(1610743836)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetType();

		[DispId(1610809344)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetVisibility();

		[DispId(1610743815)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetAlignment( int newval);

		[DispId(1610743817)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetBallooning( int onoff,  int type);

		[DispId(1610743813)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetColour( int value);

		[DispId(1610743819)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetFontName( string newname);

		[DispId(1610743821)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetHeight( double newval);

		[DispId(1610743809)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetId( int id);

		[DispId(1610743823)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetLevel( int newval);

		[DispId(1610743825)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetLocking( int newval);

		[DispId(1610743827)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetMode( int newval);

		[DispId(1610743829)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  double SetRotation( double rotation);

		[DispId(1610743831)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetSingleLine( int newval);

		[DispId(1610743833)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetStyle( int newval);

		[DispId(1610743835)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetText( string newtext);

		[DispId(1610743837)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetType( int texttype);

		[DispId(1610809345)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetVisibility( int newval);
	}
}