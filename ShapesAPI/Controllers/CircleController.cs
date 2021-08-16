using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShapesLibrary;

namespace ShapesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CircleController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CircleController> _logger;

        public CircleController(ILogger<CircleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        //public IEnumerable<Circle> Get()
        public string Get()
        {
           return "endpoint not yet implemented";
        }
    }
}


           /*
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
            */
