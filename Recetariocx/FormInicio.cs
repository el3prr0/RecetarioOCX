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
    public partial class FormInicio : MetroFramework.Forms.MetroForm
    {
        SeedDataBase seed;
        private readonly string nombredb;
        private readonly string pathdb;
        private readonly string pathImagen;
        public FormInicio()
        {
            InitializeComponent();
            seed = new SeedDataBase();

            nombredb = ConfigurationManager.AppSettings["BaseDatosNombre"].ToString();
            pathdb = ConfigurationManager.AppSettings["UrlBaseDAtos"].ToString();
            pathImagen = ConfigurationManager.AppSettings["UrlImagen"].ToString();
        }

        private async void FormInicio_Load(object sender, EventArgs e)
        {
            if (!File.Exists(pathdb + nombredb + ".db"))
            {
                Directory.CreateDirectory(pathdb);
                Directory.CreateDirectory(pathImagen);
                await seed.CreaBaseDatos();
                await seed.AgregarUsuarioAdmin();
                await seed.CargarCatalogos();
            }
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            metroProgressBar1.Increment(1);
            if (metroProgressBar1.Value == 100) {
                this.Close();
            }
        }
    }
}
