using AnonymousEuroSong.Models;

namespace AnonymousEuroSong.Data
{
    public class AnonymousEuroSongDataList : IAnonymousEuroSongDataContext
    {
        static List<Song> songs = new List<Song>();

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public IEnumerable<Song> GetSongs()
        {
            return songs;
        }
    }
}
