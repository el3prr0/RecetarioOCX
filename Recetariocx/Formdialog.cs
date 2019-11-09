using Logic.Models;
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
    public partial class Formdialog : Form
    {
        private readonly IEnumerable<Instruccion> instrucciones;

        public Formdialog(IEnumerable<Instruccion> instrucciones)
        {
            InitializeComponent();
            this.instrucciones = instrucciones;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             this.DialogResult = DialogResult.Cancel;
           
        }

        private void Formdialog_Load(object sender, EventArgs e)
        {
            foreach (var item in instrucciones) {
                this.listBox1.Items.Add(item.Paso);
            }
        }
    }
}
