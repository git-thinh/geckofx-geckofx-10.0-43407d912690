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
// Generated by IDLImporter from file nsITimer.idl
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
    /// The callback interface for timers.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a796816d-7d47-4348-9ab8-c7aeb3216a7d")]
	public interface nsITimerCallback
	{
		
		/// <summary>
        /// @param aTimer the timer which has expired
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Notify([MarshalAs(UnmanagedType.Interface)] nsITimer timer);
	}
	
	/// <summary>
    /// nsITimer instances must be initialized by calling one of the "init" methods
    /// documented below.  You may also re-initialize (using one of the init()
    /// methods) an existing instance to avoid the overhead of destroying and
    /// creating a timer.  It is not necessary to cancel the timer in that case.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("193fc37a-8aa4-4d29-aa57-1acd87c26b66")]
	public interface nsITimer
	{
		
		/// <summary>
        /// Initialize a timer that will fire after the said delay.
        /// A user must keep a reference to this timer till it is
        /// is no longer needed or has been cancelled.
        ///
        /// @param aObserver   the callback object that observes the
        /// ``timer-callback'' topic with the subject being
        /// the timer itself when the timer fires:
        ///
        /// observe(nsISupports aSubject, => nsITimer
        /// string aTopic,        => ``timer-callback''
        /// wstring data          =>  null
        ///
        /// @param aDelay      delay in milliseconds for timer to fire
        /// @param aType       timer type per TYPE* consts defined above
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver, uint aDelay, uint aType);
		
		/// <summary>
        /// Initialize a timer to fire after the given millisecond interval.
        /// This version takes a function to call and a closure to pass to
        /// that function.
        ///
        /// @param aFunc      The function to invoke
        /// @param aClosure   An opaque pointer to pass to that function
        /// @param aDelay     The millisecond interval
        /// @param aType      Timer type per TYPE* consts defined above
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithFuncCallback(System.IntPtr aCallback, System.IntPtr aClosure, uint aDelay, uint aType);
		
		/// <summary>
        /// Initialize a timer to fire after the given millisecond interval.
        /// This version takes a function to call and a closure to pass to
        /// that function.
        ///
        /// @param aFunc      nsITimerCallback interface to call when timer expires
        /// @param aDelay     The millisecond interval
        /// @param aType      Timer type per TYPE* consts defined above
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithCallback([MarshalAs(UnmanagedType.Interface)] nsITimerCallback aCallback, uint aDelay, uint aType);
		
		/// <summary>
        /// Cancel the timer.  This method works on all types, not just on repeating
        /// timers -- you might want to cancel a TYPE_ONE_SHOT timer, and even reuse
        /// it by re-initializing it (to avoid object destruction and creation costs
        /// by conserving one timer instance).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel();
		
		/// <summary>
        /// The millisecond delay of the timeout.
        ///
        /// NOTE: Re-setting the delay on a one-shot timer that has already fired
        /// doesn't restart the timer. Call one of the init() methods to restart
        /// a one-shot timer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetDelayAttribute();
		
		/// <summary>
        /// The millisecond delay of the timeout.
        ///
        /// NOTE: Re-setting the delay on a one-shot timer that has already fired
        /// doesn't restart the timer. Call one of the init() methods to restart
        /// a one-shot timer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDelayAttribute(uint aDelay);
		
		/// <summary>
        /// The timer type - one of the above TYPE_* constants.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTypeAttribute();
		
		/// <summary>
        /// The timer type - one of the above TYPE_* constants.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute(uint aType);
		
		/// <summary>
        /// The opaque pointer pass to initWithFuncCallback.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetClosureAttribute();
		
		/// <summary>
        /// The nsITimerCallback object passed to initWithCallback.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITimerCallback GetCallbackAttribute();
		
		/// <summary>
        /// The nsIEventTarget where the callback will be dispatched. Note that this
        /// target may only be set before the call to one of the init methods above.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIEventTarget GetTargetAttribute();
		
		/// <summary>
        /// The nsIEventTarget where the callback will be dispatched. Note that this
        /// target may only be set before the call to one of the init methods above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTargetAttribute([MarshalAs(UnmanagedType.Interface)] nsIEventTarget aTarget);
	}
}
