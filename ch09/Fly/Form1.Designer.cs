namespace Fly
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
            this.btnStart = new System.Windows.Forms.Button();
            this.imgBtn = new System.Windows.Forms.ImageList(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.imgBirds = new System.Windows.Forms.ImageList(this.components);
            this.tmrFly = new System.Windows.Forms.Timer(this.components);
            this.picBird = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.ImageIndex = 0;
            this.btnStart.ImageList = this.imgBtn;
            this.btnStart.Location = new System.Drawing.Point(456, 179);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(67, 62);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imgBtn
            // 
            this.imgBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBtn.ImageStream")));
            this.imgBtn.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBtn.Images.SetKeyName(0, "start.bmp");
            this.imgBtn.Images.SetKeyName(1, "stop.bmp");
            // 
            // btnStop
            // 
            this.btnStop.ImageIndex = 1;
            this.btnStop.ImageList = this.imgBtn;
            this.btnStop.Location = new System.Drawing.Point(456, 249);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(67, 62);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // imgBirds
            // 
            this.imgBirds.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBirds.ImageStream")));
            this.imgBirds.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBirds.Images.SetKeyName(0, "bird0.png");
            this.imgBirds.Images.SetKeyName(1, "bird1.png");
            this.imgBirds.Images.SetKeyName(2, "bird2.png");
            this.imgBirds.Images.SetKeyName(3, "bird3.png");
            this.imgBirds.Images.SetKeyName(4, "bird4.png");
            this.imgBirds.Images.SetKeyName(5, "bird5.png");
            // 
            // tmrFly
            // 
            this.tmrFly.Tick += new System.EventHandler(this.tmrFly_Tick);
            // 
            // picBird
            // 
            this.picBird.Location = new System.Drawing.Point(179, 32);
            this.picBird.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(159, 108);
            this.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBird.TabIndex = 2;
            this.picBird.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(127, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Speed: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picBird);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ImageList imgBtn;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ImageList imgBirds;
        private System.Windows.Forms.Timer tmrFly;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

