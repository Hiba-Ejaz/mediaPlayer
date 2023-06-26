
using MediaPlayer.Domain;

namespace MediaPlayer.Services
{
    public class PlayListService : IPlayListService
    {
        private IMediaRepository _MediaRepository;
        private IPlaylistRepository _PlaylistRepository;
        public PlayListService(IMediaRepository mediaRepository, IPlaylistRepository playlistRepository)
        {
            _MediaRepository = mediaRepository;
            _PlaylistRepository = playlistRepository;
        }
        public void AddMediaFileToPlayList(string PlayListTitle, MediaFile media)
        {
            MediaFile mediaFile = _MediaRepository.ReadMediaFile(media.MediaId);
            if (mediaFile != null)
            {
                _PlaylistRepository.AddMediaFileToPlayList(PlayListTitle, media);
                Console.WriteLine("media file added to playlist");
            }
            else
            {
                Console.WriteLine("media file not found in playlist");
            }
        }

        public void createPlayList(string PlayListTitle)
        {
            _PlaylistRepository.createPlayList(PlayListTitle);
        }

        public void OrganisePlayList(string PlayListTitle)
        {
            _PlaylistRepository.OrganisePlayList(PlayListTitle);
            Console.WriteLine("Playlist organized");
        }

        public void RemoveMediaFileFromPlayList(string playListTitle, MediaFile media)
        {
            MediaFile mediaFile = _MediaRepository.ReadMediaFile(media.MediaId);
            if (mediaFile != null)
            {
                _PlaylistRepository.RemoveMediaFileFromPlayList(playListTitle, media);
                Console.WriteLine("media file removed from playlist");
            }
            else
            {
                Console.WriteLine("media file not found in playlist");
            }
        }
    }
}