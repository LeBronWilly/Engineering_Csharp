namespace Linq3
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
            this.btnSelEmpById = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnEmpId = new System.Windows.Forms.Button();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSelEmpById
            // 
            this.btnSelEmpById.Location = new System.Drawing.Point(185, 221);
            this.btnSelEmpById.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelEmpById.Name = "btnSelEmpById";
            this.btnSelEmpById.Size = new System.Drawing.Size(67, 23);
            this.btnSelEmpById.TabIndex = 14;
            this.btnSelEmpById.Text = "單筆查詢";
            this.btnSelEmpById.UseVisualStyleBackColor = true;
            this.btnSelEmpById.Click += new System.EventHandler(this.btnSelEmpById_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(274, 181);
            this.btnDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(67, 23);
            this.btnDate.TabIndex = 13;
            this.btnDate.Text = "雇用日期";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(185, 181);
            this.btnSalary.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(67, 23);
            this.btnSalary.TabIndex = 12;
            this.btnSalary.Text = "薪資";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnEmpId
            // 
            this.btnEmpId.Location = new System.Drawing.Point(102, 181);
            this.btnEmpId.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpId.Name = "btnEmpId";
            this.btnEmpId.Size = new System.Drawing.Size(67, 23);
            this.btnEmpId.TabIndex = 11;
            this.btnEmpId.Text = "員工編號";
            this.btnEmpId.UseVisualStyleBackColor = true;
            this.btnEmpId.Click += new System.EventHandler(this.btnEmpId_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(102, 222);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(68, 22);
            this.txtEmpId.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "查詢員工編號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "排序規則";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 11);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(499, 147);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 265);
            this.Controls.Add(this.btnSelEmpById);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnEmpId);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "員工查詢";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelEmpById;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnEmpId;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

