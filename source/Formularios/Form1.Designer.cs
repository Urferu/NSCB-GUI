namespace NSCB_GUI
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblArrastre = new MetroFramework.Controls.MetroLabel();
            this.botonConvertir = new MetroFramework.Controls.MetroButton();
            this.botonEmpaquetar = new MetroFramework.Controls.MetroButton();
            this.panelJuegos = new MetroFramework.Controls.MetroPanel();
            this.toltipArrastre = new MetroFramework.Components.MetroToolTip();
            this.btnDependencias = new MetroFramework.Controls.MetroButton();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbParchar = new MetroFramework.Controls.MetroCheckBox();
            this.cbFirware = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblArrastre
            // 
            this.lblArrastre.AutoSize = true;
            this.lblArrastre.BackColor = System.Drawing.Color.Transparent;
            this.lblArrastre.Location = new System.Drawing.Point(23, 64);
            this.lblArrastre.Name = "lblArrastre";
            this.lblArrastre.Size = new System.Drawing.Size(150, 19);
            this.lblArrastre.TabIndex = 1;
            this.lblArrastre.Text = "Arrastre los juegos aqui:";
            // 
            // botonConvertir
            // 
            this.botonConvertir.Location = new System.Drawing.Point(262, 348);
            this.botonConvertir.Name = "botonConvertir";
            this.botonConvertir.Size = new System.Drawing.Size(75, 23);
            this.botonConvertir.TabIndex = 1;
            this.botonConvertir.Text = "Convertir";
            this.toltipArrastre.SetToolTip(this.botonConvertir, "Convierte los juegos agregados");
            this.botonConvertir.UseSelectable = true;
            this.botonConvertir.Click += new System.EventHandler(this.botonConvertir_Click);
            // 
            // botonEmpaquetar
            // 
            this.botonEmpaquetar.Location = new System.Drawing.Point(343, 348);
            this.botonEmpaquetar.Name = "botonEmpaquetar";
            this.botonEmpaquetar.Size = new System.Drawing.Size(75, 23);
            this.botonEmpaquetar.TabIndex = 2;
            this.botonEmpaquetar.Text = "Empaquetar";
            this.toltipArrastre.SetToolTip(this.botonEmpaquetar, "Empaqueta los juegos agregados");
            this.botonEmpaquetar.UseSelectable = true;
            this.botonEmpaquetar.Click += new System.EventHandler(this.botonEmpaquetar_Click);
            // 
            // panelJuegos
            // 
            this.panelJuegos.AllowDrop = true;
            this.panelJuegos.AutoScroll = true;
            this.panelJuegos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelJuegos.HorizontalScrollbar = true;
            this.panelJuegos.HorizontalScrollbarBarColor = true;
            this.panelJuegos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelJuegos.HorizontalScrollbarSize = 10;
            this.panelJuegos.Location = new System.Drawing.Point(23, 143);
            this.panelJuegos.Name = "panelJuegos";
            this.panelJuegos.Size = new System.Drawing.Size(395, 199);
            this.panelJuegos.TabIndex = 4;
            this.panelJuegos.VerticalScrollbar = true;
            this.panelJuegos.VerticalScrollbarBarColor = true;
            this.panelJuegos.VerticalScrollbarHighlightOnWheel = false;
            this.panelJuegos.VerticalScrollbarSize = 10;
            this.panelJuegos.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.panelJuegos.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelJuegos_DragEnter);
            // 
            // toltipArrastre
            // 
            this.toltipArrastre.Style = MetroFramework.MetroColorStyle.Blue;
            this.toltipArrastre.StyleManager = null;
            this.toltipArrastre.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnDependencias
            // 
            this.btnDependencias.Location = new System.Drawing.Point(23, 348);
            this.btnDependencias.Name = "btnDependencias";
            this.btnDependencias.Size = new System.Drawing.Size(126, 23);
            this.btnDependencias.TabIndex = 0;
            this.btnDependencias.Text = "Instalar dependencias";
            this.toltipArrastre.SetToolTip(this.btnDependencias, "Instala las dependencias necesarias\r\npara las conversiones.");
            this.btnDependencias.UseSelectable = true;
            this.btnDependencias.Click += new System.EventHandler(this.btnDependencias_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Items.AddRange(new object[] {
            "XCI",
            "NSP",
            "Ambos"});
            this.comboBox1.Location = new System.Drawing.Point(344, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 29);
            this.comboBox1.TabIndex = 6;
            this.toltipArrastre.SetToolTip(this.comboBox1, "Formato al que se desean convertir los juegos");
            this.comboBox1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(277, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Formato:";
            // 
            // cbParchar
            // 
            this.cbParchar.AutoSize = true;
            this.cbParchar.Location = new System.Drawing.Point(23, 122);
            this.cbParchar.Name = "cbParchar";
            this.cbParchar.Size = new System.Drawing.Size(125, 15);
            this.cbParchar.TabIndex = 7;
            this.cbParchar.Text = "Parche de firmware";
            this.cbParchar.UseSelectable = true;
            this.cbParchar.CheckedChanged += new System.EventHandler(this.cbParchar_CheckedChanged);
            // 
            // cbFirware
            // 
            this.cbFirware.Enabled = false;
            this.cbFirware.FormattingEnabled = true;
            this.cbFirware.ItemHeight = 23;
            this.cbFirware.Items.AddRange(new object[] {
            "1.0",
            "2.0-2.3",
            "3.0",
            "3.0.1-3.02",
            "4.0.0-4.1.0",
            "5.0.0-5.1.0",
            "6.0.0-6.1.0",
            "6.2.0"});
            this.cbFirware.Location = new System.Drawing.Point(277, 112);
            this.cbFirware.Name = "cbFirware";
            this.cbFirware.Size = new System.Drawing.Size(141, 29);
            this.cbFirware.TabIndex = 9;
            this.toltipArrastre.SetToolTip(this.cbFirware, "Firmware para el que se quiere parchar el juego");
            this.cbFirware.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(168, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Firmware patch:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 394);
            this.Controls.Add(this.cbFirware);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbParchar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnDependencias);
            this.Controls.Add(this.panelJuegos);
            this.Controls.Add(this.botonEmpaquetar);
            this.Controls.Add(this.botonConvertir);
            this.Controls.Add(this.lblArrastre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nintendo Switch Clean and Builder GUI";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblArrastre;
        private MetroFramework.Controls.MetroButton botonConvertir;
        private MetroFramework.Controls.MetroButton botonEmpaquetar;
        private MetroFramework.Controls.MetroPanel panelJuegos;
        private MetroFramework.Components.MetroToolTip toltipArrastre;
        private MetroFramework.Controls.MetroButton btnDependencias;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private MetroFramework.Controls.MetroCheckBox cbParchar;
        private MetroFramework.Controls.MetroComboBox cbFirware;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

