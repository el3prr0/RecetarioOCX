using Logic.Helpers;
using Logic.Models;
using Logic.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recetariocx
{
    public partial class FormUsuarios : MetroFramework.Forms.MetroForm
    {
        UsuarioRepository _usuarioRepository;
        private int _id;
        private readonly string Salt;
        public FormUsuarios()
        {
            InitializeComponent();
            _usuarioRepository = new UsuarioRepository();
            Salt = ConfigurationManager.AppSettings["SecretKey"].ToString();
        }

        private async void FormUsuarios_Load(object sender, EventArgs e)
        {
          await  CargarUsuarios();
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
            {

                if (await _usuarioRepository.Add(new Login { Nombre = txtNombre.Text.Trim(), Telefono = txtTelefono.Text.Trim(), Correo = txtCorreo.Text.Trim(), Password = txtPassword.Text.Trim(), Usuario = txtUsuario.Text.Trim(),Nivel = cbNivel.Text }))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Se Agrego Usuario");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Ocurrio un problema");
                }
                await CargarUsuarios();


            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Agregar Datos");
            }
        }

        private async void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0)
            {



                if (await _usuarioRepository.Save(new Login { Nombre = txtNombre.Text.Trim(), Telefono = txtTelefono.Text.Trim(), Id = _id, Correo = txtCorreo.Text.Trim(),Password = txtPassword.Text.Trim(),Usuario = txtUsuario.Text.Trim(),Nivel = cbNivel.Text }))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Se Modifico Usuario");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Ocurrio un problema");
                }
                await CargarUsuarios();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Introducir Datos");
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, $"Desea eliminar usuario", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (await _usuarioRepository.Delete(_id))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Se elimino el usuario");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Ocurrio un problema");
                }
                await CargarUsuarios();
            }
        }

        private async Task CargarUsuarios()
        {
            var usuarios = await _usuarioRepository.GetAll();
            dgUsuarios.DataSource = usuarios;

            dgUsuarios.Columns["Id"].Visible = false;
            dgUsuarios.Columns["Password"].Visible = false;

            txtNombre.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;


        }

        private void DgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                _id = Convert.ToInt32(dgUsuarios.Rows[e.RowIndex].Cells["Id"].FormattedValue);

                txtNombre.Text = dgUsuarios.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
                txtCorreo.Text = dgUsuarios.Rows[e.RowIndex].Cells["Correo"].FormattedValue.ToString();
                txtTelefono.Text = dgUsuarios.Rows[e.RowIndex].Cells["Telefono"].FormattedValue.ToString();
                txtUsuario.Text  = dgUsuarios.Rows[e.RowIndex].Cells["Usuario"].FormattedValue.ToString();
                cbNivel.Text = dgUsuarios.Rows[e.RowIndex].Cells["Nivel"].FormattedValue.ToString();



                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
    }
}
