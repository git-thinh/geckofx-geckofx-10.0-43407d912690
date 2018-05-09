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
// Generated by IDLImporter from file nsIResumableChannel.idl
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
	
	
	/// <summary>nsIResumableChannel </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4ad136fa-83af-4a22-a76e-503642c0f4a8")]
	public interface nsIResumableChannel
	{
		
		/// <summary>
        /// Prepare this channel for resuming. The request will not start until
        /// asyncOpen or open is called. Calling resumeAt after open or asyncOpen
        /// has been called has undefined behaviour.
        ///
        /// @param startPos the starting offset, in bytes, to use to download
        /// @param entityID information about the file, to match before obtaining
        /// the file. Pass an empty string to use anything.
        ///
        /// During OnStartRequest, this channel will have a status of
        /// NS_ERROR_NOT_RESUMABLE if the file cannot be resumed, eg because the
        /// server doesn't support this. This error may occur even if startPos
        /// is 0, so that the front end can warn the user.
        /// Similarly, the status of this channel during OnStartRequest may be
        /// NS_ERROR_ENTITY_CHANGED, which indicates that the entity has changed,
        /// as indicated by a changed entityID.
        /// In both of these cases, no OnDataAvailable will be called, and
        /// OnStopRequest will immediately follow with the same status code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResumeAt(ulong startPos, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase entityID);
		
		/// <summary>
        /// The entity id for this URI. Available after OnStartRequest.
        /// @throw NS_ERROR_NOT_RESUMABLE if this load is not resumable.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEntityIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aEntityID);
	}
}
