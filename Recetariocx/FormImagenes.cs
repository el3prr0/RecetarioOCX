using Logic.Helpers;
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
    public partial class FormImagenes : MetroFramework.Forms.MetroForm
    {
        private readonly int _productoId;
        private readonly string _nombre;
        ImagenRepository _imagenRepository;

        private string Url = ConfigurationManager.AppSettings["UrlImagen"].ToString();

        public FormImagenes(int productoId,string nombre)
        {
            InitializeComponent();
            _productoId = productoId;
            _nombre = nombre;
            _imagenRepository = new ImagenRepository();
        }

        private async Task CargarImagenes()
        {
            
            var Imagenes = await _imagenRepository.GetWithProduct(_productoId);
            
            foreach(Imagen imagen in Imagenes)
            {
                if (imagen.Orden == 1)
                {
                    pbImagen1.Image = Image.FromFile(Url+imagen.Nombre);
                    
                    btnEliminar1.Enabled = true;
                    btnAgregar1.Enabled = false;
                }

                if(imagen.Orden == 2)
                {
                    pbImagen2.Image = Image.FromFile(Url+imagen.Nombre);
                    btnEliminar2.Enabled = true;
                    
                    btnAgregar2.Enabled = false;
                }

                if(imagen.Orden == 3)
                {
                    pbImagen3.Image = Image.FromFile(Url+imagen.Nombre);
                    btnEliminar3.Enabled = true;
                    btnAgregar3.Enabled = false;
                }
                
            }
           
            

        }



        private async  void FormImagenes_Load(object sender, EventArgs e)
        {
            lblNombre.Text = _nombre;
            await CargarImagenes();
        }


        private async void BtnAgregar1_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivo JPG|*.jpg";

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
               
                var imagenBit = ImagenesHelper.ResizeImage(new Bitmap(BuscarImagen.FileName), 600, 600);
               

                var Guardo = await _imagenRepository.Add(new Imagen
                {
                    ProductoId = _productoId,
                    Nombre = _nombre + "_1.jpg",
                    Url = Url + _nombre + "_1.jpg",
                    Orden = 1
                });
                if (Guardo)
                {
                    pbImagen1.Image = null;
                    if (File.Exists(Url + _nombre + "_1.jpg"))
                    {
                        File.Delete(Url + _nombre + "_1.jpg");
                    }
                    pbImagen1.Image = imagenBit;
                    pbImagen1.Image.Save(Url + _nombre + "_1.jpg");
                    imagenBit.Dispose();
                    btnEliminar1.Enabled = true;
                    btnAgregar1.Enabled = false;
                }
            } 
        }

        private async void BtnAgregar2_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivo JPG|*.jpg";

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                var imagenBit = ImagenesHelper.ResizeImage(new Bitmap(BuscarImagen.FileName), 600, 600);
                


                var Guardo = await _imagenRepository.Add(new Imagen
                {
                    ProductoId = _productoId,
                    Nombre = _nombre + "_2.jpg",
                    Url = Url + _nombre + "_2.jpg",
                    Orden = 2
                });
                if (Guardo)
                {
                    pbImagen2.Image = null;
                    if (File.Exists(Url + _nombre + "_2.jpg"))
                    {
                        File.Delete(Url + _nombre + "_2.jpg");
                    }
                    pbImagen2.Image = imagenBit;
                    pbImagen2.Image.Save(Url + _nombre + "_2.jpg");
                    imagenBit.Dispose();
                    btnEliminar2.Enabled = true;
                    btnAgregar2.Enabled = false;
                }
            }
        }

        private async void BtnAgregar3_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivo JPG|*.jpg";

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                var imagenBit = ImagenesHelper.ResizeImage(new Bitmap(BuscarImagen.FileName), 600, 600);
                
                var Guardo = await _imagenRepository.Add(new Imagen
                {
                    ProductoId = _productoId,
                    Nombre = _nombre + "_3.jpg",
                    Url = Url + _nombre + "_3.jpg",
                    Orden = 3
                });
                if (Guardo)
                {
                    pbImagen3.Image = null;
                    if (File.Exists(Url + _nombre + "_3.jpg"))
                    {
                        File.Delete(Url + _nombre + "_3.jpg");
                    }
                    pbImagen3.Image = imagenBit;
                    pbImagen3.Image.Save(Url + _nombre + "_3.jpg");
                    imagenBit.Dispose();
                    btnEliminar3.Enabled = true;
                    btnAgregar3.Enabled = false;
                }
            }


            
        }

        private async void BtnEliminar1_Click(object sender, EventArgs e)
        {
            var imagenes = await _imagenRepository.GetWithProduct(_productoId);
            var Id = imagenes.FirstOrDefault(i => i.Nombre == _nombre + "_1.jpg").Id;

            if (Id > 0)
            {
                
                
                pbImagen1.Image.Dispose();
                try
                {
                    if (await _imagenRepository.Delete(Id))
                    {
                        if (File.Exists(Url + _nombre + "_1.jpg"))
                        {
                            File.Delete(Url + _nombre + "_1.jpg");
                        }
                        pbImagen1.Image = null;
                    }

                }
                catch (IOException ioExp)
                {
                    Console.WriteLine(ioExp.Message);
                }
            }
            btnAgregar1.Enabled = true;
            btnEliminar1.Enabled = false;
        }

        private async void BtnEliminar2_Click(object sender, EventArgs e)
        {
            var imagenes = await _imagenRepository.GetWithProduct(_productoId);
            var Id = imagenes.FirstOrDefault(i => i.Nombre == _nombre + "_2.jpg").Id;

            if (Id > 0)
            {
                
                
                pbImagen2.Image.Dispose();
                try
                {
                    if (await _imagenRepository.Delete(Id))
                    {
                        if (File.Exists(Url + _nombre + "_2.jpg"))
                        {
                            File.Delete(Url + _nombre + "_2.jpg");
                        }
                        pbImagen2.Image = null;
                    }

                }
                catch (IOException ioExp)
                {
                    Console.WriteLine(ioExp.Message);
                }
            }
            btnAgregar2.Enabled = true;
            btnEliminar2.Enabled = false;
        }

        private async void BtnEliminar3_Click(object sender, EventArgs e)
        {
            var imagenes = await _imagenRepository.GetWithProduct(_productoId);
            var Id = imagenes.FirstOrDefault(i => i.Nombre == _nombre + "_3.jpg").Id;

            if (Id > 0)
            {
                //pbImagen3.Image = null;
                pbImagen3.Image.Dispose();
                try {
                    if (await _imagenRepository.Delete(Id))
                    {

                        if (File.Exists(Url + _nombre + "_3.jpg"))
                        {
                            File.Delete(Url + _nombre + "_3.jpg");
                        }

                        pbImagen3.Image = null;
                    }

                }
                catch (IOException ioExp)
                {
                    Console.WriteLine(ioExp.Message);
                }
                
                
            }
            btnAgregar3.Enabled = true;
            btnEliminar3.Enabled = false;
        }
    }
}
