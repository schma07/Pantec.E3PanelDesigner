using E3Series.Proxy.Abstract;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pantec.E3Proxy
{
	public class E3DbeBridgeProxy : E3ProxyBase
	{
		[MethodImpl(4096, MethodCodeType = 3)]
		public E3DbeBridgeProxy(object comObject) : base(comObject)
		{
		}

		[DispId(1610678272)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  void BringToForeground();

		[DispId(1610678274)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  void Edit( int mode,  int what,  string entry,  string version);

		[DispId(1610678276)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  void EditWithPreconditions( int mode,  int what,  string entry,  string version,  ref object preconditions);

		[DispId(1610678273)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  void New( int mode,  int what,  string baseEntry,  string baseVersion,  string name,  string version);

		[DispId(1610678275)]
		[MethodImpl(4096, MethodCodeType=3)]
		public  void NewWithPreconditions( int mode,  int what,  string baseEntry,  string baseVersion,  string name,  string version,  ref object preconditions);
	}
}