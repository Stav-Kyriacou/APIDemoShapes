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
    public class SquareController : ControllerBase
    {
        private static List<Square> SquaresData = new List<Square>()
        {
            new Square(){ID = 1, SideLength = 2},
            new Square(){ID = 2, SideLength = 3}
        };

        private readonly ILogger<SquareController> _logger;

        public SquareController(ILogger<SquareController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Square> Get()
        {
            return SquaresData.ToArray();
        }

        [HttpPost]
        public string Post([FromBody]Square sq)
        {
            bool IsDuplicate = false;

            foreach(var s in SquaresData){
                if(s.ID == sq.ID)
                    IsDuplicate = true;
            }

            if(IsDuplicate){
                return "Duplicate ID entered";
            }
            else{
                SquaresData.Add(sq);
                return "Post Success";
            }
          }

        [HttpPut]
        public string Put([FromBody]Square sq)
        {
            foreach(var s in SquaresData){
                if (s.ID == sq.ID){
                    s.SideLength = sq.SideLength;
                }
            }
            return "Put Success";
        }

        [HttpDelete]
        public string Delete([FromBody]Square sq)
        {
           // SquaresData.Remove(sq);

            /*
            foreach(var s in SquaresData){
                if (s.ID == sq.ID){
                    int index = SquaresData.IndexOf(s);
                    SquaresData.RemoveAt(index);
                }
            }
            */
            var SD = new List<Square>();
            foreach(var s in SquaresData){
                if (s.ID != sq.ID){
                    SD.Add(s);
                }
            }
            SquaresData = SD;
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