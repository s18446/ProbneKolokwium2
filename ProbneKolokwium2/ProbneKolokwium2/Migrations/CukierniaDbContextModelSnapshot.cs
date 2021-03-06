﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProbneKolokwium2.Models;

namespace ProbneKolokwium2.Migrations
{
    [DbContext(typeof(CukierniaDbContext))]
    partial class CukierniaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProbneKolokwium2.Models.Klient", b =>
                {
                    b.Property<int>("IdKlient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nazwisko")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdKlient");

                    b.ToTable("Klienci");

                    b.HasData(
                        new
                        {
                            IdKlient = 1,
                            Imie = "Daniel",
                            Nazwisko = "Rogowski"
                        },
                        new
                        {
                            IdKlient = 2,
                            Imie = "Jan",
                            Nazwisko = "Kowalski"
                        });
                });

            modelBuilder.Entity("ProbneKolokwium2.Models.Pracownik", b =>
                {
                    b.Property<int>("IdPracownik")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nazwisko")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdPracownik");

                    b.ToTable("Pracownicy");

                    b.HasData(
                        new
                        {
                            IdPracownik = 1,
                            Imie = "Tomasz",
                            Nazwisko = "Nowak"
                        },
                        new
                        {
                            IdPracownik = 2,
                            Imie = "Anna",
                            Nazwisko = "Laskowska"
                        });
                });

            modelBuilder.Entity("ProbneKolokwium2.Models.WyrobCukierniczy", b =>
                {
                    b.Property<int>("IdWyrobuCukierniczego")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CenaZaSzt")
                        .HasColumnType("real");

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Typ")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("IdWyrobuCukierniczego");

                    b.ToTable("WyrobCukierniczy");

                    b.HasData(
                        new
                        {
                            IdWyrobuCukierniczego = 1,
                            CenaZaSzt = 6f,
                            Nazwa = "Ptys",
                            Typ = "Przekaska"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 2,
                            CenaZaSzt = 80f,
                            Nazwa = "tort",
                            Typ = "Ciasto"
                        });
                });

            modelBuilder.Entity("ProbneKolokwium2.Models.Zamowienie", b =>
                {
                    b.Property<int>("IdZamowienie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPrzyjecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRealizacji")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdKlient")
                        .HasColumnType("int");

                    b.Property<int>("IdPracownik")
                        .HasColumnType("int");

                    b.Property<string>("Uwagi")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("IdZamowienie");

                    b.HasIndex("IdKlient");

                    b.HasIndex("IdPracownik");

                    b.ToTable("Zamowienie");

                    b.HasData(
                        new
                        {
                            IdZamowienie = 1,
                            DataPrzyjecia = new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataRealizacji = new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdKlient = 1,
                            IdPracownik = 2,
                            Uwagi = "na urodziny"
                        },
                        new
                        {
                            IdZamowienie = 2,
                            DataPrzyjecia = new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataRealizacji = new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdKlient = 2,
                            IdPracownik = 1,
                            Uwagi = "No cos tam"
                        });
                });

            modelBuilder.Entity("ProbneKolokwium2.Models.ZamowienieWyrobCukierniczy", b =>
                {
                    b.Property<int>("IdWyrobCukierniczy")
                        .HasColumnType("int");

                    b.Property<int>("IdZamowienie")
                        .HasColumnType("int");

                    b.Property<int>("Ilosc")
                        .HasColumnType("int");

                    b.Property<string>("Uwagi")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("IdWyrobCukierniczy", "IdZamowienie");

                    b.HasIndex("IdZamowienie");

                    b.ToTable("ZamowienieWyrobCukierniczy");

                    b.HasData(
                        new
                        {
                            IdWyrobCukierniczy = 2,
                            IdZamowienie = 1,
                            Ilosc = 1,
                            Uwagi = "na urodziny"
                        },
                        new
                        {
                            IdWyrobCukierniczy = 1,
                            IdZamowienie = 2,
                            Ilosc = 11,
                            Uwagi = "jakies tam"
                        });
                });

            modelBuilder.Entity("ProbneKolokwium2.Models.Zamowienie", b =>
                {
                    b.HasOne("ProbneKolokwium2.Models.Klient", "Klient")
                        .WithMany()
                        .HasForeignKey("IdKlient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProbneKolokwium2.Models.Pracownik", "Pracownik")
                        .WithMany()
                        .HasForeignKey("IdPracownik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProbneKolokwium2.Models.ZamowienieWyrobCukierniczy", b =>
                {
                    b.HasOne("ProbneKolokwium2.Models.WyrobCukierniczy", "WyrobCukierniczy")
                        .WithMany()
                        .HasForeignKey("IdWyrobCukierniczy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProbneKolokwium2.Models.Zamowienie", "Zamowienie")
                        .WithMany()
                        .HasForeignKey("IdZamowienie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
