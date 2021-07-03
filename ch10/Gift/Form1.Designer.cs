namespace Gift
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
            this.picGift = new System.Windows.Forms.PictureBox();
            this.lstGift = new System.Windows.Forms.ListBox();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGift)).BeginInit();
            this.SuspendLayout();
            // 
            // picGift
            // 
            this.picGift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picGift.Location = new System.Drawing.Point(438, 136);
            this.picGift.Margin = new System.Windows.Forms.Padding(4);
            this.picGift.Name = "picGift";
            this.picGift.Size = new System.Drawing.Size(231, 217);
            this.picGift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGift.TabIndex = 11;
            this.picGift.TabStop = false;
            // 
            // lstGift
            // 
            this.lstGift.FormattingEnabled = true;
            this.lstGift.ItemHeight = 15;
            this.lstGift.Location = new System.Drawing.Point(215, 220);
            this.lstGift.Margin = new System.Windows.Forms.Padding(4);
            this.lstGift.Name = "lstGift";
            this.lstGift.Size = new System.Drawing.Size(189, 124);
            this.lstGift.TabIndex = 10;
            this.lstGift.SelectedIndexChanged += new System.EventHandler(this.lstGift_SelectedIndexChanged);
            // 
            // cboArea
            // 
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(215, 155);
            this.cboArea.Margin = new System.Windows.Forms.Padding(4);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(190, 23);
            this.cboArea.TabIndex = 9;
            this.cboArea.SelectedIndexChanged += new System.EventHandler(this.cboArea_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "伴手禮：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "地區：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(292, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "台灣伴手禮";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 462);
            this.Controls.Add(this.picGift);
            this.Controls.Add(this.lstGift);
            this.Controls.Add(this.cboArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGift;
        private System.Windows.Forms.ListBox lstGift;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

