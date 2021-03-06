﻿#region ***** BEGIN LICENSE BLOCK *****
/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */
#endregion END LICENSE BLOCK

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using GeckoFX.Microsoft;
using System.Threading;

namespace Gecko
{
	/// <summary>
	/// Provides low-level access to XPCOM.
	/// </summary>
	public static class Xpcom
	{
		#region XpCom Methods
		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		static extern int NS_InitXPCOM2([MarshalAs(UnmanagedType.Interface)] out nsIServiceManager serviceManager, [MarshalAs(UnmanagedType.IUnknown)] object binDirectory, nsIDirectoryServiceProvider appFileLocationProvider);

		/// <summary>
		/// Shutdown XPCOM. You must call this method after you are finished
		/// using xpcom. 
		/// </summary>
		/// <param name="serviceManager"></param>
		/// <returns></returns>
		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		static extern int NS_ShutdownXPCOM([MarshalAs(UnmanagedType.Interface)] nsIServiceManager serviceManager);
		
		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		static extern int NS_NewNativeLocalFile(nsACString path, bool followLinks, [MarshalAs(UnmanagedType.IUnknown)] out object result);
		
		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		static extern int NS_GetComponentManager([MarshalAs(UnmanagedType.Interface)]out nsIComponentManager componentManager);		
		
		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		static extern int NS_GetComponentRegistrar([MarshalAs(UnmanagedType.Interface)] out nsIComponentRegistrar componentRegistrar);
		
		[DllImport("xpcom", EntryPoint="NS_Alloc")]
		public static extern IntPtr Alloc(int size);
		
		[DllImport("xpcom", EntryPoint="NS_Realloc")]
		public static extern IntPtr Realloc(IntPtr ptr, int size);
		
		[DllImport("xpcom", EntryPoint="NS_Free")]
		public static extern void Free(IntPtr ptr);
		#endregion

		#region Fields
		static bool? m_isMono;
		static bool _IsInitialized;
		static string _ProfileDirectory;
        static int _XpcomThreadId;
		#endregion

		#region CLR runtime
		/// <summary>
		/// GeckoFX is running on Linux
		/// </summary>
		public static bool IsLinux
		{
			get { return Environment.OSVersion.Platform == PlatformID.Unix; }
		}

		/// <summary>
		/// GeckoFX is running on Windows
		/// </summary>
		public static bool IsWindows
		{
			get { return !IsLinux; }
		}

		/// <summary>
		/// GeckoFX is running on Mono CLR implementation
		/// </summary>
		public static bool IsMono
		{
			get
			{
				if (m_isMono == null)
					m_isMono = Type.GetType("Mono.Runtime") != null;

				return (bool)m_isMono;
			}
		}

		/// <summary>
		///  GeckoFX is running on Microsoft CLR implementation (.NET Framework)
		/// </summary>
		public static bool IsDotNet
		{
			get { return !IsMono; }
		}
		#endregion

		public static bool IsInitialized
		{
			get { return _IsInitialized; }
		}

		public static nsIComponentManager ComponentManager;
		public static nsIComponentRegistrar ComponentRegistrar;
		public static nsIServiceManager ServiceManager;

		#region Init & shudown
		/// <summary>
		/// Initializes XPCOM using the current directory as the XPCOM directory.
		/// </summary>
		public static void Initialize()
		{
			Initialize(null);
		}

		/// <summary>
		/// Initializes XPCOM using the specified directory.
		/// </summary>
		/// <param name="binDirectory">The directory which contains xpcom.dll.</param>
		public static void Initialize(string binDirectory)
		{
			if (_IsInitialized)
				return;

            Interlocked.Exchange(ref _XpcomThreadId, Thread.CurrentThread.ManagedThreadId);

			if (IsWindows)
				Kernel32.SetDllDirectory(binDirectory);
			
			string folder = binDirectory ?? Environment.CurrentDirectory;
			string xpcomPath = Path.Combine(folder, IsLinux ? "libxpcom.so" : "xpcom.dll");
			
			if (Debugger.IsAttached)
			{
				// make sure this DLL is there
				if (!File.Exists(xpcomPath))
				{
					if (MessageBox.Show("Couldn't find XULRunner in '" + folder + "'.  Call Xpcom.Initialize() in your application startup code and specify the directory where XULRunner is installed.\r\n\r\n" +
						"If you do not have XULRunner installed, click Yes to open the download page.  Otherwise, click No, and update your application startup code.",
							"XULRunner Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
					{
						Process.Start("http://releases.mozilla.org/pub/mozilla.org/xulrunner/releases/1.9.1.2/runtimes/xulrunner-1.9.1.2.en-US.win32.zip");
					}
					
					Environment.Exit(0);
				}
			}
			
			if (binDirectory != null)
			{
				Environment.SetEnvironmentVariable("path",
					Environment.GetEnvironmentVariable("path") + ";" + binDirectory, EnvironmentVariableTarget.Process);
			}
			
			object mreAppDir = null;
			
			if (binDirectory != null)
			{
				using (nsACString str = new nsACString(Path.GetFullPath(binDirectory)))
					if (NS_NewNativeLocalFile(str, true, out mreAppDir) != 0)
					{
						throw new Exception("Failed on NS_NewNativeLocalFile");
					}
			}
			
			// temporarily change the current directory so NS_InitEmbedding can find all the DLLs it needs
			String oldCurrent = Environment.CurrentDirectory;
			Environment.CurrentDirectory = folder;
			
			nsIServiceManager serviceManagerPtr;
			//int res = NS_InitXPCOM2(out serviceManagerPtr, mreAppDir, new DirectoryServiceProvider());
			int res = NS_InitXPCOM2(out serviceManagerPtr, mreAppDir, null);
			
			// change back
			Environment.CurrentDirectory = oldCurrent;
			
			if (res != 0)
			{
				throw new Exception("Failed on NS_InitXPCOM2");
			}
			
			ServiceManager = (nsIServiceManager)serviceManagerPtr;
			
			// get some global objects we will need later
			NS_GetComponentManager(out ComponentManager);
			NS_GetComponentRegistrar(out ComponentRegistrar);
			
			// RegisterProvider is neccessary to get link styles etc.
			nsIDirectoryService directoryService = GetService<nsIDirectoryService>("@mozilla.org/file/directory_service;1");
			if (directoryService != null)
				directoryService.RegisterProvider(new ProfileProvider());

			if (UseCustomPrompt)
				PromptFactoryFactory.Register();
			
			_IsInitialized = true;
		}

		public static void Shutdown()
		{
			Marshal.ReleaseComObject(ComponentRegistrar);
			Marshal.ReleaseComObject(ComponentManager);
			NS_ShutdownXPCOM(ServiceManager);
			_IsInitialized = false;
		}

        public static void AssertCorrectThread()
        {
            if (Thread.CurrentThread.ManagedThreadId != _XpcomThreadId)
            {
                throw new InvalidOperationException("Xpcom must run on own thread");
            }
        }
		#endregion

		/// <summary>
		/// Gets or sets the path to the directory which contains the user profile.
		/// The default directory is Geckofx\DefaultProfile in the user's local application data directory.
		/// </summary>
		public static string ProfileDirectory
		{
			get
			{
				if (_ProfileDirectory == null)
				{

					string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Geckofx\1.9\DefaultProfile");

					if (!Directory.Exists(directory))
					{
						Directory.CreateDirectory(directory);
					}
					return directory;
				}
				return _ProfileDirectory;
			}
			set
			{
				if (!String.IsNullOrEmpty(value))
				{
					if (!Directory.Exists(value))
					{
						throw new DirectoryNotFoundException();
					}
				}
				_ProfileDirectory = value;
			}
		}

		public static bool UseCustomPrompt
		{
			get;
			set;
		}

		#region External Methods
		
		public static object NewNativeLocalFile(string filename)
		{
			object result;
			
			using (nsACString str = new nsACString(filename))
				if (NS_NewNativeLocalFile(str, true, out result) == 0)
					return result;
			
			return null;
		}

		#region CreateInstance
		//public static object CreateInstance(Guid classIID)
		//{
		//	Guid iid = typeof(nsISupports).GUID;
		//	return ComponentManager.CreateInstance(ref classIID, null, ref iid);
		//}
		
		//public static object CreateInstance(string contractID)
		//{
		//	return CreateInstance<nsISupports>(contractID);
		//}
		
		public static TInterfaceType CreateInstance<TInterfaceType>(string contractID)
		{
			Guid iid = typeof(TInterfaceType).GUID;
			IntPtr ptr = ComponentManager.CreateInstanceByContractID(contractID, null, ref iid);
			return (TInterfaceType)Marshal.GetObjectForIUnknown(ptr);
		}
		#endregion

		#region QueryInterface
		
		public static TInterfaceType QueryInterface<TInterfaceType>(object obj)
		{
			return (TInterfaceType)QueryInterface(obj, typeof(TInterfaceType).GUID);
		}

		public static object QueryInterface(object obj, Guid iid)
		{
            AssertCorrectThread();

			if (obj == null)
				return null;

			// get an nsISupports (aka IUnknown) pointer from the object
			IntPtr pUnk = Marshal.GetIUnknownForObject(obj);
			if (pUnk == IntPtr.Zero)
				return null;
			
			// query interface
			IntPtr ppv;
			Marshal.QueryInterface(pUnk, ref iid, out ppv);
			
			// if QueryInterface didn't work, try using nsIInterfaceRequestor instead
			if (ppv == IntPtr.Zero)
			{
				// QueryInterface the object for nsIInterfaceRequestor
				Guid interfaceRequestorIID = typeof(nsIInterfaceRequestor).GUID;
				IntPtr pInterfaceRequestor;
				Marshal.QueryInterface(pUnk, ref interfaceRequestorIID, out pInterfaceRequestor);
				
				// if we got a pointer to nsIInterfaceRequestor
				if (pInterfaceRequestor != IntPtr.Zero)
				{
					// convert it to a managed interface
					QI_nsIInterfaceRequestor req = (QI_nsIInterfaceRequestor)Marshal.GetObjectForIUnknown(pInterfaceRequestor);
					
					if (req != null)
					{
					
						try
						{
							req.GetInterface(ref iid, out ppv);
							// clean up
							Marshal.ReleaseComObject(req);
						}
						catch(NullReferenceException e)
						{
							Debug.WriteLine("NullRefException from native code.");
						}
					}
					Marshal.Release(pInterfaceRequestor);
				}
			}
			
			object result = (ppv != IntPtr.Zero) ? Marshal.GetObjectForIUnknown(ppv) : null;
			
			Marshal.Release(pUnk);
			if (ppv != IntPtr.Zero)
				Marshal.Release(ppv);
			
			return result;
		}
		#endregion

		#region GetService
		public static object GetService(Guid classIID)
		{
            AssertCorrectThread();

			Guid iid = typeof(nsISupports).GUID;
			return ServiceManager.GetService(ref classIID, ref iid);
		}
		
		//public static object GetService(string contractID)
		//{
		//    return GetService<nsISupports>(contractID);
		//}
		
		public static TInterfaceType GetService<TInterfaceType>(string contractID)
		{
            AssertCorrectThread();

			Guid iid = typeof(TInterfaceType).GUID;
			IntPtr ptr = ServiceManager.GetServiceByContractID(contractID, ref iid);
			return (TInterfaceType)Marshal.GetObjectForIUnknown(ptr);
		}
		#endregion
		/// <summary>
		/// Registers a factory to be used to instantiate a particular class identified by ClassID, and creates an association of class name and ContractID with the class.
		/// </summary>
		/// <param name="classID">The ClassID of the class being registered.</param>
		/// <param name="className">The name of the class being registered. This value is intended as a human-readable name for the class and need not be globally unique.</param>
		/// <param name="contractID">The ContractID of the class being registered.</param>
		/// <param name="factory">The nsIFactory instance of the class being registered.</param>
		public static void RegisterFactory(Guid classID, string className, string contractID, nsIFactory factory)
		{
			ComponentRegistrar.RegisterFactory(ref classID, className, contractID, factory);
		}

		
		#endregion



		#region Extension Methods for nsISupports
		/**
		internal static T QueryInterface<T>(this nsISupports proxy)
		{
			var guid = typeof(T).GUID;
			IntPtr ptr = proxy.QueryInterface(ref guid);
			var obj = (T)Marshal.GetObjectForIUnknown(ptr);
			return obj;
		}

		internal static object QueryInterface(this nsISupports proxy, Type type)
		{
			var guid = type.GUID;
			IntPtr ptr = proxy.QueryInterface(ref guid);
			var obj = Marshal.GetObjectForIUnknown(ptr);
			return obj;
		}
        /**/
		#endregion

		///	<summary>
		/// Helper method for WeakReference
		///	</summary>
		internal static IntPtr QueryReferent(object obj, ref Guid uuid )
		{		
            Xpcom.AssertCorrectThread();

			IntPtr ppv, pUnk = Marshal.GetIUnknownForObject(obj);

            Marshal.QueryInterface(pUnk, ref uuid, out ppv);

            Marshal.Release(pUnk);

            return ppv;
   
		}

		#region Internal class & interface declarations
		#region QI_nsIInterfaceRequestor	
		/// <summary>
		/// A special declaration of nsIInterfaceRequestor used only for QueryInterface, using PreserveSig
		/// to prevent .NET from throwing an exception when the interface doesn't exist.
		/// </summary>
		[Guid("033a1470-8b2a-11d3-af88-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		interface QI_nsIInterfaceRequestor
		{

			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[PreserveSig]
			int GetInterface(ref Guid uuid, out IntPtr pUnk);
		}
		#endregion

		#region ProfileProvider
		/// <summary>
		/// A simple nsIDirectoryServiceProvider which provides the profile directory.
		/// </summary>
		class ProfileProvider : nsIDirectoryServiceProvider
		{
			public nsIFile GetFile(string prop, ref bool persistent)
			{
				if (prop == "ProfD")
				{
					return (nsIFile)NewNativeLocalFile(ProfileDirectory ?? "");
				}
				return null;
			}
		}
		#endregion
		#endregion
	}
}
