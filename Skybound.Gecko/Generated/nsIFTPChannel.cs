// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIFTPChannel.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// This interface may be used to determine if a channel is a FTP channel.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("07f0d5cd-1fd5-4aa3-b6fc-665bdc5dbf9f")]
	public interface nsIFTPChannel
	{
		
		/// <summary>
        /// This interface may be used to determine if a channel is a FTP channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastModifiedTimeAttribute();
		
		/// <summary>
        /// This interface may be used to determine if a channel is a FTP channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLastModifiedTimeAttribute(long aLastModifiedTime);
	}
	
	/// <summary>
    /// This interface may be defined as a notification callback on the FTP
    /// channel.  It allows a consumer to receive a log of the FTP control
    /// connection conversation.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("455d4234-0330-43d2-bbfb-99afbecbfeb0")]
	public interface nsIFTPEventSink
	{
		
		/// <summary>
        /// XXX document this method!  (see bug 328915)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnFTPControlLog([MarshalAs(UnmanagedType.U1)] bool server, [MarshalAs(UnmanagedType.LPStr)] string msg);
	}
}
