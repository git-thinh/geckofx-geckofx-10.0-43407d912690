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
// Generated by IDLImporter from file nsIWifiListener.idl
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
	
	
	/// <summary>nsIWifiListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("BCD4BEDE-F4A5-4A62-9071-D7A60174E376")]
	public interface nsIWifiListener
	{
		
		/// <summary>
        /// Called when the list of access points changes.
        ///
        /// @param accessPoints An array of nsIWifiAccessPoint representing all
        /// access points in view.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnChange([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] nsIWifiAccessPoint[] accessPoints, uint aLen);
		
		/// <summary>
        /// Called when there is a problem with listening to wifi
        ///
        /// @param error the error which caused this event.  The
        /// error values will be nsresult codes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnError(int error);
	}
}
