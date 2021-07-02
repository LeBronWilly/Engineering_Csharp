
namespace LoadImage
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnStretch = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnSheep = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImage.Image = global::LoadImage.Properties.Resources.貓;
            this.picImage.Location = new System.Drawing.Point(12, 23);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(629, 415);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // btnNormal
            // 
            this.btnNormal.AutoSize = true;
            this.btnNormal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNormal.Location = new System.Drawing.Point(668, 25);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(120, 35);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.Text = "原尺寸";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnStretch
            // 
            this.btnStretch.AutoSize = true;
            this.btnStretch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStretch.Location = new System.Drawing.Point(668, 79);
            this.btnStretch.Name = "btnStretch";
            this.btnStretch.Size = new System.Drawing.Size(120, 35);
            this.btnStretch.TabIndex = 2;
            this.btnStretch.Text = "放大";
            this.btnStretch.UseVisualStyleBackColor = true;
            this.btnStretch.Click += new System.EventHandler(this.btnStretch_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.AutoSize = true;
            this.btnZoom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnZoom.Location = new System.Drawing.Point(667, 183);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(122, 35);
            this.btnZoom.TabIndex = 3;
            this.btnZoom.Text = "等比例放大";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.AutoSize = true;
            this.btnCenter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCenter.Location = new System.Drawing.Point(668, 132);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(122, 35);
            this.btnCenter.TabIndex = 4;
            this.btnCenter.Text = "原尺寸置中";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnSheep
            // 
            this.btnSheep.AutoSize = true;
            this.btnSheep.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSheep.Location = new System.Drawing.Point(668, 314);
            this.btnSheep.Name = "btnSheep";
            this.btnSheep.Size = new System.Drawing.Size(121, 35);
            this.btnSheep.TabIndex = 5;
            this.btnSheep.Text = "綿羊";
            this.btnSheep.UseVisualStyleBackColor = true;
            this.btnSheep.Click += new System.EventHandler(this.btnSheep_Click);
            // 
            // btnCat
            // 
            this.btnCat.AutoSize = true;
            this.btnCat.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCat.Location = new System.Drawing.Point(667, 359);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(121, 35);
            this.btnCat.TabIndex = 6;
            this.btnCat.Text = "貓貓";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(667, 403);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 35);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "移除圖片";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.AutoSize = true;
            this.btnAuto.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAuto.Location = new System.Drawing.Point(667, 233);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(122, 35);
            this.btnAuto.TabIndex = 8;
            this.btnAuto.Text = "AutoSize";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Visible = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnSheep);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.btnStretch);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.picImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnStretch;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnSheep;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAuto;
    }
}

