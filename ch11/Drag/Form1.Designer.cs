namespace Drag
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
            this.btnDrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrag
            // 
            this.btnDrag.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnDrag.Location = new System.Drawing.Point(92, 105);
            this.btnDrag.Name = "btnDrag";
            this.btnDrag.Size = new System.Drawing.Size(100, 50);
            this.btnDrag.TabIndex = 1;
            this.btnDrag.Text = "button1";
            this.btnDrag.UseVisualStyleBackColor = true;
            this.btnDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDrag_MouseDown);
            this.btnDrag.MouseEnter += new System.EventHandler(this.btnDrag_MouseEnter);
            this.btnDrag.MouseLeave += new System.EventHandler(this.btnDrag_MouseLeave);
            this.btnDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDrag_MouseMove);
            this.btnDrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDrag_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDrag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrag;
    }
}

