using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp;
using WeifenLuo.WinFormsUI.Docking;

namespace TestCef
{
    public partial class frmMain : Form
    {
        public static frmBrowser fB;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            fB = new frmBrowser("http://www.facebot.org/testing.html");
            fB.TabText = "Test";
            fB.Show(dPMain, DockState.Document);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fB = new frmBrowser("http://www.facebot.org/testing.html");
            fB.TabText = "Test";
            fB.Show(dPMain, DockState.Document);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cef.Shutdown();
            Environment.Exit(0);
        }
    }
}
