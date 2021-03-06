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
// Generated by IDLImporter from file nsISystemProxySettings.idl
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
    /// This interface allows the proxy code to use platform-specific proxy
    /// settings when the proxy preference is set to "automatic discovery". This service
    /// acts like a PAC parser to netwerk, but it will actually read the system settings and
    /// either return the proper proxy data from the autoconfig URL specified in the system proxy,
    /// or generate proxy data based on the system's manual proxy settings.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a9f3ae38-b769-4e0b-9317-578388e326c9")]
	public interface nsISystemProxySettings
	{
		
		/// <summary>
        /// If non-empty, use this PAC file. If empty, call getProxyForURI instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPACURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPACURI);
		
		/// <summary>
        /// See nsIProxyAutoConfig::getProxyForURI; this function behaves exactly
        /// the same way.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProxyForURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
	}
}
