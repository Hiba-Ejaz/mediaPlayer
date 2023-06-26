
namespace MediaPlayer.Domain
{
    public class PlayList
    {
        public string PlayListTitle { set; get; }
        public List<MediaFile> MediaFiles { get; set; }
        public PlayList(string title)
        {
            PlayListTitle = title;
            MediaFiles = new List<MediaFile>();
        }
    }
}