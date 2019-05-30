using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Imagen
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Url { get; set; }
        public DateTime fechaCreacion { get; set; }
        public bool Principal { get; set; }
        public bool Activo { get; set; }

        public int Orden { get; set; }

        public Bitmap Img { get; set; }
    }
}
