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
// Generated by IDLImporter from file nsIDeviceMotion.idl
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
	
	
	/// <summary>nsIDeviceMotionData </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1B406E32-CF42-471E-A470-6FD600BF4C7B")]
	public interface nsIDeviceMotionData
	{
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTypeAttribute();
		
		/// <summary>Member GetXAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetXAttribute();
		
		/// <summary>Member GetYAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetYAttribute();
		
		/// <summary>Member GetZAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetZAttribute();
	}
	
	/// <summary>nsIDeviceMotionListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f01774a2-3b7e-4630-954b-196dc178221f")]
	public interface nsIDeviceMotionListener
	{
		
		/// <summary>Member OnMotionChange </summary>
		/// <param name='aMotionData'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnMotionChange([MarshalAs(UnmanagedType.Interface)] nsIDeviceMotionData aMotionData);
	}
	
	/// <summary>nsIDeviceMotion </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B6E5C463-AAA6-44E2-BD07-7A7DC6192E68")]
	public interface nsIDeviceMotion
	{
		
		/// <summary>Member AddListener </summary>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddListener([MarshalAs(UnmanagedType.Interface)] nsIDeviceMotionListener aListener);
		
		/// <summary>Member RemoveListener </summary>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsIDeviceMotionListener aListener);
		
		/// <summary>
        /// to call RemoveWindowListener before the window is deleted.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddWindowListener([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>Member RemoveWindowListener </summary>
		/// <param name='aWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveWindowListener([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
	}
	
	/// <summary>
    ///for use by IPC system to notify non-chrome processes of
    /// device motion events
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d3a56f08-b7b1-46bb-9dc1-fc3665a3631a")]
	public interface nsIDeviceMotionUpdate : nsIDeviceMotion
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddListener([MarshalAs(UnmanagedType.Interface)] nsIDeviceMotionListener aListener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveListener([MarshalAs(UnmanagedType.Interface)] nsIDeviceMotionListener aListener);
		
		/// <summary>
        /// to call RemoveWindowListener before the window is deleted.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddWindowListener([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveWindowListener([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        ///must be called on the main thread or else </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeviceMotionChanged(uint type, double x, double y, double z);
	}
}
