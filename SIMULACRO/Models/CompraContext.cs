using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SIMULACRO.Models
{
    public class AdopcionContext : DbContext
    {
        public DbSet<SolicitudCompra> SolicitudesAdopcion { get; set; }
        public AdopcionContext(DbContextOptions dco) : base(dco) {

        }
    }
}