using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks; // Add this namespace for Task

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllHeroes()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Spiderman",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place="New York City"
                }
            };

            return Ok(heroes); // Return the list of heroes as response
        }
    }
}
