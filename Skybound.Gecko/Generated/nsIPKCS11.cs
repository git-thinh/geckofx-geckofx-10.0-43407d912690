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
// Generated by IDLImporter from file nsIPKCS11.idl
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
	
	
	/// <summary>nsIPKCS11 </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5743f870-958e-4f02-aef2-c0afeef67f05")]
	public interface nsIPKCS11
	{
		
		/// <summary>Member DeleteModule </summary>
		/// <param name='moduleName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteModule([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase moduleName);
		
		/// <summary>Member AddModule </summary>
		/// <param name='moduleName'> </param>
		/// <param name='libraryFullPath'> </param>
		/// <param name='cryptoMechanismFlags'> </param>
		/// <param name='cipherFlags'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddModule([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase moduleName, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase libraryFullPath, int cryptoMechanismFlags, int cipherFlags);
	}
}
