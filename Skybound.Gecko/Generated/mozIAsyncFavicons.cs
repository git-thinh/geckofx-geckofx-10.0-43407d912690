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
// Generated by IDLImporter from file mozIAsyncFavicons.idl
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
    /// Interface for accessing the favicon service asynchronously.
    ///
    /// @status EXPERIMENTAL
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0cb4e536-e120-41e6-998f-66123d81ec53")]
	public interface mozIAsyncFavicons
	{
		
		/// <summary>
        /// Declares that a given page uses a favicon with the given URI and
        /// attempts to fetch and save the icon data by loading the favicon URI
        /// through an async network request.
        ///
        /// If the icon data already exists, we won't try to reload the icon unless
        /// aForceReload is true.  Similarly, if the icon is in the failed favicon
        /// cache we won't do anything unless aForceReload is true, in which case
        /// we'll try to reload the favicon.
        ///
        /// This function will only save favicons for "good" URIs, as defined by what
        /// gets added to history or is a bookmark.  For "bad" URIs, this function
        /// will succeed but do nothing.  This function will also ignore the error
        /// page favicon URI (see FAVICON_ERRORPAGE_URL below).
        ///
        /// Icons that fail to load will automatically be added to the failed favicon
        /// cache, and this function will not save favicons for non-bookmarked URIs
        /// when history is disabled.
        ///
        /// @note This function is identical to
        /// nsIFaviconService::setAndLoadFaviconForPage.
        ///
        /// @param aPageURI
        /// URI of the page whose favicon is being set.
        /// @param aFaviconURI
        /// URI of the favicon to associate with the page.
        /// @param aForceReload
        /// If aForceReload is false, we try to reload the favicon only if we
        /// don't have it or it has expired from the cache.  Setting
        /// aForceReload to true causes us to reload the favicon even if we
        /// have a usable copy.
        /// @param aCallback
        /// Once we're done setting and/or fetching the favicon, we invoke this
        /// callback.
        ///
        /// @see nsIFaviconDataCallback in nsIFaviconService.idl.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAndFetchFaviconForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, [MarshalAs(UnmanagedType.U1)] bool aForceReload, [MarshalAs(UnmanagedType.Interface)] nsIFaviconDataCallback aCallback);
		
		/// <summary>
        /// Retrieve the URL of the favicon for the given page.
        ///
        /// @param aPageURI
        /// URI of the page whose favicon's URL we're looking up
        /// @param aCallback
        /// Once we've found the favicon's URL, we invoke this callback.  Note
        /// that the callback's aDataLen will be 0, aData will be null, and
        /// aMimeType will be empty -- only aURI will be non-zero/null/empty.
        ///
        /// @see nsIFaviconDataCallback in nsIFaviconService.idl.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFaviconURLForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI, [MarshalAs(UnmanagedType.Interface)] nsIFaviconDataCallback aCallback);
		
		/// <summary>
        /// Retrieve the URL and data of the favicon for the given page.
        ///
        /// @param aPageURI
        /// URI of the page whose favicon's URL and data we're looking up
        /// @param aCallback
        /// Once we've found the favicon's URL, we invoke this callback with
        /// the favicon data.
        ///
        /// @see nsIFaviconDataCallback in nsIFaviconService.idl.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFaviconDataForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI, [MarshalAs(UnmanagedType.Interface)] nsIFaviconDataCallback aCallback);
	}
}