using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProbneKolokwium2.DTOs;
using ProbneKolokwium2.Models;
using ProbneKolokwium2.Services;

namespace ProbneKolokwium2.Controllers
{
    
    [ApiController]
    public class CukierniaController : ControllerBase
    {
        private readonly ICukierniaDbService _service;
       

        public CukierniaController(ICukierniaDbService service)
        {
            _service = service;
        }
      

        [HttpGet]
        [Route("api/orders")]
        public IActionResult GetOrders(GetOrdersRequest request)
        {
            try
            {
                var list = _service.GetOrders(request);
                return Ok(list);
            }catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
        }
    }
}