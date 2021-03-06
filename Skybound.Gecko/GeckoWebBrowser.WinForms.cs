﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Gecko.Listeners;

// PLZ keep all Windows Forms related code here
namespace Gecko
{
	partial class GeckoWebBrowser
		: Control
	{
		#region Overridden Properties
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override Color BackColor
		{
			get { return base.BackColor; }
			set { base.BackColor = value; }
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override Image BackgroundImage
		{
			get { return base.BackgroundImage; }
			set { base.BackgroundImage = value; }
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override ImageLayout BackgroundImageLayout
		{
			get { return base.BackgroundImageLayout; }
			set { base.BackgroundImageLayout = value; }
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override Color ForeColor
		{
			get { return base.ForeColor; }
			set { base.ForeColor = value; }
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override Font Font
		{
			get { return base.Font; }
			set { base.Font = value; }
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string Text
		{
			get { return base.Text; }
			set { base.Text = value; }
		}
		#endregion

		#region Overriden WinForms functions	

		private nsIDOMEventTarget _target;

		protected override void OnHandleCreated(EventArgs e)
		{
#if GTK	
			if (Xpcom.IsMono)
			{
				base.OnHandleCreated(e);
				m_wrapper.Init();
			}
#endif
			if (!this.DesignMode)
			{
				Xpcom.Initialize();
				WindowCreator.Register();
#if !GTK
				LauncherDialogFactory.Register();
#endif

				WebBrowser = Xpcom.CreateInstance<nsIWebBrowser>("@mozilla.org/embedding/browser/nsWebBrowser;1");
				WebBrowserFocus = (nsIWebBrowserFocus)WebBrowser;
				BaseWindow = (nsIBaseWindow)WebBrowser;

				WebNav = (nsIWebNavigation)WebBrowser;

				WebBrowser.SetContainerWindowAttribute(this);
#if GTK
				if (Xpcom.IsMono)
					BaseWindow.InitWindow(m_wrapper.BrowserWindow.Handle, IntPtr.Zero, 0, 0, this.Width, this.Height);
				else
#endif
				BaseWindow.InitWindow(this.Handle, IntPtr.Zero, 0, 0, this.Width, this.Height);


				RecordNewJsContext();
				BaseWindow.Create();

				Guid nsIWebProgressListenerGUID = typeof(nsIWebProgressListener).GUID;
				WebBrowser.AddWebBrowserListener(this.GetWeakReference(), ref nsIWebProgressListenerGUID);

				if (UseHttpActivityObserver)
				{
					ObserverService.AddObserver(this, ObserverNotifications.HttpRequests.HttpOnModifyRequest, false);

					nsIHttpActivityDistributor activityDistributor = Xpcom.GetService<nsIHttpActivityDistributor>("@mozilla.org/network/http-activity-distributor;1");
					activityDistributor = Xpcom.QueryInterface<nsIHttpActivityDistributor>(activityDistributor);
					activityDistributor.AddObserver(this);
				}

               // var domEventListener = new GeckoDOMEventListener(this);

				_target = Xpcom.QueryInterface<nsIDOMWindow>(WebBrowser.GetContentDOMWindowAttribute()).GetWindowRootAttribute();

                _target.AddEventListener(new nsAString("submit"), this, true, true, 2);
				_target.AddEventListener(new nsAString("keydown"), this, true, true, 2);
				_target.AddEventListener(new nsAString("keyup"), this, true, true, 2);
				_target.AddEventListener(new nsAString("keypress"), this, true, true, 2);
				_target.AddEventListener(new nsAString("mousemove"), this, true, true, 2);
				_target.AddEventListener(new nsAString("mouseover"), this, true, true, 2);
				_target.AddEventListener(new nsAString("mouseout"), this, true, true, 2);
				_target.AddEventListener(new nsAString("mousedown"), this, true, true, 2);
				_target.AddEventListener(new nsAString("mouseup"), this, true, true, 2);
				_target.AddEventListener(new nsAString("click"), this, true, true, 2);
				_target.AddEventListener(new nsAString("dblclick"), this, true, true, 2);
				_target.AddEventListener(new nsAString("compositionstart"), this, true, true, 2);
				_target.AddEventListener(new nsAString("compositionend"), this, true, true, 2);
				_target.AddEventListener(new nsAString("contextmenu"), this, true, true, 2);
				_target.AddEventListener(new nsAString("DOMMouseScroll"), this, true, true, 2);
				_target.AddEventListener(new nsAString("focus"), this, true, true, 2);
				_target.AddEventListener(new nsAString("blur"), this, true, true, 2);
				// Load event added here rather than DOMDocument as DOMDocument recreated when navigating
				// ths losing attached listener.
				_target.AddEventListener(new nsAString("load"), this, true, true, 2);
				_target.AddEventListener(new nsAString("change"), this, true, true, 2);

				// history
				{
					var sessionHistory = WebNav.GetSessionHistoryAttribute();
					if (sessionHistory!=null) sessionHistory.AddSHistoryListener( this );
				}

				BaseWindow.SetVisibilityAttribute(true);

				// this fix prevents the browser from crashing if the first page loaded is invalid (missing file, invalid URL, etc)
				if (Document !=null)
				{
					// only for html documents
					Document.Cookie = "";
				}
			}
			
			base.OnHandleCreated(e);
		}

		protected override void OnEnter(EventArgs e)
		{
			if (WebBrowserFocus != null)
				WebBrowserFocus.Activate();
#if GTK
			m_wrapper.SetInputFocus();		
#endif
			base.OnEnter(e);
		}

		protected override void OnLeave(EventArgs e)
		{
			if (WebBrowserFocus != null && !IsBusy)
				WebBrowserFocus.Deactivate();
#if GTK
			m_wrapper.RemoveInputFocus();		
#endif
			base.OnLeave(e);
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			if (BaseWindow != null)
			{
				BaseWindow.SetPositionAndSize(0, 0, ClientSize.Width, ClientSize.Height, true);
			}

			base.OnSizeChanged(e);
		}

		#region protected override void WndProc(ref Message m)
		protected override void WndProc(ref Message m)
		{
			const int WM_GETDLGCODE = 0x87;
			const int DLGC_WANTALLKEYS = 0x4;
			const int WM_MOUSEACTIVATE = 0x21;
			const int MA_ACTIVATE = 0x1;
			const int WM_IME_SETCONTEXT = 0x0281;

			if (!DesignMode)
			{
				switch (m.Msg)
				{
					case WM_GETDLGCODE:
						m.Result = (IntPtr)DLGC_WANTALLKEYS;
						return;
					case WM_MOUSEACTIVATE:
						// TODO FIXME: port for Linux
						if (Xpcom.IsWindows)
						{
							m.Result = (IntPtr)MA_ACTIVATE;

							if (!GeckoFX.Microsoft.User32.IsChild(Handle, GeckoFX.Microsoft.User32.GetFocus()))
							{
								this.Focus();
							}
							return;
						}
						return;
					case WM_IME_SETCONTEXT:
						if (!DisableWmImeSetContext)
						{
							//Console.WriteLine("WM_IME_SETCONTEXT {0} {1}", m.WParam, m.LParam.ToString("X8"));
							if (m.WParam == IntPtr.Zero)
							{
								// zero
								WebBrowserFocus.Deactivate();
							}
							else
							{
								// non-zero (1)
								WebBrowserFocus.Activate();
							}
							return;
						}
						break;
				}
			}

			base.WndProc(ref m);
		}

		public bool DisableWmImeSetContext { get; set; }
		#endregion

		protected override void OnPaint(PaintEventArgs e)
		{
			if (this.DesignMode)
			{
				string versionString = ((AssemblyFileVersionAttribute)Attribute.GetCustomAttribute(GetType().Assembly, typeof(AssemblyFileVersionAttribute))).Version;
				string copyright = ((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(GetType().Assembly, typeof(AssemblyCopyrightAttribute))).Copyright;

				using (Brush brush = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.SolidDiamond, Color.FromArgb(240, 240, 240), Color.White))
					e.Graphics.FillRectangle(brush, this.ClientRectangle);

				e.Graphics.DrawString(
					string.Format( "Skybound GeckoFX v{0}\r\n{1}\r\n" + "http://www.geckofx.org", versionString, copyright ),
					SystemFonts.MessageBoxFont,
					Brushes.Black,
					new RectangleF( 2, 2, this.Width - 4, this.Height - 4 ) );
				e.Graphics.DrawRectangle(SystemPens.ControlDark, 0, 0, Width - 1, Height - 1);
			}
			base.OnPaint(e);
		}
		#endregion

		#region Internal classes
		#region class ToolTipWindow : Form
		/// <summary>
		/// A window to contain a tool tip.
		/// </summary>
		class ToolTipWindow : Form
		{
			public ToolTipWindow()
			{
				//this.ControlBox = false;
				this.FormBorderStyle = FormBorderStyle.None;
				this.ShowInTaskbar = false;
				this.StartPosition = FormStartPosition.Manual;
				this.VisibleChanged += delegate { UpdateSize(); };

				this.BackColor = SystemColors.Info;
				this.ForeColor = SystemColors.InfoText;
				this.Font = SystemFonts.DialogFont;

				label = new Label();
				label.Location = new Point(5, 5);
				label.AutoSize = true;
				label.SizeChanged += delegate { UpdateSize(); };
				this.Controls.Add(label);
			}

			void UpdateSize()
			{
				this.Size = label.Size + new Size(10, 10);
			}

			Label label;

			public override string Text
			{
				get { return (label == null) ? "" : label.Text; }
				set
				{
					if (label != null)
						label.Text = value;
				}
			}

			protected override bool ShowWithoutActivation
			{
				get { return true; }
			}

			protected override void OnPaint(PaintEventArgs e)
			{
				// draw border and background
				e.Graphics.DrawRectangle(SystemPens.InfoText, 0, 0, Width - 1, Height - 1);
				e.Graphics.FillRectangle(SystemBrushes.Info, 1, 1, Width - 2, Height - 2);
			}

			protected override CreateParams CreateParams
			{
				get
				{
					const int CS_DROPSHADOW = 0x20000;

					// adds a soft drop shadow (windows xp or later required)
					CreateParams cp = base.CreateParams;
					cp.ClassStyle |= CS_DROPSHADOW;
					return cp;
				}
			}
		}
		#endregion
		#endregion
		
	}
}
