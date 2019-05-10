using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Unidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Valor { get; set; }

        public bool Activo { get; set; }
    }
}
