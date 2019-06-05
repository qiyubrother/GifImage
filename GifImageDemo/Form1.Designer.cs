namespace GifImageDemo
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
            this.gifImage1 = new GifImage.GifImage();
            this.SuspendLayout();
            // 
            // gifImage1
            // 
            this.gifImage1.AnimateImage = global::GifImageDemo.Properties.Resources.Bk;
            this.gifImage1.BackColor = System.Drawing.Color.Transparent;
            this.gifImage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gifImage1.Location = new System.Drawing.Point(0, 0);
            this.gifImage1.Margin = new System.Windows.Forms.Padding(0);
            this.gifImage1.Name = "gifImage1";
            this.gifImage1.Size = new System.Drawing.Size(1455, 734);
            this.gifImage1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1455, 734);
            this.Controls.Add(this.gifImage1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private GifImage.GifImage gifImage1;
    }
}

