using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProbneKolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbneKolokwium2.Configurations
{
    public class ZamowienieWyrobCukierniczyEfConfiguration : IEntityTypeConfiguration<ZamowienieWyrobCukierniczy>
    {
        public void Configure(EntityTypeBuilder<ZamowienieWyrobCukierniczy> builder)
        {
            builder.HasKey(e => new { e.IdWyrobCukierniczy, e.IdZamowienie });
            builder.Property(e => e.Uwagi).HasMaxLength(300);
        }
    }
}
