namespace imageList
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btPrav = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "微信图片_20240727102615.jpg");
            this.imageList1.Images.SetKeyName(1, "微信图片_20240727102617.jpg");
            this.imageList1.Images.SetKeyName(2, "微信图片_20240727102619.jpg");
            this.imageList1.Images.SetKeyName(3, "微信图片_20240727102621.jpg");
            this.imageList1.Images.SetKeyName(4, "微信图片_20240727102625.jpg");
            this.imageList1.Images.SetKeyName(5, "微信图片_20240727102634.jpg");
            this.imageList1.Images.SetKeyName(6, "微信图片_20240727102645.jpg");
            this.imageList1.Images.SetKeyName(7, "微信图片_20240727102629.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(191, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 468);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btPrav
            // 
            this.btPrav.AutoSize = true;
            this.btPrav.Location = new System.Drawing.Point(200, 566);
            this.btPrav.Name = "btPrav";
            this.btPrav.Size = new System.Drawing.Size(63, 25);
            this.btPrav.TabIndex = 1;
            this.btPrav.Text = "上一张";
            this.btPrav.UseVisualStyleBackColor = true;
            this.btPrav.Click += new System.EventHandler(this.btPrav_Click);
            // 
            // btNext
            // 
            this.btNext.AutoSize = true;
            this.btNext.Location = new System.Drawing.Point(566, 565);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(63, 25);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "下一张";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 691);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrav);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btPrav;
        private System.Windows.Forms.Button btNext;
    }
}

