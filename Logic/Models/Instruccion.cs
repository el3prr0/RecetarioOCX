using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Instruccion
    {
        private string _paso = string.Empty;
        public int Id { get; set; }
        public int ProductoId { get; set; }

        public int Orden { get; set; } = 0;

        public bool Activo { get; set; }

        public string PasoDB { get; set; }
        public string Paso { get => _paso.Contains("Paso")? _paso: $"Paso {Orden}:" +_paso ; set => _paso = value; }
    }
}
