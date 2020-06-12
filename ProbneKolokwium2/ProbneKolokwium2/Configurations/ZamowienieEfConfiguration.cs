using Microsoft.AspNetCore.Routing;
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
            builder.HasOne(e => e.Pracownik).WithMany().HasForeignKey(e => e.IdPracownik);
            builder.HasOne(e => e.Klient).WithMany().HasForeignKey(e => e.IdKlient);

            builder.Property(e => e.Uwagi).HasMaxLength(300);

            var list = new List<Zamowienie>();

            list.Add(new Zamowienie
            {
                DataPrzyjecia = new DateTime(2020, 6, 10),
                DataRealizacji = new DateTime(2020, 6, 12),
                IdKlient = 1,
                IdZamowienie = 1,
                IdPracownik = 2,
                Uwagi = "na urodziny"
            });

            list.Add(new Zamowienie
            {
                DataPrzyjecia = new DateTime(2020, 4, 11),
                DataRealizacji = new DateTime(2020, 4, 11),
                IdKlient = 2,
                IdZamowienie = 2,
                IdPracownik = 1,
                Uwagi = "No cos tam"
            });

            builder.HasData(list);

        }
    }
}
