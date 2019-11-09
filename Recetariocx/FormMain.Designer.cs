namespace Recetariocx
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProductoOK = new TextBoxWKeyBoard.TexBoxWKeyBoard();
            this.listProductos = new System.Windows.Forms.ListBox();
            this.listInstrucciones = new System.Windows.Forms.ListBox();
            this.listIngredientes = new System.Windows.Forms.ListBox();
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtGuarnicion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnPrevious = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.btnTimer = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtProductoOK);
            this.panel1.Location = new System.Drawing.Point(6, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 57);
            this.panel1.TabIndex = 70;
            // 
            // txtProductoOK
            // 
            this.txtProductoOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoOK.Location = new System.Drawing.Point(8, 14);
            this.txtProductoOK.Name = "txtProductoOK";
            this.txtProductoOK.Size = new System.Drawing.Size(353, 26);
            this.txtProductoOK.TabIndex = 96;
            this.txtProductoOK.TextEntryMode = TextBoxWKeyBoard.TexBoxWKeyBoard.EntryMode.Standard;
            this.txtProductoOK.TextChanged += new System.EventHandler(this.TxtProducto_TextChanged_1);
            // 
            // listProductos
            // 
            this.listProductos.BackColor = System.Drawing.Color.YellowGreen;
            this.listProductos.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProductos.ForeColor = System.Drawing.Color.Black;
            this.listProductos.FormattingEnabled = true;
            this.listProductos.ItemHeight = 19;
            this.listProductos.Location = new System.Drawing.Point(14, 95);
            this.listProductos.Name = "listProductos";
            this.listProductos.ScrollAlwaysVisible = true;
            this.listProductos.Size = new System.Drawing.Size(358, 118);
            this.listProductos.TabIndex = 0;
            this.listProductos.SelectedIndexChanged += new System.EventHandler(this.ListProductos_SelectedIndexChanged);
            // 
            // listInstrucciones
            // 
            this.listInstrucciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listInstrucciones.BackColor = System.Drawing.Color.YellowGreen;
            this.listInstrucciones.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listInstrucciones.ForeColor = System.Drawing.Color.Black;
            this.listInstrucciones.FormattingEnabled = true;
            this.listInstrucciones.HorizontalScrollbar = true;
            this.listInstrucciones.ItemHeight = 16;
            this.listInstrucciones.Location = new System.Drawing.Point(407, 332);
            this.listInstrucciones.Name = "listInstrucciones";
            this.listInstrucciones.Size = new System.Drawing.Size(519, 228);
            this.listInstrucciones.TabIndex = 72;
            this.listInstrucciones.SelectedIndexChanged += new System.EventHandler(this.ListInstrucciones_SelectedIndexChanged);
            this.listInstrucciones.DoubleClick += new System.EventHandler(this.ListInstrucciones_DoubleClick);
            // 
            // listIngredientes
            // 
            this.listIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listIngredientes.BackColor = System.Drawing.Color.YellowGreen;
            this.listIngredientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listIngredientes.ForeColor = System.Drawing.Color.Black;
            this.listIngredientes.FormattingEnabled = true;
            this.listIngredientes.HorizontalScrollbar = true;
            this.listIngredientes.ItemHeight = 16;
            this.listIngredientes.Location = new System.Drawing.Point(410, 102);
            this.listIngredientes.Name = "listIngredientes";
            this.listIngredientes.Size = new System.Drawing.Size(307, 196);
            this.listIngredientes.TabIndex = 73;
            // 
            // pbImagenes
            // 
            this.pbImagenes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbImagenes.Location = new System.Drawing.Point(17, 252);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(350, 220);
            this.pbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenes.TabIndex = 82;
            this.pbImagenes.TabStop = false;
            this.pbImagenes.Click += new System.EventHandler(this.PbImagenes_Click);
            this.pbImagenes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbImagenes_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // txtGuarnicion
            // 
            this.txtGuarnicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGuarnicion.BackColor = System.Drawing.Color.YellowGreen;
            // 
            // 
            // 
            this.txtGuarnicion.CustomButton.Image = null;
            this.txtGuarnicion.CustomButton.Location = new System.Drawing.Point(303, 1);
            this.txtGuarnicion.CustomButton.Name = "";
            this.txtGuarnicion.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.txtGuarnicion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuarnicion.CustomButton.TabIndex = 1;
            this.txtGuarnicion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuarnicion.CustomButton.UseSelectable = true;
            this.txtGuarnicion.CustomButton.Visible = false;
            this.txtGuarnicion.ForeColor = System.Drawing.Color.Black;
            this.txtGuarnicion.Lines = new string[0];
            this.txtGuarnicion.Location = new System.Drawing.Point(17, 505);
            this.txtGuarnicion.MaxLength = 32767;
            this.txtGuarnicion.Multiline = true;
            this.txtGuarnicion.Name = "txtGuarnicion";
            this.txtGuarnicion.PasswordChar = '\0';
            this.txtGuarnicion.ReadOnly = true;
            this.txtGuarnicion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuarnicion.SelectedText = "";
            this.txtGuarnicion.SelectionLength = 0;
            this.txtGuarnicion.SelectionStart = 0;
            this.txtGuarnicion.ShortcutsEnabled = true;
            this.txtGuarnicion.Size = new System.Drawing.Size(355, 53);
            this.txtGuarnicion.TabIndex = 86;
            this.txtGuarnicion.UseCustomBackColor = true;
            this.txtGuarnicion.UseCustomForeColor = true;
            this.txtGuarnicion.UseSelectable = true;
            this.txtGuarnicion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuarnicion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 484);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 87;
            this.metroLabel1.Text = "Guarnicion";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrevious.BackColor = System.Drawing.Color.Olive;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrevious.Location = new System.Drawing.Point(108, 223);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(44, 23);
            this.btnPrevious.TabIndex = 88;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseCustomBackColor = true;
            this.btnPrevious.UseCustomForeColor = true;
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNext.BackColor = System.Drawing.Color.Olive;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(328, 223);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(44, 23);
            this.btnNext.TabIndex = 89;
            this.btnNext.Text = ">>";
            this.btnNext.UseCustomBackColor = true;
            this.btnNext.UseCustomForeColor = true;
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTimer.BackColor = System.Drawing.Color.Olive;
            this.btnTimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimer.Location = new System.Drawing.Point(159, 223);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(162, 23);
            this.btnTimer.TabIndex = 90;
            this.btnTimer.Text = "Detener";
            this.btnTimer.UseCustomBackColor = true;
            this.btnTimer.UseCustomForeColor = true;
            this.btnTimer.UseSelectable = true;
            this.btnTimer.Click += new System.EventHandler(this.BtnTimer_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 91;
            this.metroLabel2.Text = "Productos";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(407, 310);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.TabIndex = 92;
            this.metroLabel3.Text = "Instrucciones";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(407, 80);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 93;
            this.metroLabel4.Text = "Ingredientes";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(15, 224);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 25);
            this.metroLabel5.TabIndex = 94;
            this.metroLabel5.Text = "Imagenes";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.Location = new System.Drawing.Point(780, 62);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(132, 143);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 95;
            this.pbLogo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(980, 615);
            this.Controls.Add(this.pbImagenes);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.listIngredientes);
            this.Controls.Add(this.listInstrucciones);
            this.Controls.Add(this.listProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtGuarnicion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listProductos;
        private System.Windows.Forms.ListBox listInstrucciones;
        private System.Windows.Forms.ListBox listIngredientes;
        private System.Windows.Forms.PictureBox pbImagenes;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTextBox txtGuarnicion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnPrevious;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroButton btnTimer;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.PictureBox pbLogo;
        private TextBoxWKeyBoard.TexBoxWKeyBoard txtProductoOK;
    }
}