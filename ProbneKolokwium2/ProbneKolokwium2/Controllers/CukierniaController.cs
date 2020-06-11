using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProbneKolokwium2.Models;

namespace ProbneKolokwium2.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class CukierniaController : ControllerBase
    {
        private readonly CukierniaDbContext _context;
        public CukierniaController(CukierniaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok();
        }
    }
}