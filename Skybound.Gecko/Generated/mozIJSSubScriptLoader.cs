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
// Generated by IDLImporter from file mozIJSSubScriptLoader.idl
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
	
	
	/// <summary>mozIJSSubScriptLoader </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8792d77e-1dd2-11b2-ac7f-9bc9be4f2916")]
	public interface mozIJSSubScriptLoader
	{
		
		/// <summary>
        /// This method should only be called from JS!
        /// In JS, the signature looks like:
        /// rv loadSubScript (url [, obj] [, charset]);
        /// @param url the url if the sub-script, it MUST be either a file:,
        /// resource:, or chrome: url, and MUST be local.
        /// @param obj an optional object to evaluate the script onto, it
        /// defaults to the global object of the caller.
        /// @param charset optionally specifies the character encoding of
        /// the file. If absent, the file is interpreted
        ///		      as ASCII.
        /// @retval rv the value returned by the sub-script
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadSubScript([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string url);
	}
}
