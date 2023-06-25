
using MediaPlayer.Domain;

namespace MediaPlayer.Application
{
    public class AudioFileServices : IMediaControl
    {
        public int _Bitrate { get; set; }
        public void pauseMedia(MediaFile media)
        {
            throw new NotImplementedException();
        }
        public void playMedia(MediaFile media)
        {
            throw new NotImplementedException();
        }
        public void seekMedia(MediaFile media)
        {
            throw new NotImplementedException();
        }

        public void stopMedia(MediaFile media)
        {
            throw new NotImplementedException();
        }
    }
}