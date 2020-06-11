using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProbneKolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbneKolokwium2.Configurations
{
    public class WyrobCukierniczyEfConfiguration : IEntityTypeConfiguration<WyrobCukierniczy>
    {
        public void Configure(EntityTypeBuilder<WyrobCukierniczy> builder)
        {
            builder.HasKey(e => e.IdWyrobuCukierniczego);

            builder.Property(e => e.Nazwa).HasMaxLength(200);

            builder.Property(e => e.Typ).HasMaxLength(40);
        }
    }
}
