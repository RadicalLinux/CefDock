using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace TestCef
{


    public partial class BrowserControl : UserControl
    {
        public IWinFormsWebBrowser Browser { get; private set; }
        public ChromiumWebBrowser browser;
        public BrowserControl(string url)
        {
            InitializeComponent();
            browser = new ChromiumWebBrowser(url)
            {
                Dock = DockStyle.Fill
            };
            browserPanel.Controls.Add(browser);
            BrowserSettings bs = new BrowserSettings();
            bs.WebSecurityDisabled = true;
            bs.DefaultEncoding = "UTF8";
            browser.BrowserSettings = bs;


            Browser = browser;

            //browser.HandleCreated += OnBrowserHandleCreated;
            browser.IsLoadingChanged += OnLoadingChanged;
            browser.FrameLoadStart += FrameLoadStart;
            browser.FrameLoadEnd += FrameLoadEnd;
            browser.NavStateChanged += OnBrowserNavStateChanged;
            Disposed += BrowserControlDisposed;
        }


        private void BrowserControlDisposed(object sender, EventArgs e)
        {
            Disposed -= BrowserControlDisposed;

            Browser.FrameLoadStart -= FrameLoadStart;
            Browser.FrameLoadEnd -= FrameLoadEnd;
            Browser.NavStateChanged -= OnBrowserNavStateChanged;

            Browser.Dispose();
        }

        private void OnLoadingChanged(object sender, IsLoadingChangedEventArgs e)
        {
            if (e.IsLoading == true)
            {
                this.InvokeOnUiThreadIfRequired(() => pbWaitIndicator.Visible = true);
            }
            else
            {
                this.InvokeOnUiThreadIfRequired(() => pbWaitIndicator.Visible = false);
            }
        }


        private void FrameLoadStart(object sender, FrameLoadStartEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => pbWaitIndicator.Visible = true);
            if (args.IsMainFrame)
            {

                if (! args.Url.ToString().Contains("127.0.0.1"))
                {
                    this.InvokeOnUiThreadIfRequired(() => addressBox1.Enabled = true);
                }
                else
                {
                    this.InvokeOnUiThreadIfRequired(() => addressBox1.Enabled = false);
                }
            }
        }

        private void FrameLoadEnd(object sender, FrameLoadEndEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => pbWaitIndicator.Visible = false);
            if (args.IsMainFrame)
            {
                this.InvokeOnUiThreadIfRequired(() => addressBox1.Text = args.Url);

                if (!Browser.Address.Contains("127.0.0.1"))
                {
                    this.InvokeOnUiThreadIfRequired(() => this.Text = Browser.Title);
                    this.InvokeOnUiThreadIfRequired(() => addressBox1.Enabled = true);
                }
                else
                {
                    if (!Browser.Title.Contains("127.0.0.1"))
                    {
                        this.InvokeOnUiThreadIfRequired(() => this.Text = Browser.Title);
                    }
                    this.InvokeOnUiThreadIfRequired(() => addressBox1.Enabled = false);
                }
            }
        }

        private void OnBrowserNavStateChanged(object sender, NavStateChangedEventArgs args)
        {
            SetCanGoBack(args.CanGoBack);

            //SetCanGoForward(args.CanGoForward);
        }

        private void SetCanGoBack(bool canGoBack)
        {
            this.InvokeOnUiThreadIfRequired(() => btnBack.Enabled = canGoBack);
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Browser.Reload(true);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Browser.CanGoBack)
            {
                Browser.Back();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Browser.Stop();
        }

        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnFindNext.PerformClick();
                e.Handled = true;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(addressBox1.Text);
            MessageBox.Show("Address Copied to Clipboard", "faceBot Extreme");
        }

        private void clearCookiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cef.DeleteCookies("", "");
            MessageBox.Show("Browser Cookies Cleared", "faceBot Extreme");
        }


        private void addressBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                LoadUrl(addressBox1.Text);
                e.Handled = true;
            }
        }

        public void LoadUrl(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                Browser.Load(url);
            }
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            Find(true);
        }

        private void Find(bool next)
        {
            if (!string.IsNullOrEmpty(txtFind.Text))
            {
                Browser.Find(0, txtFind.Text, next, false, false);
            }
        }

        private void btnFindPrevious_Click_1(object sender, EventArgs e)
        {
            Find(false);
        }


        private void devToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browser.ShowDevTools();
        }


    }
}
