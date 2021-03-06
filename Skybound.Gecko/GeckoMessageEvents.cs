﻿//License MPL, the GPL or the LGPL.

using System;
using System.Runtime.InteropServices;

namespace Gecko
{
	/// <summary>
	/// Provides data froma a message event.
	/// doxygen.db48x.net/mozilla.../interfacensIDOMMessageEvent.html
	/// </summary>
	public class GeckoDomMessageEventArgs : GeckoDomEventArgs
	{
		private nsIDOMMessageEvent _event;

		internal GeckoDomMessageEventArgs(nsIDOMMessageEvent ev)
			: base(ev)
		{
			_event = ev;
		}
		
		/// <summary>
		/// The Message payload of the event
		/// </summary>
		public string Message
		{
			get
			{
				using (AutoJSContext context = new AutoJSContext())
				{
					var val = JsVal.FromPtr(_event.GetDataAttribute(context.ContextPointer));
					//TODO if(!val.IsString)
					//throw new NotImplementedException("GeckoFx currently only supports messages which are strings.");

					try
					{
						return val.ToString();
					}
					catch (AccessViolationException e)
					{
						//NB: errors here can be caused by not getting an actual string back. E.g., is it a number, a bool, etc.? Those aren't supported (but you could easily add them).
						throw e;
					}
				}
			}
		}

		#region Interop

		/// <summary>
		/// This is just a piece of a JsVal implementation, just enough to get the message out.
		/// netmonkey and spidermonkeydotnet have fuller implementations
		/// </summary>
		/// <remarks>
		/// 		/// WARNING:
		/// https://developer.mozilla.org/En/SpiderMonkey/JSAPI_Reference/Jsval
		/// Says: "jsval is a variant type whose exact representation varies by architecture.  
		///			Embeddings should not rely on observed representation details, the size of jsval, 
		///			or whether jsval is a primitive type."
		///	In the code below, we are just using API calls to access it, except for the attempt to get at the value tag directly (which didn't work).
		///	
		/// This JsVal implementations is very broken. 
		/// (for a start IntPtr on 32 bit systems is only 4 bytes and casting it to (ulong doesn't help))
		/// and C++ bit shifts AsBits >> 47 to access the ValueTag.
		/// </remarks>
		[StructLayout(LayoutKind.Explicit)]
		private struct JsVal
		{
			public static JsVal FromPtr(IntPtr value)
			{
				return new JsVal() {AsBits = (ulong)value};
			}

			[FieldOffset(0)] public ulong AsBits;
			[FieldOffset(0)] public double AsDouble;
			[FieldOffset(0)] public IntPtr AsPtr;
			[FieldOffset(0)] public int I32;
			[FieldOffset(0)] public uint U32;
			[FieldOffset(0)] public int Boo;
			[FieldOffset(0)] public IntPtr Ptr;
			[FieldOffset(4)] public ValueTag Tag;	//this is suspect

			public enum ValueTag : uint
			{
				Clear = 0xFFFF0000,
				Int32 = Clear | 1,
				Undefined = Clear | 2,
				String = Clear | 5,
				Boolean = Clear | 3,
				Magic = Clear | 4,
				Null = Clear | 6,
				Object = Clear | 7
			}

			[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr JS_EncodeString(IntPtr cx, IntPtr str);

			[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
			public static extern JSType JS_TypeOfValue(IntPtr cx, IntPtr jsVal);

			public enum JSType : int
			{
				JSTYPE_VOID,                /* undefined */
				JSTYPE_OBJECT,              /* object */
				JSTYPE_FUNCTION,            /* function */
				JSTYPE_STRING,              /* string */
				JSTYPE_NUMBER,              /* number */
				JSTYPE_BOOLEAN,             /* boolean */
				JSTYPE_NULL,                /* null */
				JSTYPE_XML,                 /* xml object */
				JSTYPE_LIMIT
			}

/*			
			I've been unable to actually find out the type. See below:
 
			public bool IsString
			{
				get
				{
					//always killed the process just binding to it, before it was actually called: JS_GetTypeName(context.ContextPointer, Type);
					//always returned JSTYPE_NUMBER: return Type == JSType.JSTYPE_STRING;
					//always returned 0 return Tag == ValueTag.String; 
					return true; ///argghhh
				}
			}
*/

			public JSType Type
			{
				get
				{
					using (AutoJSContext context = new AutoJSContext())
					{
						return JS_TypeOfValue(context.ContextPointer, Ptr);
					}
				}
			}

			public string ToString()
			{
//		TODO		if (!IsString)
//					throw new NotImplementedException("JsVal.ToString() only supported when the type is String.");

				using (AutoJSContext context = new AutoJSContext())
				{
					return Marshal.PtrToStringAnsi(JS_EncodeString(context.ContextPointer, Ptr));
				}
			}
		}

		#endregion
	}
}
