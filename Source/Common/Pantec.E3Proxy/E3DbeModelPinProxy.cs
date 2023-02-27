using E3Series.Proxy.Abstract;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pantec.E3Proxy
{
	public class E3DbeModelPinProxy : E3ProxyBase
	{
		[MethodImpl(4096, MethodCodeType = 3)]
		public E3DbeModelPinProxy(object comObject) : base(comObject)
		{
		}

		[DispId(1610743810)]
		[MethodImpl(4096, MethodCodeType=3)]
		public int GetCrimpingRules( ref object rules);

		[DispId(1610743808)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int GetId();

		[DispId(1610743811)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetCrimpingRules(ref object rules);

		[DispId(1610743809)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  int SetId( int id);
	}
}