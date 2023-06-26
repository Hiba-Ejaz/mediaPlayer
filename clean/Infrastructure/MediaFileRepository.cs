
using MediaPlayer.Application;
using MediaPlayer.Domain;

namespace MediaPlayer.Infrastructure
{
    public class MediaFileRepository : IMediaRepository
    {
        private List<MediaFile> _mediaFiles = new List<MediaFile>();
        public void AddMediaFile(MediaFile media)
        {
            _mediaFiles.Add(media);
        }

        public IEnumerable<MediaFile> GetAllMediaFiles()
        {
            return _mediaFiles;
        }

        public MediaFile ReadMediaFile(int mediaId)
        {

            return _mediaFiles.FirstOrDefault(m => m.MediaId == mediaId);
        }

    }
}