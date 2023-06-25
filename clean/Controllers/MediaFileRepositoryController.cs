
using MediaPlayer.Application;
using MediaPlayer.Domain;


namespace MediaPlayer.Controller
{
    public class MediaFileRepositoryController
    {
        private readonly List<MediaFile> _mediaFiles=new();
        private IMediaManagementService _mediaManagementService;

        public MediaFileRepositoryController(IMediaManagementService mediaManagementService)
        {
            _mediaManagementService = mediaManagementService;
           // _mediaFiles = new List<MediaFile>();
        }

        public void AddMediaFile(int mediaId, string title, string duration, string genre, MediaType type, int? bitrate, int? resolution)
        {
            Console.WriteLine("add media file in controller"+mediaId);
            _mediaManagementService.AddMediaFile(mediaId, title, duration, genre, type, bitrate, resolution);
            MediaFile mediaFile = _mediaManagementService.ReadMediaFile(mediaId);
            _mediaFiles.Add(mediaFile);
        }

        public MediaFile ReadMediaFile(int mediaId)
        {
            Console.WriteLine("read media file in controller");
            return _mediaManagementService.ReadMediaFile(mediaId);
        }

        public IEnumerable<MediaFile> GetAllMediaFiles()
        {
            return _mediaFiles;
        }
    }
}




// using MediaPlayer.Application;
// using MediaPlayer.Domain;

// namespace MediaPlayer.Controller
// {
//     public class MediaFileRepositoryController
//     {
//        // private readonly List<MediaFile> _mediaFiles;
//        private IMediaManagementService _mediaManagementService;  
//        public MediaFileRepositoryController(IMediaManagementService mediaManagementService){
//          _mediaManagementService= mediaManagementService;
//        }
//         public void AddMediaFile(int mediaId,string title,string duration,string genre,MediaType type,int? bitrate,int? resolution)
//         {
//            _mediaManagementService.AddMediaFile(mediaId, title,duration,genre,type,bitrate,resolution);
//         }
//         public MediaFile readMediaFile(int mediaId)
//         {
//            return _mediaManagementService.readMediaFile(mediaId);
//         }

//          public IEnumerable<MediaFile> GetAllMediaFiles()
//         {
//             return _mediaManagementService.GetAllMediaFiles();
//         }
//     }
// }