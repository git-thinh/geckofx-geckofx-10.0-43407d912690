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
// Generated by IDLImporter from file nsICommandLineRunner.idl
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
    /// Extension of nsICommandLine that allows for initialization of new command lines
    /// and running the command line actions by processing the command line handlers.
    ///
    /// @status INTERNAL - This interface is not meant for use by embedders, and is
    /// not intended to be frozen. If you are an embedder and need
    /// functionality provided by this interface, talk to Benjamin
    /// Smedberg <benjamin@smedbergs.us>.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c1f4cfbf-a41f-4628-aa6c-9fb914478af8")]
	public interface nsICommandLineRunner : nsICommandLine
	{
		
		/// <summary>
        /// Number of arguments in the command line. The application name is not
        /// part of the command line.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetLengthAttribute();
		
		/// <summary>
        /// Get an argument from the array of command-line arguments.
        ///
        /// On windows, flags of the form /flag are normalized to -flag. /flag:param
        /// are normalized to -flag param.
        ///
        /// On *nix and mac flags of the form --flag are normalized to -flag. --flag=param
        /// are normalized to the form -flag param.
        ///
        /// @param aIndex The argument to retrieve. This index is 0-based, and does
        /// not include the application name.
        /// @return       The indexth argument.
        /// @throws       NS_ERROR_INVALID_ARG if aIndex is out of bounds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetArgument(int aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Find a command-line flag.
        ///
        /// @param aFlag          The flag name to locate. Do not include the initial
        /// hyphen.
        /// @param aCaseSensitive Whether to do case-sensitive comparisons.
        /// @return               The position of the flag in the command line.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int FindFlag([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aFlag, [MarshalAs(UnmanagedType.U1)] bool aCaseSensitive);
		
		/// <summary>
        /// Remove arguments from the command line. This normally occurs after
        /// a handler has processed the arguments.
        ///
        /// @param aStart  Index to begin removing.
        /// @param aEnd    Index to end removing, inclusive.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveArguments(int aStart, int aEnd);
		
		/// <summary>
        /// A helper method which will find a flag and remove it in one step.
        ///
        /// @param aFlag  The flag name to find and remove.
        /// @param aCaseSensitive Whether to do case-sensitive comparisons.
        /// @return       Whether the flag was found.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HandleFlag([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aFlag, [MarshalAs(UnmanagedType.U1)] bool aCaseSensitive);
		
		/// <summary>
        /// Find a flag with a parameter and remove both. This is a helper
        /// method that combines "findFlag" and "removeArguments" in one step.
        ///
        /// @return   null (a void astring) if the flag is not found. The parameter value
        /// if found. Note that null and the empty string are not the same.
        /// @throws   NS_ERROR_INVALID_ARG if the flag exists without a parameter
        ///
        /// @param aFlag The flag name to find and remove.
        /// @param aCaseSensitive Whether to do case-sensitive flag search.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void HandleFlagWithParam([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aFlag, [MarshalAs(UnmanagedType.U1)] bool aCaseSensitive, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// The type of command line being processed.
        ///
        /// STATE_INITIAL_LAUNCH  is the first launch of the application instance.
        /// STATE_REMOTE_AUTO     is a remote command line automatically redirected to
        /// this instance.
        /// STATE_REMOTE_EXPLICIT is a remote command line explicitly redirected to
        /// this instance using xremote/windde/appleevents.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetStateAttribute();
		
		/// <summary>
        /// There may be a command-line handler which performs a default action if
        /// there was no explicit action on the command line (open a default browser
        /// window, for example). This flag allows the default action to be prevented.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetPreventDefaultAttribute();
		
		/// <summary>
        /// There may be a command-line handler which performs a default action if
        /// there was no explicit action on the command line (open a default browser
        /// window, for example). This flag allows the default action to be prevented.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPreventDefaultAttribute([MarshalAs(UnmanagedType.U1)] bool aPreventDefault);
		
		/// <summary>
        /// The working directory for this command line. Use this property instead
        /// of the working directory for the current process, since a redirected
        /// command line may have had a different working directory.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIFile GetWorkingDirectoryAttribute();
		
		/// <summary>
        /// A window to be targeted by this command line. In most cases, this will
        /// be null (xremote will sometimes set this attribute).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindow GetWindowContextAttribute();
		
		/// <summary>
        /// Resolve a file-path argument into an nsIFile. This method gracefully
        /// handles relative or absolute file paths, according to the working
        /// directory of this command line.
        ///
        /// @param aArgument  The command-line argument to resolve.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIFile ResolveFile([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aArgument);
		
		/// <summary>
        /// Resolves a URI argument into a URI. This method has platform-specific
        /// logic for converting an absolute URI or a relative file-path into the
        /// appropriate URI object; it gracefully handles win32 C:\ paths which would
        /// confuse the ioservice if passed directly.
        ///
        /// @param aArgument  The command-line argument to resolve.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI ResolveURI([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aArgument);
		
		/// <summary>
        /// This method assumes a native character set, and is meant to be called
        /// with the argc/argv passed to main(). Talk to bsmedberg if you need to
        /// create a command line using other data. argv will not be altered in any
        /// way.
        ///
        /// On Windows, the "native" character set is UTF-8, not the native codepage.
        ///
        /// @param workingDir The working directory for resolving file and URI paths.
        /// @param state      The nsICommandLine.state flag.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init(int argc, System.IntPtr argv, [MarshalAs(UnmanagedType.Interface)] nsIFile workingDir, uint state);
		
		/// <summary>
        /// Set the windowContext parameter.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWindowContext([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        /// Process the command-line handlers in the proper order, calling "handle()" on
        /// each.
        ///
        /// @throws NS_ERROR_ABORT if any handler throws NS_ERROR_ABORT. All other errors
        /// thrown by handlers will be silently ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Run();
		
		/// <summary>
        /// Process and combine the help text provided by each command-line handler.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHelpTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHelpText);
	}
}
