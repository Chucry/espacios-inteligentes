namespace WebDev.Models
{
    public class Locker
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Alto { get; set; }
        public int Largo { get; set; }
        public int Ancho { get; set; }
        public int SucursalId { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public int PrecioUnitario { get; set; }
    }
}
