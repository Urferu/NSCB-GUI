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
        List<string> directorios;
        public Form1()
        {
            juegos = new List<string>();
            directorios = new List<string>();
            InitializeComponent();
            comboBox1.SelectedIndex = 2;
            cbFirware.SelectedIndex = 7;
            if(!File.Exists("novedad.dat"))
            {
                NovedadesForm novedades = new NovedadesForm();
                novedades.ShowDialog();
                StreamWriter srNovedad = new StreamWriter("novedad.dat");
                srNovedad.Close();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panelJuegos.Width = this.Width - 45;
            panelJuegos.Height = this.Height - 195;
            botonEmpaquetar.Location = new Point(this.Width - 97, this.Height - 42);
            botonConvertir.Location = new Point(this.Width - 178, botonEmpaquetar.Location.Y);
            btnCortar.Location = new Point(this.Width - 260, botonEmpaquetar.Location.Y);
            btnDependencias.Location = new Point(btnDependencias.Location.X, botonEmpaquetar.Location.Y);
            metroLabel1.Location = new Point(this.Width - 164, metroLabel1.Location.Y);
            comboBox1.Location = new Point(this.Width - 97, comboBox1.Location.Y);
            metroLabel2.Location = new Point(this.Width - 273, metroLabel2.Location.Y);
            cbFirware.Location = new Point(this.Width - 164, cbFirware.Location.Y);
            if (juegos.Count > 0)
            {
                LlenarListaDeJuegos();
            }
            if(directorios.Count > 0)
            {
                LlenarListaDeDirectorios();
            }
        }

        private void panelJuegos_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //bool archivosConEspacios = false;
            foreach (string file in files)
            {
                if(Path.GetExtension(file).ToUpper().Equals(".NSP") || Path.GetExtension(file).ToUpper().Equals(".XCI"))
                {
                    juegos.Add(file);
                }
                else if(Directory.Exists(file))
                {
                    if (WinApi.CountFiles(file, "*.NSP", "*.XCI") > 0)
                    {
                        directorios.Add(file);
                    }
                }
            }
            if(directorios.Count > 0 && juegos.Count > 0)
            {
                DialogResult mensaje = MetroMessageBox.Show(this, "Se ha detectado que se han arrastrado archivos y carpetas. ¿Deseas Tomar las carpetas para empaquetar los juegos?",
                    this.Text , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(mensaje == DialogResult.Yes)
                {
                    juegos.Clear();
                }
                else
                {
                    directorios.Clear();
                }
            }
            if(juegos.Count > 0)
            {
                LlenarListaDeJuegos();
            }
            if(directorios.Count > 0)
            {
                LlenarListaDeDirectorios();
                botonEmpaquetar.Enabled = true;
                botonConvertir.Enabled = false;
            }
            else
            {
                botonEmpaquetar.Enabled = true;
                botonConvertir.Enabled = true;
            }

            if (juegos.Count > 8)
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
        private void LlenarListaDeDirectorios()
        {
            panelJuegos.Controls.Clear();
            DirectorioArrastrado juegoArrastradoActual;
            int posicionYActual = 3;
            int indice = 0;

            foreach(string juego in directorios)
            {
                juegoArrastradoActual = new DirectorioArrastrado(EliminaDirectorio);
                juegoArrastradoActual.ubicacionJuego = juego;
                juegoArrastradoActual.indiceJuego = indice;
                juegoArrastradoActual.Location = new Point(3, posicionYActual);
                juegoArrastradoActual.Width = panelJuegos.Width - 6;
                panelJuegos.Controls.Add(juegoArrastradoActual);
                posicionYActual = posicionYActual + juegoArrastradoActual.Height + 3;
                indice++;
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

        private void EliminaDirectorio(int indice)
        {
            directorios.RemoveAt(indice);
            LlenarListaDeDirectorios();
        }

        private void botonConvertir_Click(object sender, EventArgs e)
        {
            Process proeso = new Process();
            proeso.StartInfo.FileName = "cmd.exe";
            proeso.StartInfo.Arguments = string.Format("/c NSCB.bat 1 1 {0} {1} {2}", comboBox1.SelectedIndex + 1, cbParchar.Checked ? 1 : 0, cbFirware.SelectedIndex);
            AgregarJuegosALaListaa("list.txt");
            FormProgreso formProgreso = new FormProgreso("Convirtiendo...", proeso, cbApagar.Checked, cbSplit.Checked);
            if (formProgreso.ShowDialog() == DialogResult.OK)
                completado(null, null);
        }

        private void botonEmpaquetar_Click(object sender, EventArgs e)
        {
            string nombreFinal = "temp";
            if (directorios.Count == 0)
            {
                FrmNombreEmpaquetado formEmpaquetado = new FrmNombreEmpaquetado();
                formEmpaquetado.ShowDialog();
                nombreFinal = formEmpaquetado.nombreFinal;
            }

            Process proeso = new Process();
            proeso.StartInfo.FileName = "cmd.exe";
            proeso.StartInfo.Arguments = string.Format("/c NSCB.bat 2 1 {0} {1} {2} {3}", comboBox1.SelectedIndex + 1, cbParchar.Checked ? 1 : 0, cbFirware.SelectedIndex, nombreFinal);
            if (directorios.Count == 0)
                AgregarJuegosALaListaa("mlist.txt");
            FormProgreso formProgreso = new FormProgreso("Empaquetando...", proeso, cbApagar.Checked, cbSplit.Checked, directorios.Count > 0 ? panelJuegos.Controls : null);
            if(formProgreso.ShowDialog() == DialogResult.OK)
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
                if (cbApagar.Checked)
                {
                    Process shutdown = new Process();
                    ProcessStartInfo modulo = new ProcessStartInfo("C:\\WINDOWS\\SYSTEM32\\SHUTDOWN.EXE");
                    modulo.Arguments = " -s -t 0";
                    shutdown.StartInfo = modulo;
                    shutdown.Start();
                }
                else
                {
                    Process carpeta = new Process();
                    carpeta.StartInfo.FileName = "explorer.exe";
                    carpeta.StartInfo.Arguments = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\NSCB_output";
                    carpeta.Start();
                    juegos.Clear();
                    directorios.Clear();
                    panelJuegos.Controls.Clear();
                }
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
            cbFirware.Visible = cbParchar.Checked;
            metroLabel2.Visible = cbParchar.Checked;
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            if(juegos.Count > 0)
            {
                foreach(string juego in juegos)
                {
                    XCICutter.cutter(Path.GetDirectoryName(juego));
                }
            }

            if(directorios.Count > 0)
            {
                foreach (string directorio in directorios)
                {
                    XCICutter.cutter(directorio);
                }
            }
            juegos.Clear();
            directorios.Clear();
            panelJuegos.Controls.Clear();
        }
    }
}

