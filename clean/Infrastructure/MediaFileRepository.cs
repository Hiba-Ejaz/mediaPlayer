
using MediaPlayer.Application;
using MediaPlayer.Domain;

namespace MediaPlayer.Infrastructure
{
    public class MediaFileRepository : IMediaRepository
    {
        private List<MediaFile> _mediaFiles = new List<MediaFile>();

        public void AddMediaFile(MediaFile media)
        {
            Console.WriteLine("it is coming in repository addMediaFile sath service say yeh laya media id is"+media.Title);
            _mediaFiles.Add(media);
        }
        // public void AddMediaFile(int mediaId, string title, string duration, string genre, MediaTye type, int? bitrate, int? resolution)
        // {
        //      MediaFile media = new MediaFile(mediaId, title, duration, genre, type, bitrate, resolution);
        //      _mediaFiles.Add(media);
        //     }


        // public void AddMediaFile(int mediaId,string title,string duration,string genre,MediaType type,int? bitrate,int? resolution)
        // {
        //     _mediaFiles.Add(mediaId,title,duration,genre,type,bitrate, resolution);
        // }

        public IEnumerable<MediaFile> GetAllMediaFiles()
        {
            return _mediaFiles;
        }
           
        public MediaFile ReadMediaFile(int mediaId)
{

    return _mediaFiles.FirstOrDefault(m => m.MediaId == mediaId);
}
        // public MediaFile readMediaFile(int mediaId)
        // {
        //    MediaFile file = _mediaFiles.Find(m=>m.MediaId==mediaId);
        //     return file;
        // }
    }
}