
using MediaPlayer.Domain;

namespace MediaPlayer.Application
{
    public class MediaManagementServices : IMediaManagementService
    {
        private static MediaManagementServices _MediaPlayerInstance;
        private static readonly object _lock = new object();
        private readonly IMediaRepository _mediaRepository;
        private IMediaFactory _mediaFactory;
        public MediaManagementServices(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
            _mediaFactory = new MediaFactory();
        }

        public static MediaManagementServices GetMediaPlayerInstance(IMediaRepository mediaRepository)
        {
            if (_MediaPlayerInstance == null)
            {
                lock (_lock)
                {
                    if (_MediaPlayerInstance == null)
                    {
                        _MediaPlayerInstance = new MediaManagementServices(mediaRepository);
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("Singleton instance of media player already exists.");
            }

            return _MediaPlayerInstance;
        }
        public void AddMediaFile(int mediaId, string title, string duration, string genre, MediaType type, int? bitrate, int? resolution)
        {
            MediaFile mediaFile = _mediaFactory.CreateMedia(mediaId, title, duration, genre, type, bitrate, resolution);
            _mediaRepository.AddMediaFile(mediaFile);
        }

        public void DeleteMediaFile(MediaFile media)
        {
            Console.WriteLine("removed");
        }

        public IEnumerable<MediaFile> GetAllMediaFiles()
        {
            return _mediaRepository.GetAllMediaFiles();
        }

        public MediaFile ReadMediaFile(int mediaId)
        {
            Console.WriteLine("read media file in service");
            return _mediaRepository.ReadMediaFile(mediaId);
        }

        public void UpdateMediaFile(MediaFile media)
        {
            Console.WriteLine("media file updated");
        }
    }
}