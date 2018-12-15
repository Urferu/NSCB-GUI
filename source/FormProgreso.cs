using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Net;

namespace NSCB_GUI
{
    public partial class FormProgreso : MetroForm
    {
        private Process convertirEmpaquetar;
        Random randomTipoDiversion = new Random();
        Random randomNumeroDiversion = new Random();
        bool cancelado = false;
        public FormProgreso(string title, Process proceso)
        {
            InitializeComponent();
            convertirEmpaquetar = proceso;
            Text = title;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        }

        private void FormProgreso_Load(object sender, System.EventArgs e)
        {
            PreparaComienzo();
        }

        private void PreparaComienzo()
        {
            procesoConversion.RunWorkerAsync();
        }

        private void procesoConversion_DoWork(object sender, DoWorkEventArgs e)
        {
            convertirEmpaquetar.EnableRaisingEvents = true;
            convertirEmpaquetar.Start();
            while (convertirEmpaquetar.MainWindowHandle.ToInt32() == 0)
            {
            }
            if (convertirEmpaquetar.MainWindowHandle.ToInt32() > 0)
            {
                WinApi.SetParent(convertirEmpaquetar.MainWindowHandle, pnDatos.Handle);
                WinApi.MoveWindow(convertirEmpaquetar.MainWindowHandle,
                    0, 0,
                    nWidth: pnDatos.Width,
                    nHeight: pnDatos.Height, bRepaint: 1);
                WinApi.RemoveBorder(convertirEmpaquetar);
            }
            convertirEmpaquetar.WaitForExit();
            if(!cancelado)
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
                    lista = DownloadStringServer("https://raw.githubusercontent.com/Urferu/NSCB-GUI/master/Chistes/" + siguiente);
                    Cursor.Current = Cursors.Default;
                    MetroMessageBox.Show(this, lista.Split(':')[1], "CHISTE - " + lista.Split(':')[0], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    lista = DownloadStringServer("https://raw.githubusercontent.com/Urferu/NSCB-GUI/master/Consejos/cantidad_consejos");
                    siguiente = randomNumeroDiversion.Next(1, Convert.ToInt32(lista) + 1);
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
    }
}
