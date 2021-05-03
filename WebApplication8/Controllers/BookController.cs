using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.model;

namespace WebApplication8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController :ControllerBase
    

    {
        private readonly ILogger<WeatherForecastController> _logger;

        public BookController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            Employee e = new Employee();
            e.Id = 100;
            e.Name = "ahmad";
            e.City = "bihar";
            return Ok(e);
        }


        [HttpPost()]
        public IActionResult Post(Employee employee)
        {
            employee.City = "Mumbai";
            return Ok(employee);
        }

        [HttpPut()]
        public IActionResult Put(Employee employee)
        {
            employee.City = "Mumbai";
            return Ok(employee);
        }
    }
}
