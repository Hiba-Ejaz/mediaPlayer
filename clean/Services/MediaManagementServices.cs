
using MediaPlayer.Domain;

namespace MediaPlayer.Application{
    public class MediaManagementServices : IMediaManagementService
    {
        private readonly IMediaRepository _mediaRepository;
        private MediaFactory _mediaFactory;
        public MediaManagementServices(IMediaRepository mediaRepository){
        _mediaRepository=mediaRepository;
        _mediaFactory=new MediaFactory();
        }
        public void AddMediaFile(int mediaId,string title,string duration,string genre,MediaType type,int? bitrate,int? resolution)
        {
            Console.WriteLine("add media file in service"+mediaId);
     MediaFile mediaFile = _mediaFactory.CreateMedia(mediaId,title,duration,genre,type,bitrate,resolution);
   Console.WriteLine("create say wapis aaya hai service sath yeh laya"+mediaFile.MediaId);
    _mediaRepository.AddMediaFile(mediaFile);
             //_mediaFactory.CreateMedia(type);
             //_mediaRepository.AddMediaFile(_mediaFactory.CreateMedia(type));
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
            return  _mediaRepository.ReadMediaFile(mediaId);
        }

        public void UpdateMediaFile(MediaFile media)
        {
             Console.WriteLine("media file updated");
        }
    }
}