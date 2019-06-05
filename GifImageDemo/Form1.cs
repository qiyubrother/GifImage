using System;
using System.Windows.Forms;

namespace GifImageDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            gifImage1.AnimateImage = Properties.Resources.动图;
            //gifImage1.AnimateImage = Properties.Resources.人体解刨图;

            gifImage1.Play();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
