namespace NSCB_GUI.Controls
{
    partial class DirectorioArrastrado
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuitarJuego = new System.Windows.Forms.Label();
            this.quitarJuego = new MetroFramework.Controls.MetroButton();
            this.toolTip1 = new MetroFramework.Components.MetroToolTip();
            this.btnMostrarJuegos = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblQuitarJuego
            // 
            this.lblQuitarJuego.AutoSize = true;
            this.lblQuitarJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitarJuego.Location = new System.Drawing.Point(3, 4);
            this.lblQuitarJuego.Name = "lblQuitarJuego";
            this.lblQuitarJuego.Size = new System.Drawing.Size(137, 24);
            this.lblQuitarJuego.TabIndex = 0;
            this.lblQuitarJuego.Text = "Nombre Juego";
            // 
            // quitarJuego
            // 
            this.quitarJuego.Location = new System.Drawing.Point(359, 5);
            this.quitarJuego.Name = "quitarJuego";
            this.quitarJuego.Size = new System.Drawing.Size(27, 23);
            this.quitarJuego.Style = MetroFramework.MetroColorStyle.Silver;
            this.quitarJuego.TabIndex = 1;
            this.quitarJuego.Text = "X";
            this.quitarJuego.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.quitarJuego, "Quitar juego");
            this.quitarJuego.UseSelectable = true;
            this.quitarJuego.Click += new System.EventHandler(this.quitarJuego_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Style = MetroFramework.MetroColorStyle.Silver;
            this.toolTip1.StyleManager = null;
            this.toolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnMostrarJuegos
            // 
            this.btnMostrarJuegos.Location = new System.Drawing.Point(339, 5);
            this.btnMostrarJuegos.Name = "btnMostrarJuegos";
            this.btnMostrarJuegos.Size = new System.Drawing.Size(27, 23);
            this.btnMostrarJuegos.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnMostrarJuegos.TabIndex = 1;
            this.btnMostrarJuegos.Text = "...";
            this.btnMostrarJuegos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toolTip1.SetToolTip(this.btnMostrarJuegos, "Mostrara Archivos");
            this.btnMostrarJuegos.UseSelectable = true;
            this.btnMostrarJuegos.Click += new System.EventHandler(this.btnMostrarJuegos_Click);
            // 
            // DirectorioArrastrado
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblQuitarJuego);
            this.Controls.Add(this.quitarJuego);
            this.Controls.Add(this.btnMostrarJuegos);
            this.Size = new System.Drawing.Size(389, 35);
            this.Resize += new System.EventHandler(this.JuegoArrastrado_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuitarJuego;
        private MetroFramework.Controls.MetroButton quitarJuego;
        private MetroFramework.Components.MetroToolTip toolTip1;
        private MetroFramework.Controls.MetroButton btnMostrarJuegos;
    }
}
