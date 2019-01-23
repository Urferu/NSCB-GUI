using MetroFramework;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace NSCB_GUI
{
    public partial class MemesForm : MetroForm
    {
        public MemesForm(string url)
        {
            InitializeComponent();
            pictureBox1.Load(url);
            Image imagen = pictureBox1.Image;
            int diferencia = 0;
            bool masAlta = true;
            if(imagen.Height > pictureBox1.Width)
            {
                diferencia = imagen.Height - imagen.Width;
            }
            else
            {
                diferencia = imagen.Width - imagen.Height;
                masAlta = false;
            }

            if(masAlta && imagen.Height + 80 > Screen.PrimaryScreen.WorkingArea.Height)
            {
                imagen = ResizeImage(imagen, Screen.PrimaryScreen.WorkingArea.Height - 80, Screen.PrimaryScreen.WorkingArea.Height - 80 - diferencia);
            }
            else if(imagen.Width + 40 > Screen.PrimaryScreen.WorkingArea.Width)
            {
                imagen = ResizeImage(imagen, Screen.PrimaryScreen.WorkingArea.Width - 40 - diferencia, Screen.PrimaryScreen.WorkingArea.Width - 40);
            }
            pictureBox1.Image = imagen;
            Height = pictureBox1.Image.Height + 80;
            Width = pictureBox1.Image.Width + 40;
        }

        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
