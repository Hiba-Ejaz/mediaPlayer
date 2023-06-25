
using MediaPlayer.Domain;


namespace MediaPlayer.Application
{
    public interface IUserPlaybackServices
    {
        void PlayFile(MediaFile media){
           
            Console.WriteLine("media is playing");
        }
    }
}