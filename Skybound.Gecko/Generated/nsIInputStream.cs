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
// Generated by IDLImporter from file nsIInputStream.idl
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
    /// nsIInputStream
    ///
    /// An interface describing a readable stream of data.  An input stream may be
    /// "blocking" or "non-blocking" (see the IsNonBlocking method).  A blocking
    /// input stream may suspend the calling thread in order to satisfy a call to
    /// Close, Available, Read, or ReadSegments.  A non-blocking input stream, on
    /// the other hand, must not block the calling thread of execution.
    ///
    /// NOTE: blocking input streams are often read on a background thread to avoid
    /// locking up the main application thread.  For this reason, it is generally
    /// the case that a blocking input stream should be implemented using thread-
    /// safe AddRef and Release.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fa9c7f6c-61b3-11d4-9877-00c04fa0cf4a")]
	public interface nsIInputStream
	{
		
		/// <summary>
        /// Close the stream.  This method causes subsequent calls to Read and
        /// ReadSegments to return 0 bytes read to indicate end-of-file.  Any
        /// subsequent calls to Available should throw NS_BASE_STREAM_CLOSED.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		/// <summary>
        /// Determine number of bytes available in the stream.  A non-blocking
        /// stream that does not yet have any data to read should return 0 bytes
        /// from this method (i.e., it must not throw the NS_BASE_STREAM_WOULD_BLOCK
        /// exception).
        ///
        /// In addition to the number of bytes available in the stream, this method
        /// also informs the caller of the current status of the stream.  A stream
        /// that is closed will throw an exception when this method is called.  That
        /// enables the caller to know the condition of the stream before attempting
        /// to read from it.  If a stream is at end-of-file, but not closed, then
        /// this method returns 0 bytes available.  (Note: some nsIInputStream
        /// implementations automatically close when eof is reached; some do not).
        ///
        /// @return number of bytes currently available in the stream, or
        /// PR_UINT32_MAX if the size of the stream exceeds PR_UINT32_MAX.
        ///
        /// @throws NS_BASE_STREAM_CLOSED if the stream is closed normally.
        /// @throws <other-error> if the stream is closed due to some error
        /// condition
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint Available();
		
		/// <summary>
        /// Read data from the stream.
        ///
        /// @param aBuf the buffer into which the data is to be read
        /// @param aCount the maximum number of bytes to be read
        ///
        /// @return number of bytes read (may be less than aCount).
        /// @return 0 if reached end-of-file
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if reading from the input stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws <other-error> on failure
        ///
        /// NOTE: this method should not throw NS_BASE_STREAM_CLOSED.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint Read(System.IntPtr aBuf, uint aCount);
		
		/// <summary>
        /// Low-level read method that provides access to the stream's underlying
        /// buffer.  The writer function may be called multiple times for segmented
        /// buffers.  ReadSegments is expected to keep calling the writer until
        /// either there is nothing left to read or the writer returns an error.
        /// ReadSegments should not call the writer with zero bytes to consume.
        ///
        /// @param aWriter the "consumer" of the data to be read
        /// @param aClosure opaque parameter passed to writer
        /// @param aCount the maximum number of bytes to be read
        ///
        /// @return number of bytes read (may be less than aCount)
        /// @return 0 if reached end-of-file (or if aWriter refused to consume data)
        ///
        /// @throws NS_BASE_STREAM_WOULD_BLOCK if reading from the input stream would
        /// block the calling thread (non-blocking mode only)
        /// @throws NS_ERROR_NOT_IMPLEMENTED if the stream has no underlying buffer
        /// @throws <other-error> on failure
        ///
        /// NOTE: this function may be unimplemented if a stream has no underlying
        /// buffer (e.g., socket input stream).
        ///
        /// NOTE: this method should not throw NS_BASE_STREAM_CLOSED.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint ReadSegments(nsWriteSegmentFun aWriter, System.IntPtr aClosure, uint aCount);
		
		/// <summary>
        /// @return true if stream is non-blocking
        ///
        /// NOTE: reading from a blocking input stream will block the calling thread
        /// until at least one byte of data can be extracted from the stream.
        ///
        /// NOTE: a non-blocking input stream may implement nsIAsyncInputStream to
        /// provide consumers with a way to wait for the stream to have more data
        /// once its read method is unable to return any data without blocking.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsNonBlocking();
	}
}
