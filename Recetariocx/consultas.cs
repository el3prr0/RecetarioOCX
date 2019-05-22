using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Printing;
using Logic.Repository;
using Logic.Models;
using System.IO;
//using Microsoft.Office.Interop.Excel;

namespace Recetariocx
{
    public partial class consultas : MetroFramework.Forms.MetroForm
    {
        int _productoId = 0;
        string _nombre = string.Empty;

        ProductoRepository _productoRepository;
        ImagenRepository _imagenRepository;
        IngredienteRepository _ingredienteRepository;
        InstruccionRepository _instruccionRepository;
        public consultas()
        {
            InitializeComponent();
        }

        private async void consultas_Load(object sender, EventArgs e)
        {
            _productoRepository = new ProductoRepository();
            _imagenRepository = new ImagenRepository();
            _ingredienteRepository = new IngredienteRepository();
            _instruccionRepository = new InstruccionRepository();

            await CargarProductos();
        }

        private async Task<bool> Eliminar()
        {
            var Imagenes = await _imagenRepository.GetWithProduct(_productoId);
            foreach (Imagen imagen in Imagenes)
            {
                if(await _imagenRepository.Delete(imagen.Id))
                {
                    File.Delete(imagen.Url);
                }
            }

            var Instrucciones = await _instruccionRepository.GetWithProduct(_productoId);
            foreach(Instruccion instruccion in Instrucciones)
            {
                await _instruccionRepository.Delete(instruccion.Id);
            }

            var Ingredientes = await _ingredienteRepository.GetWithProduct(_productoId);
            foreach(Ingrediente ingrediente in Ingredientes)
            {
                await _ingredienteRepository.Delete(ingrediente.Id);
            }

            return await _productoRepository.Delete(_productoId);
            
            
        }
        private async Task CargarProductos()
        {
             var productos = await _productoRepository.GetAll();
            CargarADataGrid(productos);


        }
        private async Task CargarProducto(string producto)
        {
            var productos = await _productoRepository.Get(producto);
            CargarADataGrid(productos);
        }

        private void CargarADataGrid(IEnumerable<Producto> productos)
        {
            dtProductos.DataSource = productos;
            dtProductos.Columns["Id"].Visible = false;
            dtProductos.Columns["Activo"].Visible = false;
            dtProductos.Columns["ImagenPrincipal"].Visible = false;
            dtProductos.Columns["Nombre"].Width = 500;

            DesabilitarBotones();

        }


        private void DesabilitarBotones()
        {
            _productoId = 0;
            _nombre = string.Empty;

            txtNombre.Text = string.Empty;
            txtGuarnicion.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            nmPrecio.Value = 0;

            btnEliminar.Enabled = false;
            btnmodificar.Enabled = false;

            btnInstrucciones.Enabled = false;
            btnImagenes.Enabled = false;
            btnIngredientes.Enabled = false;
        }

        private async void Btnmodificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 0)
            {
                await _productoRepository.Save(new Producto { Id = _productoId, Nombre = txtNombre.Text.Trim().ToUpper(), Guarnicion = txtGuarnicion.Text.Trim().ToUpper(),Precio = nmPrecio.Value,Descripcion=txtDescripcion.Text.Trim().ToUpper() });
                DesabilitarBotones();
                await CargarProductos();
            }

        }

        private void BtnIngredientes_Click(object sender, EventArgs e)
        {
            FormIngredientes formIngredientes = new FormIngredientes(_productoId, _nombre);
            formIngredientes.ShowDialog();
            DesabilitarBotones();
        }

        private void BtnImagenes_Click(object sender, EventArgs e)
        {
            FormImagenes formImagenes = new FormImagenes(_productoId, _nombre);
            formImagenes.ShowDialog();
            DesabilitarBotones();
        }

        private async void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text.Trim().Length > 0)
            {
                await CargarProducto(txtFiltro.Text.Trim().ToUpper());
            }
            else
            {
                await CargarProducto("");
            }
        }

        private void BtnInstrucciones_Click(object sender, EventArgs e)
        {

            FormInstrucciones formInstrucciones = new FormInstrucciones(_productoId, _nombre);
            formInstrucciones.ShowDialog();
            DesabilitarBotones();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            var dialogResult = MetroFramework.MetroMessageBox.Show(this,"\n\nEliminar Producto", "Se Eliminar el producto con sus ingredientes, imagenes e instrucciones relacionadas.",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (await Eliminar())
                {
                    MetroFramework.MetroMessageBox.Show(this,"Se Elimino Producto");

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Ocurrio un problema");
                }
                DesabilitarBotones();
                await CargarProductos();
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void DtProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _productoId = Convert.ToInt32(dtProductos.Rows[e.RowIndex].Cells["Id"].FormattedValue);
                _nombre = dtProductos.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();

                txtNombre.Text = _nombre;
                txtGuarnicion.Text = dtProductos.Rows[e.RowIndex].Cells["Guarnicion"].FormattedValue.ToString();
                txtDescripcion.Text = dtProductos.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString();
                nmPrecio.Value = Convert.ToDecimal(dtProductos.Rows[e.RowIndex].Cells["Precio"].FormattedValue);

                btnmodificar.Enabled = true;
                btnEliminar.Enabled = true;

                btnInstrucciones.Enabled = true;
                btnImagenes.Enabled = true;
                btnIngredientes.Enabled = true;
                btnmodificar.Enabled = true;
            }
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            altas altas = new altas();
            altas.ShowDialog();
            await CargarProductos();
        }


    }

}
