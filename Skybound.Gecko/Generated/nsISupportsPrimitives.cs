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
// Generated by IDLImporter from file nsISupportsPrimitives.idl
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
    /// Primitive base interface.
    ///
    /// These first three are pointer types and do data copying
    /// using the nsIMemory. Be careful!
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d0d4b136-1dd1-11b2-9371-f0727ef827c0")]
	public interface nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetTypeAttribute();
	}
	
	/// <summary>
    /// Scriptable storage for nsID structures
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d18290a0-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsID : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for nsID structures
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for nsID structures
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(System.IntPtr aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for ASCII strings
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d65ff270-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsCString : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for ASCII strings
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aData);
		
		/// <summary>
        /// Scriptable storage for ASCII strings
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for Unicode strings
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d79dc970-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsString : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for Unicode strings
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aData);
		
		/// <summary>
        /// Scriptable storage for Unicode strings
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aData);
		
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for booleans
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ddc3b490-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsPRBool : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for booleans
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for booleans
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute([MarshalAs(UnmanagedType.U1)] bool aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for 8-bit integers
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("dec2e4e0-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsPRUint8 : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for 8-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		byte GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for 8-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(byte aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for unsigned 16-bit integers
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("dfacb090-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsPRUint16 : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for unsigned 16-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for unsigned 16-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(ushort aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for unsigned 32-bit integers
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e01dc470-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsPRUint32 : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for unsigned 32-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for unsigned 32-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(uint aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for 64-bit integers
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e13567c0-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsPRUint64 : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for 64-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ulong GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for 64-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(ulong aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for NSPR date/time values
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e2563630-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsPRTime : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for NSPR date/time values
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for NSPR date/time values
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(long aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for single character values
    /// (often used to store an ASCII character)
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e2b05e40-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsChar : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for single character values
        /// (often used to store an ASCII character)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		char GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for single character values
        /// (often used to store an ASCII character)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(char aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for 16-bit integers
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e30d94b0-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsPRInt16 : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for 16-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for 16-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(short aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for 32-bit integers
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e36c5250-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsPRInt32 : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for 32-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for 32-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(int aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for 64-bit integers
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e3cb0ff0-4a1c-11d3-9890-006008962422")]
	public interface nsISupportsPRInt64 : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for 64-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for 64-bit integers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(long aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for floating point numbers
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("abeaa390-4ac0-11d3-baea-00805f8a5dd7")]
	public interface nsISupportsFloat : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for floating point numbers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for floating point numbers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(float aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for doubles
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b32523a0-4ac0-11d3-baea-00805f8a5dd7")]
	public interface nsISupportsDouble : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for doubles
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for doubles
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(double aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for generic pointers
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("464484f0-568d-11d3-baf8-00805f8a5dd7")]
	public interface nsISupportsVoid : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for generic pointers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for generic pointers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute(System.IntPtr aData);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
	
	/// <summary>
    /// Scriptable storage for other XPCOM objects
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("995ea724-1dd1-11b2-9211-c21bdd3e7ed0")]
	public interface nsISupportsInterfacePointer : nsISupportsPrimitive
	{
		
		/// <summary>
        /// Primitive base interface.
        ///
        /// These first three are pointer types and do data copying
        /// using the nsIMemory. Be careful!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetTypeAttribute();
		
		/// <summary>
        /// Scriptable storage for other XPCOM objects
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetDataAttribute();
		
		/// <summary>
        /// Scriptable storage for other XPCOM objects
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aData);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetDataIIDAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDataIIDAttribute(System.IntPtr aDataIID);
		
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToString();
	}
}
