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
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.cbFirware = new MetroFramework.Controls.MetroComboBox();
            this.cbApagar = new MetroFramework.Controls.MetroCheckBox();
            this.cbSplit = new MetroFramework.Controls.MetroCheckBox();
            this.btnCortar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbParchar = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblArrastre
            // 
            this.lblArrastre.AutoSize = true;
            this.lblArrastre.BackColor = System.Drawing.Color.Transparent;
            this.lblArrastre.Location = new System.Drawing.Point(23, 121);
            this.lblArrastre.Name = "lblArrastre";
            this.lblArrastre.Size = new System.Drawing.Size(150, 19);
            this.lblArrastre.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblArrastre.TabIndex = 1;
            this.lblArrastre.Text = "Arrastre los juegos aqui:";
            this.lblArrastre.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // botonConvertir
            // 
            this.botonConvertir.Location = new System.Drawing.Point(262, 348);
            this.botonConvertir.Name = "botonConvertir";
            this.botonConvertir.Size = new System.Drawing.Size(75, 23);
            this.botonConvertir.Style = MetroFramework.MetroColorStyle.Blue;
            this.botonConvertir.TabIndex = 1;
            this.botonConvertir.Text = "Convertir";
            this.botonConvertir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toltipArrastre.SetToolTip(this.botonConvertir, "Convierte los juegos agregados");
            this.botonConvertir.UseSelectable = true;
            this.botonConvertir.Click += new System.EventHandler(this.botonConvertir_Click);
            // 
            // botonEmpaquetar
            // 
            this.botonEmpaquetar.Location = new System.Drawing.Point(343, 348);
            this.botonEmpaquetar.Name = "botonEmpaquetar";
            this.botonEmpaquetar.Size = new System.Drawing.Size(75, 23);
            this.botonEmpaquetar.Style = MetroFramework.MetroColorStyle.Blue;
            this.botonEmpaquetar.TabIndex = 2;
            this.botonEmpaquetar.Text = "Empaquetar";
            this.botonEmpaquetar.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.panelJuegos.Style = MetroFramework.MetroColorStyle.Blue;
            this.panelJuegos.TabIndex = 4;
            this.panelJuegos.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.comboBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toltipArrastre.SetToolTip(this.comboBox1, "Formato al que se desean convertir los juegos");
            this.comboBox1.UseSelectable = true;
            // 
            // cbFirware
            // 
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
            "6.2.0",
            "7.0.0-7.0.1"});
            this.cbFirware.Location = new System.Drawing.Point(277, 87);
            this.cbFirware.Name = "cbFirware";
            this.cbFirware.Size = new System.Drawing.Size(141, 29);
            this.cbFirware.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbFirware.TabIndex = 9;
            this.cbFirware.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toltipArrastre.SetToolTip(this.cbFirware, "Firmware para el que se quiere parchar el juego");
            this.cbFirware.UseSelectable = true;
            this.cbFirware.Visible = false;
            // 
            // cbApagar
            // 
            this.cbApagar.AutoSize = true;
            this.cbApagar.Location = new System.Drawing.Point(23, 64);
            this.cbApagar.Name = "cbApagar";
            this.cbApagar.Size = new System.Drawing.Size(117, 15);
            this.cbApagar.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbApagar.TabIndex = 10;
            this.cbApagar.Text = "Apagar al finalizar";
            this.cbApagar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toltipArrastre.SetToolTip(this.cbApagar, "Apaga el sistema al finalizar la tarea solicitada.\r\n(Si algún archivo se encuentr" +
        "a dañado la app\r\npuede quedar congelada y la pc no se apagará)");
            this.cbApagar.UseSelectable = true;
            // 
            // cbSplit
            // 
            this.cbSplit.AutoSize = true;
            this.cbSplit.Location = new System.Drawing.Point(23, 80);
            this.cbSplit.Name = "cbSplit";
            this.cbSplit.Size = new System.Drawing.Size(70, 15);
            this.cbSplit.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbSplit.TabIndex = 12;
            this.cbSplit.Text = "4GB Split";
            this.cbSplit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toltipArrastre.SetToolTip(this.cbSplit, "Cortar el archivo o archivos resultantes\r\nen archivos de 4GB para unidades FAT32." +
        "\r\n(Solo funciona con xci)");
            this.cbSplit.UseSelectable = true;
            // 
            // btnCortar
            // 
            this.btnCortar.Location = new System.Drawing.Point(181, 348);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(75, 23);
            this.btnCortar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCortar.TabIndex = 13;
            this.btnCortar.Text = "Cortar";
            this.btnCortar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toltipArrastre.SetToolTip(this.btnCortar, "Convierte los juegos agregados");
            this.btnCortar.UseSelectable = true;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(277, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Formato:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cbParchar
            // 
            this.cbParchar.AutoSize = true;
            this.cbParchar.Location = new System.Drawing.Point(23, 96);
            this.cbParchar.Name = "cbParchar";
            this.cbParchar.Size = new System.Drawing.Size(125, 15);
            this.cbParchar.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbParchar.TabIndex = 7;
            this.cbParchar.Text = "Parche de firmware";
            this.cbParchar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbParchar.UseSelectable = true;
            this.cbParchar.CheckedChanged += new System.EventHandler(this.cbParchar_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(168, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Firmware patch:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.Visible = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 394);
            this.Controls.Add(this.btnCortar);
            this.Controls.Add(this.cbSplit);
            this.Controls.Add(this.cbApagar);
            this.Controls.Add(this.cbFirware);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbParchar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroLabel1);
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
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private MetroFramework.Controls.MetroCheckBox cbParchar;
        private MetroFramework.Controls.MetroComboBox cbFirware;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox cbApagar;
        private MetroFramework.Controls.MetroCheckBox cbSplit;
        private MetroFramework.Controls.MetroButton btnCortar;
    }
}

