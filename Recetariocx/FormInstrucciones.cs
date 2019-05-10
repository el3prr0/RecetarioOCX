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
    public partial class FormInstrucciones : MetroFramework.Forms.MetroForm
    {
        private readonly int _productoId;
        private readonly string _nombre;
        private int _id;
        InstruccionRepository _instruccionRepository;

        public FormInstrucciones(int productoId,string nombre)
        {
            InitializeComponent();
            _productoId = productoId;
            _nombre = nombre;
        }

        private async void FormInstrucciones_Load(object sender, EventArgs e)
        {
            _instruccionRepository = new InstruccionRepository();
            lblNombre.Text = _nombre;
            await CargarInstrucciones();
        }

        private async Task CargarInstrucciones()
        {
            var Instrucciones = await _instruccionRepository.GetWithProduct(_productoId);
            dgInstrucciones.DataSource = Instrucciones;

            dgInstrucciones.Columns["Id"].Visible = false;
            dgInstrucciones.Columns["ProductoId"].Visible = false;
            dgInstrucciones.Columns["Activo"].Visible = false;


            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtInstruccion.Text = string.Empty;
        }









        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtInstruccion.Text.Trim().Length > 0)
            {
                if (await _instruccionRepository.Add(new Instruccion { Paso = txtInstruccion.Text.Trim().ToUpper(), ProductoId = _productoId }))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Se Agrego una Instrunccion");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Ocurrio un problema");
                }
                await CargarInstrucciones();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Agregar una Instruccion");
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this,$"Desea eliminar la instruccion", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (await _instruccionRepository.Delete(_id))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Se elimino la instruccion");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Ocurrio un problema");
                }
                await CargarInstrucciones();
            }
        }

        private async void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtInstruccion.Text.Trim().Length > 0)
            {
                if (await _instruccionRepository.Save(new Instruccion { Paso = txtInstruccion.Text.Trim().ToUpper(), ProductoId = _productoId, Id = _id }))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Se modifico una Instrunccion");
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Ocurrio un problema");
                }
                await CargarInstrucciones();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Agregar una Instruccion");
            }
        }

        private void DgInstrucciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                _id = Convert.ToInt32(dgInstrucciones.Rows[e.RowIndex].Cells["Id"].FormattedValue);
                txtInstruccion.Text = dgInstrucciones.Rows[e.RowIndex].Cells["Paso"].FormattedValue.ToString();

                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }

        }
    }
}
