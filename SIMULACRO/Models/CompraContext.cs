using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SIMULACRO.Models
{
    public class CompraContext : DbContext
    {
        public DbSet<SolicitudCompra> SolicitudCompra { get; set; }
        public CompraContext(DbContextOptions dco) : base(dco) {

        }
    }
}