// Users should be able to play audio and video files.//user class and actions Interface
// Provide controls for play, pause, stop, and seek functionality.//media class and media Interface
// Display the current playback status, such as the current position and duration.//features for user class

using MediaPlayer.Domain;

namespace MediaPlayer.Application{
    public interface IPlayBackServices
    {
        void playMedia( MediaFile media);
        void pauseMedia(MediaFile media);
        void stopMedia(MediaFile media);
        void seekMedia(MediaFile media);
    }   
}