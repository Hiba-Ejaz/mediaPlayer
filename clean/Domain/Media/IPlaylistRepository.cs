
namespace MediaPlayer.Domain
{
    public interface IPlaylistRepository
    {
           public void createPlayList(string PlayListName);
        public void AddMediaFileToPlayList(string PlayListTitle, MediaFile media);
        public void RemoveMediaFileFromPlayList(string PlayListTitle, MediaFile media);
        public void OrganisePlayList(string PlayListTitle);
    }
}