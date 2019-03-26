using MetroFramework;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System;
using MetroFramework.Forms;

namespace NSCB_GUI
{
    public partial class NovedadesForm : MetroForm
    {
        public NovedadesForm()
        {
            InitializeComponent();
        }

        private void pbNovedad_Click(object sender, System.EventArgs e)
        {
            int indice = Convert.ToInt32(pbNovedad.Tag) + 1;
            switch (indice)
            {
                case 1:
                    pbNovedad.Image = Properties.Resources.Novedad_1;
                    break;
                case 2:
                    pbNovedad.Image = Properties.Resources.Novedad_2;
                    break;
                case 3:
                //    pbNovedad.Image = Properties.Resources.Novedad_3;
                //    break;
                //case 4:
                //    pbNovedad.Image = Properties.Resources.Novedad_4;
                //    break;
                //case 5:
                //    pbNovedad.Image = Properties.Resources.Novedad_5;
                //    break;
                //case 6:
                    pbNovedad.Image = Properties.Resources.Novedad_6;
                    break;
                default:
                    this.Close();
                    break;
            }
            pbNovedad.Tag = indice;
        }
    }
}
