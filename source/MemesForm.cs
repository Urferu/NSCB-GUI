using MetroFramework;
using MetroFramework.Forms;

namespace NSCB_GUI
{
    public partial class MemesForm : MetroForm
    {
        public MemesForm(string url)
        {
            InitializeComponent();
            pictureBox1.Load(url);
            Height = pictureBox1.Image.Height + 80;
            Width = pictureBox1.Image.Width + 40;
        }
    }
}
