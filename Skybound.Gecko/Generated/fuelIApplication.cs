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
// Generated by IDLImporter from file fuelIApplication.idl
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
    /// Interface representing a collection of annotations associated
    /// with a bookmark or bookmark folder.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("335c9292-91a1-4ca0-ad0b-07d5f63ed6cd")]
	public interface fuelIAnnotations
	{
		
		/// <summary>
        /// Array of the annotation names associated with the owning item
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetNamesAttribute();
		
		/// <summary>
        /// Determines if an annotation exists with the given name.
        /// @param   aName
        /// The name of the annotation
        /// @returns true if an annotation exists with the given name,
        /// false otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Has([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		/// <summary>
        /// Gets the value of an annotation with the given name.
        /// @param   aName
        /// The name of the annotation
        /// @returns A variant containing the value of the annotation. Supports
        /// string, boolean and number.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant Get([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		/// <summary>
        /// Sets the value of an annotation with the given name.
        /// @param   aName
        /// The name of the annotation
        /// @param   aValue
        /// The new value of the annotation. Supports string, boolean
        /// and number
        /// @param   aExpiration
        /// The expiration policy for the annotation.
        /// See nsIAnnotationService.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Set([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue, int aExpiration);
		
		/// <summary>
        /// Removes the named annotation from the owner item.
        /// @param   aName
        /// The name of annotation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
	}
	
	/// <summary>
    /// Interface representing a bookmark item.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("808585b6-7568-4b26-8c62-545221bf2b8c")]
	public interface fuelIBookmark
	{
		
		/// <summary>
        /// The id of the bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetIdAttribute();
		
		/// <summary>
        /// The title of the bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle);
		
		/// <summary>
        /// The title of the bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle);
		
		/// <summary>
        /// The uri of the bookmark.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetUriAttribute();
		
		/// <summary>
        /// The uri of the bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUriAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aUri);
		
		/// <summary>
        /// The description of the bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDescription);
		
		/// <summary>
        /// The description of the bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDescription);
		
		/// <summary>
        /// The keyword associated with the bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetKeywordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aKeyword);
		
		/// <summary>
        /// The keyword associated with the bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetKeywordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aKeyword);
		
		/// <summary>
        /// The type of the bookmark.
        /// values: "bookmark", "separator"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>
        /// The parent folder of the bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIBookmarkFolder GetParentAttribute();
		
		/// <summary>
        /// The parent folder of the bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentAttribute(fuelIBookmarkFolder aParent);
		
		/// <summary>
        /// The annotations object for the bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIAnnotations GetAnnotationsAttribute();
		
		/// <summary>
        /// The events object for the bookmark.
        /// supports: "remove", "change", "visit", "move"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		extIEvents GetEventsAttribute();
		
		/// <summary>
        /// Removes the item from the parent folder. Used to
        /// delete a bookmark or separator
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove();
	}
	
	/// <summary>
    /// Interface representing a bookmark folder. Folders
    /// can hold bookmarks, separators and other folders.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9f42fe20-52de-4a55-8632-a459c7716aa0")]
	public interface fuelIBookmarkFolder
	{
		
		/// <summary>
        /// The id of the folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetIdAttribute();
		
		/// <summary>
        /// The title of the folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle);
		
		/// <summary>
        /// The title of the folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle);
		
		/// <summary>
        /// The description of the folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDescription);
		
		/// <summary>
        /// The description of the folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDescription);
		
		/// <summary>
        /// The type of the folder.
        /// values: "folder"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>
        /// The parent folder of the folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIBookmarkFolder GetParentAttribute();
		
		/// <summary>
        /// The parent folder of the folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentAttribute(fuelIBookmarkFolder aParent);
		
		/// <summary>
        /// The annotations object for the folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIAnnotations GetAnnotationsAttribute();
		
		/// <summary>
        /// The events object for the folder.
        /// supports: "add", "addchild", "remove", "removechild", "change", "move"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		extIEvents GetEventsAttribute();
		
		/// <summary>
        /// Array of all bookmarks, separators and folders contained
        /// in this folder.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetChildrenAttribute();
		
		/// <summary>
        /// Adds a new child bookmark to this folder.
        /// @param   aTitle
        /// The title of bookmark.
        /// @param   aURI
        /// The uri of bookmark.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIBookmark AddBookmark([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Adds a new child separator to this folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIBookmark AddSeparator();
		
		/// <summary>
        /// Adds a new child folder to this folder.
        /// @param   aTitle
        /// The title of folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIBookmarkFolder AddFolder([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle);
		
		/// <summary>
        /// Removes the folder from the parent folder.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove();
	}
	
	/// <summary>
    /// Interface representing a container for bookmark roots. Roots
    /// are the top level parents for the various types of bookmarks in the system.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c9a80870-eb3c-11dc-95ff-0800200c9a66")]
	public interface fuelIBookmarkRoots
	{
		
		/// <summary>
        /// The folder for the 'bookmarks menu' root.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIBookmarkFolder GetMenuAttribute();
		
		/// <summary>
        /// The folder for the 'personal toolbar' root.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIBookmarkFolder GetToolbarAttribute();
		
		/// <summary>
        /// The folder for the 'tags' root.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIBookmarkFolder GetTagsAttribute();
		
		/// <summary>
        /// The folder for the 'unfiled bookmarks' root.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIBookmarkFolder GetUnfiledAttribute();
	}
	
	/// <summary>
    /// Interface representing a browser window.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("207edb28-eb5e-424e-a862-b0e97C8de866")]
	public interface fuelIWindow
	{
		
		/// <summary>
        /// A collection of browser tabs within the browser window.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetTabsAttribute();
		
		/// <summary>
        /// The currently-active tab within the browser window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIBrowserTab GetActiveTabAttribute();
		
		/// <summary>
        /// Open a new browser tab, pointing to the specified URI.
        /// @param   aURI
        /// The uri to open the browser tab to
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIBrowserTab Open([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// The events object for the browser window.
        /// supports: "TabOpen", "TabClose", "TabMove", "TabSelect"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		extIEvents GetEventsAttribute();
	}
	
	/// <summary>
    /// Interface representing a browser tab.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3073ceff-777c-41ce-9ace-ab37268147c1")]
	public interface fuelIBrowserTab
	{
		
		/// <summary>
        /// The current uri of this tab.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetUriAttribute();
		
		/// <summary>
        /// The current index of this tab in the browser window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetIndexAttribute();
		
		/// <summary>
        /// The browser window that is holding the tab.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIWindow GetWindowAttribute();
		
		/// <summary>
        /// The content document of the browser tab.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLDocument GetDocumentAttribute();
		
		/// <summary>
        /// The events object for the browser tab.
        /// supports: "load"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		extIEvents GetEventsAttribute();
		
		/// <summary>
        /// Load a new URI into this browser tab.
        /// @param   aURI
        /// The uri to load into the browser tab
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Load([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Give focus to this browser tab, and bring it to the front.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Focus();
		
		/// <summary>
        /// Close the browser tab. This may not actually close the tab
        /// as script may abort the close operation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		/// <summary>
        /// Moves this browser tab before another browser tab within the window.
        /// @param   aBefore
        /// The tab before which the target tab will be moved
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MoveBefore(fuelIBrowserTab aBefore);
		
		/// <summary>
        /// Move this browser tab to the last tab within the window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MoveToEnd();
	}
	
	/// <summary>
    /// Interface for managing and accessing the applications systems
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fe74cf80-aa2d-11db-abbd-0800200c9a66")]
	public interface fuelIApplication : extIApplication
	{
		
		/// <summary>
        /// The id of the application.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aId);
		
		/// <summary>
        /// The name of the application.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		/// <summary>
        /// The version number of the application.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aVersion);
		
		/// <summary>
        /// The console object for the application.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new extIConsole GetConsoleAttribute();
		
		/// <summary>
        /// The extensions object for the application. Contains a list
        /// of all installed extensions.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetExtensions(extIExtensionsCallback aCallback);
		
		/// <summary>
        /// The preferences object for the application. Defaults to an empty
        /// root branch.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new extIPreferenceBranch GetPrefsAttribute();
		
		/// <summary>
        /// The storage object for the application.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new extISessionStorage GetStorageAttribute();
		
		/// <summary>
        /// The events object for the application.
        /// supports: "load", "ready", "quit", "unload"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new extIEvents GetEventsAttribute();
		
		/// <summary>
        /// Quits the application (if nobody objects to quit-application-requested).
        /// @returns whether quitting will proceed
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Quit();
		
		/// <summary>
        /// Restarts the application (if nobody objects to quit-application-requested).
        /// @returns whether restarting will proceed
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Restart();
		
		/// <summary>
        /// The root bookmarks object for the application.
        /// Contains all the bookmark roots in the system.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIBookmarkRoots GetBookmarksAttribute();
		
		/// <summary>
        /// An array of browser windows within the application.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetWindowsAttribute();
		
		/// <summary>
        /// The currently active browser window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		fuelIWindow GetActiveWindowAttribute();
	}
}
