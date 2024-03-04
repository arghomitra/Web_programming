using Eurosong.Controllers;
using Eurosong.Model;

namespace Eurosong.Data
{
    public interface DataContext
    {
        void AddSong(Song song);

        void DeleteSong(int id);
        IEnumerable<Song> GetSongs();
        IEnumerable<Song> GetSongsByTitle(string word);
        Song GetSongById(int id);
    }
}
