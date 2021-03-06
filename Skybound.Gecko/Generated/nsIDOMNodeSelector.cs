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
// Generated by IDLImporter from file nsIDOMNodeSelector.idl
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
    /// The nsIDOMNodeSelector interface is an interface for getting nodes
    /// that match a given CSS selector.
    ///
    /// For more information on this interface please see
    /// <http://dev.w3.org/2006/webapi/selectors-api/>
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7cebc153-168a-416c-ba5a-56a8c2ddb2ec")]
	public interface nsIDOMNodeSelector
	{
		
		/// <summary>
        /// The nsIDOMNodeSelector interface is an interface for getting nodes
        /// that match a given CSS selector.
        ///
        /// For more information on this interface please see
        /// <http://dev.w3.org/2006/webapi/selectors-api/>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement QuerySelector([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase selectors);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList QuerySelectorAll([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase selectors);
	}
}
