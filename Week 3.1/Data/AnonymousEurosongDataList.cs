using Week_3._1.Models;
using Week_3._1.Data;

namespace Week_3._1.Data
{
    public class AnonymousEurosongDataList : IAnonymousEurosonDataContext
    {
        List<Songs> songs = new List<Songs>();
        
        public void addSong(Songs song)
        {
            songs.Add(song);
        }

        public IEnumerable<Songs> GetSongs()
        {
            return songs;
        }
    }
}
