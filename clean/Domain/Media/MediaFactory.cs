namespace MediaPlayer.Domain
{
    public class MediaFactory:IMediaFactory
    {
        public MediaFile CreateMedia(int mediaId, string title, string duration, string genre, MediaType type, int? bitrate, int? resolution)
        {
            
            switch (type)
            {
                case MediaType.Audio:
                
                    return new AudioFile(mediaId, title, duration, genre, bitrate);
                case MediaType.Video:
              
                    return new VideoFile(mediaId, title, duration, genre, resolution);
                    
                default:
                    throw new Exception("Invalid media type.");
            }
        }
    }
}

