namespace Linq1
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSortIncrease = new System.Windows.Forms.Button();
            this.btnSortDecrease = new System.Windows.Forms.Button();
            this.btnGreater30000 = new System.Windows.Forms.Button();
            this.btnSmaller30000 = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "員工薪資列表";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(163, 150);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnSortIncrease
            // 
            this.btnSortIncrease.Location = new System.Drawing.Point(210, 63);
            this.btnSortIncrease.Name = "btnSortIncrease";
            this.btnSortIncrease.Size = new System.Drawing.Size(112, 26);
            this.btnSortIncrease.TabIndex = 2;
            this.btnSortIncrease.Text = "遞增排序";
            this.btnSortIncrease.UseVisualStyleBackColor = true;
            this.btnSortIncrease.Click += new System.EventHandler(this.btnSortIncrease_Click);
            // 
            // btnSortDecrease
            // 
            this.btnSortDecrease.Location = new System.Drawing.Point(210, 95);
            this.btnSortDecrease.Name = "btnSortDecrease";
            this.btnSortDecrease.Size = new System.Drawing.Size(112, 26);
            this.btnSortDecrease.TabIndex = 2;
            this.btnSortDecrease.Text = "遞減排序";
            this.btnSortDecrease.UseVisualStyleBackColor = true;
            this.btnSortDecrease.Click += new System.EventHandler(this.btnSortDecrease_Click);
            // 
            // btnGreater30000
            // 
            this.btnGreater30000.Location = new System.Drawing.Point(210, 127);
            this.btnGreater30000.Name = "btnGreater30000";
            this.btnGreater30000.Size = new System.Drawing.Size(112, 26);
            this.btnGreater30000.TabIndex = 2;
            this.btnGreater30000.Text = "大於30000";
            this.btnGreater30000.UseVisualStyleBackColor = true;
            this.btnGreater30000.Click += new System.EventHandler(this.btnGreater30000_Click);
            // 
            // btnSmaller30000
            // 
            this.btnSmaller30000.Location = new System.Drawing.Point(210, 159);
            this.btnSmaller30000.Name = "btnSmaller30000";
            this.btnSmaller30000.Size = new System.Drawing.Size(112, 26);
            this.btnSmaller30000.TabIndex = 2;
            this.btnSmaller30000.Text = "小於等於30000";
            this.btnSmaller30000.UseVisualStyleBackColor = true;
            this.btnSmaller30000.Click += new System.EventHandler(this.btnSmaller30000_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(210, 191);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(112, 26);
            this.btnAvg.TabIndex = 2;
            this.btnAvg.Text = "平均薪資";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 243);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnSmaller30000);
            this.Controls.Add(this.btnGreater30000);
            this.Controls.Add(this.btnSortDecrease);
            this.Controls.Add(this.btnSortIncrease);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "員工薪資列表";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSortIncrease;
        private System.Windows.Forms.Button btnSortDecrease;
        private System.Windows.Forms.Button btnGreater30000;
        private System.Windows.Forms.Button btnSmaller30000;
        private System.Windows.Forms.Button btnAvg;
    }
}

