using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook
{
	[ComImport]
	[CompilerGenerated]
	[Guid("00063034-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	public interface _MailItem
	{
		[DispId(63509)]
		Attachments Attachments
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(63509)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(23)]
		OlImportance Importance
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(23)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(23)]
			[param: In]
			set;
		}

		[DispId(55)]
		string Subject
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(55)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(55)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(62468)]
		string HTMLBody
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(62468)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(62468)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(63508)]
		Recipients Recipients
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(63508)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(66)]
		string SentOnBehalfOfName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(66)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[DispId(66)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		void _VtblGap1_5();

		void _VtblGap2_14();

		void _VtblGap3_14();

		void _VtblGap4_6();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(61606)]
		void Display([In] [MarshalAs(UnmanagedType.Struct)] object Modal = null);

		void _VtblGap5_24();

		void _VtblGap6_11();

		void _VtblGap7_19();
	}
}
