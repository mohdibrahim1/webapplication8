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
        public class DishController : ControllerBase
        {
            private readonly ILogger<WeatherForecastController> _logger;

            public DishController(ILogger<WeatherForecastController> logger)
            {
                _logger = logger;
            }

            [HttpGet()]
            public IActionResult Get()
            {
                Dish dish = new Dish();
                dish.Name = "mutton keema";
                dish.HalfPrice = 50;
                dish.FullPrice = 50;
                dish.IsFull = false;

                return Ok(dish);
            }


            [HttpPost()]
            public IActionResult Post(Dish dish)
            {
                dish.Name = "paya";
                return Ok(dish);
            }

            [HttpPut()]
            public IActionResult Put(Dish dish)
            {
                dish.Name = "vada pav";
                return Ok(dish);
            }
        }
    }

