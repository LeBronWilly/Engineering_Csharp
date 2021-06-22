namespace EF01
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
            this.lblShow = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelEmpById
            // 
            this.btnSelEmpById.Location = new System.Drawing.Point(272, 366);
            this.btnSelEmpById.Name = "btnSelEmpById";
            this.btnSelEmpById.Size = new System.Drawing.Size(100, 34);
            this.btnSelEmpById.TabIndex = 22;
            this.btnSelEmpById.Text = "單筆查詢";
            this.btnSelEmpById.UseVisualStyleBackColor = true;
            this.btnSelEmpById.Click += new System.EventHandler(this.btnSelEmpById_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(405, 306);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(100, 34);
            this.btnDate.TabIndex = 21;
            this.btnDate.Text = "雇用日期";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(272, 306);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(100, 34);
            this.btnSalary.TabIndex = 20;
            this.btnSalary.Text = "薪資";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnEmpId
            // 
            this.btnEmpId.Location = new System.Drawing.Point(147, 306);
            this.btnEmpId.Name = "btnEmpId";
            this.btnEmpId.Size = new System.Drawing.Size(100, 34);
            this.btnEmpId.TabIndex = 19;
            this.btnEmpId.Text = "員工編號";
            this.btnEmpId.UseVisualStyleBackColor = true;
            this.btnEmpId.Click += new System.EventHandler(this.btnEmpId_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(147, 367);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 29);
            this.txtEmpId.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "查詢員工編號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "排序規則";
            // 
            // lblShow
            // 
            this.lblShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblShow.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShow.Location = new System.Drawing.Point(574, 306);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(214, 109);
            this.lblShow.TabIndex = 23;
            this.lblShow.Text = "lblShow";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(759, 244);
            this.dataGridView1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnSelEmpById);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnEmpId);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

