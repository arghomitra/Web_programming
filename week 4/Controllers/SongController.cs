using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using week_4.model;

namespace week_4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : ControllerBase
    {
        static private List<Song> songslist = new List<Song>();
        [HttpGet]
        public ActionResult<IEnumerable<Song>> Get()
        {
            return Ok(songslist);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Song song)
        {
            songslist.Add(song);
            return Ok("Hooray");
        }

        [HttpGet("{id}")]
        public ActionResult<Song> Get(int id)
        {
            return Ok(db.GetSong(id));
        }
    }
}
