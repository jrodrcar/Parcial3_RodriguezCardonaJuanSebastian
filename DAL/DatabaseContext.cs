using Microsoft.EntityFrameworkCore;
using Parcial3_RodriguezCardonaJuanSebastian.DAL.Entities;
using System.Diagnostics.Metrics;

namespace Parcial3_RodriguezCardonaJuanSebastian.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Service> Services { get; set; }

    }
}
