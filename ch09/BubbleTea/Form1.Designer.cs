namespace BubbleTea
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbSizeL = new System.Windows.Forms.RadioButton();
            this.rdbSizeS = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTea3 = new System.Windows.Forms.RadioButton();
            this.rdbTea2 = new System.Windows.Forms.RadioButton();
            this.rdbTea1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbSizeL);
            this.groupBox2.Controls.Add(this.rdbSizeS);
            this.groupBox2.Location = new System.Drawing.Point(108, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(81, 94);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "大小";
            // 
            // rdbSizeL
            // 
            this.rdbSizeL.AutoSize = true;
            this.rdbSizeL.Location = new System.Drawing.Point(9, 40);
            this.rdbSizeL.Name = "rdbSizeL";
            this.rdbSizeL.Size = new System.Drawing.Size(47, 16);
            this.rdbSizeL.TabIndex = 1;
            this.rdbSizeL.TabStop = true;
            this.rdbSizeL.Text = "大杯";
            this.rdbSizeL.UseVisualStyleBackColor = true;
            // 
            // rdbSizeS
            // 
            this.rdbSizeS.AutoSize = true;
            this.rdbSizeS.Location = new System.Drawing.Point(9, 18);
            this.rdbSizeS.Name = "rdbSizeS";
            this.rdbSizeS.Size = new System.Drawing.Size(47, 16);
            this.rdbSizeS.TabIndex = 0;
            this.rdbSizeS.TabStop = true;
            this.rdbSizeS.Text = "小杯";
            this.rdbSizeS.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblPrice.Location = new System.Drawing.Point(15, 169);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 16);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "label2";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(253, 30);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(60, 25);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "結帳";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk3);
            this.groupBox3.Controls.Add(this.chk2);
            this.groupBox3.Controls.Add(this.chk1);
            this.groupBox3.Location = new System.Drawing.Point(205, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 94);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "其他";
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(6, 64);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(72, 16);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "自備容器";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(6, 42);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(60, 16);
            this.chk2.TabIndex = 1;
            this.chk2.Text = "塑膠袋";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(6, 21);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(48, 16);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "加冰";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTea3);
            this.groupBox1.Controls.Add(this.rdbTea2);
            this.groupBox1.Controls.Add(this.rdbTea1);
            this.groupBox1.Location = new System.Drawing.Point(11, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "類別";
            // 
            // rdbTea3
            // 
            this.rdbTea3.AutoSize = true;
            this.rdbTea3.Location = new System.Drawing.Point(6, 62);
            this.rdbTea3.Name = "rdbTea3";
            this.rdbTea3.Size = new System.Drawing.Size(47, 16);
            this.rdbTea3.TabIndex = 2;
            this.rdbTea3.TabStop = true;
            this.rdbTea3.Text = "奶茶";
            this.rdbTea3.UseVisualStyleBackColor = true;
            // 
            // rdbTea2
            // 
            this.rdbTea2.AutoSize = true;
            this.rdbTea2.Location = new System.Drawing.Point(6, 40);
            this.rdbTea2.Name = "rdbTea2";
            this.rdbTea2.Size = new System.Drawing.Size(47, 16);
            this.rdbTea2.TabIndex = 1;
            this.rdbTea2.TabStop = true;
            this.rdbTea2.Text = "綠茶";
            this.rdbTea2.UseVisualStyleBackColor = true;
            // 
            // rdbTea1
            // 
            this.rdbTea1.AutoSize = true;
            this.rdbTea1.Location = new System.Drawing.Point(6, 19);
            this.rdbTea1.Name = "rdbTea1";
            this.rdbTea1.Size = new System.Drawing.Size(47, 16);
            this.rdbTea1.TabIndex = 0;
            this.rdbTea1.TabStop = true;
            this.rdbTea1.Text = "紅茶";
            this.rdbTea1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F);
            this.label1.Location = new System.Drawing.Point(53, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "手搖茶飲專賣店";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 199);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbSizeL;
        private System.Windows.Forms.RadioButton rdbSizeS;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTea3;
        private System.Windows.Forms.RadioButton rdbTea2;
        private System.Windows.Forms.RadioButton rdbTea1;
        private System.Windows.Forms.Label label1;
    }
}

