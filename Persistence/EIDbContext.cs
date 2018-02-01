using Microsoft.EntityFrameworkCore;
using WebDev.Models;

namespace WebDev.Persistence
{
    public class EIDbContext : DbContext
    {
        public EIDbContext(DbContextOptions<EIDbContext> options)
            : base(options)
        {
        }

        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<PromoCode> PromoCode { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Venta> Venta { get; set; }
    }
}
