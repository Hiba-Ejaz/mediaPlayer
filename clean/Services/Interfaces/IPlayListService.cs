
using MediaPlayer.Domain;

namespace MediaPlayer.Services
{
    public interface IPlayListService
    {
    public void createPlayList(string PlayListName);
     public void AddMediaFileToPlayList(string PlayListTitle,MediaFile media);   
     public void RemoveMediaFileFromPlayList(string PlayListTitle, MediaFile media);   
     public void OrganisePlayList(string PlayListTitle);   
    }
}