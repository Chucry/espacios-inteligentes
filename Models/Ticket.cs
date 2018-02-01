using System;
using System.Collections.Generic;

namespace WebDev.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public int PromoCodeId { get; set; }
        public virtual PromoCode PromoCode { get; set; }
        public DateTime FechaCompra { get; set; }
        public IList<Venta> Ventas { get; set; }
    }
}
