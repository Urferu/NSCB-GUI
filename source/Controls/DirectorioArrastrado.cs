using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace NSCB_GUI.Controls
{
    public partial class DirectorioArrastrado : Panel
    {
        private List<string> juegosCarpeta;

        public List<string> JuegosLista
        {
            get
            {
                return juegosCarpeta;
            }
        }
        /// <summary>
        /// Corresponde al nombre del juego
        /// </summary>
        public string NombreJuego
        {
            get { return lblQuitarJuego.Text; }
            set
            {
                toolTip1.SetToolTip(lblQuitarJuego, value);
                lblQuitarJuego.Text = value;
            }
        }
        /// <summary>
        /// Corresponde al indice del juego
        /// </summary>
        public int indiceJuego;

        private string ubicacionJuegoLocal = "";
        public string ubicacionJuego
        {
            get { return ubicacionJuegoLocal; }
            set
            {
                if (Directory.Exists(value))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(value);
                    toolTip1.SetToolTip(lblQuitarJuego, dirInfo.Name);
                    lblQuitarJuego.Text = dirInfo.Name;
                    LlenarJuegosCarpeta(dirInfo);
                }
                ubicacionJuegoLocal = value;
            }
        }

        public delegate void EliminaJuegoDelegado(int indiceEliminar);

        private EliminaJuegoDelegado borrarIndice;

        public DirectorioArrastrado(EliminaJuegoDelegado metodoBorrar)
        {
            InitializeComponent();
            juegosCarpeta = new List<string>();
            quitarJuego.BringToFront();
            btnMostrarJuegos.BringToFront();
            indiceJuego = 0;
            ubicacionJuego = "";
            borrarIndice = metodoBorrar;
        }

        private void quitarJuego_Click(object sender, System.EventArgs e)
        {
            borrarIndice(indiceJuego);
        }

        private void btnMostrarJuegos_Click(object sender, System.EventArgs e)
        {
            MostrarListaDeJuegos();
        }

        private void JuegoArrastrado_Resize(object sender, System.EventArgs e)
        {
            quitarJuego.Location = new System.Drawing.Point(this.Width - 30, quitarJuego.Location.Y);
            btnMostrarJuegos.Location = new System.Drawing.Point(this.Width - 60, quitarJuego.Location.Y);
        }

        private void LlenarJuegosCarpeta(DirectoryInfo path)
        {
            FileInfo[] Files = path.GetFiles("*.nsp");

            foreach (FileInfo file in Files)
            {
                juegosCarpeta.Add(path.FullName + "\\" + file.Name);
            }

            Files = path.GetFiles("*.xci");

            foreach (FileInfo file in Files)
            {
                juegosCarpeta.Add(path.FullName + "\\" + file.Name);
            }
        }

        private void MostrarListaDeJuegos()
        {
            Formularios.FormJuegosCarpeta formJuegos = new Formularios.FormJuegosCarpeta(NombreJuego, juegosCarpeta);
            formJuegos.ShowDialog();
        }
    }
}
