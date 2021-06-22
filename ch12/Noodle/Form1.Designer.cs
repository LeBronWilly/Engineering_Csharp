namespace Noodle
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
            this.components = new System.ComponentModel.Container();
            this.cmnuNoodle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuNoodle1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuNoodle2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuBeef = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuBeef1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuBeef2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuBeef3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuSide = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuSide1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuSide2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuSide3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuNoodle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBeef = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSide = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNoodle = new System.Windows.Forms.Label();
            this.lblBeef = new System.Windows.Forms.Label();
            this.lblSide = new System.Windows.Forms.Label();
            this.cmnuNoodle.SuspendLayout();
            this.cmnuBeef.SuspendLayout();
            this.cmnuSide.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmnuNoodle
            // 
            this.cmnuNoodle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuNoodle1,
            this.cmnuNoodle2});
            this.cmnuNoodle.Name = "cmnuNoodle";
            this.cmnuNoodle.Size = new System.Drawing.Size(99, 48);
            // 
            // cmnuNoodle1
            // 
            this.cmnuNoodle1.Name = "cmnuNoodle1";
            this.cmnuNoodle1.Size = new System.Drawing.Size(98, 22);
            this.cmnuNoodle1.Text = "寬麵";
            this.cmnuNoodle1.Click += new System.EventHandler(this.cmnuNoodle1_Click);
            // 
            // cmnuNoodle2
            // 
            this.cmnuNoodle2.Name = "cmnuNoodle2";
            this.cmnuNoodle2.Size = new System.Drawing.Size(98, 22);
            this.cmnuNoodle2.Text = "細麵";
            // 
            // cmnuBeef
            // 
            this.cmnuBeef.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuBeef1,
            this.cmnuBeef2,
            this.cmnuBeef3});
            this.cmnuBeef.Name = "cmnuBeef";
            this.cmnuBeef.Size = new System.Drawing.Size(99, 70);
            // 
            // cmnuBeef1
            // 
            this.cmnuBeef1.Name = "cmnuBeef1";
            this.cmnuBeef1.Size = new System.Drawing.Size(98, 22);
            this.cmnuBeef1.Text = "清燉";
            this.cmnuBeef1.Click += new System.EventHandler(this.cmnuBeef1_Click);
            // 
            // cmnuBeef2
            // 
            this.cmnuBeef2.Name = "cmnuBeef2";
            this.cmnuBeef2.Size = new System.Drawing.Size(98, 22);
            this.cmnuBeef2.Text = "紅燒";
            // 
            // cmnuBeef3
            // 
            this.cmnuBeef3.Name = "cmnuBeef3";
            this.cmnuBeef3.Size = new System.Drawing.Size(98, 22);
            this.cmnuBeef3.Text = "招牌";
            // 
            // cmnuSide
            // 
            this.cmnuSide.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuSide1,
            this.cmnuSide2,
            this.cmnuSide3});
            this.cmnuSide.Name = "cmnuSide";
            this.cmnuSide.Size = new System.Drawing.Size(123, 70);
            // 
            // cmnuSide1
            // 
            this.cmnuSide1.Name = "cmnuSide1";
            this.cmnuSide1.Size = new System.Drawing.Size(122, 22);
            this.cmnuSide1.Text = "皮蛋豆腐";
            this.cmnuSide1.Click += new System.EventHandler(this.cmnuSide1_Click);
            // 
            // cmnuSide2
            // 
            this.cmnuSide2.Name = "cmnuSide2";
            this.cmnuSide2.Size = new System.Drawing.Size(122, 22);
            this.cmnuSide2.Text = "小魚豆干";
            // 
            // cmnuSide3
            // 
            this.cmnuSide3.Name = "cmnuSide3";
            this.cmnuSide3.Size = new System.Drawing.Size(122, 22);
            this.cmnuSide3.Text = "豬耳朵";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNoodle,
            this.mnuBeef,
            this.mnuSide,
            this.mnuExit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(250, 24);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuNoodle
            // 
            this.mnuNoodle.Name = "mnuNoodle";
            this.mnuNoodle.Size = new System.Drawing.Size(43, 20);
            this.mnuNoodle.Text = "麵條";
            // 
            // mnuBeef
            // 
            this.mnuBeef.Name = "mnuBeef";
            this.mnuBeef.Size = new System.Drawing.Size(43, 20);
            this.mnuBeef.Text = "口味";
            // 
            // mnuSide
            // 
            this.mnuSide.Name = "mnuSide";
            this.mnuSide.Size = new System.Drawing.Size(43, 20);
            this.mnuSide.Text = "小菜";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(43, 20);
            this.mnuExit.Text = "結束";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "麵條：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "口味：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "小菜：";
            // 
            // lblNoodle
            // 
            this.lblNoodle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNoodle.Location = new System.Drawing.Point(57, 36);
            this.lblNoodle.Name = "lblNoodle";
            this.lblNoodle.Size = new System.Drawing.Size(177, 23);
            this.lblNoodle.TabIndex = 7;
            this.lblNoodle.Text = "label4";
            // 
            // lblBeef
            // 
            this.lblBeef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBeef.Location = new System.Drawing.Point(57, 65);
            this.lblBeef.Name = "lblBeef";
            this.lblBeef.Size = new System.Drawing.Size(177, 23);
            this.lblBeef.TabIndex = 7;
            this.lblBeef.Text = "label5";
            // 
            // lblSide
            // 
            this.lblSide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSide.Location = new System.Drawing.Point(57, 94);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(177, 23);
            this.lblSide.TabIndex = 7;
            this.lblSide.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 129);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.lblBeef);
            this.Controls.Add(this.lblNoodle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmnuNoodle.ResumeLayout(false);
            this.cmnuBeef.ResumeLayout(false);
            this.cmnuSide.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmnuNoodle;
        private System.Windows.Forms.ToolStripMenuItem cmnuNoodle1;
        private System.Windows.Forms.ToolStripMenuItem cmnuNoodle2;
        private System.Windows.Forms.ContextMenuStrip cmnuBeef;
        private System.Windows.Forms.ToolStripMenuItem cmnuBeef1;
        private System.Windows.Forms.ToolStripMenuItem cmnuBeef2;
        private System.Windows.Forms.ToolStripMenuItem cmnuBeef3;
        private System.Windows.Forms.ContextMenuStrip cmnuSide;
        private System.Windows.Forms.ToolStripMenuItem cmnuSide1;
        private System.Windows.Forms.ToolStripMenuItem cmnuSide2;
        private System.Windows.Forms.ToolStripMenuItem cmnuSide3;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuNoodle;
        private System.Windows.Forms.ToolStripMenuItem mnuBeef;
        private System.Windows.Forms.ToolStripMenuItem mnuSide;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNoodle;
        private System.Windows.Forms.Label lblBeef;
        private System.Windows.Forms.Label lblSide;
    }
}

