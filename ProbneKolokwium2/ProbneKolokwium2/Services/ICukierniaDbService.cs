using ProbneKolokwium2.DTOs;
using ProbneKolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbneKolokwium2.Services
{
    public interface ICukierniaDbService
    {
        public IEnumerable<Zamowienie> GetOrders(GetOrdersRequest request);
        
    }
}
