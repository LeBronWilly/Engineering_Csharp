namespace RunAway
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picMouse = new System.Windows.Forms.PictureBox();
            this.imgMouse = new System.Windows.Forms.ImageList(this.components);
            this.tmrBall = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // picBall
            // 
            this.picBall.Image = global::RunAway.Properties.Resources.ball;
            this.picBall.Location = new System.Drawing.Point(126, 3);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(20, 20);
            this.picBall.TabIndex = 3;
            this.picBall.TabStop = false;
            // 
            // picMouse
            // 
            this.picMouse.Location = new System.Drawing.Point(126, 225);
            this.picMouse.Name = "picMouse";
            this.picMouse.Size = new System.Drawing.Size(32, 32);
            this.picMouse.TabIndex = 2;
            this.picMouse.TabStop = false;
            // 
            // imgMouse
            // 
            this.imgMouse.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMouse.ImageStream")));
            this.imgMouse.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMouse.Images.SetKeyName(0, "stand.gif");
            this.imgMouse.Images.SetKeyName(1, "left.gif");
            this.imgMouse.Images.SetKeyName(2, "right.gif");
            // 
            // tmrBall
            // 
            this.tmrBall.Tick += new System.EventHandler(this.tmrBall_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picMouse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picMouse;
        private System.Windows.Forms.ImageList imgMouse;
        private System.Windows.Forms.Timer tmrBall;
    }
}

