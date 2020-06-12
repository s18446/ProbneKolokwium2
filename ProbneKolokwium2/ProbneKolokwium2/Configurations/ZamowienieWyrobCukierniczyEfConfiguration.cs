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
            builder.HasOne(e => e.WyrobCukierniczy).WithMany().HasForeignKey(e => e.IdWyrobCukierniczy);
            builder.HasOne(e => e.Zamowienie).WithMany().HasForeignKey(e => e.IdZamowienie);
            builder.Property(e => e.Uwagi).HasMaxLength(300);

            var list = new List<ZamowienieWyrobCukierniczy>();

            list.Add(new ZamowienieWyrobCukierniczy
            {
                IdWyrobCukierniczy = 2,
                IdZamowienie = 1,
                Ilosc = 1,
                Uwagi = "na urodziny"
            });

            list.Add(new ZamowienieWyrobCukierniczy
            {
                IdWyrobCukierniczy = 1,
                IdZamowienie = 2,
                Ilosc = 11,
                Uwagi = "jakies tam"
            });

            builder.HasData(list);
        }
    }
}
