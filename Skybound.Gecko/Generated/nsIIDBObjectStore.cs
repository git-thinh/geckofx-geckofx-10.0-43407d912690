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
// Generated by IDLImporter from file nsIIDBObjectStore.idl
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
    /// nsIIDBObjectStore interface.  See
    /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-nsIIDBObjectStore
    /// for more information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("adc6a1e2-9fd7-4d28-a7f9-9c653313124b")]
	public interface nsIIDBObjectStore
	{
		
		/// <summary>
        /// nsIIDBObjectStore interface.  See
        /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-nsIIDBObjectStore
        /// for more information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetKeyPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aKeyPath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetIndexNamesAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBTransaction GetTransactionAttribute();
		
		/// <summary>
        /// Success fires IDBTransactionEvent, result == value for key
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Get(System.IntPtr key, System.IntPtr jsContext);
		
		/// <summary>
        ///unlimited </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest GetAll(System.IntPtr key, uint limit, System.IntPtr jsContext, int argc);
		
		/// <summary>
        ///undefined </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Add(System.IntPtr value, System.IntPtr key, System.IntPtr jsContext, int argc);
		
		/// <summary>
        ///undefined </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Put(System.IntPtr value, System.IntPtr key, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// Success fires IDBTransactionEvent, result == null
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Delete(System.IntPtr key, System.IntPtr jsContext);
		
		/// <summary>
        /// Success fires IDBTransactionEvent, result == null
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Clear();
		
		/// <summary>
        ///NEXT </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest OpenCursor(System.IntPtr range, ushort direction, System.IntPtr jsContext, int argc);
		
		/// <summary>
        ///none </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBIndex CreateIndex([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase keyPath, System.IntPtr options, System.IntPtr jsContext);
		
		/// <summary>
        /// Returns object immediately
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBIndex Index([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteIndex([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>
        /// Accepts null, a key value, or a nsIIDBKeyRange object.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Count(System.IntPtr key, System.IntPtr jsContext, int argc);
	}
}
