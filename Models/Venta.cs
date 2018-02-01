using System;

namespace WebDev.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public int LockerId { get; set; }
        public Locker Locker { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public int Tipo { get; set; }
        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
