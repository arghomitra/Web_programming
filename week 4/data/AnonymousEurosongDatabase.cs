using LiteDB;
using week_4.model;

namespace week_4.data
{
    public class AnonymousEurosongDatabase : IAnonymousEurosongDataContext
    {
        LiteDatabase db = new LiteDatabase(@"data.db");
        private const string _SONGS = "Songs";


        public void AddSong(Song song)
        {
            db.GetCollection<Song>("Songs").Insert(song);
        }

        public Song GetSongById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Song> GetSongs()
        {
            return db.GetCollection<Song>("Songs").FindAll();
        }
    }
}
