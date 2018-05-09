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
// Generated by IDLImporter from file nsITraceableChannel.idl
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
    /// A channel implementing this interface allows one to intercept its data by
    /// inserting intermediate stream listeners.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("68167b0b-ef34-4d79-a09a-8045f7c5140e")]
	public interface nsITraceableChannel
	{
		
		/// <summary>
        /// Replace the channel's listener with a new one, and return the listener
        /// the channel used to have. The new listener intercepts OnStartRequest,
        /// OnDataAvailable and OnStopRequest calls and must pass them to
        /// the original listener after examination. If multiple callers replace
        /// the channel's listener, a chain of listeners is created.
        /// The caller of setNewListener has no way to control at which place
        /// in the chain its listener is placed.
        ///
        /// Note: The caller of setNewListener must not delay passing
        /// OnStartRequest to the original listener.
        ///
        /// Note2: A channel may restrict when the listener can be replaced.
        /// It is not recommended to allow listener replacement after OnStartRequest
        /// has been called.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStreamListener SetNewListener([MarshalAs(UnmanagedType.Interface)] nsIStreamListener aListener);
	}
}
