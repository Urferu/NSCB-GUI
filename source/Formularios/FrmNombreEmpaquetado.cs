using MetroFramework;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace NSCB_GUI
{
    public partial class FrmNombreEmpaquetado : MetroForm
    {
        public string nombreFinal;
        public FrmNombreEmpaquetado()
        {
            InitializeComponent();
        }

        private void botonAceptar_Click(object sender, System.EventArgs e)
        {
            if (txtNombreFinal.Text.Trim().Length == 0)
            {
                MetroMessageBox.Show(this, "Es necesario capturar el nombre que tendra el empaquetado.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nombreFinal = txtNombreFinal.Text.Trim();
            this.Close();
        }
    }
}
