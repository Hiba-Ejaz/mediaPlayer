
using MediaPlayer.Domain;
using MediaPlayer.Services;

namespace MediaPlayer.Controllers
{
    public class PlayListController
    {
        private IPlayListService _PlayListService;
        public PlayListController(IPlayListService playListService)
        {
            _PlayListService = playListService;
        }
        public void createPlayList(string PlayListTitle)
        {
            _PlayListService.createPlayList(PlayListTitle);
        }
        public void AddMediaFileToPlayList(string playListTitle, MediaFile media)
        {
            _PlayListService.AddMediaFileToPlayList(playListTitle, media);
        }
        public void RemoveMediaFileFromPlayList(string playListTitle, MediaFile media)
        {
            _PlayListService.RemoveMediaFileFromPlayList(playListTitle, media);
        }
        public void OrganisePlayList(string playListTitle)
        {
            _PlayListService.OrganisePlayList(playListTitle);
        }
    }
}