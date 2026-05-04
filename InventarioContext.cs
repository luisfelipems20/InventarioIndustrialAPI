using InventarioIndustrialAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioIndustrialAPI
{
    public class InventarioContext : DbContext
    {
        public InventarioContext(DbContextOptions<InventarioContext> options)
            : base(options) { }

        public DbSet<Repuesto> Repuestos { get; set; }
    }
}