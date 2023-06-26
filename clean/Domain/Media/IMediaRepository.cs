
namespace MediaPlayer.Domain
{
    public interface IMediaRepository
    {
        public void AddMediaFile(MediaFile media);
        public MediaFile ReadMediaFile(int mediaId);
        public IEnumerable<MediaFile> GetAllMediaFiles();
    }
}