
namespace MediaPlayer.Domain
{
    public class AudioFile : MediaFile
    {
        private int? _Bitrate { get; set; }
        public AudioFile(int mediaId,string title,string duration,string genre,int? bitrate):base(mediaId,title,duration,genre)
        {
         
        _Bitrate=bitrate;
            
        }
        
    }
}