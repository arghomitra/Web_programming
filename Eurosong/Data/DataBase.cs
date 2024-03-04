using Eurosong.Model;
using LiteDB;

namespace Eurosong.Data
{
    public class DataBase: DataContext
    {
        LiteDatabase db = new LiteDatabase(@"data.db");
        

        const string songs = "Songs";
        public void Addsong(Song song)
        {
            db.GetCollection<Song>(songs).Insert(song);
        }
        public IEnumerable<Song> GetSongs()
        {
            return db.GetCollection<Song>(songs).FindAll();

        }

        public IEnumerable<Song> GetSongsByTitle(string title)
        {
            return db.GetCollection<Song>(songs).FindAll().Where(s => s.Title.Contains(title));
        }

        public Song GetSongById(int id)
        {
            return db.GetCollection<Song>(songs).FindById(id);
        }

        public void DeleteSong(int id)
        {
            db.GetCollection<Song>(songs).Delete(id);
        }

        void DataContext.AddSong(Song song)
        {
            throw new NotImplementedException();
        }
    }
}
