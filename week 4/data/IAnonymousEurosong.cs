using week_4.model;

namespace week_4.data
{
    public interface IAnonymousEurosong
    {
        // Interface cannot contain fields
        void AddSong(Song song);
    }

    // Implementing class that implements the interface
    public class AnonymousEurosong : IAnonymousEurosong
    {
        static private List<Song> songs = new List<Song>(); // Field to hold songs

        // Implementing the method from the interface
        public void AddSong(Song song)
        {
            songs.Add(song); // Assuming Song class has a property 'Title'
        }
    }
}
