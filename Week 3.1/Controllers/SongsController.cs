using Microsoft.AspNetCore.Mvc;
using Week_3._1.Models;
using Week_3._1.Data;

namespace Week_3._1.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class SongsController : ControllerBase
    {
        private IAnonymousEurosonDataContext _data;

        public SongsController(IAnonymousEurosonDataContext data)
        {
            this._data = data;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Songs>> Get()
        {
            return Ok(_data.GetSongs());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Songs song)
        {
            _data.addSong(song);
           
            return Ok("Hooray");
        }
    }
}
