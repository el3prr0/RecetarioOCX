using Logic.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Recetariocx
{
    public partial class formmenu : MetroFramework.Forms.MetroForm
    {
        SeedDataBase seed;
        private readonly string nombredb;
        private readonly string pathdb;
        private readonly string pathImagen;

        private bool CanAccess = false;
        private bool IsAdmin = false;
        public formmenu()
        {
            InitializeComponent();
            seed = new SeedDataBase();

            nombredb = ConfigurationManager.AppSettings["BaseDatosNombre"].ToString();
            pathdb = ConfigurationManager.AppSettings["UrlBaseDAtos"].ToString();
            pathImagen =ConfigurationManager.AppSettings["UrlImagen"].ToString();
            IsAdmin = Convert.ToBoolean(ConfigurationManager.AppSettings["IA"].ToString());


        }


        private void consultarProductosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            consultas acts = new consultas();
            acts.MdiParent = this;
            acts.Show();
        }

        private void altaDeProductosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            altas acts = new altas();
            acts.MdiParent = this;
            acts.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda acts = new ayuda();
            acts.MdiParent = this;
            acts.Show();
        }


        private void BartTenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMain acts = new FormMain();
            acts.MdiParent = this;
            acts.Show();
        }


        private async  void CREARDATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, $"Desea crear una nueva base de datos?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MetroFramework.MetroMessageBox.Show(this, $"Informacion actual no se respaldara,\n aun desea crear una nueva base de datos?", "Notificacion", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    Directory.CreateDirectory(pathdb);
                    Directory.CreateDirectory(pathImagen);
                    await seed.CreaBaseDatos();
                    await seed.AgregarUsuarioAdmin();
                    await seed.CargarCatalogos();
                }
            }
        }



        private void UnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnidad formUnidad = new FormUnidad();
            formUnidad.MdiParent = this;
            formUnidad.Show();
        }

        private void AdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            CanAccess = formLogin.IsLogin;
            if (CanAccess)
            {

                switch (formLogin.Nivel)
                {
                    case "Administrador":
                        catalogosToolStripMenuItem.Visible = CanAccess;
                        configuracionToolStripMenuItem.Visible = CanAccess;
                        cerrarSessionToolStripMenuItem.Visible = CanAccess;
                        bartTenderToolStripMenuItem.Visible = CanAccess;
                        administradorToolStripMenuItem.Visible = !CanAccess;
                        break;
                    case "Cliente":
                        cerrarSessionToolStripMenuItem.Visible = CanAccess;
                        administradorToolStripMenuItem.Visible = !CanAccess;
                        break;
                    case "Empleado":
                        bartTenderToolStripMenuItem.Visible = CanAccess;
                        cerrarSessionToolStripMenuItem.Visible = CanAccess;
                        administradorToolStripMenuItem.Visible = !CanAccess;
                        break;
                    default:
                        CerrarSession();
                        break;
                }
            }
        }

        private void CerrarSession()
        {
            catalogosToolStripMenuItem.Visible = !CanAccess;
            bartTenderToolStripMenuItem.Visible = !CanAccess;
            configuracionToolStripMenuItem.Visible = !CanAccess;
            cerrarSessionToolStripMenuItem.Visible = !CanAccess;
            administradorToolStripMenuItem.Visible = CanAccess;
        }

        private void CerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarSession();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.MdiParent = this;
            formUsuarios.Show();
        }

        private void LOGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogo formLogo = new FormLogo();
            formLogo.ShowDialog();
        }

        private async void Formmenu_Load(object sender, EventArgs e)
        {
            if (!File.Exists(pathdb + nombredb + ".db"))
            {
                Directory.CreateDirectory(pathdb);
                Directory.CreateDirectory(pathImagen);
                await seed.CreaBaseDatos();
                await seed.AgregarUsuarioAdmin();
                await seed.CargarCatalogos();
            }
            administradorToolStripMenuItem.Enabled = IsAdmin;
            administradorToolStripMenuItem.Visible = IsAdmin;
        }

        private void VistaPreviaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.MdiParent = this;
            formCliente.Show();
        }
    }
}
