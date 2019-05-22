using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

        public string Nivel { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }
        public string Telefono { get; set; }
    }
}
