namespace MediaPlayer.Domain
{
    public class MediaFactory:IMediaFactory
    {
        public MediaFile CreateMedia(int mediaId, string title, string duration, string genre, MediaType type, int? bitrate, int? resolution)
        {
            Console.WriteLine("read media file in factory"+mediaId);
            switch (type)
            {
                case MediaType.Audio:
                Console.WriteLine("audio type k andar");
                    return new AudioFile(mediaId, title, duration, genre, bitrate);
                case MediaType.Video:
                Console.WriteLine("video type k andar");
                    return new VideoFile(mediaId, title, duration, genre, resolution);
                    
                default:
                    throw new Exception("Invalid media type.");
            }
        }
    }
}


// namespace MediaPlayer.Domain
// {
//     public class MediaFactory
//     {
//         public int MediaId { get; set; }
//         public string Title { get; set; }
//         public string Filetype { get; set; }
//         public string Duration { get; set; }
//         public string status { get; set; }
//         public string Genre { get; set; }
//         public int? Bitrate { get; set; }
//         public int? Resolution { get; set; }
//        // public  MediaFactory(int mediaId, string title, string duration, string genre, MediaType type,int? bitrate,int? resolution)
//        // {
//  public  MediaFactory(){
//             // MediaId = mediaId;
//             // Title = title;
//             // Duration = duration;
//             // Genre = genre;
//             // Bitrate = bitrate;
//         }
//         public MediaFile CreateMedia(int mediaId,string title,string duration,string genre,MediaType type,int? bitrate,int? resolution){
//             switch(type)
//             {
//                 case MediaType.Audio:
//                 return new AudioFile(mediaId,title,duration,genre,bitrate);
//                 case MediaType.Video:
//                 return new VideoFile(mediaId,title,duration,genre,resolution);
//                 default:
//                 throw new Exception("invalid data");
//             }
//         }

//     }
//     // public class AudioFileFactory : MediaFactory
//     // {
//     //     public int Bitrate { get; set; }
//     //     public AudioFileFactory(int mediaId, string title, string duration, string genre, int bitrate) : base(mediaId, title, duration, genre)
//     //     {
//     //         Bitrate = bitrate;
//     //     }
//     //     public override MediaFile CreateMedia()
//     //     {
//     //         return new AudioFile(MediaId, Title, Duration, Genre, Bitrate
//     //     );
//     //     }
//     // }
//     // public class VideoFileFactory : MediaFactory
//     // {
//     //     public int Resolution { get; set; }
//     //     public VideoFileFactory(int mediaId, string title, string duration, string genre, int resolution) : base(mediaId, title, duration, genre)
//     //     {
//     //         Resolution = resolution;
//     //     }
//     //     public override MediaFile CreateMedia()
//     //     {
//     //         return new VideoFile(MediaId, Title, Duration, Genre, Resolution);
//     //     }
//     // }
// }