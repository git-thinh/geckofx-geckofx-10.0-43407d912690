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
// Generated by IDLImporter from file nsITooltipListener.idl
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
    /// An optional interface for embedding clients wishing to receive
    /// notifications for when a tooltip should be displayed or removed.
    /// The embedder implements this interface on the web browser chrome
    /// object associated with the window that notifications are required
    /// for.
    ///
    /// @see nsITooltipTextProvider
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("44b78386-1dd2-11b2-9ad2-e4eee2ca1916")]
	public interface nsITooltipListener
	{
		
		/// <summary>
        /// Called when a tooltip should be displayed.
        ///
        /// @param aXCoords The tooltip left edge X coordinate.
        /// @param aYCoords The tooltip top edge Y coordinate.
        /// @param aTipText The text to display in the tooltip, typically obtained
        /// from the TITLE attribute of the node (or containing parent)
        /// over which the pointer has been positioned.
        ///
        /// @note
        /// Coordinates are specified in pixels, relative to the top-left
        /// corner of the browser area.
        ///
        /// @return <code>NS_OK</code> if the tooltip was displayed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnShowTooltip(int aXCoords, int aYCoords, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTipText);
		
		/// <summary>
        /// Called when the tooltip should be hidden, either because the pointer
        /// has moved or the tooltip has timed out.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnHideTooltip();
	}
}
