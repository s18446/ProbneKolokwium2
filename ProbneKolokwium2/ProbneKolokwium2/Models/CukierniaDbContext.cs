using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbneKolokwium2.Models
{
    public class CukierniaDbContext : DbContext
    {
        public DbSet<Klient> Klienci { get; set; }

        public CukierniaDbContext(DbContextOptions options)
            : base(options) { 
        

        }
    }
}
