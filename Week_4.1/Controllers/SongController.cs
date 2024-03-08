using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
using Week_4._1.data;
using Week_4._1.model;

namespace Week_4._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        //static private List<Song> songlist = new List<Song>();




        private IAnonymousEurosongDataContext _data;

        public SongController( IAnonymousEurosongDataContext data)
        {
            _data = data;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Song>> Get()
        {
            return Ok(_data.GetSongs());
        }


        [HttpPost]
        public ActionResult Post([FromBody] Song song)
        {
            _data.AddSong(song);
            return Ok("Hooray");
        }

        [HttpGet("{id}")]
        public ActionResult<Song> Get(int id)
        {
            Song s = _data.GetSongById(id);
            if (s != null) return Ok(s);
            return NotFound("Song not found! Try another ID!");
        }


    }
}
