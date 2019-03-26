namespace NSCB_GUI.Formularios
{
    partial class FormJuegosCarpeta
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
            this.panelJuegos = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // panelJuegos
            // 
            this.panelJuegos.AllowDrop = true;
            this.panelJuegos.AutoScroll = true;
            this.panelJuegos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelJuegos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJuegos.HorizontalScrollbar = true;
            this.panelJuegos.HorizontalScrollbarBarColor = true;
            this.panelJuegos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelJuegos.HorizontalScrollbarSize = 10;
            this.panelJuegos.Location = new System.Drawing.Point(20, 60);
            this.panelJuegos.Name = "panelJuegos";
            this.panelJuegos.Size = new System.Drawing.Size(432, 295);
            this.panelJuegos.Style = MetroFramework.MetroColorStyle.Silver;
            this.panelJuegos.TabIndex = 5;
            this.panelJuegos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelJuegos.VerticalScrollbar = true;
            this.panelJuegos.VerticalScrollbarBarColor = true;
            this.panelJuegos.VerticalScrollbarHighlightOnWheel = false;
            this.panelJuegos.VerticalScrollbarSize = 10;
            // 
            // FormJuegosCarpeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 375);
            this.Controls.Add(this.panelJuegos);
            this.KeyPreview = true;
            this.Name = "FormJuegosCarpeta";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Juegos a empaquetar";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormJuegosCarpeta_KeyDown);
            this.Resize += new System.EventHandler(this.FormJuegosCarpeta_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelJuegos;
    }
}