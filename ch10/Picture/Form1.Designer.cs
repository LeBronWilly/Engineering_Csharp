namespace Picture
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
            this.lblNum = new System.Windows.Forms.Label();
            this.tkbNum = new System.Windows.Forms.TrackBar();
            this.vsbHeight = new System.Windows.Forms.VScrollBar();
            this.hsbWidth = new System.Windows.Forms.HScrollBar();
            this.picShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(254, 249);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(33, 12);
            this.lblNum.TabIndex = 9;
            this.lblNum.Text = "label1";
            // 
            // tkbNum
            // 
            this.tkbNum.Location = new System.Drawing.Point(23, 249);
            this.tkbNum.Name = "tkbNum";
            this.tkbNum.Size = new System.Drawing.Size(222, 45);
            this.tkbNum.TabIndex = 8;
            this.tkbNum.ValueChanged += new System.EventHandler(this.tkbNum_ValueChanged);
            // 
            // vsbHeight
            // 
            this.vsbHeight.Location = new System.Drawing.Point(296, 7);
            this.vsbHeight.Name = "vsbHeight";
            this.vsbHeight.Size = new System.Drawing.Size(18, 203);
            this.vsbHeight.TabIndex = 7;
            this.vsbHeight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbHeight_Scroll);
            // 
            // hsbWidth
            // 
            this.hsbWidth.Location = new System.Drawing.Point(23, 219);
            this.hsbWidth.Name = "hsbWidth";
            this.hsbWidth.Size = new System.Drawing.Size(264, 17);
            this.hsbWidth.TabIndex = 6;
            this.hsbWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbWidth_Scroll);
            // 
            // picShow
            // 
            this.picShow.Location = new System.Drawing.Point(23, 22);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(180, 144);
            this.picShow.TabIndex = 5;
            this.picShow.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 291);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.tkbNum);
            this.Controls.Add(this.vsbHeight);
            this.Controls.Add(this.hsbWidth);
            this.Controls.Add(this.picShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TrackBar tkbNum;
        private System.Windows.Forms.VScrollBar vsbHeight;
        private System.Windows.Forms.HScrollBar hsbWidth;
        private System.Windows.Forms.PictureBox picShow;
    }
}

