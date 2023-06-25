
namespace MediaPlayer.Domain
{
    public interface IMediaFactory
    {
        MediaFile CreateMedia(int mediaId, string title, string duration, string genre, MediaType type, int? bitrate, int? resolution);
    }
}
