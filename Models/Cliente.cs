using System;

namespace WebDev.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NumeroContacto { get; set; }
        public int MunicipioId { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}
