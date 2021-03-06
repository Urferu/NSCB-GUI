﻿namespace NSCB_GUI.Controls
{
    partial class JuegoArrastrado
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
            this.btnMostrarInfoGame = new MetroFramework.Controls.MetroButton();
            this.toolTip1 = new MetroFramework.Components.MetroToolTip();
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
            this.quitarJuego.Style = MetroFramework.MetroColorStyle.Blue;
            this.quitarJuego.TabIndex = 1;
            this.quitarJuego.Text = "X";
            this.quitarJuego.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolTip1.SetToolTip(this.quitarJuego, "Quitar juego");
            this.quitarJuego.UseSelectable = true;
            this.quitarJuego.Click += new System.EventHandler(this.quitarJuego_Click);
            // 
            // btnMostrarInfoGame
            // 
            this.btnMostrarInfoGame.Location = new System.Drawing.Point(339, 5);
            this.btnMostrarInfoGame.Name = "btnMostrarInfoGame";
            this.btnMostrarInfoGame.Size = new System.Drawing.Size(27, 23);
            this.btnMostrarInfoGame.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnMostrarInfoGame.TabIndex = 2;
            this.btnMostrarInfoGame.Text = "?";
            this.btnMostrarInfoGame.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolTip1.SetToolTip(this.btnMostrarInfoGame, "Game Info");
            this.btnMostrarInfoGame.UseSelectable = true;
            this.btnMostrarInfoGame.Click += new System.EventHandler(this.btnMostrarInfoGame_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolTip1.StyleManager = null;
            this.toolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // JuegoArrastrado
            // 
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblQuitarJuego);
            this.Controls.Add(this.quitarJuego);
            this.Controls.Add(this.btnMostrarInfoGame);
            this.Size = new System.Drawing.Size(389, 35);
            this.Resize += new System.EventHandler(this.JuegoArrastrado_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuitarJuego;
        private MetroFramework.Controls.MetroButton quitarJuego;
        private MetroFramework.Components.MetroToolTip toolTip1;
        private MetroFramework.Controls.MetroButton btnMostrarInfoGame;
    }
}
