using AnonymousEuroSong.Data;
using AnonymousEuroSong.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnonymousEuroSong.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongsController : Controller
    {
        private IAnonymousEuroSongDataContext _data;

        public SongsController(IAnonymousEuroSongDataContext data)
        {
            _data = data;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Song>> Get()
        {
            return Ok(_data.GetSongs());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {
            _data.AddSong(song);
            return Ok("Hooray");
        }
    }
}



