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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbSizeL);
            this.groupBox2.Controls.Add(this.rdbSizeS);
            this.groupBox2.Location = new System.Drawing.Point(350, 134);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(108, 118);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "大小";
            // 
            // rdbSizeL
            // 
            this.rdbSizeL.AutoSize = true;
            this.rdbSizeL.Location = new System.Drawing.Point(12, 50);
            this.rdbSizeL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSizeL.Name = "rdbSizeL";
            this.rdbSizeL.Size = new System.Drawing.Size(58, 19);
            this.rdbSizeL.TabIndex = 1;
            this.rdbSizeL.TabStop = true;
            this.rdbSizeL.Text = "大杯";
            this.rdbSizeL.UseVisualStyleBackColor = true;
            // 
            // rdbSizeS
            // 
            this.rdbSizeS.AutoSize = true;
            this.rdbSizeS.Location = new System.Drawing.Point(12, 22);
            this.rdbSizeS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSizeS.Name = "rdbSizeS";
            this.rdbSizeS.Size = new System.Drawing.Size(58, 19);
            this.rdbSizeS.TabIndex = 0;
            this.rdbSizeS.TabStop = true;
            this.rdbSizeS.Text = "小杯";
            this.rdbSizeS.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblPrice.Location = new System.Drawing.Point(226, 269);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 25);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "label2";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(543, 96);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 31);
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
            this.groupBox3.Location = new System.Drawing.Point(479, 134);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(132, 118);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "其他";
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(8, 80);
            this.chk3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(104, 19);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "有自備容器";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(8, 52);
            this.chk2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(82, 19);
            this.chk2.TabIndex = 1;
            this.chk2.Text = "+塑膠袋";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(8, 26);
            this.chk1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(52, 19);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "+冰";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTea3);
            this.groupBox1.Controls.Add(this.rdbTea2);
            this.groupBox1.Controls.Add(this.rdbTea1);
            this.groupBox1.Location = new System.Drawing.Point(221, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(107, 118);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "類別";
            // 
            // rdbTea3
            // 
            this.rdbTea3.AutoSize = true;
            this.rdbTea3.Location = new System.Drawing.Point(8, 78);
            this.rdbTea3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbTea3.Name = "rdbTea3";
            this.rdbTea3.Size = new System.Drawing.Size(58, 19);
            this.rdbTea3.TabIndex = 2;
            this.rdbTea3.TabStop = true;
            this.rdbTea3.Text = "奶茶";
            this.rdbTea3.UseVisualStyleBackColor = true;
            // 
            // rdbTea2
            // 
            this.rdbTea2.AutoSize = true;
            this.rdbTea2.Location = new System.Drawing.Point(8, 50);
            this.rdbTea2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbTea2.Name = "rdbTea2";
            this.rdbTea2.Size = new System.Drawing.Size(58, 19);
            this.rdbTea2.TabIndex = 1;
            this.rdbTea2.TabStop = true;
            this.rdbTea2.Text = "綠茶";
            this.rdbTea2.UseVisualStyleBackColor = true;
            // 
            // rdbTea1
            // 
            this.rdbTea1.AutoSize = true;
            this.rdbTea1.Location = new System.Drawing.Point(8, 24);
            this.rdbTea1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbTea1.Name = "rdbTea1";
            this.rdbTea1.Size = new System.Drawing.Size(58, 19);
            this.rdbTea1.TabIndex = 0;
            this.rdbTea1.TabStop = true;
            this.rdbTea1.Text = "紅茶";
            this.rdbTea1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(277, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "手搖茶飲專賣店";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(627, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(649, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "杯數";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.label3.Location = new System.Drawing.Point(17, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 175);
            this.label3.TabIndex = 14;
            this.label3.Text = "紅茶、綠茶：30元\r\n奶茶：35元\r\n\r\n加大+5元\r\n加冰不用錢\r\n加塑膠袋+2元\r\n自備容器可-5元";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(62, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Menu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

