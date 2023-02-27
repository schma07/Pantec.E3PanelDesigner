using E3Series.Proxy.Abstract;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pantec.E3Proxy
{
	public class E3DbeNodeClass : E3ProxyBase
	{
		[MethodImpl(4096, MethodCodeType = 3)]
		public E3DbeNodeClass(object comObject) : base(comObject)
		{
		}

		[DispId(1610743810)]
		[MethodImpl(4096, MethodCodeType=3)]
		public int GetDirection( int flags = 0);

		[DispId(1610743808)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetId();

		[DispId(1610743814)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetPosition(ref object x,  ref object y);

		[DispId(1610743813)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetTextIds( ref object ids,  int texttype = 0);

		[DispId(1610743812)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int HasPassWires();

		[DispId(1610809344)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int IsBusbarPin();

		[DispId(1610743811)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int IsBusPin();

		[DispId(1610743809)]
		[MethodImpl(4096, MethodCodeType=3)]
		public virtual extern int SetId( int id);
	}
}