using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbneKolokwium2.Models
{
    public class ZamowienieWyrobCukierniczy
    {
        public int Ilosc { get; set; }
        public string Uwagi { get; set; }
        public int IdWyrobCukierniczy { get; set; }
        public int IdZamowienie { get; set; }
        public virtual WyrobCukierniczy WyrobCukierniczy { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}
