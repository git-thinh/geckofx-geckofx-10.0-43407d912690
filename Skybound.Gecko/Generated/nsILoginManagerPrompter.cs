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
// Generated by IDLImporter from file nsILoginManagerPrompter.idl
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
	
	
	/// <summary>nsILoginManagerPrompter </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("68b3cb59-51b8-4c57-bd7f-b2ce955a593d")]
	public interface nsILoginManagerPrompter
	{
		
		/// <summary>
        /// Initialize the prompter. Must be called before using other interfaces.
        ///
        /// @param aWindow
        /// The in which the user is doing some login-related action that's
        /// resulting in a need to prompt them for something. The prompt
        /// will be associated with this window (or, if a notification bar
        /// is being used, topmost opener in some cases).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        /// Ask the user if they want to save a login (Yes, Never, Not Now)
        ///
        /// @param aLogin
        /// The login to be saved.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PromptToSavePassword([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aLogin);
		
		/// <summary>
        /// Ask the user if they want to change a login's password. If the
        /// user consents, modifyLogin() will be called.
        ///
        /// @param aOldLogin
        /// The existing login (with the old password).
        /// @param aNewLogin
        /// The new login.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PromptToChangePassword([MarshalAs(UnmanagedType.Interface)] nsILoginInfo aOldLogin, [MarshalAs(UnmanagedType.Interface)] nsILoginInfo aNewLogin);
		
		/// <summary>
        /// Ask the user if they want to change the password for one of
        /// multiple logins, when the caller can't determine exactly which
        /// login should be changed. If the user consents, modifyLogin() will
        /// be called.
        ///
        /// @param logins
        /// An array of existing logins.
        /// @param count
        /// (length of the array)
        /// @param aNewLogin
        /// The new login.
        ///
        /// Note: Because the caller does not know the username of the login
        /// to be changed, aNewLogin.username and aNewLogin.usernameField
        /// will be set (using the user's selection) before modifyLogin()
        /// is called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PromptToChangePasswordWithUsernames([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] nsILoginInfo[] logins, uint count, [MarshalAs(UnmanagedType.Interface)] nsILoginInfo aNewLogin);
	}
}
