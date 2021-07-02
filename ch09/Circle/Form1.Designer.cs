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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblAns = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.rdbL = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbInch = new System.Windows.Forms.RadioButton();
            this.rdbCm = new System.Windows.Forms.RadioButton();
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
            this.panel1.Location = new System.Drawing.Point(134, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 99);
            this.panel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(256, 16);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 29);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "計算";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblAns.Location = new System.Drawing.Point(15, 59);
            this.lblAns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(53, 20);
            this.lblAns.TabIndex = 2;
            this.lblAns.Text = "label2";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(99, 18);
            this.txtR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(132, 25);
            this.txtR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入半徑：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbA);
            this.groupBox1.Controls.Add(this.rdbL);
            this.groupBox1.Location = new System.Drawing.Point(134, 211);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(160, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "計算類別";
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(23, 54);
            this.rdbA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(73, 19);
            this.rdbA.TabIndex = 1;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "圓面積";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // rdbL
            // 
            this.rdbL.AutoSize = true;
            this.rdbL.Location = new System.Drawing.Point(23, 26);
            this.rdbL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbL.Name = "rdbL";
            this.rdbL.Size = new System.Drawing.Size(73, 19);
            this.rdbL.TabIndex = 0;
            this.rdbL.TabStop = true;
            this.rdbL.Text = "圓周長";
            this.rdbL.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbInch);
            this.groupBox2.Controls.Add(this.rdbCm);
            this.groupBox2.Location = new System.Drawing.Point(323, 211);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(165, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "單位";
            // 
            // rdbInch
            // 
            this.rdbInch.AutoSize = true;
            this.rdbInch.Location = new System.Drawing.Point(21, 54);
            this.rdbInch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbInch.Name = "rdbInch";
            this.rdbInch.Size = new System.Drawing.Size(58, 19);
            this.rdbInch.TabIndex = 1;
            this.rdbInch.TabStop = true;
            this.rdbInch.Text = "英吋";
            this.rdbInch.UseVisualStyleBackColor = true;
            // 
            // rdbCm
            // 
            this.rdbCm.AutoSize = true;
            this.rdbCm.Location = new System.Drawing.Point(21, 26);
            this.rdbCm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbCm.Name = "rdbCm";
            this.rdbCm.Size = new System.Drawing.Size(58, 19);
            this.rdbCm.TabIndex = 0;
            this.rdbCm.TabStop = true;
            this.rdbCm.Text = "公分";
            this.rdbCm.UseVisualStyleBackColor = true;
            this.rdbCm.CheckedChanged += new System.EventHandler(this.rdbCm_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 407);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

