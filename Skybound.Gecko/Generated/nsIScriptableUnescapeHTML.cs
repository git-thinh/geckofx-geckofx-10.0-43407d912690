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
// Generated by IDLImporter from file nsIScriptableUnescapeHTML.idl
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
    /// A utility class that unescapes HTML strings.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3ab244a9-f09d-44da-9e3f-ee4d67367f2d")]
	public interface nsIScriptableUnescapeHTML
	{
		
		/// <summary>
        /// Converts all entities to Unicode.
        ///
        /// @param src The HTML string to escape.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Unescape([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase src, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Appends the text to the element.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocumentFragment ParseFragment([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase fragment, [MarshalAs(UnmanagedType.U1)] bool isXML, [MarshalAs(UnmanagedType.Interface)] nsIURI baseURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement element);
	}
}
