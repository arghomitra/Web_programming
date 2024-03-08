using Week_4._1.model;

namespace Week_4._1.data
{
    public interface IAnonymousEurosongDataContext
    {
        void AddSong(Song song);
        IEnumerable<Song> GetSongs();
        Song GetSongById(int id);
    }
}
