namespace NSCB_GUI
{
    partial class NovedadesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovedadesForm));
            this.pbNovedad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNovedad)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNovedad
            // 
            this.pbNovedad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbNovedad.Image = global::NSCB_GUI.Properties.Resources.Novedad_0;
            this.pbNovedad.Location = new System.Drawing.Point(20, 60);
            this.pbNovedad.Name = "pbNovedad";
            this.pbNovedad.Size = new System.Drawing.Size(598, 398);
            this.pbNovedad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNovedad.TabIndex = 0;
            this.pbNovedad.TabStop = false;
            this.pbNovedad.Tag = "0";
            this.pbNovedad.Click += new System.EventHandler(this.pbNovedad_Click);
            // 
            // NovedadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 478);
            this.Controls.Add(this.pbNovedad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovedadesForm";
            this.Resizable = false;
            this.Text = "Novedades";
            ((System.ComponentModel.ISupportInitialize)(this.pbNovedad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNovedad;
    }
}