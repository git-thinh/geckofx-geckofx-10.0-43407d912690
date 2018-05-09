using System;
using System.Windows.Forms;
using Gecko;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Drawing;
using Gecko.DOM;
using System.Linq;

// Tested with mono 2.6.3 and mono 2.8
// Run this with the following command:
// MONO_PATH=/usr/lib/cli/gdk-sharp-2.0/ LD_LIBRARY_PATH="/usr/lib/xulrunner-1.9.2.13/" mono --debug GeckoFxTest.exe
// requires gdk-sharp assembly in the gac (which is in package libgtk2.0-cil)
namespace GeckoFxTest
{

    class MyForm : Form
    {
        const string m_url = @"http://web20office.com/crm/demo/system/login.php?r=/crm/demo";
        GeckoWebBrowser browser;
        Label bg = new Label() { Dock = DockStyle.Fill, AutoSize = false, Text = string.Empty };
        public MyForm()
        {
            this.Icon = Resources.ico;

            this.Text = "ERP - version 3.9 | Call supporter ☎ +84.975.600.710";
            this.WindowState = FormWindowState.Maximized;

            this.Shown += MyForm_Shown;

            browser = new GeckoWebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.DisableWmImeSetContext = true;
            browser.DomContextMenu += Browser_DomContextMenu;
            browser.DocumentCompleted += Browser_DocumentCompleted;
            this.Controls.Add(browser);
            this.Controls.Add(bg);
            bg.BringToFront();
        }

        private void Browser_DocumentCompleted(object sender, EventArgs e)
        {
            if (browser.Url.ToString() == m_url)
            {
                foreach (var a in browser.Document.GetElementsByTagName("A").Cast<GeckoAnchorElement>())
                {
                    a.Style.CssText = "display:none";
                    break;
                }

                foreach (var img in browser.Document.GetElementsByTagName("IMG").Cast<GeckoImageElement>())
                {
                    if (img.Src == "http://web20office.com/web/images/web20office.png")
                    {
                        img.Style.CssText = "display:none";
                        bg.SendToBack();
                        break;
                    }
                }
            }
            else {
                foreach (var a in browser.Document.GetElementsByTagName("DIV"))
                {
                    if (a.Id == "mainTop2") {
                        a.SetAttribute("style", "display:none;");
                        break;
                    }
                }

            }
        }

        private void Browser_DomContextMenu(object sender, GeckoDomMouseEventArgs e)
        {
            //contextMenu.Show(browser, PointToClient(new Point(e.ScreenX, e.ScreenY)));
            e.Handled = true;
        }

        private void MyForm_Shown(object sender, EventArgs e)
        {
            browser.Navigate(m_url);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.SuspendLayout();
            // 
            // MyForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyForm";
            this.ResumeLayout(false);

        }
    }
}

