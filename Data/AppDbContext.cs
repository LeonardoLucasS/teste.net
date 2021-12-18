using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.Controllers;

namespace teste.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().Property(p => p.Name).HasMaxLength(80);
            modelBuilder.Entity<Produto>().Property(p => p.Value).HasPrecision(10,2);
            modelBuilder.Entity<Produto>()
            .HasData(
                new Produto {Id = 1, Name = "TV SMART", Value = 500},
                new Produto {Id = 2, Name = "NOTEBOOK", Value = 300},
                new Produto {Id = 3, Name = "TABLET", Value = 200} );
        }

    }
}