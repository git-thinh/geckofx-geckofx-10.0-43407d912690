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
// Generated by IDLImporter from file nsIAccessibleSelectable.idl
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
    /// An interface for the accessibility module and in-process accessibility clients
    /// for dealing with getting and changing the selection of accessible nodes.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("34d268d6-1dd2-11b2-9d63-83a5e0ada290")]
	public interface nsIAccessibleSelectable
	{
		
		/// <summary>
        /// Return an nsIArray of selected nsIAccessible children
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetSelectedChildren();
		
		/// <summary>
        /// Returns the number of accessible children currently selected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetSelectionCountAttribute();
		
		/// <summary>
        /// Adds the specified accessible child of the object to the
        /// object's selection.
        /// If the specified object is already selected, then it does nothing.
        /// @throws NS_ERROR_FAILURE if the specified object is not selectable.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddChildToSelection(int index);
		
		/// <summary>
        /// Removes the specified child of the object from the object's selection.
        /// If the specified object was not selected, then it does nothing.
        /// @throws NS_ERROR_FAILURE if the specified object is not selectable.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveChildFromSelection(int index);
		
		/// <summary>
        /// Clears the selection in the object so that no children in the object
        /// are selected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearSelection();
		
		/// <summary>
        /// Returns a reference to the accessible object representing the specified
        /// selected child of the object.
        /// @param index Zero-based selected accessible child index
        /// @return The nth selected accessible child
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAccessible RefSelection(int index);
		
		/// <summary>
        /// Determines if the current child of this object is selected
        /// @param The zero-based accessible child index
        /// @return Returns true if the child is selected, false if not.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsChildSelected(int index);
		
		/// <summary>
        /// Select all children
        /// @return If the object does not accept multiple selection, return false.
        /// Otherwise, returns true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SelectAllSelection();
	}
}
