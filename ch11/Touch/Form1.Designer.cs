namespace Touch
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
            this.picTouch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTouch)).BeginInit();
            this.SuspendLayout();
            // 
            // picTouch
            // 
            this.picTouch.Image = global::Touch.Properties.Resources.hat;
            this.picTouch.Location = new System.Drawing.Point(328, 165);
            this.picTouch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTouch.MinimumSize = new System.Drawing.Size(68, 93);
            this.picTouch.Name = "picTouch";
            this.picTouch.Size = new System.Drawing.Size(155, 199);
            this.picTouch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTouch.TabIndex = 1;
            this.picTouch.TabStop = false;
            this.picTouch.DoubleClick += new System.EventHandler(this.picTouch_DoubleClick);
            this.picTouch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picTouch_MouseDown);
            this.picTouch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picTouch_MouseMove);
            this.picTouch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picTouch_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 541);
            this.Controls.Add(this.picTouch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.picTouch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTouch;
    }
}

