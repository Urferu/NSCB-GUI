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
            this.lblArchivos.Location = new System.Drawing.Point(439, 108);
            this.lblArchivos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchivos.Name = "lblArchivos";
            this.lblArchivos.Size = new System.Drawing.Size(92, 20);
            this.lblArchivos.TabIndex = 13;
            this.lblArchivos.Text = "0 partes de 5";
            // 
            // pbArchivos
            // 
            this.pbArchivos.Location = new System.Drawing.Point(31, 78);
            this.pbArchivos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbArchivos.Name = "pbArchivos";
            this.pbArchivos.Size = new System.Drawing.Size(523, 28);
            this.pbArchivos.TabIndex = 12;
            // 
            // lblBytesLeidos
            // 
            this.lblBytesLeidos.AutoSize = true;
            this.lblBytesLeidos.BackColor = System.Drawing.Color.Transparent;
            this.lblBytesLeidos.Location = new System.Drawing.Point(451, 165);
            this.lblBytesLeidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBytesLeidos.Name = "lblBytesLeidos";
            this.lblBytesLeidos.Size = new System.Drawing.Size(83, 20);
            this.lblBytesLeidos.TabIndex = 15;
            this.lblBytesLeidos.Text = "0/14502354";
            // 
            // pbBytesLeidos
            // 
            this.pbBytesLeidos.Location = new System.Drawing.Point(31, 137);
            this.pbBytesLeidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBytesLeidos.Name = "pbBytesLeidos";
            this.pbBytesLeidos.Size = new System.Drawing.Size(523, 28);
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
            this.botonCancelar.Location = new System.Drawing.Point(454, 189);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(100, 28);
            this.botonCancelar.TabIndex = 16;
            this.botonCancelar.Text = "Cancelar";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 236);
            this.ControlBox = false;
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.lblBytesLeidos);
            this.Controls.Add(this.pbBytesLeidos);
            this.Controls.Add(this.lblArchivos);
            this.Controls.Add(this.pbArchivos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCortando";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "Cortando XCI...";
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