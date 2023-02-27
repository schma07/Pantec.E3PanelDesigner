using E3Series.Proxy.Abstract;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pantec.E3Proxy
{
	public class E3DbeAttributeProxy : E3ProxyBase
	{
		[MethodImpl(4096, MethodCodeType = 3)]
		public E3DbeAttributeProxy(object comObject) : base(comObject)
		{
		}

		[DispId(1610743811)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int Delete();

		[DispId(1610809347)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  string GetFormattedValue();

		[DispId(1610743808)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetId();

		[DispId(1610809345)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  string GetInternalName();

		[DispId(1610809346)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  string GetInternalValue();

		[DispId(1610809344)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  string GetName();

		[DispId(1610809348)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  string GetValue();

		[DispId(1610743809)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetId( int id);

		[DispId(1610743810)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetValue( string value);
	}
}