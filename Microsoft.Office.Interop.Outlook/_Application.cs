using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	[ComImport]
	[CompilerGenerated]
	[Guid("00063001-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	public interface _Application
	{
		void _VtblGap1_9();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(266)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateItem([In] OlItemType ItemType);
	}
}
