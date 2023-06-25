

using MediaPlayer.Application;
using MediaPlayer.Domain;

namespace MediaPlayer.Controller
{
    public class MediaPlayBackController
    {
        private IPlayBackServices _PlaybackServices;
    
        public MediaPlayBackController(IPlayBackServices playbackServices){
            _PlaybackServices=playbackServices;
        }
        public void playMedia( MediaFile media){
            _PlaybackServices.playMedia(media);
        }
        public void pauseMedia(MediaFile media){
         _PlaybackServices.pauseMedia(media);
        }
        public void stopMedia(MediaFile media){
         _PlaybackServices.stopMedia(media);
        }
        // void seekMedia(MediaFile media);
        // {

        // }
    }
}