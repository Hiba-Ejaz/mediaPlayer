
namespace MediaPlayer.Domain
{
    public class VideoFile : MediaFile
    {
        public int? _Resolution{get;set;}
        public VideoFile(int mediaId,string title,string duration,string genre,int? resolution):base(mediaId,title,duration,genre)
        {
                _Resolution=resolution;
        }
    }
}