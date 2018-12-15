using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NSCB_GUI.Controls;
using MetroFramework;
using MetroFramework.Forms;
using System.Diagnostics;

namespace NSCB_GUI
{
    public partial class Form1 : MetroForm
    {
        List<string> juegos;
        public Form1()
        {
            juegos = new List<string>();
            InitializeComponent();
            comboBox1.SelectedIndex = 2;
            cbFirware.SelectedIndex = 7;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panelJuegos.Width = this.Width - 45;
            panelJuegos.Height = this.Height - 195;
            botonEmpaquetar.Location = new Point(this.Width - 97, this.Height - 42);
            botonConvertir.Location = new Point(this.Width - 178, botonEmpaquetar.Location.Y);
            btnDependencias.Location = new Point(btnDependencias.Location.X, botonEmpaquetar.Location.Y);
            if (juegos.Count > 0)
            {
                LlenarListaDeJuegos();
            }
        }

        private void panelJuegos_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            bool archivosConEspacios = false;
            foreach (string file in files)
            {
                if(Path.GetExtension(file).ToUpper().Equals(".NSP") || Path.GetExtension(file).ToUpper().Equals(".XCI"))
                {
                    if(Path.GetFileName(file).Contains(" "))
                    {
                        File.Move(file, file.Replace(' ', '_'));
                        juegos.Add(file.Replace(' ', '_'));
                        archivosConEspacios = true;
                    }
                    else
                    {
                        juegos.Add(file);
                    }
                }
            }
            if(juegos.Count > 0)
            {
                if(archivosConEspacios)
                {
                    MetroMessageBox.Show(this, "Se han encontrado archivos con espacios en el nombre y han sido reemplazados por '_', Esperamos que no te moleste =)",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LlenarListaDeJuegos();
            }
            if(juegos.Count > 8)
            {
                botonEmpaquetar.Enabled = false;
            }
            else
            {
                botonEmpaquetar.Enabled = true;
            }
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

            foreach(string juego in juegos)
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

        private void botonConvertir_Click(object sender, EventArgs e)
        {
            Process proeso = new Process();
            proeso.StartInfo.FileName = "cmd.exe";
            proeso.StartInfo.Arguments = string.Format("/c NSCB.bat 1 1 {0} {1} {2}", comboBox1.SelectedIndex + 1, cbParchar.Checked ? 1 : 0, cbFirware.SelectedIndex);
            AgregarJuegosALaListaa("list.txt");
            FormProgreso formProgreso = new FormProgreso("Convirtiendo...", proeso);
            formProgreso.ShowDialog();
            completado(null, null);
        }

        private void botonEmpaquetar_Click(object sender, EventArgs e)
        {
            FrmNombreEmpaquetado formEmpaquetado = new FrmNombreEmpaquetado();
            formEmpaquetado.ShowDialog();
            string nombreFinal = formEmpaquetado.nombreFinal;

            Process proeso = new Process();
            proeso.StartInfo.FileName = "cmd.exe";
            proeso.StartInfo.Arguments = string.Format("/c NSCB.bat 2 1 {0} {1} {2} {3}", comboBox1.SelectedIndex + 1, cbParchar.Checked ? 1 : 0, cbFirware.SelectedIndex, nombreFinal);
            AgregarJuegosALaListaa("mlist.txt");
            FormProgreso formProgreso = new FormProgreso("Convirtiendo...", proeso);
            formProgreso.ShowDialog();
            completado(null, null);
        }

        private List<string> CreaDirectoriosNecesarios()
        {
            string nuevaRuta = "";
            string rutaEmp = "";
            List<string> juegosNuevos = new List<string>();
            rutaEmp = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Empaquetados";
            if (!Directory.Exists(rutaEmp))
            {
                Directory.CreateDirectory(rutaEmp);
            }
            foreach(string juego in juegos)
            {
                nuevaRuta = rutaEmp + "\\" + Path.GetFileName(juego);
                File.Move(juego, nuevaRuta);
                juegosNuevos.Add(nuevaRuta);
            }
            return juegosNuevos;
        }

        private void DevolverJuegos(List<string>rutaActual)
        {
            for(int i = 0; i < rutaActual.Count; i++)
            {
                File.Move(rutaActual[i], juegos[i]);
            }
        }

        private void AgregarJuegosALaListaa(string nombreLista)
        {
            StreamWriter lista = new StreamWriter(nombreLista);
            foreach (string juego in juegos)
            {
                lista.WriteLine(juego);
            }
            lista.Close();
        }

        delegate void completadoDelegate(object sender, EventArgs e);

        private void completado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Invoke(new completadoDelegate(completado), null, null);
            }
            else
            {
                if(File.Exists("list.txt"))
                {
                    File.Delete("list.txt");
                }
                if (File.Exists("mlist.txt"))
                {
                    File.Delete("mlist.txt");
                }
                Process carpeta = new Process();
                carpeta.StartInfo.FileName = "explorer.exe";
                carpeta.StartInfo.Arguments = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\NSCB_output";
                carpeta.Start();
                panelJuegos.Controls.Clear();
                juegos.Clear();
            }
        }

        private void btnDependencias_Click(object sender, EventArgs e)
        {
            Process proeso = new Process();
            proeso.StartInfo.FileName = "install_dependencies.bat";
            proeso.EnableRaisingEvents = true;
            proeso.Start();
            proeso.WaitForExit();
        }

        private void cbParchar_CheckedChanged(object sender, EventArgs e)
        {
            cbFirware.Enabled = cbParchar.Checked;
        }
    }
}
