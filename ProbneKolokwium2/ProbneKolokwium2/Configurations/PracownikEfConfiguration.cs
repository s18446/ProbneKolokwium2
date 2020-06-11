using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProbneKolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbneKolokwium2.Configurations
{
    public class PracownikEfConfiguration : IEntityTypeConfiguration<Pracownik>
    {
        public void Configure(EntityTypeBuilder<Pracownik> builder)
        {
            builder.HasKey(e => e.IdPracownik);

            builder.Property(e => e.Imie).HasMaxLength(50);

            builder.Property(e => e.Nazwisko).HasMaxLength(60);
        }
    }
}
