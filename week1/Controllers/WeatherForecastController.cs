using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace week1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [AcceptVerbs("GET")]
        [Route("METHOD_ROUTE")]
        [HttpGet("{range}")]

        public IEnumerable<WeatherForecast> Get(int range)
        {
            return Enumerable.Range(1, range).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        
        

        

        [AcceptVerbs("GET","POST")]

        public IEnumerable<string> Get2(int range=5)
        {
            
            List<string> input = new List<string>();
            for (int i = 0; i < range; i++)
            {
                input.Add(i.ToString());
            }
            return input;


        }
    }
}
