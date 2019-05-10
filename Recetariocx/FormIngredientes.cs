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
    public partial class FormIngredientes : MetroFramework.Forms.MetroForm
    {
        private readonly int _productoId;
        private readonly string _nombre;
        private int _id;
        private IngredienteRepository _ingredienteRepository;
        private UnidadRepository _unidadRepository;

        public FormIngredientes(int productoId,string nombre)
        {
            InitializeComponent();
            _productoId = productoId;
            _nombre = nombre;
        }

        private async void FormIngredientes_Load(object sender, EventArgs e)
        {
            lblNombre.Text = _nombre;
            _ingredienteRepository = new IngredienteRepository();
            _unidadRepository = new UnidadRepository();
            await CargarIngredientes();
            await CargarUnidades();
        }


        private async Task CargarIngredientes()
        {
            var Ingredientes = await _ingredienteRepository.GetWithProduct(_productoId);
            dgIngredientes.DataSource = Ingredientes;

            dgIngredientes.Columns["Id"].Visible = false;
            dgIngredientes.Columns["ProductoId"].Visible = false;
            dgIngredientes.Columns["Activo"].Visible = false;
            dgIngredientes.Columns["Reglon"].Visible = false;

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtIngredienteNombre.Text = string.Empty;
        }

        private async Task CargarUnidades()
        {
            var unidades = await _unidadRepository.GetAll();
            cbUnidad.DataSource = unidades;
            cbUnidad.DisplayMember = "Nombre";
            cbUnidad.ValueMember = "Nombre";
        }








        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this,$"Desea eliminar el ingrediente", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (await _ingredienteRepository.Delete(_id))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Se elimino el ingrediente");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Ocurrio un problema");
                }
                await CargarIngredientes();
            }
        }

        private async void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtIngredienteNombre.Text.Trim().Length > 0)
            {
                if (nmCantidad.Value > 0)
                {

                    if (await _ingredienteRepository.Save(new Ingrediente { Id = _id, Nombre = txtIngredienteNombre.Text, Unidad = cbUnidad.Text.Trim(), ProductoId = _productoId, Cantidad = Convert.ToInt32(nmCantidad.Value) }))
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Se Modifico Ingrediente");
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Ocurrio un problema");
                    }
                    await CargarIngredientes();
                    await CargarUnidades();


                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Cantidad debe ser mayor de 0");
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Agregar Nombre del Ingrediente");
            }
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIngredienteNombre.Text.Trim().Length > 0)
            {
                if (nmCantidad.Value > 0)
                {
                    var Ingredientes = await _ingredienteRepository.GetWithProduct(_productoId);
                    var Existe = Ingredientes.FirstOrDefault(i => i.Nombre == txtIngredienteNombre.Text.Trim());
                    if (Existe != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this,"Este Ingrediente ya se encuentra registrado");
                    }
                    else
                    {
                        if (await _ingredienteRepository.Add(new Ingrediente { Nombre = txtIngredienteNombre.Text, Unidad = cbUnidad.Text.Trim(), ProductoId = _productoId, Cantidad = Convert.ToInt32(nmCantidad.Value) }))
                        {
                            MetroFramework.MetroMessageBox.Show(this,"Se Agrego Ingrediente");
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this,"Ocurrio un problema");
                        }
                        await CargarIngredientes();
                        await CargarUnidades();
                    }

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Cantidad debe ser mayor de 0");
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Agregar Nombre del Ingrediente");
            }
        }

        private void DgIngredientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                _id = Convert.ToInt32(dgIngredientes.Rows[e.RowIndex].Cells["Id"].FormattedValue);

                txtIngredienteNombre.Text = dgIngredientes.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();

                nmCantidad.Value = Convert.ToInt32(dgIngredientes.Rows[e.RowIndex].Cells["Cantidad"].FormattedValue);

                cbUnidad.Text = dgIngredientes.Rows[e.RowIndex].Cells["Unidad"].FormattedValue.ToString();


                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
    }
}
