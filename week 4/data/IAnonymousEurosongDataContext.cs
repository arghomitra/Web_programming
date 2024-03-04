using week_4.model;

namespace week_4.data
{
    public interface IAnonymousEurosongDataContext
    {
        void AddSong(Song song);
        IEnumerable<Song> GetSongs();
        Song GetSongById(int id);


    }
}
