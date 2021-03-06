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
// Generated by IDLImporter from file nsIFrameMessageManager.idl
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
	
	
	/// <summary>nsIFrameMessageListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("938fcb95-3d63-46be-aa72-94d08fd3b418")]
	public interface nsIFrameMessageListener
	{
		
		/// <summary>
        /// This is for JS only.
        /// receiveMessage is called with one parameter, which has the following
        /// properties:
        /// {
        /// name:    %message name%,
        /// sync:    %true or false%.
        /// json:    %json object or null%,
        /// objects: %array of handles or null, always null if sync is false%
        /// }
        /// @note objects property isn't implemented yet.
        ///
        /// if the message is synchronous, possible return value is sent back
        /// as JSON.
        ///
        /// When the listener is called, 'this' value is the target of the message.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReceiveMessage();
	}
	
	/// <summary>nsIFrameMessageManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a27d8fcd-8de9-4a51-87f4-2b83bba901d5")]
	public interface nsIFrameMessageManager
	{
		
		/// <summary>Member AddMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage, System.IntPtr aListener);
		
		/// <summary>Member RemoveMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage, System.IntPtr aListener);
		
		/// <summary>Member SendAsyncMessage </summary>
		/// <param name='messageName'> </param>
		/// <param name='obj'> </param>
		/// <param name='jsContext'> </param>
		/// <param name='argc'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendAsyncMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase messageName, System.IntPtr obj, System.IntPtr jsContext, int argc);
	}
	
	/// <summary>nsISyncMessageSender </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("21e5d940-d457-4c0f-bb5e-35c159ed19e3")]
	public interface nsISyncMessageSender : nsIFrameMessageManager
	{
		
		/// <summary>Member AddMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage, System.IntPtr aListener);
		
		/// <summary>Member RemoveMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage, System.IntPtr aListener);
		
		/// <summary>Member SendAsyncMessage </summary>
		/// <param name='messageName'> </param>
		/// <param name='obj'> </param>
		/// <param name='jsContext'> </param>
		/// <param name='argc'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SendAsyncMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase messageName, System.IntPtr obj, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// Returns an array of JSON objects.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr SendSyncMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase messageName, System.IntPtr obj, System.IntPtr jsContext, int argc);
	}
	
	/// <summary>nsIContentFrameMessageManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("78a1d024-60e3-4b7b-98cd-4c6b84b4f060")]
	public interface nsIContentFrameMessageManager : nsISyncMessageSender
	{
		
		/// <summary>Member AddMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage, System.IntPtr aListener);
		
		/// <summary>Member RemoveMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage, System.IntPtr aListener);
		
		/// <summary>Member SendAsyncMessage </summary>
		/// <param name='messageName'> </param>
		/// <param name='obj'> </param>
		/// <param name='jsContext'> </param>
		/// <param name='argc'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SendAsyncMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase messageName, System.IntPtr obj, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// Returns an array of JSON objects.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr SendSyncMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase messageName, System.IntPtr obj, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// The current top level window in the frame or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetContentAttribute();
		
		/// <summary>
        /// The top level docshell or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShell GetDocShellAttribute();
		
		/// <summary>
        /// Print a string to stdout.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Dump([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aStr);
		
		/// <summary>
        /// If leak detection is enabled, print a note to the leak log that this
        /// process will intentionally crash.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrivateNoteIntentionalCrash();
		
		/// <summary>
        /// Ascii base64 data to binary data and vice versa
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Atob([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAsciiString, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>Member Btoa </summary>
		/// <param name='aBase64Data'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Btoa([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBase64Data, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
	}
	
	/// <summary>nsIInProcessContentFrameMessageManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1f7af930-a232-4a84-a049-73eaa45f2db5")]
	public interface nsIInProcessContentFrameMessageManager : nsIContentFrameMessageManager
	{
		
		/// <summary>Member AddMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage, System.IntPtr aListener);
		
		/// <summary>Member RemoveMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage, System.IntPtr aListener);
		
		/// <summary>Member SendAsyncMessage </summary>
		/// <param name='messageName'> </param>
		/// <param name='obj'> </param>
		/// <param name='jsContext'> </param>
		/// <param name='argc'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SendAsyncMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase messageName, System.IntPtr obj, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// Returns an array of JSON objects.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr SendSyncMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase messageName, System.IntPtr obj, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// The current top level window in the frame or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindow GetContentAttribute();
		
		/// <summary>
        /// The top level docshell or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDocShell GetDocShellAttribute();
		
		/// <summary>
        /// Print a string to stdout.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Dump([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aStr);
		
		/// <summary>
        /// If leak detection is enabled, print a note to the leak log that this
        /// process will intentionally crash.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PrivateNoteIntentionalCrash();
		
		/// <summary>
        /// Ascii base64 data to binary data and vice versa
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Atob([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAsciiString, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>Member Btoa </summary>
		/// <param name='aBase64Data'> </param>
		/// <param name='retval'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Btoa([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBase64Data, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>Member GetOwnerContent </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetOwnerContent();
	}
	
	/// <summary>nsITreeItemFrameMessageManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e91b0939-a74a-4c4f-8cfd-17dd42e8642a")]
	public interface nsITreeItemFrameMessageManager : nsIFrameMessageManager
	{
		
		/// <summary>Member AddMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage, System.IntPtr aListener);
		
		/// <summary>Member RemoveMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage, System.IntPtr aListener);
		
		/// <summary>Member SendAsyncMessage </summary>
		/// <param name='messageName'> </param>
		/// <param name='obj'> </param>
		/// <param name='jsContext'> </param>
		/// <param name='argc'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SendAsyncMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase messageName, System.IntPtr obj, System.IntPtr jsContext, int argc);
		
		/// <summary>Member GetChildCountAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetChildCountAttribute();
		
		/// <summary>Member GetChildAt </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A nsITreeItemFrameMessageManager</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITreeItemFrameMessageManager GetChildAt(uint aIndex);
	}
	
	/// <summary>nsIChromeFrameMessageManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("14e1f147-793d-4788-bbbb-ae806ecdddbb")]
	public interface nsIChromeFrameMessageManager : nsITreeItemFrameMessageManager
	{
		
		/// <summary>Member AddMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage, System.IntPtr aListener);
		
		/// <summary>Member RemoveMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage, System.IntPtr aListener);
		
		/// <summary>Member SendAsyncMessage </summary>
		/// <param name='messageName'> </param>
		/// <param name='obj'> </param>
		/// <param name='jsContext'> </param>
		/// <param name='argc'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SendAsyncMessage([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase messageName, System.IntPtr obj, System.IntPtr jsContext, int argc);
		
		/// <summary>Member GetChildCountAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetChildCountAttribute();
		
		/// <summary>Member GetChildAt </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A nsITreeItemFrameMessageManager</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsITreeItemFrameMessageManager GetChildAt(uint aIndex);
		
		/// <summary>
        /// Load a script in the (remote) frame. aURL must be the absolute URL.
        /// data: URLs are also supported. For example data:,dump("foo\n");
        /// If aAllowDelayedLoad is true, script will be loaded when the
        /// remote frame becomes available. Otherwise the script will be loaded
        /// only if the frame is already available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadFrameScript([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aURL, [MarshalAs(UnmanagedType.U1)] bool aAllowDelayedLoad);
		
		/// <summary>
        /// Removes aURL from the list of scripts which support delayed load.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveDelayedFrameScript([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aURL);
	}
}
