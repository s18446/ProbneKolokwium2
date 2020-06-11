using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProbneKolokwium2.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbneKolokwium2.Models
{
    public class CukierniaDbContext : DbContext
    {
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Pracownik> Pracownicy { get; set; }
        public DbSet<WyrobCukierniczy> WyrobCukierniczy { get; set; }
        public DbSet<Zamowienie> Zamowienie { get; set; }
        public DbSet<ZamowienieWyrobCukierniczy> ZamowienieWyrobCukierniczy { get; set; }
        public CukierniaDbContext() { }
        public CukierniaDbContext(DbContextOptions options)
            : base(options) { 
        

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new KlientEfConfiguration());
            modelBuilder.ApplyConfiguration(new PracownikEfConfiguration());
            modelBuilder.ApplyConfiguration(new WyrobCukierniczyEfConfiguration());
            modelBuilder.ApplyConfiguration(new ZamowienieEfConfiguration());
            modelBuilder.ApplyConfiguration(new ZamowienieWyrobCukierniczyEfConfiguration());
        }
    }
}
