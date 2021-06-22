namespace Circle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.rdbL = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbCm = new System.Windows.Forms.RadioButton();
            this.rdbInch = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.lblAns);
            this.panel1.Controls.Add(this.txtR);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入半徑：";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(74, 14);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 22);
            this.txtR.TabIndex = 1;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblAns.Location = new System.Drawing.Point(11, 47);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(46, 16);
            this.lblAns.TabIndex = 2;
            this.lblAns.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbA);
            this.groupBox1.Controls.Add(this.rdbL);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "計算類別";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(192, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(54, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "計算";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rdbL
            // 
            this.rdbL.AutoSize = true;
            this.rdbL.Location = new System.Drawing.Point(17, 21);
            this.rdbL.Name = "rdbL";
            this.rdbL.Size = new System.Drawing.Size(59, 16);
            this.rdbL.TabIndex = 0;
            this.rdbL.TabStop = true;
            this.rdbL.Text = "圓周長";
            this.rdbL.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(17, 43);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(59, 16);
            this.rdbA.TabIndex = 1;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "圓面積";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbInch);
            this.groupBox2.Controls.Add(this.rdbCm);
            this.groupBox2.Location = new System.Drawing.Point(154, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "單位";
            // 
            // rdbCm
            // 
            this.rdbCm.AutoSize = true;
            this.rdbCm.Location = new System.Drawing.Point(16, 21);
            this.rdbCm.Name = "rdbCm";
            this.rdbCm.Size = new System.Drawing.Size(47, 16);
            this.rdbCm.TabIndex = 0;
            this.rdbCm.TabStop = true;
            this.rdbCm.Text = "公分";
            this.rdbCm.UseVisualStyleBackColor = true;
            this.rdbCm.CheckedChanged += new System.EventHandler(this.rdbCm_CheckedChanged);
            // 
            // rdbInch
            // 
            this.rdbInch.AutoSize = true;
            this.rdbInch.Location = new System.Drawing.Point(16, 43);
            this.rdbInch.Name = "rdbInch";
            this.rdbInch.Size = new System.Drawing.Size(47, 16);
            this.rdbInch.TabIndex = 1;
            this.rdbInch.TabStop = true;
            this.rdbInch.Text = "英吋";
            this.rdbInch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 190);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.RadioButton rdbL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbInch;
        private System.Windows.Forms.RadioButton rdbCm;
    }
}

