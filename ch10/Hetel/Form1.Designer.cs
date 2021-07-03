namespace Hetel
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mcnDate = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(433, 380);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "4. 確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(194, 286);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(223, 115);
            this.lblMsg.TabIndex = 14;
            this.lblMsg.Text = "label4";
            // 
            // cboRoom
            // 
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(197, 238);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(219, 23);
            this.cboRoom.TabIndex = 13;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "2. 請選擇房型：";
            // 
            // mcnDate
            // 
            this.mcnDate.AnnuallyBoldedDates = new System.DateTime[] {
        new System.DateTime(2021, 6, 13, 0, 0, 0, 0)};
            this.mcnDate.BoldedDates = new System.DateTime[] {
        new System.DateTime(2021, 7, 12, 0, 0, 0, 0)};
            this.mcnDate.Location = new System.Drawing.Point(433, 173);
            this.mcnDate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcnDate.Name = "mcnDate";
            this.mcnDate.TabIndex = 11;
            this.mcnDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcnDate_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "3. 請選擇入住期間：";
            // 
            // dtpBD
            // 
            this.dtpBD.CustomFormat = "M月d日";
            this.dtpBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBD.Location = new System.Drawing.Point(194, 173);
            this.dtpBD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.ShowUpDown = true;
            this.dtpBD.Size = new System.Drawing.Size(184, 25);
            this.dtpBD.TabIndex = 9;
            this.dtpBD.ValueChanged += new System.EventHandler(this.dtpBD_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "1. 請輸入生日：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14F);
            this.label4.Location = new System.Drawing.Point(317, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "快樂旅館訂房系統";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 529);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.cboRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mcnDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBD);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar mcnDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

