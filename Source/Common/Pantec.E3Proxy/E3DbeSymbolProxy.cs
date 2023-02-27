using E3Series.Proxy.Abstract;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pantec.E3Proxy
{
	public class E3DbeSymbolProxy : E3ProxyBase
	{
		[MethodImpl(4096, MethodCodeType = 3)]
		public E3DbeSymbolProxy(object comObject) : base(comObject)
		{
		}

		[DispId(1610743815)]
		[MethodImpl(4096, MethodCodeType=3)]
		public int AddAttributeValue( string name,  string value);

		[DispId(1610809344)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int FitSpaceRequirement();

		[DispId(1610743812)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetAttributeIds( ref object ids,  string attnam = "");

		[DispId(1610743818)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  string GetCharacteristic();

		[DispId(1610809347)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetDXFSize( string filename,  string font,  ref object dx,  ref object dy,  ref object scale);

		[DispId(1610743813)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetGraphicIds( ref object ids);

		[DispId(1610743808)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetId();

		[DispId(1610743816)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  string GetName();

		[DispId(1610940416)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetNodeIds( ref object ids,  int flags = 0);

		[DispId(1610743819)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetSubType();

		[DispId(1610809345)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetSymbolType();

		[DispId(1610743814)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetTextIds([In] ref object ids, [In] int texttype = 0);

		[DispId(1610743817)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  string GetVersion();

		[DispId(1610809346)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int ImportDXF([In] string filename, [In] double scale, [In] double x, [In] double y, [In] int rot, [In] string font, int flags);

		[DispId(1610874880)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int PlaceSymbol([In] string symname, [In] string version, [In] double x, [In] double y, [In] string rot, [In] int flags = 0);

		[DispId(1610743811)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int Remove([In] int save_changes = 0);

		[DispId(1610743810)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int Save();

		[DispId(1610743809)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetId([In] int id);

		[DispId(1610743820)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetSubType( int subtype);
	}
}