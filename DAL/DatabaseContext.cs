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
        //public DbSet<User> Users{ get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Service>().HasIndex(s => s.Name).IsUnique();
        //}

    }
}
