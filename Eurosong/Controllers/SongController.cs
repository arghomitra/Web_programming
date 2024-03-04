using Eurosong.Data;
using Eurosong.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eurosong.Controllers
{
    [ApiController]
    [Route("api/songs")] // Correcting the route
    public class SongController : ControllerBase
    {
        private DataContext _data;

        public SongController(DataContext data)
        {
            this._data = data;
        }

        [HttpPost]
        [Authorize(Policy = "BasicAuthentication")]
        public ActionResult Post(Song song) // Accepting Song object
        {
            _data.AddSong(song); // Calling AddSong method
            return Ok("Song posted!");
        }

        [HttpDelete("{id}")] // Correcting the route
        [Authorize(Policy = "BasicAuthentication", Roles = "admin")]
        public ActionResult Delete(int id)
        {
            _data.DeleteSong(id); // Corrected method call
            return Ok("Song deleted!");
        }

        [HttpGet]
        public ActionResult<List<Song>> Get()
        {
            return Ok(_data.GetSongs());
        }

        [HttpGet("Search")]
        public ActionResult<List<Song>> GetByTitle(string word)
        {
            return Ok(_data.GetSongsByTitle(word));
        }

        [HttpGet("{id}")]
        public ActionResult<Song> GetAction(int id)
        {
            Song song = _data.GetSongById(id);
            if (song == null) return NotFound("Wrong id? Id not found in database");
            return Ok(song);
        }
    }
}
