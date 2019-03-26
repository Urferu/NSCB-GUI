namespace NSCB_GUI
{
    partial class FormCortando
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
            this.components = new System.ComponentModel.Container();
            this.lblArchivos = new MetroFramework.Controls.MetroLabel();
            this.pbArchivos = new System.Windows.Forms.ProgressBar();
            this.lblBytesLeidos = new MetroFramework.Controls.MetroLabel();
            this.pbBytesLeidos = new System.Windows.Forms.ProgressBar();
            this.tmUpdateBytes = new System.Windows.Forms.Timer(this.components);
            this.bwCortar = new System.ComponentModel.BackgroundWorker();
            this.botonCancelar = new MetroFramework.Controls.MetroButton();
            this.tmVelocidad = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblArchivos
            // 
            this.lblArchivos.AutoSize = true;
            this.lblArchivos.BackColor = System.Drawing.Color.Transparent;
            this.lblArchivos.Location = new System.Drawing.Point(329, 88);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(86, 19);
            this.lblArchivos.Style = MetroFramework.MetroColorStyle.Silver;
            this.lblArchivos.TabIndex = 13;
            this.lblArchivos.Text = "0 partes de 5";
            this.lblArchivos.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pbArchivos
            // 
            this.pbArchivos.Location = new System.Drawing.Point(23, 63);
            this.pbArchivos.Name = "pbArchivos";
            this.pbArchivos.Size = new System.Drawing.Size(392, 23);
            this.pbArchivos.TabIndex = 12;
            // 
            // lblBytesLeidos
            // 
            this.lblBytesLeidos.AutoSize = true;
            this.lblBytesLeidos.BackColor = System.Drawing.Color.Transparent;
            this.lblBytesLeidos.Location = new System.Drawing.Point(338, 134);
            this.lblBytesLeidos.Name = "lblBytesLeidos";
            this.lblBytesLeidos.Size = new System.Drawing.Size(77, 19);
            this.lblBytesLeidos.Style = MetroFramework.MetroColorStyle.Silver;
            this.lblBytesLeidos.TabIndex = 15;
            this.lblBytesLeidos.Text = "0/14502354";
            this.lblBytesLeidos.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pbBytesLeidos
            // 
            this.pbBytesLeidos.Location = new System.Drawing.Point(23, 111);
            this.pbBytesLeidos.Name = "pbBytesLeidos";
            this.pbBytesLeidos.Size = new System.Drawing.Size(392, 23);
            this.pbBytesLeidos.TabIndex = 14;
            // 
            // tmUpdateBytes
            // 
            this.tmUpdateBytes.Interval = 1000;
            this.tmUpdateBytes.Tick += new System.EventHandler(this.tmUpdateBytes_Tick);
            // 
            // bwCortar
            // 
            this.bwCortar.WorkerReportsProgress = true;
            this.bwCortar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCortar_DoWork);
            this.bwCortar.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwCortar_ProgressChanged);
            this.bwCortar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCortar_RunWorkerCompleted);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(340, 154);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.Style = MetroFramework.MetroColorStyle.Silver;
            this.botonCancelar.TabIndex = 16;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.botonCancelar.UseSelectable = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // tmVelocidad
            // 
            this.tmVelocidad.Interval = 2000;
            this.tmVelocidad.Tick += new System.EventHandler(this.tmVelocidad_Tick);
            // 
            // FormCortando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 192);
            this.ControlBox = false;
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.lblBytesLeidos);
            this.Controls.Add(this.pbBytesLeidos);
            this.Controls.Add(this.lblArchivos);
            this.Controls.Add(this.pbArchivos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCortando";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Cortando XCI...";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormCortando_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblArchivos;
        private System.Windows.Forms.ProgressBar pbArchivos;
        private MetroFramework.Controls.MetroLabel lblBytesLeidos;
        private System.Windows.Forms.ProgressBar pbBytesLeidos;
        private System.Windows.Forms.Timer tmUpdateBytes;
        private System.ComponentModel.BackgroundWorker bwCortar;
        private MetroFramework.Controls.MetroButton botonCancelar;
        private System.Windows.Forms.Timer tmVelocidad;
    }
}