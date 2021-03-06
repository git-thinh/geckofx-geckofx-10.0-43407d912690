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
// Generated by IDLImporter from file nsIDOMNSRange.idl
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
	
	
	/// <summary>nsIDOMNSRange </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fed93d11-f24d-41d8-ae55-4197927999bb")]
	public interface nsIDOMNSRange
	{
		
		/// <summary>Member CreateContextualFragment </summary>
		/// <param name='fragment'> </param>
		/// <returns>A nsIDOMDocumentFragment</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocumentFragment CreateContextualFragment([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase fragment);
		
		/// <summary>
        /// of the boundary points or is between them.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsPointInRange([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parent, int offset);
		
		/// <summary>
        /// Sort of a strcmp for ranges.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short ComparePoint([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parent, int offset);
		
		/// <summary>Member GetClientRects </summary>
		/// <returns>A nsIDOMClientRectList</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMClientRectList GetClientRects();
		
		/// <summary>Member GetBoundingClientRect </summary>
		/// <returns>A nsIDOMClientRect</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMClientRect GetBoundingClientRect();
	}
}
