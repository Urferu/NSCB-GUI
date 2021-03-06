﻿using System.Windows.Forms;
using System.IO;

namespace NSCB_GUI.Controls
{
    public partial class JuegoArrastrado : Panel
    {
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
                string fileValue = value;
                if (File.Exists(fileValue))
                {
                    toolTip1.SetToolTip(lblQuitarJuego, Path.GetFileName(fileValue));
                    lblQuitarJuego.Text = Path.GetFileName(fileValue);
                }
                ubicacionJuegoLocal = fileValue;
            }
        }

        public delegate void EliminaJuegoDelegado(int indiceEliminar);

        private EliminaJuegoDelegado borrarIndice;

        public JuegoArrastrado(EliminaJuegoDelegado metodoBorrar)
        {
            InitializeComponent();
            quitarJuego.BringToFront();
            btnMostrarInfoGame.BringToFront();
            indiceJuego = 0;
            ubicacionJuego = "";
            borrarIndice = metodoBorrar;
        }

        private void quitarJuego_Click(object sender, System.EventArgs e)
        {
            borrarIndice(indiceJuego);
        }

        private void btnMostrarInfoGame_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process infoGame = new System.Diagnostics.Process();
            infoGame.StartInfo = new System.Diagnostics.ProcessStartInfo(System.Environment.CurrentDirectory + "\\ztools\\XCI-Explorer.exe", $"\"{ubicacionJuegoLocal}\"");
            infoGame.StartInfo.UseShellExecute = false;
            infoGame.Start();
            infoGame.WaitForExit();
        }

        private void JuegoArrastrado_Resize(object sender, System.EventArgs e)
        {
            quitarJuego.Location = new System.Drawing.Point(this.Width - 30, quitarJuego.Location.Y);
            btnMostrarInfoGame.Location = new System.Drawing.Point(this.Width - 60, quitarJuego.Location.Y);
        }
    }
}
