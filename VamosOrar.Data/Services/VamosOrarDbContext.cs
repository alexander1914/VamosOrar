using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VamosOrar.Data.Models;

namespace VamosOrar.Data.Services
{
    public class VamosOrarDbContext : DbContext
    {
        public DbSet<PedidosOracoes> PedidosOracoes { get; set; }
    }
}
