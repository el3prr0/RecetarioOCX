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
using Logic.Models;
using Logic.Repository;
using System.Configuration;
using Logic.Helpers;

namespace Recetariocx
{
   
    public partial class altas : MetroFramework.Forms.MetroForm
    {
        
        Producto _producto;
        List<Ingrediente> _Ingredientes;
        List<Instruccion> _Instrucciones;
        List<Imagen> _Imagenes;


        UnidadRepository _unidadRepository;
        ProductoRepository _productoRepository;
        ImagenRepository _imagenRepository;
        IngredienteRepository _ingredienteRepository;
        InstruccionRepository _instruccionRepository;

        Instruccion _instruccion;
        Ingrediente _ingrediente;

        AutoCompleteStringCollection coll;


        private string Url = ConfigurationManager.AppSettings["UrlImagen"].ToString();

        public altas()
        {
            InitializeComponent();

            _producto = new Producto();
            _Ingredientes = new List<Ingrediente>();
            _Instrucciones = new List<Instruccion>();
            _productoRepository = new ProductoRepository();
            _instruccionRepository = new InstruccionRepository();
            _imagenRepository = new ImagenRepository();
            _ingredienteRepository = new IngredienteRepository();
            _Imagenes = new List<Imagen>();
            coll = new AutoCompleteStringCollection();
        }

        private async void altas_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();

            await CargaUnidades();
            await AutoComplete();

        }

 

        private async Task GuardarProducto()
        {
            

            try
            {
                if(await _productoRepository.Add(_producto))
                {
                    var producto = await _productoRepository.Get(_producto.Nombre);
                    var productoId = producto.OrderByDescending(i => i.Id).FirstOrDefault(p => p.Nombre == _producto.Nombre).Id;
                    if(productoId > 0)
                    {
                        foreach(Ingrediente ing in _Ingredientes)
                        {
                            ing.ProductoId = productoId;
                            await _ingredienteRepository.Add(ing);
                        }

                        foreach(Instruccion ins in _Instrucciones)
                        {
                            ins.ProductoId = productoId;
                            await _instruccionRepository.Add(ins);
                        }
                        foreach(Imagen img in _Imagenes)
                        {
                            img.ProductoId = productoId;
                            img.Nombre = _producto.Nombre + "_" + img.Nombre + ".jpg";
                            img.Url = Url + img.Nombre;
                            
                            if(await _imagenRepository.Add(img))
                            {
                                img.Img.Save(img.Url);
                            }
                        }
                    }
                    MetroFramework.MetroMessageBox.Show(this,"Se Creo un producto nuevo");
                }
                
                
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private async Task CargaUnidades()
        {
            _unidadRepository = new UnidadRepository();
            var unidades = await _unidadRepository.GetAll();
            cbUnidad.DataSource = unidades;
            cbUnidad.DisplayMember = "Nombre";
            cbUnidad.ValueMember = "Nombre";
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool SePuedeAgregar = true;
            if (txtNombre.Text.Trim().Length <= 0)
            {
                MetroFramework.MetroMessageBox.Show(this,"Introducir un nombre valido");
                SePuedeAgregar = false;
            }
            else
            {
                _producto.Nombre = txtNombre.Text.Trim().ToUpper();
                _producto.Guarnicion = txtGuarnicion.Text.Trim().ToUpper();
            }

            if (_Ingredientes.Count <= 0)
            {
                MetroFramework.MetroMessageBox.Show(this,"Agregar Ingedientes necesarios para la bebida");
                SePuedeAgregar = false;
            }

            if (_Instrucciones.Count <= 0)
            {
                MetroFramework.MetroMessageBox.Show(this,"Introducir un Instrucciones necesarias para preparar la bebida");
                SePuedeAgregar = false;
            }
            if (_Imagenes.Count <= 0)
            {
                MetroFramework.MetroMessageBox.Show(this,"Agregar por lo menos una imagen");
                SePuedeAgregar = false;
            }

            _producto.Descripcion = txtDescripcion.Text.Trim().ToUpper();
            _producto.Precio = nmPrecio.Value;

            if (SePuedeAgregar)
            {
                await GuardarProducto();
                this.Close();
            }
        }

        private void BtnAgregarInstruccion_Click(object sender, EventArgs e)
        {
            if (txtInstruccion.Text.Trim().Length > 1)
            {
                ListInstrucciones.Items.Clear();

                _Instrucciones.Add(new Instruccion { PasoDB = txtInstruccion.Text.ToUpper().Trim(), Paso = txtInstruccion.Text.ToUpper().Trim(), Orden = _Instrucciones.Count() + 1 });
                ListInstrucciones.DisplayMember = "Paso";
                foreach (Instruccion instruccion in _Instrucciones)
                {
                    ListInstrucciones.Items.Add(instruccion);
                }
                txtInstruccion.Text = string.Empty;
                
            }
        }

        private void BtnAgregarIngrediente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIngredienteNombre.Text.Trim()))
            {
                if (nmCantidad.Value > 0)
                {
                    listIngredientes.Items.Clear();
                    _Ingredientes.Add(new Ingrediente
                    {
                        Nombre = txtIngredienteNombre.Text.ToUpper().Trim(),
                        Cantidad = nmCantidad.Value,
                        Unidad = cbUnidad.Text.Trim()
                    });
                    listIngredientes.DisplayMember = "Reglon";
                    foreach (Ingrediente ingrediente in _Ingredientes)
                    {
                        listIngredientes.Items.Add(ingrediente);
                    }
                    txtIngredienteNombre.Text = " ";
                    nmCantidad.Value = 1;

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Ingresar una cantidad mayor a 0");
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Favor de agregar un ingrediente valido");
            }
        }

        private void BtnSubirFoto1_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivo JPG|*.jpg";

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {

                var imagenBit = ImagenesHelper.ResizeImage(new Bitmap(BuscarImagen.FileName), 600, 800);

                pbImagen1.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImagen1.Image = imagenBit;
                _Imagenes.Add(new Imagen { Nombre = "1", Img = imagenBit });

                btnSubirFoto1.Enabled = false;
                BtnRemoverImagen1.Enabled = true;

            }
            
        }

        private void BtnSubirFoto2_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivo JPG|*.jpg";



            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                var imagenBit = ImagenesHelper.ResizeImage(new Bitmap(BuscarImagen.FileName), 600, 800);
                pbImagen2.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImagen2.Image = imagenBit;
                _Imagenes.Add(new Imagen { Nombre = "2", Img = imagenBit });

                btnSubirFoto2.Enabled = false;
                BtnRemoverImagen2.Enabled = true;

            }
            
        }

        private void BtnSubirFoto3_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivo JPG|*.jpg";



            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                var imagenBit = ImagenesHelper.ResizeImage(new Bitmap(BuscarImagen.FileName), 600, 800);
                pbImagen3.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImagen3.Image = imagenBit;
                _Imagenes.Add(new Imagen { Nombre = "3", Img = imagenBit });

                btnSubirFoto3.Enabled = false;
                BtnRemoverImagen3.Enabled = true;
            }

            
        }

        private void BtnRemoverImagen1_Click(object sender, EventArgs e)
        {
            _Imagenes.RemoveAll(i => i.Nombre == "1");
            pbImagen1.Image = null;
            btnSubirFoto1.Enabled = true;
            BtnRemoverImagen1.Enabled = false;
        }

        private void BtnRemoverImagen2_Click(object sender, EventArgs e)
        {
            _Imagenes.RemoveAll(i => i.Nombre == "2");
            pbImagen2.Image = null;
            btnSubirFoto2.Enabled = true;
            BtnRemoverImagen2.Enabled = false;
        }

        private void BtnRemoverImagen3_Click(object sender, EventArgs e)
        {
            _Imagenes.RemoveAll(i => i.Nombre == "3");
            pbImagen3.Image = null;
            btnSubirFoto3.Enabled = true;
            BtnRemoverImagen3.Enabled = false;
        }

        private void BtnLimpiarIngredientes_Click(object sender, EventArgs e)
        {
            if (_Ingredientes.Count > 0)
            {
                if(_ingrediente.Nombre != null)
                {
                    _Ingredientes.Remove(_ingrediente);
                    listIngredientes.Items.Clear();
                    listIngredientes.DisplayMember = "Reglon";
                    foreach (Ingrediente ingrediente in _Ingredientes)
                    {

                        listIngredientes.Items.Add(ingrediente);
                    }
                }

            }
            btnLimpiarIngredientes.Enabled = false;
        }

        private void BtnLimpiarInstrucciones_Click(object sender, EventArgs e)
        {
            if (_Instrucciones.Count > 0)
            {
                if(_instruccion.Paso != null)
                {
                    _Instrucciones.Remove(_instruccion);
                    ListInstrucciones.Items.Clear();
                    ListInstrucciones.DisplayMember = "Paso";
                    int Orden = 1;
                    foreach (Instruccion instruccion in _Instrucciones)
                    {
                        _Instrucciones[Orden - 1].Orden = Orden;
                        ListInstrucciones.Items.Add(instruccion);
                        Orden++;
                    }
                }

            }
            btnLimpiarInstrucciones.Enabled = false;
        }

        private void ListIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ingrediente = new Ingrediente();
            
            _ingrediente = (Ingrediente)listIngredientes.SelectedItem;
            btnLimpiarIngredientes.Enabled = true;
        }

        private void ListInstrucciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            _instruccion = new Instruccion();
            _instruccion = (Instruccion)ListInstrucciones.SelectedItem;
            btnLimpiarInstrucciones.Enabled = true;
        }


        async Task AutoComplete()
        {
            var Ingredientes  =await _ingredienteRepository.GetAll();

            foreach (Ingrediente ingrediente in Ingredientes) {

                coll.Add(ingrediente.Nombre);

            }

            txtIngredienteNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtIngredienteNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtIngredienteNombre.AutoCompleteCustomSource = coll;
        }
    }
}
