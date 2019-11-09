using Logic.Models;
using Logic.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recetariocx
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        ProductoRepository _productoRepository;
        IngredienteRepository _IngredienteRepository;
        InstruccionRepository _InstruccionRepository;
        ImagenRepository _ImagenRepository;
        IEnumerable<Instruccion> instrucciones;
        private int selected = 0;
        private string[] folderFile = null;
        private readonly string imagenpath;
        private string Url = ConfigurationManager.AppSettings["UrlImagen"].ToString();
        public int Vproductid;
        
        public FormMain()
        {
            InitializeComponent();
            _productoRepository = new ProductoRepository();
            _IngredienteRepository = new IngredienteRepository();
            _InstruccionRepository = new InstruccionRepository();
            _ImagenRepository = new ImagenRepository();
            imagenpath = ConfigurationManager.AppSettings["LogoPath"].ToString();
        }


        private async Task BuscarProductos(string filtro)
        {
            var productos = await _productoRepository.Get(filtro);

            listProductos.Items.Clear();
            timer1.Enabled = false;
            pbImagenes.Image = null;

            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnTimer.Enabled = false;
            btnTimer.Text = "Comenzar";
            listProductos.DisplayMember = "Nombre";
            listProductos.ValueMember = "Id";
            foreach(Producto producto in productos)
            {
                listProductos.Items.Add(producto);
            }
        }

        public async void ListProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var producto = (Producto)listProductos.SelectedItem;
            if(producto != null)
            {
                await CargarListas(producto.Id);
                txtGuarnicion.Text = producto.Guarnicion;
                Vproductid = producto.Id;                
            }
            
        }


        public async Task CargarListas(int productoId)
        {
            var ingredientes = await _IngredienteRepository.GetWithProduct(productoId);
            timer1.Enabled = false;
            listIngredientes.Items.Clear();

            foreach (Ingrediente ingrediente in ingredientes)
            {
                listIngredientes.Items.Add(ingrediente.Reglon);
            }


            instrucciones = await _InstruccionRepository.GetWithProduct(productoId);
            listInstrucciones.Items.Clear();
            foreach(Instruccion instruccion in instrucciones)
            {
                listInstrucciones.Items.Add(instruccion.Paso);
            }

            var Imagenes = await _ImagenRepository.GetWithProduct(productoId);
            folderFile = new string[Imagenes.Count()];
            int i = 0;
            foreach (Imagen imagen in Imagenes)
            {
                folderFile[i] = Url+imagen.Nombre;
                i++;
            }
            selected = 0;
            showImage(folderFile[selected]);
            timer1.Enabled = true;

            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnTimer.Enabled = true;
            btnTimer.Text = "Detener";
        }

        private void showImage(string path)
        {
            Image imgtemp = Image.FromFile(path);

            pbImagenes.Image = imgtemp;
        }

        private void nextImage()
        {
            if (selected == folderFile.Length - 1)
            {
                selected = 0;
                showImage(folderFile[selected]);
            }
            else
            {
                selected = selected + 1; showImage(folderFile[selected]);
            }
        }

        private void prevImage()
        {
            if (selected == 0)
            {
                selected = folderFile.Length - 1;
                showImage(folderFile[selected]);
            }
            else
            {
                selected = selected - 1; showImage(folderFile[selected]);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            nextImage();
        }




        private async void FormMain_Load(object sender, EventArgs e)
        {
            await BuscarProductos("");
             CargarLogo();
        }

        private void CargarLogo()
        {
            if (File.Exists(imagenpath))
            {
                pbLogo.Image = Image.FromFile(imagenpath);
            }
        }



        private void BtnTimer_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                btnTimer.Text = "Comenzar";
            }
            else
            {
                timer1.Enabled = true;
                btnTimer.Text = "Detener";
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            nextImage();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            prevImage();
        }

        

        private void ListInstrucciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Paso = listInstrucciones.SelectedItem;
            if( Paso != null)
            {
                metroToolTip1.SetToolTip(listInstrucciones, Paso.ToString());
            }
            
        }

        private void txtProducto_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            pbLogo.Image.Dispose();
            pbLogo.Image = null;
        }

        private async void TxtProducto_TextChanged_1(object sender, EventArgs e)
        {
            if (txtProductoOK.Text.Trim().Length > 0)
            {
                await BuscarProductos(txtProductoOK.Text.Trim().ToUpper());
            }
            else
            {
                await BuscarProductos("");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtProductoOK.Text.Length > 0)
            {
                txtProductoOK.Text = txtProductoOK.Text.TrimEnd(txtProductoOK.Text[txtProductoOK.Text.Length - 1]);

                txtProductoOK.Focus();
            }
        }

        private void PbImagenes_MouseMove(object sender, MouseEventArgs e)
        {
            agrandaimg();

        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            pbImagenes.Height = 220;
            pbImagenes.Width = 350;

            //location de img
            pbImagenes.Top = 280;
            pbImagenes.Left = 15;
        }

        private void agrandaimg()
        {
            pbImagenes.Height = 400;
            pbImagenes.Width = 600;

            //location de img
            pbImagenes.Top= 200;
            pbImagenes.Left = 15;

        }

        private void PbImagenes_Click(object sender, EventArgs e)
        {
            agrandaimg();
        }

        private void ListInstrucciones_DoubleClick(object sender, EventArgs e)
        {
            Formdialog FRM = new Formdialog(instrucciones);
            FRM.ShowDialog();
            
        }
    }
}

