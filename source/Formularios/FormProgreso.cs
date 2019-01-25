using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Net;
using NSCB_GUI.Controls;

namespace NSCB_GUI
{
    public partial class FormProgreso : MetroForm
    {
        bool apagar = false;
        bool cancelado = false;
        bool cortar = false;
        private Process convertirEmpaquetar;
        Random randomTipoDiversion = new Random();
        Random randomNumeroDiversion = new Random();
        string argumentosFinales = "";
        string juegoActual = "";
        
        Control.ControlCollection controles;
        public FormProgreso(string title, Process proceso, bool apagado, bool cortado, Control.ControlCollection directorios = null)
        {
            InitializeComponent();
            convertirEmpaquetar = proceso;
            Text = title;
            ServicePointManager.Expect100Continue = true;
            apagar = apagado;
            cortar = cortado;
            controles = directorios;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        }

        private void FormProgreso_Load(object sender, System.EventArgs e)
        {
            if(controles != null && controles.Count > 0)
            {
                pbProgreso.Visible = true;
                lblProceso.Visible = true;
                pbProgreso.Maximum = controles.Count;
                lblProceso.Text = "0/" + pbProgreso.Maximum;
                List<string> argumentos = new List<string>(convertirEmpaquetar.StartInfo.Arguments.Split(' '));
                argumentos.RemoveAt(argumentos.Count - 1);
                argumentosFinales = string.Join(" ", argumentos.ToArray());
            }
            PreparaComienzo();
        }

        private void PreparaComienzo()
        {
            procesoConversion.RunWorkerAsync();
        }

        private void procesoConversion_DoWork(object sender, DoWorkEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(argumentosFinales))
            {
                convertirEmpaquetar.EnableRaisingEvents = true;
                convertirEmpaquetar.Start();
                while (convertirEmpaquetar.MainWindowHandle.ToInt32() == 0)
                {
                }
                if (convertirEmpaquetar.MainWindowHandle.ToInt32() > 0)
                {
                    procesoConversion.ReportProgress(0);
                }

                convertirEmpaquetar.WaitForExit();
            }
            else
            {
                foreach (DirectorioArrastrado directorioactal in controles)
                {
                    if (!cancelado)
                    {
                        juegoActual = directorioactal.NombreJuego.Replace(" ", "_");
                        AgregarJuegosALaListaa("mlist.txt", directorioactal.JuegosLista);
                        convertirEmpaquetar = new Process();
                        convertirEmpaquetar.StartInfo.FileName = "cmd.exe";
                        convertirEmpaquetar.StartInfo.Arguments = string.Format("{0} {1}", argumentosFinales, juegoActual);

                        convertirEmpaquetar.EnableRaisingEvents = true;
                        convertirEmpaquetar.Start();
                        while (convertirEmpaquetar.MainWindowHandle.ToInt32() == 0)
                        {
                        }
                        if (convertirEmpaquetar.MainWindowHandle.ToInt32() > 0)
                        {
                            procesoConversion.ReportProgress(0);
                        }
                        procesoConversion.ReportProgress(1);
                        convertirEmpaquetar.WaitForExit();
                        //XCICutter.cutter(juegoActual);
                    }
                    procesoConversion.ReportProgress(2);
                }
            }
        }

        private void procesoConversion_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                WinApi.SetParent(convertirEmpaquetar.MainWindowHandle, pnDatos.Handle);
                WinApi.MoveWindow(convertirEmpaquetar.MainWindowHandle,
                    0, 0,
                    nWidth: pnDatos.Width,
                    nHeight: pnDatos.Height, bRepaint: 1);
                WinApi.RemoveBorder(convertirEmpaquetar);
            }
            else if (e.ProgressPercentage == 1)
            {
                this.Text = "Empaquetando " + juegoActual + "...";
            }
            else if (e.ProgressPercentage == 2)
            {
                pbProgreso.Value++;
                lblProceso.Text = pbProgreso.Value + "/" + pbProgreso.Maximum;
            }
            this.Refresh();
        }

        private void procesoConversion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!cancelado)
                Completado(null, null);
        }

        private delegate void completadoDelegate(object sender, EventArgs e);

        private void Completado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Invoke(new completadoDelegate(Completado), null, null);
            }
            else
            {
                if(!apagar)
                    MetroMessageBox.Show(this, "En hora buena esto ha terminado.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void botonConvertir_Click(object sender, EventArgs e)
        {
            cancelado = true;
            try
            {
                convertirEmpaquetar.Kill();
                borraPy();
            }
            catch
            {
            }
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int siguiente = randomTipoDiversion.Next(1, 4);
            string lista = "";
            Cursor.Current = Cursors.WaitCursor;
            switch(siguiente)
            {
                case 1:
                    lista = DownloadStringServer("https://raw.githubusercontent.com/Urferu/NSCB-GUI/master/Chistes/cantidad_chistes");
                    siguiente = randomNumeroDiversion.Next(1, Convert.ToInt32(lista) + 1);
                    if (Convert.ToInt32(lista) < siguiente)
                        siguiente = Convert.ToInt32(lista);
                    lista = DownloadStringServer("https://raw.githubusercontent.com/Urferu/NSCB-GUI/master/Chistes/" + siguiente);
                    Cursor.Current = Cursors.Default;
                    MetroMessageBox.Show(this, lista.Split(':')[1], "CHISTE - " + lista.Split(':')[0], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    lista = DownloadStringServer("https://raw.githubusercontent.com/Urferu/NSCB-GUI/master/Consejos/cantidad_consejos");
                    siguiente = randomNumeroDiversion.Next(1, Convert.ToInt32(lista) + 1);
                    if (Convert.ToInt32(lista) < siguiente)
                        siguiente = Convert.ToInt32(lista);
                    lista = DownloadStringServer("https://raw.githubusercontent.com/Urferu/NSCB-GUI/master/Consejos/" + siguiente);
                    Cursor.Current = Cursors.Default;
                    MetroMessageBox.Show(this, lista.Split(':')[1], "CONSEJO - " + lista.Split(':')[0]);
                    break;
                case 3:
                case 4:
                    lista = DownloadStringServer("https://raw.githubusercontent.com/Urferu/NSCB-GUI/master/Memes/cantidad_memes");
                    siguiente = randomNumeroDiversion.Next(1, Convert.ToInt32(lista) + 1);
                    if (siguiente > Convert.ToInt32(lista))
                        siguiente = Convert.ToInt32(lista);
                    Cursor.Current = Cursors.Default;
                    new MemesForm(string.Format("https://raw.githubusercontent.com/Urferu/NSCB-GUI/master/Memes/{0}.jpg", siguiente)).ShowDialog();
                    break;
            }
        }

        private string DownloadStringServer(string url)
        {
            string responseFromServer = string.Empty;
            var webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = WebRequestMethods.Http.Get;

            try
            {
                using (WebResponse response = webrequest.GetResponse())
                {
                    using (Stream stream2 = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream2))
                        {
                            responseFromServer = reader.ReadToEnd();
                            reader.Close();
                        }
                        stream2.Close();
                    }
                    response.Close();
                }

                if (string.IsNullOrWhiteSpace(responseFromServer))
                {
                    responseFromServer = "";
                }
            }
            catch
            {
            }
            return responseFromServer;
        }

        private void AgregarJuegosALaListaa(string nombreLista, List<string>juegos)
        {
            StreamWriter lista = new StreamWriter(nombreLista);
            foreach (string juego in juegos)
            {
                lista.WriteLine(juego);
            }
            lista.Close();
        }

        private void borraPy()
        {
            try
            {
                Process[] process = Process.GetProcessesByName("py");
                if(process.Length == 0)
                {
                    process = Process.GetProcessesByName("py.exe");
                }

                foreach(Process procesoActual in process)
                {
                    procesoActual.Kill();
                }

                process = Process.GetProcessesByName("python");
                if (process.Length == 0)
                {
                    process = Process.GetProcessesByName("python.exe");
                }

                foreach (Process procesoActual in process)
                {
                    procesoActual.Kill();
                }
            }
            catch
            {

            }
        }
    }
}
