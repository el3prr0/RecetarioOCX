namespace Recetariocx
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.listProductos = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPrevious = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.btnTimer = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.listIngredientes = new System.Windows.Forms.ListBox();
            this.btnBorrar = new MetroFramework.Controls.MetroButton();
            this.btnSpace = new MetroFramework.Controls.MetroButton();
            this.btnP = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnLimpiar = new MetroFramework.Controls.MetroButton();
            this.txtGuarnicion = new MetroFramework.Controls.MetroTextBox();
            this.btnM = new MetroFramework.Controls.MetroButton();
            this.btnN = new MetroFramework.Controls.MetroButton();
            this.btnB = new MetroFramework.Controls.MetroButton();
            this.btnV = new MetroFramework.Controls.MetroButton();
            this.btnC = new MetroFramework.Controls.MetroButton();
            this.btnX = new MetroFramework.Controls.MetroButton();
            this.btnZ = new MetroFramework.Controls.MetroButton();
            this.btnÑ = new MetroFramework.Controls.MetroButton();
            this.btnL = new MetroFramework.Controls.MetroButton();
            this.btnK = new MetroFramework.Controls.MetroButton();
            this.btnJ = new MetroFramework.Controls.MetroButton();
            this.btnH = new MetroFramework.Controls.MetroButton();
            this.btnG = new MetroFramework.Controls.MetroButton();
            this.btnF = new MetroFramework.Controls.MetroButton();
            this.btnD = new MetroFramework.Controls.MetroButton();
            this.btnS = new MetroFramework.Controls.MetroButton();
            this.btnA = new MetroFramework.Controls.MetroButton();
            this.btnO = new MetroFramework.Controls.MetroButton();
            this.btnI = new MetroFramework.Controls.MetroButton();
            this.btnU = new MetroFramework.Controls.MetroButton();
            this.Y = new MetroFramework.Controls.MetroButton();
            this.btnT = new MetroFramework.Controls.MetroButton();
            this.btnR = new MetroFramework.Controls.MetroButton();
            this.btnE = new MetroFramework.Controls.MetroButton();
            this.btnW = new MetroFramework.Controls.MetroButton();
            this.btnQ = new MetroFramework.Controls.MetroButton();
            this.txtProducto = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // listProductos
            // 
            this.listProductos.BackColor = System.Drawing.Color.Orange;
            this.listProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProductos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.listProductos.FormattingEnabled = true;
            this.listProductos.ItemHeight = 24;
            this.listProductos.Location = new System.Drawing.Point(626, 266);
            this.listProductos.Margin = new System.Windows.Forms.Padding(4);
            this.listProductos.Name = "listProductos";
            this.listProductos.ScrollAlwaysVisible = true;
            this.listProductos.Size = new System.Drawing.Size(603, 148);
            this.listProductos.TabIndex = 71;
            this.listProductos.SelectedIndexChanged += new System.EventHandler(this.ListProductos_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrevious.Location = new System.Drawing.Point(112, 306);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(59, 28);
            this.btnPrevious.TabIndex = 88;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseCustomBackColor = true;
            this.btnPrevious.UseCustomForeColor = true;
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(405, 306);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 28);
            this.btnNext.TabIndex = 89;
            this.btnNext.Text = ">>";
            this.btnNext.UseCustomBackColor = true;
            this.btnNext.UseCustomForeColor = true;
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimer.Location = new System.Drawing.Point(180, 306);
            this.btnTimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(216, 28);
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
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel2.Location = new System.Drawing.Point(623, 234);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 91;
            this.metroLabel2.Text = "Productos";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
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
            this.pbLogo.BackColor = System.Drawing.Color.Khaki;
            this.pbLogo.Location = new System.Drawing.Point(989, 42);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(201, 186);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 95;
            this.pbLogo.TabStop = false;
            // 
            // pbImagenes
            // 
            this.pbImagenes.BackColor = System.Drawing.Color.Khaki;
            this.pbImagenes.Location = new System.Drawing.Point(31, 347);
            this.pbImagenes.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(563, 363);
            this.pbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenes.TabIndex = 82;
            this.pbImagenes.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel3.Location = new System.Drawing.Point(619, 606);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 135;
            this.metroLabel3.Text = "Descripcion";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel4.Location = new System.Drawing.Point(626, 418);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 130;
            this.metroLabel4.Text = "Ingredientes";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Orange;
            // 
            // 
            // 
            this.txtPrecio.CustomButton.Image = null;
            this.txtPrecio.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtPrecio.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.CustomButton.Name = "";
            this.txtPrecio.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio.CustomButton.TabIndex = 1;
            this.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecio.CustomButton.UseSelectable = true;
            this.txtPrecio.CustomButton.Visible = false;
            this.txtPrecio.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPrecio.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPrecio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPrecio.Lines = new string[0];
            this.txtPrecio.Location = new System.Drawing.Point(1089, 545);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(135, 37);
            this.txtPrecio.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio.TabIndex = 137;
            this.txtPrecio.UseCustomBackColor = true;
            this.txtPrecio.UseCustomForeColor = true;
            this.txtPrecio.UseSelectable = true;
            this.txtPrecio.UseStyleColors = true;
            this.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecio.WaterMarkFont = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Orange;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(528, 2);
            this.txtDescripcion.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(71, 71);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(622, 635);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(602, 76);
            this.txtDescripcion.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.TabIndex = 133;
            this.txtDescripcion.UseCustomBackColor = true;
            this.txtDescripcion.UseCustomForeColor = true;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.UseStyleColors = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel9.Location = new System.Drawing.Point(31, 42);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(61, 20);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel9.TabIndex = 140;
            this.metroLabel9.Text = "Nombre";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel5.Location = new System.Drawing.Point(989, 546);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 157;
            this.metroLabel5.Text = "Precio $";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel8.Location = new System.Drawing.Point(31, 306);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(69, 20);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel8.TabIndex = 141;
            this.metroLabel8.Text = "Imagenes";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.DarkMagenta;
            this.metroLabel7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.metroLabel7.Location = new System.Drawing.Point(1023, 262);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(0, 0);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel7.TabIndex = 142;
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // listIngredientes
            // 
            this.listIngredientes.BackColor = System.Drawing.Color.Orange;
            this.listIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listIngredientes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.listIngredientes.FormattingEnabled = true;
            this.listIngredientes.HorizontalScrollbar = true;
            this.listIngredientes.ItemHeight = 20;
            this.listIngredientes.Location = new System.Drawing.Point(626, 447);
            this.listIngredientes.Margin = new System.Windows.Forms.Padding(4);
            this.listIngredientes.Name = "listIngredientes";
            this.listIngredientes.Size = new System.Drawing.Size(339, 124);
            this.listIngredientes.TabIndex = 120;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBorrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrar.Location = new System.Drawing.Point(855, 86);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(96, 39);
            this.btnBorrar.TabIndex = 156;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseCustomBackColor = true;
            this.btnBorrar.UseCustomForeColor = true;
            this.btnBorrar.UseSelectable = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSpace.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSpace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpace.Location = new System.Drawing.Point(854, 185);
            this.btnSpace.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(96, 39);
            this.btnSpace.TabIndex = 155;
            this.btnSpace.Text = "Espacio";
            this.btnSpace.UseCustomBackColor = true;
            this.btnSpace.UseCustomForeColor = true;
            this.btnSpace.UseSelectable = true;
            this.btnSpace.Click += new System.EventHandler(this.BtnSpace_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.DarkOrange;
            this.btnP.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnP.Location = new System.Drawing.Point(760, 134);
            this.btnP.Margin = new System.Windows.Forms.Padding(4);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(79, 39);
            this.btnP.TabIndex = 127;
            this.btnP.Text = "P";
            this.btnP.UseCustomBackColor = true;
            this.btnP.UseCustomForeColor = true;
            this.btnP.UseSelectable = true;
            this.btnP.Click += new System.EventHandler(this.BtnP_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(997, 418);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 129;
            this.metroLabel1.Text = "Guarnicion";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(854, 135);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 39);
            this.btnLimpiar.TabIndex = 147;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseCustomBackColor = true;
            this.btnLimpiar.UseCustomForeColor = true;
            this.btnLimpiar.UseSelectable = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // txtGuarnicion
            // 
            this.txtGuarnicion.BackColor = System.Drawing.Color.Orange;
            // 
            // 
            // 
            this.txtGuarnicion.CustomButton.Image = null;
            this.txtGuarnicion.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.txtGuarnicion.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuarnicion.CustomButton.Name = "";
            this.txtGuarnicion.CustomButton.Size = new System.Drawing.Size(71, 71);
            this.txtGuarnicion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuarnicion.CustomButton.TabIndex = 1;
            this.txtGuarnicion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuarnicion.CustomButton.UseSelectable = true;
            this.txtGuarnicion.CustomButton.Visible = false;
            this.txtGuarnicion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtGuarnicion.Lines = new string[0];
            this.txtGuarnicion.Location = new System.Drawing.Point(997, 447);
            this.txtGuarnicion.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtGuarnicion.Size = new System.Drawing.Size(227, 76);
            this.txtGuarnicion.TabIndex = 128;
            this.txtGuarnicion.UseCustomBackColor = true;
            this.txtGuarnicion.UseCustomForeColor = true;
            this.txtGuarnicion.UseSelectable = true;
            this.txtGuarnicion.UseStyleColors = true;
            this.txtGuarnicion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuarnicion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.DarkOrange;
            this.btnM.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnM.Location = new System.Drawing.Point(576, 185);
            this.btnM.Margin = new System.Windows.Forms.Padding(4);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(79, 39);
            this.btnM.TabIndex = 154;
            this.btnM.Text = "M";
            this.btnM.UseCustomBackColor = true;
            this.btnM.UseCustomForeColor = true;
            this.btnM.UseSelectable = true;
            this.btnM.Click += new System.EventHandler(this.BtnM_Click);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.DarkOrange;
            this.btnN.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnN.Location = new System.Drawing.Point(484, 185);
            this.btnN.Margin = new System.Windows.Forms.Padding(4);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(79, 39);
            this.btnN.TabIndex = 153;
            this.btnN.Text = "N";
            this.btnN.UseCustomBackColor = true;
            this.btnN.UseCustomForeColor = true;
            this.btnN.UseSelectable = true;
            this.btnN.Click += new System.EventHandler(this.BtnN_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.DarkOrange;
            this.btnB.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnB.Location = new System.Drawing.Point(394, 185);
            this.btnB.Margin = new System.Windows.Forms.Padding(4);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(79, 39);
            this.btnB.TabIndex = 152;
            this.btnB.Text = "B";
            this.btnB.UseCustomBackColor = true;
            this.btnB.UseCustomForeColor = true;
            this.btnB.UseSelectable = true;
            this.btnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.DarkOrange;
            this.btnV.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnV.Location = new System.Drawing.Point(303, 185);
            this.btnV.Margin = new System.Windows.Forms.Padding(4);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(79, 39);
            this.btnV.TabIndex = 151;
            this.btnV.Text = "V";
            this.btnV.UseCustomBackColor = true;
            this.btnV.UseCustomForeColor = true;
            this.btnV.UseSelectable = true;
            this.btnV.Click += new System.EventHandler(this.BtnV_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.DarkOrange;
            this.btnC.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnC.Location = new System.Drawing.Point(212, 185);
            this.btnC.Margin = new System.Windows.Forms.Padding(4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(79, 39);
            this.btnC.TabIndex = 150;
            this.btnC.Text = "C";
            this.btnC.UseCustomBackColor = true;
            this.btnC.UseCustomForeColor = true;
            this.btnC.UseSelectable = true;
            this.btnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.DarkOrange;
            this.btnX.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnX.Location = new System.Drawing.Point(122, 185);
            this.btnX.Margin = new System.Windows.Forms.Padding(4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(79, 39);
            this.btnX.TabIndex = 149;
            this.btnX.Text = "X";
            this.btnX.UseCustomBackColor = true;
            this.btnX.UseCustomForeColor = true;
            this.btnX.UseSelectable = true;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.Color.DarkOrange;
            this.btnZ.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnZ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZ.Location = new System.Drawing.Point(30, 185);
            this.btnZ.Margin = new System.Windows.Forms.Padding(4);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(80, 39);
            this.btnZ.TabIndex = 148;
            this.btnZ.Text = "Z";
            this.btnZ.UseCustomBackColor = true;
            this.btnZ.UseCustomForeColor = true;
            this.btnZ.UseSelectable = true;
            this.btnZ.Click += new System.EventHandler(this.BtnZ_Click);
            // 
            // btnÑ
            // 
            this.btnÑ.BackColor = System.Drawing.Color.DarkOrange;
            this.btnÑ.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnÑ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnÑ.Location = new System.Drawing.Point(668, 185);
            this.btnÑ.Margin = new System.Windows.Forms.Padding(4);
            this.btnÑ.Name = "btnÑ";
            this.btnÑ.Size = new System.Drawing.Size(80, 39);
            this.btnÑ.TabIndex = 131;
            this.btnÑ.Text = "Ñ";
            this.btnÑ.UseCustomBackColor = true;
            this.btnÑ.UseCustomForeColor = true;
            this.btnÑ.UseSelectable = true;
            this.btnÑ.Click += new System.EventHandler(this.BtnÑ_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.DarkOrange;
            this.btnL.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnL.Location = new System.Drawing.Point(762, 185);
            this.btnL.Margin = new System.Windows.Forms.Padding(4);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(79, 39);
            this.btnL.TabIndex = 146;
            this.btnL.Text = "L";
            this.btnL.UseCustomBackColor = true;
            this.btnL.UseCustomForeColor = true;
            this.btnL.UseSelectable = true;
            this.btnL.Click += new System.EventHandler(this.BtnL_Click);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnK.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnK.Location = new System.Drawing.Point(668, 135);
            this.btnK.Margin = new System.Windows.Forms.Padding(4);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(79, 39);
            this.btnK.TabIndex = 145;
            this.btnK.Text = "K";
            this.btnK.UseCustomBackColor = true;
            this.btnK.UseCustomForeColor = true;
            this.btnK.UseSelectable = true;
            this.btnK.Click += new System.EventHandler(this.BtnK_Click);
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.Color.DarkOrange;
            this.btnJ.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnJ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJ.Location = new System.Drawing.Point(575, 135);
            this.btnJ.Margin = new System.Windows.Forms.Padding(4);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(79, 39);
            this.btnJ.TabIndex = 144;
            this.btnJ.Text = "J";
            this.btnJ.UseCustomBackColor = true;
            this.btnJ.UseCustomForeColor = true;
            this.btnJ.UseSelectable = true;
            this.btnJ.Click += new System.EventHandler(this.BtnJ_Click);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.DarkOrange;
            this.btnH.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnH.Location = new System.Drawing.Point(483, 135);
            this.btnH.Margin = new System.Windows.Forms.Padding(4);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(79, 39);
            this.btnH.TabIndex = 143;
            this.btnH.Text = "H";
            this.btnH.UseCustomBackColor = true;
            this.btnH.UseCustomForeColor = true;
            this.btnH.UseSelectable = true;
            this.btnH.Click += new System.EventHandler(this.BtnH_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.DarkOrange;
            this.btnG.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnG.Location = new System.Drawing.Point(392, 135);
            this.btnG.Margin = new System.Windows.Forms.Padding(4);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(79, 39);
            this.btnG.TabIndex = 139;
            this.btnG.Text = "G";
            this.btnG.UseCustomBackColor = true;
            this.btnG.UseCustomForeColor = true;
            this.btnG.UseSelectable = true;
            this.btnG.Click += new System.EventHandler(this.BtnG_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.DarkOrange;
            this.btnF.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnF.Location = new System.Drawing.Point(302, 135);
            this.btnF.Margin = new System.Windows.Forms.Padding(4);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(79, 39);
            this.btnF.TabIndex = 138;
            this.btnF.Text = "F";
            this.btnF.UseCustomBackColor = true;
            this.btnF.UseCustomForeColor = true;
            this.btnF.UseSelectable = true;
            this.btnF.Click += new System.EventHandler(this.BtnF_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.DarkOrange;
            this.btnD.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnD.Location = new System.Drawing.Point(211, 135);
            this.btnD.Margin = new System.Windows.Forms.Padding(4);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(79, 39);
            this.btnD.TabIndex = 136;
            this.btnD.Text = "D";
            this.btnD.UseCustomBackColor = true;
            this.btnD.UseCustomForeColor = true;
            this.btnD.UseSelectable = true;
            this.btnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.DarkOrange;
            this.btnS.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnS.Location = new System.Drawing.Point(120, 135);
            this.btnS.Margin = new System.Windows.Forms.Padding(4);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(79, 39);
            this.btnS.TabIndex = 134;
            this.btnS.Text = "S";
            this.btnS.UseCustomBackColor = true;
            this.btnS.UseCustomForeColor = true;
            this.btnS.UseSelectable = true;
            this.btnS.Click += new System.EventHandler(this.BtnS_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.DarkOrange;
            this.btnA.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnA.Location = new System.Drawing.Point(28, 135);
            this.btnA.Margin = new System.Windows.Forms.Padding(4);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(80, 39);
            this.btnA.TabIndex = 132;
            this.btnA.Text = "A";
            this.btnA.UseCustomBackColor = true;
            this.btnA.UseCustomForeColor = true;
            this.btnA.UseSelectable = true;
            this.btnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.DarkOrange;
            this.btnO.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnO.Location = new System.Drawing.Point(762, 86);
            this.btnO.Margin = new System.Windows.Forms.Padding(4);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(79, 39);
            this.btnO.TabIndex = 126;
            this.btnO.Text = "O";
            this.btnO.UseCustomBackColor = true;
            this.btnO.UseCustomForeColor = true;
            this.btnO.UseSelectable = true;
            this.btnO.Click += new System.EventHandler(this.BtnO_Click);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.DarkOrange;
            this.btnI.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnI.Location = new System.Drawing.Point(668, 86);
            this.btnI.Margin = new System.Windows.Forms.Padding(4);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(79, 39);
            this.btnI.TabIndex = 125;
            this.btnI.Text = "I";
            this.btnI.UseCustomBackColor = true;
            this.btnI.UseCustomForeColor = true;
            this.btnI.UseSelectable = true;
            this.btnI.Click += new System.EventHandler(this.BtnI_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.DarkOrange;
            this.btnU.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnU.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnU.Location = new System.Drawing.Point(575, 86);
            this.btnU.Margin = new System.Windows.Forms.Padding(4);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(79, 39);
            this.btnU.TabIndex = 124;
            this.btnU.Text = "U";
            this.btnU.UseCustomBackColor = true;
            this.btnU.UseCustomForeColor = true;
            this.btnU.UseSelectable = true;
            this.btnU.Click += new System.EventHandler(this.BtnU_Click);
            // 
            // Y
            // 
            this.Y.BackColor = System.Drawing.Color.DarkOrange;
            this.Y.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Y.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Y.Location = new System.Drawing.Point(483, 86);
            this.Y.Margin = new System.Windows.Forms.Padding(4);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(79, 39);
            this.Y.TabIndex = 123;
            this.Y.Text = "Y";
            this.Y.UseCustomBackColor = true;
            this.Y.UseCustomForeColor = true;
            this.Y.UseSelectable = true;
            this.Y.Click += new System.EventHandler(this.Y_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.DarkOrange;
            this.btnT.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnT.Location = new System.Drawing.Point(392, 86);
            this.btnT.Margin = new System.Windows.Forms.Padding(4);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(79, 39);
            this.btnT.TabIndex = 122;
            this.btnT.Text = "T";
            this.btnT.UseCustomBackColor = true;
            this.btnT.UseCustomForeColor = true;
            this.btnT.UseSelectable = true;
            this.btnT.Click += new System.EventHandler(this.BtnT_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.DarkOrange;
            this.btnR.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnR.Location = new System.Drawing.Point(302, 86);
            this.btnR.Margin = new System.Windows.Forms.Padding(4);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(79, 39);
            this.btnR.TabIndex = 121;
            this.btnR.Text = "R";
            this.btnR.UseCustomBackColor = true;
            this.btnR.UseCustomForeColor = true;
            this.btnR.UseSelectable = true;
            this.btnR.Click += new System.EventHandler(this.BtnR_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.DarkOrange;
            this.btnE.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnE.Location = new System.Drawing.Point(211, 86);
            this.btnE.Margin = new System.Windows.Forms.Padding(4);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(79, 39);
            this.btnE.TabIndex = 119;
            this.btnE.Text = "E";
            this.btnE.UseCustomBackColor = true;
            this.btnE.UseCustomForeColor = true;
            this.btnE.UseSelectable = true;
            this.btnE.Click += new System.EventHandler(this.BtnE_Click);
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.Color.DarkOrange;
            this.btnW.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnW.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnW.Location = new System.Drawing.Point(120, 86);
            this.btnW.Margin = new System.Windows.Forms.Padding(4);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(79, 39);
            this.btnW.TabIndex = 118;
            this.btnW.Text = "W";
            this.btnW.UseCustomBackColor = true;
            this.btnW.UseCustomForeColor = true;
            this.btnW.UseSelectable = true;
            this.btnW.Click += new System.EventHandler(this.BtnW_Click);
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.Color.DarkOrange;
            this.btnQ.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQ.Location = new System.Drawing.Point(28, 86);
            this.btnQ.Margin = new System.Windows.Forms.Padding(4);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(80, 39);
            this.btnQ.TabIndex = 117;
            this.btnQ.Text = "Q";
            this.btnQ.UseCustomBackColor = true;
            this.btnQ.UseCustomForeColor = true;
            this.btnQ.UseSelectable = true;
            this.btnQ.Click += new System.EventHandler(this.BtnQ_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProducto.BackColor = System.Drawing.Color.LavenderBlush;
            // 
            // 
            // 
            this.txtProducto.CustomButton.Image = null;
            this.txtProducto.CustomButton.Location = new System.Drawing.Point(759, 2);
            this.txtProducto.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.CustomButton.Name = "";
            this.txtProducto.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProducto.CustomButton.TabIndex = 1;
            this.txtProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProducto.CustomButton.UseSelectable = true;
            this.txtProducto.CustomButton.Visible = false;
            this.txtProducto.Lines = new string[0];
            this.txtProducto.Location = new System.Drawing.Point(119, 42);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducto.MaxLength = 32767;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProducto.SelectedText = "";
            this.txtProducto.SelectionLength = 0;
            this.txtProducto.SelectionStart = 0;
            this.txtProducto.ShortcutsEnabled = true;
            this.txtProducto.Size = new System.Drawing.Size(785, 28);
            this.txtProducto.TabIndex = 116;
            this.txtProducto.UseSelectable = true;
            this.txtProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 757);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.listIngredientes);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtGuarnicion);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnÑ);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pbImagenes);
            this.Controls.Add(this.listProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Movable = false;
            this.Name = "FormCliente";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCliente_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listProductos;
        private System.Windows.Forms.PictureBox pbImagenes;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton btnPrevious;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroButton btnTimer;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ListBox listIngredientes;
        private MetroFramework.Controls.MetroButton btnBorrar;
        private MetroFramework.Controls.MetroButton btnSpace;
        private MetroFramework.Controls.MetroButton btnP;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnLimpiar;
        private MetroFramework.Controls.MetroTextBox txtGuarnicion;
        private MetroFramework.Controls.MetroButton btnM;
        private MetroFramework.Controls.MetroButton btnN;
        private MetroFramework.Controls.MetroButton btnB;
        private MetroFramework.Controls.MetroButton btnV;
        private MetroFramework.Controls.MetroButton btnC;
        private MetroFramework.Controls.MetroButton btnX;
        private MetroFramework.Controls.MetroButton btnZ;
        private MetroFramework.Controls.MetroButton btnÑ;
        private MetroFramework.Controls.MetroButton btnL;
        private MetroFramework.Controls.MetroButton btnK;
        private MetroFramework.Controls.MetroButton btnJ;
        private MetroFramework.Controls.MetroButton btnH;
        private MetroFramework.Controls.MetroButton btnG;
        private MetroFramework.Controls.MetroButton btnF;
        private MetroFramework.Controls.MetroButton btnD;
        private MetroFramework.Controls.MetroButton btnS;
        private MetroFramework.Controls.MetroButton btnA;
        private MetroFramework.Controls.MetroButton btnO;
        private MetroFramework.Controls.MetroButton btnI;
        private MetroFramework.Controls.MetroButton btnU;
        private MetroFramework.Controls.MetroButton Y;
        private MetroFramework.Controls.MetroButton btnT;
        private MetroFramework.Controls.MetroButton btnR;
        private MetroFramework.Controls.MetroButton btnE;
        private MetroFramework.Controls.MetroButton btnW;
        private MetroFramework.Controls.MetroButton btnQ;
        private MetroFramework.Controls.MetroTextBox txtProducto;
    }
}