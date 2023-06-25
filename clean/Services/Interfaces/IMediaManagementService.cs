
using MediaPlayer.Domain;


namespace MediaPlayer.Application
{
    public interface IMediaManagementService
    {
        public void AddMediaFile(int mediaId,string title,string duration,string genre,MediaType mediaType,int? bitrate,int? resolution);
        public void DeleteMediaFile(MediaFile media);
        public void UpdateMediaFile(MediaFile media);
         public MediaFile ReadMediaFile(int mediaId); 
          public IEnumerable<MediaFile> GetAllMediaFiles();
    }
}