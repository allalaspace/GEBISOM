using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	[ComImport]
	[CompilerGenerated]
	[Guid("0006303C-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	public interface Attachments : IEnumerable
	{
		[DispId(0)]
		Attachment this[[In] [MarshalAs(UnmanagedType.Struct)] object Index]
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		void _VtblGap1_5();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Attachment Add([In] [MarshalAs(UnmanagedType.Struct)] object Source, [In] [MarshalAs(UnmanagedType.Struct)] object Type = null, [In] [MarshalAs(UnmanagedType.Struct)] object Position = null, [In] [MarshalAs(UnmanagedType.Struct)] object DisplayName = null);
	}
}
