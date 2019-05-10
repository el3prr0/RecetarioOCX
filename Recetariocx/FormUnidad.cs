using Logic.Models;
using Logic.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recetariocx
{
    public partial class FormUnidad : MetroFramework.Forms.MetroForm
    {
        UnidadRepository _unidadRepository;
        private int _id;
        public FormUnidad()
        {
            InitializeComponent();
            _unidadRepository = new UnidadRepository();
        }

        private async void FormUnidad_Load(object sender, EventArgs e)
        {
            await CargarUnidades();
        }








        async Task CargarUnidades()
        {

            var Unidades = await _unidadRepository.GetAll();
            dgUnidad.DataSource = Unidades;
            dgUnidad.Columns["Id"].Visible = false;
            dgUnidad.Columns["Activo"].Visible = false;

            txtNombre.Text = string.Empty;
            numValor.Value = 1;
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 0)
            {
                if (await _unidadRepository.Add(new Unidad { Nombre = txtNombre.Text.Trim().ToUpper(), Valor = Convert.ToInt32(numValor.Value) }))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Se agrego unidad");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Ocurrio un problema");
                }
                await CargarUnidades();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Agregar nombre unidad");
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this,$"Desea eliminar la Unidad", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (await _unidadRepository.Delete(_id))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Se elimino la Unidad");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Ocurrio un problema");
                }
                await CargarUnidades();
            }
        }

        private async void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 0)
            {
                if (await _unidadRepository.Save(new Unidad { Id = _id, Nombre = txtNombre.Text.Trim().ToUpper(), Valor = Convert.ToInt32(numValor.Value) }))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Se modifico una Unidad");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Ocurrio un problema");
                }
                await CargarUnidades();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Agregar una unidad");
            }
        }

        private void DgUnidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                _id = Convert.ToInt32(dgUnidad.Rows[e.RowIndex].Cells["Id"].FormattedValue);

                txtNombre.Text = dgUnidad.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
                numValor.Value = Convert.ToInt32(dgUnidad.Rows[e.RowIndex].Cells["Valor"].FormattedValue);
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
    }
}
