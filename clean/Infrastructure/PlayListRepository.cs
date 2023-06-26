
using MediaPlayer.Domain;

namespace MediaPlayer.Infrastructure
{
    public class PlayListRepository : IPlaylistRepository
    {
        private Dictionary<string, PlayList> _playlists = new();
        public void AddMediaFileToPlayList(string PlayListTitle, MediaFile media)
        {
            if (_playlists.ContainsKey(PlayListTitle))
            {
                PlayList playList = _playlists[PlayListTitle];
                playList.MediaFiles.Add(media);
            }
            else
            {
                Console.WriteLine("playList not found, create ");
            }
        }

        public void createPlayList(string PlayListName)
        {
            PlayList playList = new PlayList(PlayListName);
            _playlists.Add(PlayListName, playList);
        }

        public void OrganisePlayList(string PlayListTitle)
        {
            PlayList playlist = _playlists[PlayListTitle];
            playlist.MediaFiles.Sort((a, b) => string.Compare(a.Title, b.Title));
        }

        public void RemoveMediaFileFromPlayList(string PlayListTitle, MediaFile media)
        {
            if (_playlists.ContainsKey(PlayListTitle))
            {
                PlayList playList = _playlists[PlayListTitle];
                playList.MediaFiles.Remove(media);
            }
            else
            {
                Console.WriteLine("playList not found, create ");
            }
        }
    }
}