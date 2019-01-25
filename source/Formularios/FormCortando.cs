using System;
using System.IO;
using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace NSCB_GUI
{
    public partial class FormCortando : MetroForm
    {
        XCIFile archivoXCI;
        decimal bytesAnteriores;
        string porSegundo;
        public FormCortando(Stream archivoOriginal, FileInfo infoOriginal, long cutterSize)
        {
            InitializeComponent();
            bytesAnteriores = 0;
            archivoXCI = new XCIFile(archivoOriginal, infoOriginal, cutterSize);
            this.Text = "Cortando " + archivoXCI.soloNombre;
            pbArchivos.Maximum = archivoXCI.partesACortar;
            lblArchivos.Text = string.Format("{0} partes de {1}", pbArchivos.Value, archivoXCI.partesACortar);
            lblArchivos.Location = new System.Drawing.Point(this.Width - 20 - lblArchivos.Width, lblArchivos.Location.Y);
            lblBytesLeidos.Text = string.Format("{0}/{1} GB", 0, (Convert.ToDecimal(cutterSize)/ 1024/1024/1024).ToString("0.00"));
            lblBytesLeidos.Location = new System.Drawing.Point(this.Width - 20 - lblBytesLeidos.Width, lblBytesLeidos.Location.Y);
        }

        private void FormCortando_Load(object sender, EventArgs e)
        {
            bwCortar.RunWorkerAsync();
            tmVelocidad.Enabled = true;
            tmUpdateBytes.Enabled = true;
        }

        private void tmUpdateBytes_Tick(object sender, EventArgs e)
        {
            tmUpdateBytes.Enabled = false;
            pbBytesLeidos.Value = archivoXCI.progresoActual;
            decimal bytes = Convert.ToDecimal(archivoXCI.bytesLeidos);
            string porSegundo = "";
            string poner = "";
            
            
            if(bytes > 1073741824)
            {
                poner = (bytes / 1024 / 1024 / 1024).ToString("0.00") + " GB";
            }
            else if(bytes > 1048576)
            {
                poner = (bytes / 1024 / 1024).ToString("0.00") + " MB";
            }
            else if (bytes > 1024)
            {
                poner = (bytes / 1024).ToString("0.00") + " KB";
            }
            

            lblBytesLeidos.Text = string.Format("Vel: {0} - {1}/{2} GB", porSegundo, poner, (Convert.ToDecimal(archivoXCI.cutterActual)/1024/1024/1024).ToString("0.00"));
            lblBytesLeidos.Location = new System.Drawing.Point(this.Width - 20 - lblBytesLeidos.Width, lblBytesLeidos.Location.Y);
            this.Refresh();
            tmUpdateBytes.Enabled = true;
        }

        private void tmVelocidad_Tick(object sender, EventArgs e)
        {
            decimal bytes = Convert.ToDecimal(archivoXCI.bytesLeidos);
            decimal velocidad = bytes - bytesAnteriores / 2;

            if (velocidad > 1073741824)
            {
                porSegundo = (velocidad / 1024 / 1024 / 1024).ToString("0.00") + " GB/s";
            }
            else if (velocidad > 1048576)
            {
                porSegundo = (velocidad / 1024 / 1024).ToString("0.00") + " MB/s";
            }
            else if (velocidad > 1024)
            {
                porSegundo = (velocidad / 1024).ToString("0.00") + " KB/s";
            }
            bytesAnteriores = bytes;
        }

        private void bwCortar_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            XCICutter.cutterParts(archivoXCI,bwCortar);
        }

        private void bwCortar_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            pbArchivos.Value = e.ProgressPercentage;
            lblArchivos.Text = string.Format("{0} partes de {1}", pbArchivos.Value, archivoXCI.partesACortar);
            lblArchivos.Location = new System.Drawing.Point(this.Width - 20 - lblArchivos.Width, lblArchivos.Location.Y);
            pbBytesLeidos.Value = 0;
            bytesAnteriores = 0;
            lblBytesLeidos.Text = string.Format("{0} B/{1} GB", bytesAnteriores, (Convert.ToDecimal(archivoXCI.cutterActual) / 1024 / 1024 / 1024).ToString("0.00"));
            lblBytesLeidos.Location = new System.Drawing.Point(this.Width - 20 - lblBytesLeidos.Width, lblBytesLeidos.Location.Y);
            this.Refresh();
        }

        private void bwCortar_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (!archivoXCI.cancelar)
                    File.Delete(archivoXCI.nombreConRuta);
            }
            catch
            {
            }
            
            tmUpdateBytes.Enabled = false;
            tmVelocidad.Enabled = false;
            this.Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            archivoXCI.cancelar = true;
        }
    }
}
