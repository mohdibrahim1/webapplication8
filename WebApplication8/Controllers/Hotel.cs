using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController: ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public HotelController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("id")]
        public IActionResult Getbyid(int id)
        {
           // string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //string[] menu = { "veg", "non-veg" };
            return Ok(new { Date = DateTime.Now, menu = "veg/non-veg"});
        }
    }
}

