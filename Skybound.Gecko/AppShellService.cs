﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko
{
	internal static class AppShellService
	{
		private static ServiceWrapper<nsIAppShellService> _appShellService;

		static AppShellService()
		{
			_appShellService=new ServiceWrapper<nsIAppShellService>( Contracts.AppShellService );	
	
			
		}

		public static void CreateHiddenWindow()
		{
			_appShellService.Instance.CreateHiddenWindow();
		}

		internal static nsIXULWindow CreateTopLevelWindow( nsIXULWindow aParent,  nsIURI aUrl, uint aChromeMask, int aInitialWidth, int aInitialHeight)
		{
			return _appShellService.Instance.CreateTopLevelWindow( aParent, aUrl, aChromeMask, aInitialWidth, aInitialHeight );
		}
	}
}
