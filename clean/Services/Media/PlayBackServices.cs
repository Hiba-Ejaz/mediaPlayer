
using MediaPlayer.Domain;

namespace MediaPlayer.Application
{
    public class PlayBackServices : IPlayBackServices
    {
        private IMediaRepository _MediaRepository;
        public PlayBackServices(IMediaRepository mediaRepository){
        _MediaRepository=mediaRepository;
        }
       // public int _Bitrate { get; set; }
        public void pauseMedia(MediaFile media)
        {
          MediaFile mediaFile = _MediaRepository.ReadMediaFile(media.MediaId);
            if (mediaFile == null)
            {
                Console.WriteLine("Media file not found.");
                return;
            }
            if(media.isPlaying){
             Console.WriteLine($"this media file is already paused: {mediaFile.Title}");  
            }
            else{
            Console.WriteLine($"Paused media file: {mediaFile.Title}");
            media.isPlaying=false;
            }
        }
        public void playMedia(MediaFile media)
        {
           MediaFile mediaFile = _MediaRepository.ReadMediaFile(media.MediaId);
            if (mediaFile == null)
            {
                Console.WriteLine("Media file not found.");
                return;
            }
            if(media.isPlaying){
             Console.WriteLine($"this media file is already playing: {mediaFile.Title}");  
            }
            else{
            Console.WriteLine($"Playing media file: {mediaFile.Title}");
            media.isPlaying=true;
            }
        }
        public void seekMedia(MediaFile media)
        {
            throw new NotImplementedException();
        }

        public void stopMedia(MediaFile media)
        {
           MediaFile mediaFile = _MediaRepository.ReadMediaFile(media.MediaId);
            if (mediaFile == null)
            {
                Console.WriteLine("Media file not found.");
                return;
            }

             Console.WriteLine($"this media file stopped: {mediaFile.Title}");  
            
   
            
        }
    }
}