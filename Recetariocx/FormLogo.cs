using Logic.Helpers;
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
    public partial class FormLogo : MetroFramework.Forms.MetroForm
    {
        private readonly string  imagenpath;
        public FormLogo()
        {
            InitializeComponent();
            imagenpath = ConfigurationManager.AppSettings["LogoPath"].ToString();
        }

        private void FormLogo_Load(object sender, EventArgs e)
        {
            if (File.Exists(imagenpath))
            {
                pbLogo.Image = Image.FromFile(imagenpath);
            }
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos Imagenes (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                
                var imagenBit = ImagenesHelper.ResizeImage(new Bitmap(BuscarImagen.FileName), 400, 200);
                pbLogo.Image = null;

                if (File.Exists(imagenpath))
                {
                    File.Delete(imagenpath);
                }
                pbLogo.Image = imagenBit;
                pbLogo.Image.Save(imagenpath);
            }
        }
        
    }
}
