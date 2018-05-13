using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	[ComImport]
	[CompilerGenerated]
	[Guid("0006303B-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	public interface Recipients : IEnumerable
	{
		[DispId(0)]
		Recipient this[[In] [MarshalAs(UnmanagedType.Struct)] object Index]
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		void _VtblGap1_5();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(111)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Recipient Add([In] [MarshalAs(UnmanagedType.BStr)] string Name);
	}
}
