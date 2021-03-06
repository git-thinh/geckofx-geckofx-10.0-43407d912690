using System;

namespace Gecko.Collections
{
	internal static class GeckoCollectionsHelper
	{
		internal static nsIMutableArray CreateArray()
		{
			return Xpcom.CreateInstance<nsIMutableArray>( "@mozilla.org/array;1" );
		}

		internal static T GetElementAs<T>(this nsIArray array,int index)
		{
			Guid uid = typeof(T).GUID;
			var ptr = array.QueryElementAt((uint)index, ref uid);
			var obj = ( T ) System.Runtime.InteropServices.Marshal.GetObjectForIUnknown( ptr );
			return obj;
		}
	}
}