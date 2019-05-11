namespace Recetariocx
{
    partial class FormInstrucciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.lblInstruccion = new MetroFramework.Controls.MetroLabel();
            this.txtInstruccion = new MetroFramework.Controls.MetroTextBox();
            this.dgInstrucciones = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstrucciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(311, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 19);
            this.lblNombre.TabIndex = 123;
            this.lblNombre.Text = "metroLabel1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(318, 363);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 47);
            this.btnAgregar.TabIndex = 124;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(588, 363);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 47);
            this.btnEliminar.TabIndex = 125;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(457, 363);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 47);
            this.btnModificar.TabIndex = 126;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(50, 268);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(130, 19);
            this.lblInstruccion.TabIndex = 127;
            this.lblInstruccion.Text = "Agregar o Modificar";
            // 
            // txtInstruccion
            // 
            // 
            // 
            // 
            this.txtInstruccion.CustomButton.Image = null;
            this.txtInstruccion.CustomButton.Location = new System.Drawing.Point(624, 1);
            this.txtInstruccion.CustomButton.Name = "";
            this.txtInstruccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInstruccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInstruccion.CustomButton.TabIndex = 1;
            this.txtInstruccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInstruccion.CustomButton.UseSelectable = true;
            this.txtInstruccion.CustomButton.Visible = false;
            this.txtInstruccion.Lines = new string[0];
            this.txtInstruccion.Location = new System.Drawing.Point(50, 291);
            this.txtInstruccion.MaxLength = 32767;
            this.txtInstruccion.Name = "txtInstruccion";
            this.txtInstruccion.PasswordChar = '\0';
            this.txtInstruccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInstruccion.SelectedText = "";
            this.txtInstruccion.SelectionLength = 0;
            this.txtInstruccion.SelectionStart = 0;
            this.txtInstruccion.ShortcutsEnabled = true;
            this.txtInstruccion.Size = new System.Drawing.Size(646, 23);
            this.txtInstruccion.TabIndex = 128;
            this.txtInstruccion.UseSelectable = true;
            this.txtInstruccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInstruccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgInstrucciones
            // 
            this.dgInstrucciones.AllowUserToAddRows = false;
            this.dgInstrucciones.AllowUserToDeleteRows = false;
            this.dgInstrucciones.AllowUserToOrderColumns = true;
            this.dgInstrucciones.AllowUserToResizeRows = false;
            this.dgInstrucciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgInstrucciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgInstrucciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInstrucciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgInstrucciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInstrucciones.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgInstrucciones.EnableHeadersVisualStyles = false;
            this.dgInstrucciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgInstrucciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgInstrucciones.Location = new System.Drawing.Point(50, 85);
            this.dgInstrucciones.Name = "dgInstrucciones";
            this.dgInstrucciones.ReadOnly = true;
            this.dgInstrucciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInstrucciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgInstrucciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgInstrucciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInstrucciones.Size = new System.Drawing.Size(643, 150);
            this.dgInstrucciones.TabIndex = 129;
            this.dgInstrucciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgInstrucciones_CellClick);
            // 
            // FormInstrucciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.dgInstrucciones);
            this.Controls.Add(this.txtInstruccion);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormInstrucciones";
            this.Text = "Instrucciones";
            this.Load += new System.EventHandler(this.FormInstrucciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInstrucciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroLabel lblInstruccion;
        private MetroFramework.Controls.MetroTextBox txtInstruccion;
        private MetroFramework.Controls.MetroGrid dgInstrucciones;
    }
}