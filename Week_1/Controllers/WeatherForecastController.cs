using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Week_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpGet]
        [AcceptVerbs("GET")]
        [Route("SUMMARIES")]
        public IEnumerable<string> GetSummaries()
        {
            return Summaries;
        }
        [HttpGet]
        public IEnumerable<WeatherForecast> Get(int range)
        {
            
            Random rng = new Random();

            
            

            WeatherForecast[] array = new WeatherForecast[range];
            for (int i = 0; i< array.Length; i++)
            {
               
                array[i] = new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(i),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                };
            }
            return array;
            
        }
        [AcceptVerbs("POST","GET")]

        public IEnumerable<WeatherForecast> Get()
        {
            return null;
        }

        
    }
}
