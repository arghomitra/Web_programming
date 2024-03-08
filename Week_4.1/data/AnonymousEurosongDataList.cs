using Week_4._1.model;

namespace Week_4._1.data
{
    public class AnonymousEurosongDataList : IAnonymousEurosongDataContext
    {
        List<Song> songs = new List<Song>();
        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public Song GetSongById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Song> GetSongs()
        {
            return songs;
        }


    }
}
