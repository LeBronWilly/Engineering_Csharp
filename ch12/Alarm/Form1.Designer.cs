namespace Alarm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tcboSet = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tcboDate = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ttxtS = new System.Windows.Forms.ToolStripTextBox();
            this.tbtnStart = new System.Windows.Forms.ToolStripButton();
            this.tbtnPause = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblSet = new System.Windows.Forms.ToolStripStatusLabel();
            this.spgbSec = new System.Windows.Forms.ToolStripProgressBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.tmrAlarm = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcboSet,
            this.toolStripSeparator2,
            this.tcboDate,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.ttxtS,
            this.tbtnStart,
            this.tbtnPause});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(296, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tcboSet
            // 
            this.tcboSet.Items.AddRange(new object[] {
            "時鐘",
            "倒數"});
            this.tcboSet.Name = "tcboSet";
            this.tcboSet.Size = new System.Drawing.Size(75, 25);
            this.tcboSet.SelectedIndexChanged += new System.EventHandler(this.tcboSet_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tcboDate
            // 
            this.tcboDate.Items.AddRange(new object[] {
            "時間",
            "日期"});
            this.tcboDate.Name = "tcboDate";
            this.tcboDate.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "秒：";
            // 
            // ttxtS
            // 
            this.ttxtS.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.ttxtS.Name = "ttxtS";
            this.ttxtS.Size = new System.Drawing.Size(30, 25);
            // 
            // tbtnStart
            // 
            this.tbtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnStart.Image = global::Alarm.Properties.Resources.play;
            this.tbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnStart.Name = "tbtnStart";
            this.tbtnStart.Size = new System.Drawing.Size(23, 22);
            this.tbtnStart.Text = "toolStripButton1";
            this.tbtnStart.Click += new System.EventHandler(this.tbtnStart_Click);
            // 
            // tbtnPause
            // 
            this.tbtnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnPause.Image = global::Alarm.Properties.Resources.pause;
            this.tbtnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnPause.Name = "tbtnPause";
            this.tbtnPause.Size = new System.Drawing.Size(23, 22);
            this.tbtnPause.Text = "toolStripButton2";
            this.tbtnPause.Click += new System.EventHandler(this.tbtnPause_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblSet,
            this.spgbSec});
            this.statusStrip1.Location = new System.Drawing.Point(0, 100);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(296, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slblSet
            // 
            this.slblSet.Name = "slblSet";
            this.slblSet.Size = new System.Drawing.Size(128, 17);
            this.slblSet.Text = "toolStripStatusLabel1";
            // 
            // spgbSec
            // 
            this.spgbSec.Name = "spgbSec";
            this.spgbSec.Size = new System.Drawing.Size(100, 16);
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("新細明體", 30F);
            this.lblTime.Location = new System.Drawing.Point(9, 31);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(278, 65);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // tmrAlarm
            // 
            this.tmrAlarm.Interval = 500;
            this.tmrAlarm.Tick += new System.EventHandler(this.tmrAlarm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 122);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnStart;
        private System.Windows.Forms.ToolStripButton tbtnPause;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ttxtS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tcboSet;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slblSet;
        private System.Windows.Forms.ToolStripProgressBar spgbSec;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Timer tmrAlarm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox tcboDate;
    }
}

