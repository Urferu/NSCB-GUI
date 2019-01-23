namespace NSCB_GUI
{
    partial class FrmNombreEmpaquetado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNombreEmpaquetado));
            this.txtNombreFinal = new MetroFramework.Controls.MetroTextBox();
            this.botonAceptar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtNombreFinal
            // 
            // 
            // 
            // 
            this.txtNombreFinal.CustomButton.Image = null;
            this.txtNombreFinal.CustomButton.Location = new System.Drawing.Point(434, 2);
            this.txtNombreFinal.CustomButton.Name = "";
            this.txtNombreFinal.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtNombreFinal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreFinal.CustomButton.TabIndex = 1;
            this.txtNombreFinal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreFinal.CustomButton.UseSelectable = true;
            this.txtNombreFinal.CustomButton.Visible = false;
            this.txtNombreFinal.Lines = new string[0];
            this.txtNombreFinal.Location = new System.Drawing.Point(23, 63);
            this.txtNombreFinal.MaxLength = 32767;
            this.txtNombreFinal.Name = "txtNombreFinal";
            this.txtNombreFinal.PasswordChar = '\0';
            this.txtNombreFinal.WaterMark = "Nombre Final del Juego";
            this.txtNombreFinal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreFinal.SelectedText = "";
            this.txtNombreFinal.SelectionLength = 0;
            this.txtNombreFinal.SelectionStart = 0;
            this.txtNombreFinal.ShortcutsEnabled = true;
            this.txtNombreFinal.Size = new System.Drawing.Size(452, 20);
            this.txtNombreFinal.TabIndex = 0;
            this.txtNombreFinal.UseSelectable = true;
            this.txtNombreFinal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreFinal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(212, 89);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 2;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseSelectable = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // FrmNombreEmpaquetado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 130);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.txtNombreFinal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNombreEmpaquetado";
            this.Text = "Capture el nombre del archivo sin extensión";
            this.ResumeLayout(false);

        }

        #endregion
        
        private MetroFramework.Controls.MetroTextBox txtNombreFinal;
        private MetroFramework.Controls.MetroButton botonAceptar;
    }
}