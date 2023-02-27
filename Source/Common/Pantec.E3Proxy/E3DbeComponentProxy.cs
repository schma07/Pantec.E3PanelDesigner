using E3Series.Proxy.Abstract;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pantec.E3Proxy
{
	public class E3DbeComponentProxy : E3ProxyBase
	{
		[MethodImpl(4096, MethodCodeType = 3)]
		public E3DbeComponentProxy(object comObject) : base(comObject)
		{
		}

		[DispId(1610743813)]
		[MethodImpl(4096, MethodCodeType=3)]
		public int AddAttributeValue( string name,  string value,  int end = 0);

		[DispId(1610743812)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetAttributeIds(ref object ids,  int end = 0,  string attnam = "");

		[DispId(1610809344)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetComponentType();

		[DispId(1610743808)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetId();

		[DispId(1610743814)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  string GetName();

		[DispId(1610743816)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetSubType();

		[DispId(1610743815)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  string GetVersion();

		[DispId(1610743811)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int Remove( int save_changes = 0);

		[DispId(1610743810)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int Save();

		[DispId(1610743809)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetId( int id);

		[DispId(1610743817)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetSubType( int subtype);
	}
}