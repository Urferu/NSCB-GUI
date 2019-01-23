using System.Collections.Generic;
using MetroFramework.Forms;
using NSCB_GUI.Controls;
using System.Drawing;

namespace NSCB_GUI.Formularios
{
    public partial class FormJuegosCarpeta : MetroForm
    {
        List<string> juegos;
        public FormJuegosCarpeta(string dirName, List<string> juegosMostrar)
        {
            InitializeComponent();
            juegos = juegosMostrar;
            LlenarListaDeJuegos();
            this.Text = "Archivos en " + dirName;
        }

        private void FormJuegosCarpeta_Resize(object sender, System.EventArgs e)
        {
            LlenarListaDeJuegos();
        }

        /// <summary>
        /// Se encarga de llenar la lista de juegos.
        /// </summary>
        private void LlenarListaDeJuegos()
        {
            panelJuegos.Controls.Clear();
            JuegoArrastrado juegoArrastradoActual;
            int posicionYActual = 3;
            int indice = 0;

            foreach (string juego in juegos)
            {
                juegoArrastradoActual = new JuegoArrastrado(EliminaJuego);
                juegoArrastradoActual.ubicacionJuego = juego;
                juegoArrastradoActual.indiceJuego = indice;
                juegoArrastradoActual.Location = new Point(3, posicionYActual);
                juegoArrastradoActual.Width = panelJuegos.Width - 6;
                panelJuegos.Controls.Add(juegoArrastradoActual);
                posicionYActual = posicionYActual + juegoArrastradoActual.Height + 3;
                indice++;
            }
        }

        private void EliminaJuego(int indice)
        {
            juegos.RemoveAt(indice);
            LlenarListaDeJuegos();
        }

        private void FormJuegosCarpeta_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
