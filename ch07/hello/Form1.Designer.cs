namespace hello
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
            this.lblShow_LBJ = new System.Windows.Forms.Label();
            this.btnHi = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShow_LBJ
            // 
            this.lblShow_LBJ.AutoSize = true;
            this.lblShow_LBJ.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow_LBJ.Location = new System.Drawing.Point(69, 113);
            this.lblShow_LBJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShow_LBJ.Name = "lblShow_LBJ";
            this.lblShow_LBJ.Size = new System.Drawing.Size(221, 70);
            this.lblShow_LBJ.TabIndex = 0;
            this.lblShow_LBJ.Text = "Hello！\r\nLeBron James";
            this.lblShow_LBJ.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // btnHi
            // 
            this.btnHi.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHi.Location = new System.Drawing.Point(54, 230);
            this.btnHi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(112, 37);
            this.btnHi.TabIndex = 1;
            this.btnHi.Text = "問候";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // btnDate
            // 
            this.btnDate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.Location = new System.Drawing.Point(279, 230);
            this.btnDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(112, 37);
            this.btnDate.TabIndex = 2;
            this.btnDate.Text = "日期";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(481, 230);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(112, 37);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "結束";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "53135";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(513, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 65);
            this.button2.TabIndex = 5;
            this.button2.Text = "LBJ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(350, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 23);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(274, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 23);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(350, 125);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(104, 23);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(350, 86);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(104, 23);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(536, 166);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(104, 23);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(477, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 48);
            this.label1.TabIndex = 12;
            this.label1.Text = "161351351";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(652, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.lblShow_LBJ);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Kobe Bryant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow_LBJ;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label1;
    }
}

