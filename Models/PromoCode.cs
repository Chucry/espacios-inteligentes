using System;

namespace WebDev.Models
{
    public class PromoCode
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Tipo { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime Expiracion { get; set; }
        public Empleado UsuarioCreador { get; set; }
    }
}
