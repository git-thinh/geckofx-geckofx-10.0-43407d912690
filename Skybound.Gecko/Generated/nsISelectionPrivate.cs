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
// Generated by IDLImporter from file nsISelectionPrivate.idl
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
	
	
	/// <summary>nsISelectionPrivate </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1820a940-6203-4e27-bc94-fa81131722a4")]
	public interface nsISelectionPrivate : nsISelection
	{
		
		/// <summary>
        /// Returns the node in which the selection begins.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetAnchorNodeAttribute();
		
		/// <summary>
        /// The offset within the (text) node where the selection begins.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetAnchorOffsetAttribute();
		
		/// <summary>
        /// Returns the node in which the selection ends.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFocusNodeAttribute();
		
		/// <summary>
        /// The offset within the (text) node where the selection ends.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetFocusOffsetAttribute();
		
		/// <summary>
        /// Indicates if the selection is collapsed or not.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsCollapsedAttribute();
		
		/// <summary>
        /// Returns the number of ranges in the selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetRangeCountAttribute();
		
		/// <summary>
        /// Returns the range at the specified index.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMRange GetRangeAt(int index);
		
		/// <summary>
        /// Collapses the selection to a single point, at the specified offset
        /// in the given DOM node. When the selection is collapsed, and the content
        /// is focused and editable, the caret will blink there.
        /// @param parentNode      The given dom node where the selection will be set
        /// @param offset          Where in given dom node to place the selection (the offset into the given node)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Collapse([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parentNode, int offset);
		
		/// <summary>
        /// Extends the selection by moving the selection end to the specified node and offset,
        /// preserving the selection begin position. The new selection end result will always
        /// be from the anchorNode to the new focusNode, regardless of direction.
        /// @param parentNode      The node where the selection will be extended to
        /// @param offset          Where in node to place the offset in the new selection end
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Extend([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parentNode, int offset);
		
		/// <summary>
        /// Collapses the whole selection to a single point at the start
        /// of the current selection (irrespective of direction).  If content
        /// is focused and editable, the caret will blink there.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CollapseToStart();
		
		/// <summary>
        /// Collapses the whole selection to a single point at the end
        /// of the current selection (irrespective of direction).  If content
        /// is focused and editable, the caret will blink there.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CollapseToEnd();
		
		/// <summary>
        /// Indicates whether the node is part of the selection. If partlyContained
        /// is set to PR_TRUE, the function returns true when some part of the node
        /// is part of the selection. If partlyContained is set to PR_FALSE, the
        /// function only returns true when the entire node is part of the selection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool ContainsNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node, [MarshalAs(UnmanagedType.U1)] bool partlyContained);
		
		/// <summary>
        /// Adds all children of the specified node to the selection.
        /// @param parentNode  the parent of the children to be added to the selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SelectAllChildren([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parentNode);
		
		/// <summary>
        /// Adds a range to the current selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddRange([MarshalAs(UnmanagedType.Interface)] nsIDOMRange range);
		
		/// <summary>
        /// Removes a range from the current selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveRange([MarshalAs(UnmanagedType.Interface)] nsIDOMRange range);
		
		/// <summary>
        /// Removes all ranges from the current selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAllRanges();
		
		/// <summary>
        /// Deletes this selection from document the nodes belong to.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void DeleteFromDocument();
		
		/// <summary>
        /// Modifies the cursor Bidi level after a change in keyboard direction
        /// @param langRTL is PR_TRUE if the new language is right-to-left or
        /// PR_FALSE if the new language is left-to-right.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SelectionLanguageChange([MarshalAs(UnmanagedType.U1)] bool langRTL);
		
		/// <summary>
        /// Returns the whole selection into a plain text string.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string ToString();
		
		/// <summary>
        /// Modifies the selection.  Note that the parameters are case-insensitive.
        ///
        /// @param alter can be one of { "move", "extend" }
        /// - "move" collapses the selection to the end of the selection and
        /// applies the movement direction/granularity to the collapsed
        /// selection.
        /// - "extend" leaves the start of the selection unchanged, and applies
        /// movement direction/granularity to the end of the selection.
        /// @param direction can be one of { "forward", "backward", "left", "right" }
        /// @param granularity can be one of { "character", "word",
        /// "line", "lineboundary" }
        ///
        /// @returns NS_ERROR_NOT_IMPLEMENTED if the granularity is "sentence",
        /// "sentenceboundary", "paragraph", "paragraphboundary", or
        /// "documentboundary".  Returns NS_ERROR_INVALID_ARG if alter, direction,
        /// or granularity has an unrecognized value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Modify([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase alter, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase direction, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase granularity);
		
		/// <summary>Member GetInterlinePositionAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetInterlinePositionAttribute();
		
		/// <summary>Member SetInterlinePositionAttribute </summary>
		/// <param name='aInterlinePosition'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInterlinePositionAttribute([MarshalAs(UnmanagedType.U1)] bool aInterlinePosition);
		
		/// <summary>
        ///startBatchChanges
        ///       match this up with endbatchChanges. will stop ui updates while multiple selection methods are called
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartBatchChanges();
		
		/// <summary>
        ///endBatchChanges
        ///       match this up with startBatchChanges
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndBatchChanges();
		
		/// <summary>Member GetEnumerator </summary>
		/// <returns>A nsIEnumerator</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIEnumerator GetEnumerator();
		
		/// <summary>Member ToStringWithFormat </summary>
		/// <param name='formatType'> </param>
		/// <param name='flags'> </param>
		/// <param name='wrapColumn'> </param>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ToStringWithFormat([MarshalAs(UnmanagedType.LPStr)] string formatType, uint flags, int wrapColumn);
		
		/// <summary>Member AddSelectionListener </summary>
		/// <param name='newListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddSelectionListener([MarshalAs(UnmanagedType.Interface)] nsISelectionListener newListener);
		
		/// <summary>Member RemoveSelectionListener </summary>
		/// <param name='listenerToRemove'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveSelectionListener([MarshalAs(UnmanagedType.Interface)] nsISelectionListener listenerToRemove);
		
		/// <summary>
        ///Test if supplied range points to a single table element:
        /// Result is one of above constants. "None" means
        /// a table element isn't selected.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTableSelectionType([MarshalAs(UnmanagedType.Interface)] nsIDOMRange range);
		
		/// <summary>
        ///Internal utility method to set the pres shell on a newly created selection </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPresShell(System.IntPtr aPresShell);
		
		/// <summary>
        ///canCacheFrameOffset
        /// Frame Offset cache can be used just during calling nsEditor::EndPlaceHolderTransaction.
        /// EndPlaceHolderTransaction will give rise to reflow/refreshing view/scroll, and call times
        /// of nsTextFrame::GetPointFromOffset whose return value is to be cached.
        /// see bugs 35296 and 199412
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanCacheFrameOffsetAttribute();
		
		/// <summary>
        ///canCacheFrameOffset
        /// Frame Offset cache can be used just during calling nsEditor::EndPlaceHolderTransaction.
        /// EndPlaceHolderTransaction will give rise to reflow/refreshing view/scroll, and call times
        /// of nsTextFrame::GetPointFromOffset whose return value is to be cached.
        /// see bugs 35296 and 199412
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCanCacheFrameOffsetAttribute([MarshalAs(UnmanagedType.U1)] bool aCanCacheFrameOffset);
		
		/// <summary>
        ///GetCachedOffsetForFrame
        /// Returns cached value for nsTextFrame::GetPointFromOffset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCachedFrameOffset(System.IntPtr aFrame, int inOffset, System.IntPtr aPoint);
		
		/// <summary>
        ///getFrameSelection
        /// Returnes a reference to the frame selection associated with this selection
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetFrameSelection();
		
		/// <summary>Member SetAncestorLimiter </summary>
		/// <param name='aContent'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAncestorLimiter(System.IntPtr aContent);
		
		/// <summary>
        /// Set the painting style for the range. The range must be a range in
        /// the selection. The textRangeStyle will be used by text frame
        /// when it is painting the selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextRangeStyle([MarshalAs(UnmanagedType.Interface)] nsIDOMRange range, System.IntPtr textRangeStyle);
		
		/// <summary>
        /// Get the direction of the selection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsDirection GetSelectionDirection();
		
		/// <summary>Member SetSelectionDirection </summary>
		/// <param name='aDirection'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectionDirection(nsDirection aDirection);
		
		/// <summary>
        /// Returns the type of the selection (see nsISelectionController for
        /// available constants).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetTypeAttribute();
		
		/// <summary>
        /// Return array of ranges intersecting with the given DOM interval.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRangesForInterval([MarshalAs(UnmanagedType.Interface)] nsIDOMNode beginNode, int beginOffset, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode endNode, int endOffset, [MarshalAs(UnmanagedType.U1)] bool allowAdjacent, ref uint resultCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=5)] ref nsIDOMRange[] results);
		
		/// <summary>Member GetRangesForIntervalCOMArray </summary>
		/// <param name='beginNode'> </param>
		/// <param name='beginOffset'> </param>
		/// <param name='endNode'> </param>
		/// <param name='endOffset'> </param>
		/// <param name='allowAdjacent'> </param>
		/// <param name='results'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRangesForIntervalCOMArray([MarshalAs(UnmanagedType.Interface)] nsIDOMNode beginNode, int beginOffset, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode endNode, int endOffset, [MarshalAs(UnmanagedType.U1)] bool allowAdjacent, System.IntPtr results);
		
		/// <summary>
        /// Scrolls a region of the selection, so that it is visible in
        /// the scrolled view.
        ///
        /// @param aRegion - the region inside the selection to scroll into view
        /// (see selection region constants defined in
        /// nsISelectionController).
        /// @param aIsSynchronous - when true, scrolls the selection into view
        /// before returning. If false, posts a request which
        /// is processed at some point after the method returns.
        /// @param aVPercent - how to align the frame vertically. A value of 0
        /// means the frame's upper edge is aligned with the top edge
        /// of the visible area. A value of 100 means the frame's
        /// bottom edge is aligned with the bottom edge of
        /// the visible area. For values in between, the point
        /// "aVPercent" down the frame is placed at the point
        /// "aVPercent" down the visible area. A value of 50 centers
        /// the frame vertically. A value of -1 means move
        /// the frame the minimum amount necessary in order for
        /// the entire frame to be visible vertically (if possible).
        /// @param aHPercent - how to align the frame horizontally. A value of 0
        /// means the frame's left edge is aligned with the left
        /// edge of the visible area. A value of 100 means the
        /// frame's right edge is aligned with the right edge of
        /// the visible area. For values in between, the point
        /// "aHPercent" across the frame is placed at the point
        /// "aHPercent" across the visible area. A value of 50
        /// centers the frame horizontally . A value of -1 means
        /// move the frame the minimum amount necessary in order
        /// for the entire frame to be visible horizontally
        /// (if possible).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollIntoView(short aRegion, [MarshalAs(UnmanagedType.U1)] bool aIsSynchronous, short aVPercent, short aHPercent);
	}
}
