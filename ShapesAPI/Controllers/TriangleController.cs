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
    public class TriangleController : ControllerBase
    {
        private static List<Triangle> TriangleData = new List<Triangle>()
        {
            new Triangle(){ID = 1, SideBase = 2, SideLengthA = 3, SideLengthC = 4, Height = 5},
            new Triangle(){ID = 2, SideBase = 6, SideLengthA = 7, SideLengthC = 8, Height = 9}
        };

        private readonly ILogger<TriangleController> _logger;

        public TriangleController(ILogger<TriangleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Triangle> Get()
        {
            return TriangleData.ToArray();
        }
        [HttpPost]
        public string Post([FromBody]Triangle tr)
        {
            bool IsDuplicate = false;

            foreach(var t in TriangleData){
                if(t.ID == tr.ID)
                    IsDuplicate = true;
            }

            if(IsDuplicate){
                return "Duplicate ID entered";
            }
            else{
                TriangleData.Add(tr);
                return "Post Success";
            }
          }

        [HttpPut]
        public string Put([FromBody]Triangle tr)
        {
            foreach(var t in TriangleData){
                if (t.ID == tr.ID){
                    t.SideBase = tr.SideBase;
                    t.SideLengthA = tr.SideLengthA;
                    t.SideLengthC = tr.SideLengthC;
                    t.Height = tr.Height;
                }
            }
            return "Put Success";
        }

        [HttpDelete]
        public string Delete([FromBody]Triangle tr)
        {
            var TD = new List<Triangle>();
            foreach(var t in TriangleData){
                if (t.ID != tr.ID){
                    TD.Add(t);
                }
            }
            TriangleData = TD;
            return "Delete Success";
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
