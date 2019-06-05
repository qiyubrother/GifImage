using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GifImage
{
    public partial class GifImage : UserControl
    {
        AnimateImage image;

        public GifImage()
        {
            InitializeComponent();
        }

        public Image AnimateImage { get; set; }

        public void Play()
        {
            if (AnimateImage != null)
            {
                image = new AnimateImage(AnimateImage);
                image.OnFrameChanged += new EventHandler<EventArgs>((o, ex) => { Invalidate(); });
                SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

                var owner = this;
                Image newImg = image.Image;
                var scWidth = owner.Width * 1.0f / image.Image.Width;
                var scHeight = owner.Height * 1.0f / image.Image.Height;
                var minScale = Math.Min(scWidth, scHeight);
                if (minScale < 1.0f)
                {
                    newImg = new Bitmap(image.Image, new Size((int)(minScale * image.Image.Width), (int)(minScale * image.Image.Height)));
                }
                if (scWidth < scHeight)
                {
                    owner.Height = newImg.Height;
                }
                else if (scWidth > scHeight)
                {
                    owner.Width = newImg.Width;
                }
                image.Play();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (image != null)
            {
                lock (image.Image)
                {
                    var owner = this;
                    Image newImg = image.Image;
                    var scWidth = owner.Width * 1.0f / image.Image.Width;
                    var scHeight = owner.Height * 1.0f / image.Image.Height;
                    var minScale = Math.Min(scWidth, scHeight);
                    if (minScale < 1.0f)
                    {
                        newImg = new Bitmap(image.Image, new Size((int)(minScale * image.Image.Width), (int)(minScale * image.Image.Height)));
                    }

                    e.Graphics.DrawImage(newImg, new Point(0, 0));
                }
            }

        }
    }
}
