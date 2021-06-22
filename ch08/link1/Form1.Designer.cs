namespace link1
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
            this.llblReadMe = new System.Windows.Forms.LinkLabel();
            this.llblApp = new System.Windows.Forms.LinkLabel();
            this.llblWeb = new System.Windows.Forms.LinkLabel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llblReadMe
            // 
            this.llblReadMe.AutoSize = true;
            this.llblReadMe.Location = new System.Drawing.Point(31, 72);
            this.llblReadMe.Name = "llblReadMe";
            this.llblReadMe.Size = new System.Drawing.Size(65, 12);
            this.llblReadMe.TabIndex = 0;
            this.llblReadMe.TabStop = true;
            this.llblReadMe.Text = "小算盤簡介";
            this.llblReadMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblReadMe_LinkClicked);
            // 
            // llblApp
            // 
            this.llblApp.AutoSize = true;
            this.llblApp.LinkArea = new System.Windows.Forms.LinkArea(0, 3);
            this.llblApp.Location = new System.Drawing.Point(112, 72);
            this.llblApp.Name = "llblApp";
            this.llblApp.Size = new System.Drawing.Size(66, 19);
            this.llblApp.TabIndex = 3;
            this.llblApp.TabStop = true;
            this.llblApp.Text = "小算盤程式";
            this.llblApp.UseCompatibleTextRendering = true;
            this.llblApp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblApp_LinkClicked);
            // 
            // llblWeb
            // 
            this.llblWeb.AutoSize = true;
            this.llblWeb.Location = new System.Drawing.Point(194, 72);
            this.llblWeb.Name = "llblWeb";
            this.llblWeb.Size = new System.Drawing.Size(53, 12);
            this.llblWeb.TabIndex = 4;
            this.llblWeb.TabStop = true;
            this.llblWeb.Text = "線上說明";
            this.llblWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblWeb_LinkClicked);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(33, 12);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 99);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.llblWeb);
            this.Controls.Add(this.llblApp);
            this.Controls.Add(this.llblReadMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblReadMe;
        private System.Windows.Forms.LinkLabel llblApp;
        private System.Windows.Forms.LinkLabel llblWeb;
        private System.Windows.Forms.Label lblMsg;
    }
}

