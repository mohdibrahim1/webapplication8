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
    public class SchoolController : ControllerBase
    {
      

        private readonly ILogger<WeatherForecastController> _logger;

        public SchoolController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("id")]
        public IActionResult Getbyid(int id)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            string[] language = { "Hindi", "Marathi", "Urdu", "English" };
            return  Ok(new { Date = DateTime.Now, medium = language[id], vehicle = cars[id] });
        }

    }
}