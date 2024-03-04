using Eurosong.Model;
using LiteDB;
namespace Eurosong.Data
{
    public class DataList : DataContext
    {
        List<Song> list = new List<Song>();
        
        public void AddSong(Song song)
        {
            list.Add(song);
        }

        public void DeleteSong(int id)
        {
            throw new NotImplementedException();
        }
        public Song GetSongById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Song> GetSongs()
        {
            return list;
        }

        public IEnumerable<Song> GetSongsByTitle(string title)
        {
            return list.Where(x=>x.Title.Contains(title));
        }
    }
}
