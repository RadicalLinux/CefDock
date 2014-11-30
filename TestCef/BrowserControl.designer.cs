namespace TestCef
{
    partial class BrowserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserControl));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbWaitIndicator = new System.Windows.Forms.PictureBox();
            this.addressBox1 = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStupid = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnFindPrevious = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCookiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWaitIndicator)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pbWaitIndicator);
            this.panel2.Controls.Add(this.addressBox1);
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 42);
            this.panel2.TabIndex = 9;
            // 
            // pbWaitIndicator
            // 
            this.pbWaitIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbWaitIndicator.Image = ((System.Drawing.Image)(resources.GetObject("pbWaitIndicator.Image")));
            this.pbWaitIndicator.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWaitIndicator.InitialImage")));
            this.pbWaitIndicator.Location = new System.Drawing.Point(586, 8);
            this.pbWaitIndicator.Name = "pbWaitIndicator";
            this.pbWaitIndicator.Size = new System.Drawing.Size(24, 24);
            this.pbWaitIndicator.TabIndex = 15;
            this.pbWaitIndicator.TabStop = false;
            this.pbWaitIndicator.Visible = false;
            // 
            // addressBox1
            // 
            this.addressBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox1.Location = new System.Drawing.Point(100, 9);
            this.addressBox1.Name = "addressBox1";
            this.addressBox1.Size = new System.Drawing.Size(480, 23);
            this.addressBox1.TabIndex = 14;
            this.addressBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressBox1_KeyPress);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.AutoSize = true;
            this.btnCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.Location = new System.Drawing.Point(613, 5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(30, 30);
            this.btnCopy.TabIndex = 13;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = true;
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(63, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(30, 30);
            this.btnStop.TabIndex = 12;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(33, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnStupid);
            this.panel1.Controls.Add(this.btnFindNext);
            this.panel1.Controls.Add(this.btnFindPrevious);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.toolStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 31);
            this.panel1.TabIndex = 10;
            // 
            // btnStupid
            // 
            this.btnStupid.Location = new System.Drawing.Point(489, 3);
            this.btnStupid.Name = "btnStupid";
            this.btnStupid.Size = new System.Drawing.Size(0, 0);
            this.btnStupid.TabIndex = 5;
            this.btnStupid.Text = "button1";
            this.btnStupid.UseVisualStyleBackColor = true;
            // 
            // btnFindNext
            // 
            this.btnFindNext.AutoSize = true;
            this.btnFindNext.Location = new System.Drawing.Point(168, 2);
            this.btnFindNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(58, 23);
            this.btnFindNext.TabIndex = 4;
            this.btnFindNext.Text = "Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnFindPrevious
            // 
            this.btnFindPrevious.AutoSize = true;
            this.btnFindPrevious.Location = new System.Drawing.Point(106, 2);
            this.btnFindPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindPrevious.Name = "btnFindPrevious";
            this.btnFindPrevious.Size = new System.Drawing.Size(58, 23);
            this.btnFindPrevious.TabIndex = 1;
            this.btnFindPrevious.Text = "Previous";
            this.btnFindPrevious.UseVisualStyleBackColor = true;
            this.btnFindPrevious.Click += new System.EventHandler(this.btnFindPrevious_Click_1);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(2, 3);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 20);
            this.txtFind.TabIndex = 0;
            this.txtFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFind_KeyPress);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.toolStrip.Location = new System.Drawing.Point(592, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(54, 27);
            this.toolStrip.Stretch = false;
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devToolsToolStripMenuItem,
            this.clearCookiesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(41, 19);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // devToolsToolStripMenuItem
            // 
            this.devToolsToolStripMenuItem.Name = "devToolsToolStripMenuItem";
            this.devToolsToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.devToolsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.devToolsToolStripMenuItem.Text = "Developer\'s Tools";
            this.devToolsToolStripMenuItem.Click += new System.EventHandler(this.devToolsToolStripMenuItem_Click);
            // 
            // clearCookiesToolStripMenuItem
            // 
            this.clearCookiesToolStripMenuItem.Name = "clearCookiesToolStripMenuItem";
            this.clearCookiesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.clearCookiesToolStripMenuItem.Text = "Clear Cookies";
            this.clearCookiesToolStripMenuItem.Click += new System.EventHandler(this.clearCookiesToolStripMenuItem_Click);
            // 
            // browserPanel
            // 
            this.browserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.browserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPanel.Location = new System.Drawing.Point(0, 42);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(650, 386);
            this.browserPanel.TabIndex = 11;
            // 
            // BrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.browserPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "BrowserControl";
            this.Size = new System.Drawing.Size(650, 459);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWaitIndicator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbWaitIndicator;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStupid;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnFindPrevious;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.MenuStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCookiesToolStripMenuItem;
        public System.Windows.Forms.TextBox addressBox1;
        public System.Windows.Forms.Panel browserPanel;
    }
}
