using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProbneKolokwium2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klienci",
                columns: table => new
                {
                    IdKlient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(maxLength: 50, nullable: true),
                    Nazwisko = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klienci", x => x.IdKlient);
                });

            migrationBuilder.CreateTable(
                name: "Pracownicy",
                columns: table => new
                {
                    IdPracownik = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(maxLength: 50, nullable: true),
                    Nazwisko = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownicy", x => x.IdPracownik);
                });

            migrationBuilder.CreateTable(
                name: "WyrobCukierniczy",
                columns: table => new
                {
                    IdWyrobuCukierniczego = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(maxLength: 200, nullable: true),
                    CenaZaSzt = table.Column<float>(nullable: false),
                    Typ = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WyrobCukierniczy", x => x.IdWyrobuCukierniczego);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienie",
                columns: table => new
                {
                    IdZamowienie = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPrzyjecia = table.Column<DateTime>(nullable: false),
                    DataRealizacji = table.Column<DateTime>(nullable: false),
                    Uwagi = table.Column<string>(maxLength: 300, nullable: true),
                    IdKlient = table.Column<int>(nullable: false),
                    IdPracownik = table.Column<int>(nullable: false),
                    KlientIdKlient = table.Column<int>(nullable: true),
                    PracownikIdPracownik = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienie", x => x.IdZamowienie);
                    table.ForeignKey(
                        name: "FK_Zamowienie_Klienci_KlientIdKlient",
                        column: x => x.KlientIdKlient,
                        principalTable: "Klienci",
                        principalColumn: "IdKlient",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zamowienie_Pracownicy_PracownikIdPracownik",
                        column: x => x.PracownikIdPracownik,
                        principalTable: "Pracownicy",
                        principalColumn: "IdPracownik",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ZamowienieWyrobCukierniczy",
                columns: table => new
                {
                    IdWyrobCukierniczy = table.Column<int>(nullable: false),
                    IdZamowienie = table.Column<int>(nullable: false),
                    Ilosc = table.Column<int>(nullable: false),
                    Uwagi = table.Column<string>(maxLength: 300, nullable: true),
                    WyrobCukierniczyIdWyrobuCukierniczego = table.Column<int>(nullable: true),
                    ZamowienieIdZamowienie = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZamowienieWyrobCukierniczy", x => new { x.IdWyrobCukierniczy, x.IdZamowienie });
                    table.ForeignKey(
                        name: "FK_ZamowienieWyrobCukierniczy_WyrobCukierniczy_WyrobCukierniczyIdWyrobuCukierniczego",
                        column: x => x.WyrobCukierniczyIdWyrobuCukierniczego,
                        principalTable: "WyrobCukierniczy",
                        principalColumn: "IdWyrobuCukierniczego",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ZamowienieWyrobCukierniczy_Zamowienie_ZamowienieIdZamowienie",
                        column: x => x.ZamowienieIdZamowienie,
                        principalTable: "Zamowienie",
                        principalColumn: "IdZamowienie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienie_KlientIdKlient",
                table: "Zamowienie",
                column: "KlientIdKlient");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienie_PracownikIdPracownik",
                table: "Zamowienie",
                column: "PracownikIdPracownik");

            migrationBuilder.CreateIndex(
                name: "IX_ZamowienieWyrobCukierniczy_WyrobCukierniczyIdWyrobuCukierniczego",
                table: "ZamowienieWyrobCukierniczy",
                column: "WyrobCukierniczyIdWyrobuCukierniczego");

            migrationBuilder.CreateIndex(
                name: "IX_ZamowienieWyrobCukierniczy_ZamowienieIdZamowienie",
                table: "ZamowienieWyrobCukierniczy",
                column: "ZamowienieIdZamowienie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZamowienieWyrobCukierniczy");

            migrationBuilder.DropTable(
                name: "WyrobCukierniczy");

            migrationBuilder.DropTable(
                name: "Zamowienie");

            migrationBuilder.DropTable(
                name: "Klienci");

            migrationBuilder.DropTable(
                name: "Pracownicy");
        }
    }
}
