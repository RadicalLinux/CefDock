using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;
using System.Reflection;
using CefSharp;
using CefSharp.WinForms;



namespace TestCef
{
    public partial class frmBrowser : DockContent
    {

        private BrowserControl browser;
        public frmBrowser(string url)
        {
            InitializeComponent();
            ResizeBegin += (s, e) => SuspendLayout();
            ResizeEnd += (s, e) => ResumeLayout(true);
            browser = new BrowserControl(url)
            {
                Dock = DockStyle.Fill
            };
            browser.addressBox1.Text = url;

            //This call isn't required for the sample to work. 
            //It's sole purpose is to demonstrate that #553 has been resolved.
            Controls.Add(browser);
            WindowState = FormWindowState.Maximized;

        }


    }



}

