using AnonymousEuroSong.Models;

namespace AnonymousEuroSong.Data
{
    public interface IAnonymousEuroSongDataContext
    {
        void AddSong(Song song);
        IEnumerable<Song> GetSongs();

    }
}
