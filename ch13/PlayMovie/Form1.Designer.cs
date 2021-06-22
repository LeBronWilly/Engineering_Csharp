namespace PlayMovie
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wmpMovie = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNone = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMini = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFull = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvisible = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMovie)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmpMovie
            // 
            this.wmpMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpMovie.Enabled = true;
            this.wmpMovie.Location = new System.Drawing.Point(0, 0);
            this.wmpMovie.Name = "wmpMovie";
            this.wmpMovie.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMovie.OcxState")));
            this.wmpMovie.Size = new System.Drawing.Size(345, 288);
            this.wmpMovie.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuMode});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(345, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "檔案";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(43, 20);
            this.mnuFile.Text = "檔案";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuOpen.Text = "開啟";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "結束";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuMode
            // 
            this.mnuMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNone,
            this.mnuMini,
            this.mnuFull,
            this.mnuInvisible});
            this.mnuMode.Name = "mnuMode";
            this.mnuMode.Size = new System.Drawing.Size(67, 20);
            this.mnuMode.Text = "選取模式";
            // 
            // mnuNone
            // 
            this.mnuNone.Name = "mnuNone";
            this.mnuNone.Size = new System.Drawing.Size(180, 22);
            this.mnuNone.Text = "None";
            this.mnuNone.Click += new System.EventHandler(this.mnuNone_Click);
            // 
            // mnuMini
            // 
            this.mnuMini.Name = "mnuMini";
            this.mnuMini.Size = new System.Drawing.Size(180, 22);
            this.mnuMini.Text = "Mini";
            this.mnuMini.Click += new System.EventHandler(this.mnuMini_Click);
            // 
            // mnuFull
            // 
            this.mnuFull.Name = "mnuFull";
            this.mnuFull.Size = new System.Drawing.Size(180, 22);
            this.mnuFull.Text = "Full";
            this.mnuFull.Click += new System.EventHandler(this.mnuFull_Click);
            // 
            // mnuInvisible
            // 
            this.mnuInvisible.Name = "mnuInvisible";
            this.mnuInvisible.Size = new System.Drawing.Size(180, 22);
            this.mnuInvisible.Text = "Invisible";
            this.mnuInvisible.Click += new System.EventHandler(this.mnuInvisible_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 288);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.wmpMovie);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wmpMovie)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpMovie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMode;
        private System.Windows.Forms.ToolStripMenuItem mnuNone;
        private System.Windows.Forms.ToolStripMenuItem mnuMini;
        private System.Windows.Forms.ToolStripMenuItem mnuFull;
        private System.Windows.Forms.ToolStripMenuItem mnuInvisible;
    }
}

