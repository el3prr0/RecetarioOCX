using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Guarnicion { get; set; }
        public int Grupo { get; set; }
        public string ImagenPrincipal { get; set; }
        public int Clave { get; set; }
        public int SubGrupo { get; set; }
        public bool Activo { get; set; }
    }
}
