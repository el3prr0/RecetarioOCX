﻿using Logic.Models;
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
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        ProductoRepository _productoRepository;
        IngredienteRepository _IngredienteRepository;
        InstruccionRepository _InstruccionRepository;
        ImagenRepository _ImagenRepository;
        private int selected = 0;
        private string[] folderFile = null;
        public FormMain()
        {
            InitializeComponent();
            _productoRepository = new ProductoRepository();
            _IngredienteRepository = new IngredienteRepository();
            _InstruccionRepository = new InstruccionRepository();
            _ImagenRepository = new ImagenRepository();
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

        private async void ListProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var producto = (Producto)listProductos.SelectedItem;
            if(producto != null)
            {
                await CargarListas(producto.Id);
                txtGuarnicion.Text = producto.Guarnicion;
            }
            
        }


        private async Task CargarListas(int productoId)
        {
            var ingredientes = await _IngredienteRepository.GetWithProduct(productoId);

            listIngredientes.Items.Clear();

            foreach (Ingrediente ingrediente in ingredientes)
            {
                listIngredientes.Items.Add(ingrediente.Reglon);
            }


            var instrucciones = await _InstruccionRepository.GetWithProduct(productoId);
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
                folderFile[i] = imagen.Url;
                i++;
            }
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
        }

        private async void TxtProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtProducto.Text.Trim().Length > 0)
            {
                await BuscarProductos(txtProducto.Text.Trim().ToUpper());
            }
            else
            {
                await BuscarProductos("");
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

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text.Length > 0)
            {
                txtProducto.Text = txtProducto.Text.TrimEnd(txtProducto.Text[txtProducto.Text.Length - 1]);
            }
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "Q";
        }

        private void BtnW_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "W";
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "E";
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "R";
        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "T";
        }

        private void Y_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "Y";
        }

        private void BtnU_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "U";
        }

        private void BtnI_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "I";
        }

        private void BtnO_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "O";
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "A";
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "S";
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "D";
        }

        private void BtnF_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "F";
        }

        private void BtnG_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "G";
        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "H";
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "J";
        }

        private void BtnK_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "K";
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "P";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtProducto.Text = string.Empty;
        }

        private void BtnZ_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "Z";
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "X";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "C";
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "V";
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "B";
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "N";
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "M";
        }

        private void BtnÑ_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "Ñ";
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            txtProducto.Text += "L";
        }

        private void BtnSpace_Click(object sender, EventArgs e)
        {
            txtProducto.Text += " ";
        }

        private void ListInstrucciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Paso = listInstrucciones.SelectedItem;
            if( Paso != null)
            {
                metroToolTip1.SetToolTip(listInstrucciones, Paso.ToString());
            }
            
        }
    }
}
