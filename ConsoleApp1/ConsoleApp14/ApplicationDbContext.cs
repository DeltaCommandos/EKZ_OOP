using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql;


namespace ConsoleApp14
{

    public class ApplicationDbContext: DbContext
    {
       
        public DbSet<Language> Languages { get; set; }
        public DbSet<Family> Families { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseNpgsql("Host=localhost;Database=E14;Username=postgres;Password=123")
                .UseLazyLoadingProxies();
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Family>()
        //        .HasMany(f => f.Languages)
        //        .WithOne(l => l.Family)
        //        .HasForeignKey(l => l.IDFamily);
        //}

    }
}
