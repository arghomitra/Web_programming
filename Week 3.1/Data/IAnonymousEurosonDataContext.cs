using Week_3._1.Models;

namespace Week_3._1.Data
{
    public interface IAnonymousEurosonDataContext
    {
        void addSong(Songs song);
        IEnumerable<Songs> GetSongs();
    }
    
}
