namespace Piano
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
            this.lblFa = new System.Windows.Forms.Label();
            this.lblSi = new System.Windows.Forms.Label();
            this.lblMi = new System.Windows.Forms.Label();
            this.lblLa = new System.Windows.Forms.Label();
            this.lblRe = new System.Windows.Forms.Label();
            this.lblSol = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFa
            // 
            this.lblFa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFa.Location = new System.Drawing.Point(150, 12);
            this.lblFa.Name = "lblFa";
            this.lblFa.Size = new System.Drawing.Size(40, 133);
            this.lblFa.TabIndex = 9;
            this.lblFa.Text = "Fa";
            this.lblFa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSi
            // 
            this.lblSi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSi.Location = new System.Drawing.Point(288, 12);
            this.lblSi.Name = "lblSi";
            this.lblSi.Size = new System.Drawing.Size(40, 133);
            this.lblSi.TabIndex = 10;
            this.lblSi.Text = "Si";
            this.lblSi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMi
            // 
            this.lblMi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMi.Location = new System.Drawing.Point(104, 11);
            this.lblMi.Name = "lblMi";
            this.lblMi.Size = new System.Drawing.Size(40, 133);
            this.lblMi.TabIndex = 11;
            this.lblMi.Text = "Mi";
            this.lblMi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLa
            // 
            this.lblLa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLa.Location = new System.Drawing.Point(242, 12);
            this.lblLa.Name = "lblLa";
            this.lblLa.Size = new System.Drawing.Size(40, 133);
            this.lblLa.TabIndex = 12;
            this.lblLa.Text = "La";
            this.lblLa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRe
            // 
            this.lblRe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRe.Location = new System.Drawing.Point(58, 11);
            this.lblRe.Name = "lblRe";
            this.lblRe.Size = new System.Drawing.Size(40, 133);
            this.lblRe.TabIndex = 13;
            this.lblRe.Text = "Re";
            this.lblRe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSol
            // 
            this.lblSol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSol.Location = new System.Drawing.Point(196, 12);
            this.lblSol.Name = "lblSol";
            this.lblSol.Size = new System.Drawing.Size(40, 133);
            this.lblSol.TabIndex = 14;
            this.lblSol.Text = "Sol";
            this.lblSol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDo
            // 
            this.lblDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDo.Location = new System.Drawing.Point(12, 10);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(40, 133);
            this.lblDo.TabIndex = 15;
            this.lblDo.Text = "Do";
            this.lblDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDo.Click += new System.EventHandler(this.lblDo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 155);
            this.Controls.Add(this.lblFa);
            this.Controls.Add(this.lblSi);
            this.Controls.Add(this.lblMi);
            this.Controls.Add(this.lblLa);
            this.Controls.Add(this.lblRe);
            this.Controls.Add(this.lblSol);
            this.Controls.Add(this.lblDo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFa;
        private System.Windows.Forms.Label lblSi;
        private System.Windows.Forms.Label lblMi;
        private System.Windows.Forms.Label lblLa;
        private System.Windows.Forms.Label lblRe;
        private System.Windows.Forms.Label lblSol;
        private System.Windows.Forms.Label lblDo;
    }
}

