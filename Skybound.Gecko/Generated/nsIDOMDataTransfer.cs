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
// Generated by IDLImporter from file nsIDOMDataTransfer.idl
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
	
	
	/// <summary>nsIDOMDataTransfer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("34042440-60A8-4992-AE5C-798E69148955")]
	public interface nsIDOMDataTransfer
	{
		
		/// <summary>
        /// The actual effect that will be used, and should always be one of the
        /// possible values of effectAllowed.
        ///
        /// For dragstart, drag and dragleave events, the dropEffect is initialized
        /// to none. Any value assigned to the dropEffect will be set, but the value
        /// isn't used for anything.
        ///
        /// For the dragenter and dragover events, the dropEffect will be initialized
        /// based on what action the user is requesting. How this is determined is
        /// platform specific, but typically the user can press modifier keys to
        /// adjust which action is desired. Within an event handler for the dragenter
        /// and dragover events, the dropEffect should be modified if the action the
        /// user is requesting is not the one that is desired.
        ///
        /// For the drop and dragend events, the dropEffect will be initialized to
        /// the action that was desired, which will be the value that the dropEffect
        /// had after the last dragenter or dragover event.
        ///
        /// Possible values:
        /// copy - a copy of the source item is made at the new location
        /// move - an item is moved to a new location
        /// link - a link is established to the source at the new location
        /// none - the item may not be dropped
        ///
        /// Assigning any other value has no effect and retains the old value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDropEffectAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDropEffect);
		
		/// <summary>
        /// The actual effect that will be used, and should always be one of the
        /// possible values of effectAllowed.
        ///
        /// For dragstart, drag and dragleave events, the dropEffect is initialized
        /// to none. Any value assigned to the dropEffect will be set, but the value
        /// isn't used for anything.
        ///
        /// For the dragenter and dragover events, the dropEffect will be initialized
        /// based on what action the user is requesting. How this is determined is
        /// platform specific, but typically the user can press modifier keys to
        /// adjust which action is desired. Within an event handler for the dragenter
        /// and dragover events, the dropEffect should be modified if the action the
        /// user is requesting is not the one that is desired.
        ///
        /// For the drop and dragend events, the dropEffect will be initialized to
        /// the action that was desired, which will be the value that the dropEffect
        /// had after the last dragenter or dragover event.
        ///
        /// Possible values:
        /// copy - a copy of the source item is made at the new location
        /// move - an item is moved to a new location
        /// link - a link is established to the source at the new location
        /// none - the item may not be dropped
        ///
        /// Assigning any other value has no effect and retains the old value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDropEffectAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDropEffect);
		
		/// <summary>
        /// Specifies the effects that are allowed for this drag. You may set this in
        /// the dragstart event to set the desired effects for the source, and within
        /// the dragenter and dragover events to set the desired effects for the
        /// target. The value is not used for other events.
        ///
        /// Possible values:
        /// copy - a copy of the source item is made at the new location
        /// move - an item is moved to a new location
        /// link - a link is established to the source at the new location
        /// copyLink, copyMove, linkMove, all - combinations of the above
        /// none - the item may not be dropped
        /// uninitialized - the default value when the effect has not been set,
        /// equivalent to all.
        ///
        /// Assigning any other value has no effect and retains the old value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEffectAllowedAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aEffectAllowed);
		
		/// <summary>
        /// Specifies the effects that are allowed for this drag. You may set this in
        /// the dragstart event to set the desired effects for the source, and within
        /// the dragenter and dragover events to set the desired effects for the
        /// target. The value is not used for other events.
        ///
        /// Possible values:
        /// copy - a copy of the source item is made at the new location
        /// move - an item is moved to a new location
        /// link - a link is established to the source at the new location
        /// copyLink, copyMove, linkMove, all - combinations of the above
        /// none - the item may not be dropped
        /// uninitialized - the default value when the effect has not been set,
        /// equivalent to all.
        ///
        /// Assigning any other value has no effect and retains the old value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEffectAllowedAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aEffectAllowed);
		
		/// <summary>
        /// Holds a list of all the local files available on this data transfer.
        /// A dataTransfer containing no files will return an empty list, and an
        /// invalid index access on the resulting file list will return null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMFileList GetFilesAttribute();
		
		/// <summary>
        /// Holds a list of the format types of the data that is stored for the first
        /// item, in the same order the data was added. An empty list will be
        /// returned if no data was added.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetTypesAttribute();
		
		/// <summary>
        /// Remove the data associated with a given format. If format is empty or not
        /// specified, the data associated with all formats is removed. If data for
        /// the specified format does not exist, or the data transfer contains no
        /// data, this method will have no effect.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearData([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase format);
		
		/// <summary>
        /// Set the data for a given format. If data for the format does not exist,
        /// it is added at the end, such that the last item in the types list will be
        /// the new format. If data for the format already exists, the existing data
        /// is replaced in the same position. That is, the order of the types list is
        /// not changed.
        ///
        /// @throws NS_ERROR_NULL_POINTER if the data is null
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetData([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase format, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase data);
		
		/// <summary>
        /// Retrieves the data for a given format, or an empty string if data for
        /// that format does not exist or the data transfer contains no data.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetData([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase format, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Set the image to be used for dragging if a custom one is desired. Most of
        /// the time, this would not be set, as a default image is created from the
        /// node that was dragged.
        ///
        /// If the node is an HTML img element, an HTML canvas element or a XUL image
        /// element, the image data is used. Otherwise, image should be a visible
        /// node and the drag image will be created from this. If image is null, any
        /// custom drag image is cleared and the default is used instead.
        ///
        /// The coordinates specify the offset into the image where the mouse cursor
        /// should be. To center the image for instance, use values that are half the
        /// width and height.
        ///
        /// @param image a node to use
        /// @param x the horizontal offset
        /// @param y the vertical offset
        /// @throws NO_MODIFICATION_ALLOWED_ERR if the item cannot be modified
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDragImage([MarshalAs(UnmanagedType.Interface)] nsIDOMElement image, int x, int y);
		
		/// <summary>
        /// Set the drag source. Usually you would not change this, but it will
        /// affect which node the drag and dragend events are fired at. The
        /// default target is the node that was dragged.
        ///
        /// @param element drag source to use
        /// @throws NO_MODIFICATION_ALLOWED_ERR if the item cannot be modified
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement element);
	}
	
	/// <summary>nsIDOMNSDataTransfer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("AE6DF4E2-FA37-4701-A33E-A5678F826EED")]
	public interface nsIDOMNSDataTransfer
	{
		
		/// <summary>
        /// Integer version of dropEffect, set to one of the constants in nsIDragService.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetDropEffectIntAttribute();
		
		/// <summary>
        /// Integer version of dropEffect, set to one of the constants in nsIDragService.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDropEffectIntAttribute(uint aDropEffectInt);
		
		/// <summary>
        /// Integer version of effectAllowed, set to one or a combination of the
        /// constants in nsIDragService.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetEffectAllowedIntAttribute();
		
		/// <summary>
        /// Integer version of effectAllowed, set to one or a combination of the
        /// constants in nsIDragService.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEffectAllowedIntAttribute(uint aEffectAllowedInt);
		
		/// <summary>
        /// Creates a copy of the data transfer object, for the given event type and
        /// user cancelled flag.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDataTransfer Clone(uint aEventType, [MarshalAs(UnmanagedType.U1)] bool aUserCancelled);
		
		/// <summary>
        /// The number of items being dragged.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMozItemCountAttribute();
		
		/// <summary>
        /// Sets the drag cursor state. Primarily used to control the cursor during
        /// tab drags, but could be expanded to other uses. XXX Currently implemented
        /// on Win32 only.
        ///
        /// Possible values:
        /// auto - use default system behavior.
        /// default - set the cursor to an arrow during the drag operation.
        ///
        /// Values other than 'default' are indentical to setting mozCursor to
        /// 'auto'.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMozCursorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMozCursor);
		
		/// <summary>
        /// Sets the drag cursor state. Primarily used to control the cursor during
        /// tab drags, but could be expanded to other uses. XXX Currently implemented
        /// on Win32 only.
        ///
        /// Possible values:
        /// auto - use default system behavior.
        /// default - set the cursor to an arrow during the drag operation.
        ///
        /// Values other than 'default' are indentical to setting mozCursor to
        /// 'auto'.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozCursorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMozCursor);
		
		/// <summary>
        /// Holds a list of the format types of the data that is stored for an item
        /// at the specified index. If the index is not in the range from 0 to
        /// itemCount - 1, an empty string list is returned.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr MozTypesAt(uint index);
		
		/// <summary>
        /// Remove the data associated with the given format for an item at the
        /// specified index. The index is in the range from zero to itemCount - 1.
        ///
        /// If the last format for the item is removed, the entire item is removed,
        /// reducing the itemCount by one.
        ///
        /// If format is empty, then the data associated with all formats is removed.
        /// If the format is not found, then this method has no effect.
        ///
        /// @param format the format to remove
        /// @throws NS_ERROR_DOM_INDEX_SIZE_ERR if index is greater or equal than itemCount
        /// @throws NO_MODIFICATION_ALLOWED_ERR if the item cannot be modified
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MozClearDataAt([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase format, uint index);
		
		/// <summary>
        /// A data transfer may store multiple items, each at a given zero-based
        /// index. setDataAt may only be called with an index argument less than
        /// itemCount in which case an existing item is modified, or equal to
        /// itemCount in which case a new item is added, and the itemCount is
        /// incremented by one.
        ///
        /// Data should be added in order of preference, with the most specific
        /// format added first and the least specific format added last. If data of
        /// the given format already exists, it is replaced in the same position as
        /// the old data.
        ///
        /// The data should be either a string, a primitive boolean or number type
        /// (which will be converted into a string) or an nsISupports.
        ///
        /// @param format the format to add
        /// @param data the data to add
        /// @throws NS_ERROR_NULL_POINTER if the data is null
        /// @throws NS_ERROR_DOM_INDEX_SIZE_ERR if index is greater than itemCount
        /// @throws NO_MODIFICATION_ALLOWED_ERR if the item cannot be modified
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MozSetDataAt([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase format, [MarshalAs(UnmanagedType.Interface)] nsIVariant data, uint index);
		
		/// <summary>
        /// Retrieve the data associated with the given format for an item at the
        /// specified index, or null if it does not exist. The index should be in the
        /// range from zero to itemCount - 1.
        ///
        /// @param format the format of the data to look up
        /// @returns the data of the given format, or null if it doesn't exist.
        /// @throws NS_ERROR_DOM_INDEX_SIZE_ERR if index is greater or equal than itemCount
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant MozGetDataAt([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase format, uint index);
		
		/// <summary>
        /// Will be true when the user has cancelled the drag (typically by pressing
        /// Escape) and when the drag has been cancelled unexpectedly.  This will be
        /// false otherwise, including when the drop has been rejected by its target.
        /// This property is only relevant for the dragend event.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMozUserCancelledAttribute();
		
		/// <summary>
        /// The node that the mouse was pressed over to begin the drag. For external
        /// drags, or if the caller cannot access this node, this will be null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetMozSourceNodeAttribute();
	}
}
