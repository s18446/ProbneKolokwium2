using ProbneKolokwium2.DTOs;
using ProbneKolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbneKolokwium2.Services
{
    public class EfCukierniaDbService : ICukierniaDbService
    {
        private readonly CukierniaDbContext _context;
        public EfCukierniaDbService(CukierniaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Zamowienie> GetOrders(GetOrdersRequest request)
        {
            IEnumerable<Zamowienie> list = _context.Zamowienie.ToList();
            if (request.NazwiskoKlienta != null)
            {
                //int liczbaKlientow = _context.Klienci.Count(e => e.Nazwisko == request.NazwiskoKlienta);

                var Klient = _context.Klienci.ToList().Where(e => e.Nazwisko == request.NazwiskoKlienta);
                
                return list.Where(e => e.IdKlient == Klient.First().IdKlient);
            }
            return list;
        }
    }
}
