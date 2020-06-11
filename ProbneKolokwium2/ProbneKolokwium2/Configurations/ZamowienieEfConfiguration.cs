using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProbneKolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbneKolokwium2.Configurations
{
    public class ZamowienieEfConfiguration : IEntityTypeConfiguration<Zamowienie>
    {
        public void Configure(EntityTypeBuilder<Zamowienie> builder)
        {
            builder.HasKey(e => e.IdZamowienie);

            builder.Property(e => e.Uwagi).HasMaxLength(300);
        }
    }
}
