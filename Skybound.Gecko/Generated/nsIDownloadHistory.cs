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
// Generated by IDLImporter from file nsIDownloadHistory.idl
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
    /// This interface can be used to add a download to history.  There is a separate
    /// interface specifically for downloads in case embedders choose to track
    /// downloads differently from other types of history.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a7a3358c-9af2-41e3-adfe-3bf0b7ac2c38")]
	public interface nsIDownloadHistory
	{
		
		/// <summary>
        /// Adds a download to history.  This will also notify observers that the
        /// URI aSource is visited with the topic NS_LINK_VISITED_EVENT_TOPIC if
        /// aSource has not yet been visited.
        ///
        /// @param aSource
        /// The source of the download we are adding to history.  This cannot be
        /// null.
        /// @param aReferrer
        /// [optional] The referrer of source URI.
        /// @param aStartTime
        /// [optional] The time the download was started.  If the start time
        /// is not given, the current time is used.
        /// @param aDestination
        /// [optional] The target where the download is to be saved on the local
        /// filesystem.
        /// @throws NS_ERROR_NOT_AVAILABLE
        /// In a situation where a history implementation is not available,
        /// where 'history implementation' refers to something like
        /// nsIGlobalHistory and friends.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddDownload([MarshalAs(UnmanagedType.Interface)] nsIURI aSource, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, long aStartTime, [MarshalAs(UnmanagedType.Interface)] nsIURI aDestination);
	}
}
