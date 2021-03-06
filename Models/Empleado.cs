using System;

namespace WebDev.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
        public string Puesto { get; set; }
        public DateTime FechaContratacion { get; set; }
        public DateTime? FechaTerminacion { get; set; }
        public decimal SueldoBase { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string Curp { get; set; }
        public string Clabe { get; set; }

        public Empleado()
        {
            Departamento = new Departamento();
        }
    }
}