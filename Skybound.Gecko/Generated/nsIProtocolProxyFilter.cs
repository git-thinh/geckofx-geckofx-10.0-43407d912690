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
// Generated by IDLImporter from file nsIProtocolProxyFilter.idl
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
    /// This interface is used to apply filters to the proxies selected for a given
    /// URI.  Use nsIProtocolProxyService::registerFilter to hook up instances of
    /// this interface.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f424abd3-32b4-456c-9f45-b7e3376cb0d1")]
	public interface nsIProtocolProxyFilter
	{
		
		/// <summary>
        /// This method is called to apply proxy filter rules for the given URI
        /// and proxy object (or list of proxy objects).
        ///
        /// @param aProxyService
        /// A reference to the Protocol Proxy Service.  This is passed so that
        /// implementations may easily access methods such as newProxyInfo.
        /// @param aURI
        /// The URI for which these proxy settings apply.
        /// @param aProxy
        /// The proxy (or list of proxies) that would be used by default for
        /// the given URI.  This may be null.
        ///
        /// @return The proxy (or list of proxies) that should be used in place of
        /// aProxy.  This can be just be aProxy if the filter chooses not to
        /// modify the proxy.  It can also be null to indicate that a direct
        /// connection should be used.  Use aProxyService.newProxyInfo to
        /// construct nsIProxyInfo objects.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProxyInfo ApplyFilter([MarshalAs(UnmanagedType.Interface)] nsIProtocolProxyService aProxyService, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aProxy);
	}
}
