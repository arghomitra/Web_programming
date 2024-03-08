using LiteDB;
using Week_4._1.model;

namespace Week_4._1.data
{
    public class AnonymousEurosongDatabase : IAnonymousEurosongDataContext
    {
        LiteDatabase db = new LiteDatabase(@"data.db");
        private const string _SONGS = "Songs";


        public void AddSong(Song song)
        {
            db.GetCollection<Song>("Songs").Insert(song);
        }


        public IEnumerable<Song> GetSongs()
        {
            return db.GetCollection<Song>("Songs").FindAll();
        }
        public Song GetSongById(int id) 
        {
            return db.GetCollection<Song>("Songs").FindById(id);
        }
    }

}
