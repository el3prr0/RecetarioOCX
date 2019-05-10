namespace Logic.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Unidad { get; set; }
        public int Cantidad { get; set; }


        public string Reglon { get { return Nombre + " " + Cantidad.ToString() +" "+Unidad; } }

        public bool Activo { get; set; }
    }
}