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
        private static List<Circle> CircleData = new List<Circle>()
        {
            new Circle(){ID = 1, Radius = 2},
            new Circle(){ID = 2, Radius = 3}
        };

        private readonly ILogger<CircleController> _logger;

        public CircleController(ILogger<CircleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Circle> Get()
        {
            return CircleData.ToArray();
        }

        [HttpPost]
        public string Post([FromBody]Circle cir)
        {
            bool IsDuplicate = false;

            foreach(var c in CircleData){
                if(c.ID == cir.ID)
                    IsDuplicate = true;
            }

            if(IsDuplicate){
                return "Duplicate ID entered";
            }
            else{
                CircleData.Add(cir);
                return "Post Success";
            }
          }

        [HttpPut]
        public string Put([FromBody]Circle cir)
        {
            foreach(var c in CircleData){
                if (c.ID == cir.ID){
                    c.Radius = cir.Radius;
                }
            }
            return "Put Success";
        }

        [HttpDelete]
        public string Delete([FromBody]Circle cir)
        {
            var CD = new List<Circle>();
            foreach(var c in CircleData){
                if (c.ID != cir.ID){
                    CD.Add(c);
                }
            }
            CircleData = CD;
            return "Delete Success";
        }

/*[HttpPost]
public async Task<IActionResult> PostAsync([FromBody] CreateModel createModel)
{
    // Create domain entity and persist
    var entity = await _service.Create(createModel);

    // Return 201
    return new ObjectResult(entity) { StatusCode = StatusCodes.Status201Created };
}
*/


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