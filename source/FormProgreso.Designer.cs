﻿namespace NSCB_GUI
{
    partial class FormProgreso
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
            this.botonConvertir = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.procesoConversion = new System.ComponentModel.BackgroundWorker();
            this.procesoEmpquetacion = new System.ComponentModel.BackgroundWorker();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // botonConvertir
            // 
            this.botonConvertir.Location = new System.Drawing.Point(575, 389);
            this.botonConvertir.Name = "botonConvertir";
            this.botonConvertir.Size = new System.Drawing.Size(75, 23);
            this.botonConvertir.TabIndex = 7;
            this.botonConvertir.Text = "Cancelar";
            this.botonConvertir.UseSelectable = true;
            this.botonConvertir.Click += new System.EventHandler(this.botonConvertir_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(476, 389);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(93, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Ya me aburrí";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // procesoConversion
            // 
            this.procesoConversion.WorkerReportsProgress = true;
            this.procesoConversion.WorkerSupportsCancellation = true;
            this.procesoConversion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.procesoConversion_DoWork);
            // 
            // procesoEmpquetacion
            // 
            this.procesoEmpquetacion.WorkerReportsProgress = true;
            this.procesoEmpquetacion.WorkerSupportsCancellation = true;
            // 
            // pnDatos
            // 
            this.pnDatos.Location = new System.Drawing.Point(12, 63);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(640, 320);
            this.pnDatos.TabIndex = 9;
            // 
            // FormProgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 423);
            this.ControlBox = false;
            this.Controls.Add(this.pnDatos);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.botonConvertir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProgreso";
            this.Resizable = false;
            this.Text = "Convirtiendo...";
            this.Load += new System.EventHandler(this.FormProgreso_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton botonConvertir;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.ComponentModel.BackgroundWorker procesoConversion;
        private System.ComponentModel.BackgroundWorker procesoEmpquetacion;
        private System.Windows.Forms.Panel pnDatos;
    }
}