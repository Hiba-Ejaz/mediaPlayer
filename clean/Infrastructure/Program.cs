using MediaPlayer.Domain;
using MediaPlayer.Application;
using MediaPlayer.Controller;
using MediaPlayer.Infrastructure;

namespace MediaPlayer
{
    class Program
    {
        static void Main()
        {
            var mediaRepository = new MediaFileRepository();
            MediaManagementServices mediaPlayer=MediaManagementServices.GetMediaPlayerInstance(mediaRepository);
            var mediaFileRepositoryController = new MediaFileRepositoryController(mediaPlayer);
            mediaFileRepositoryController.AddMediaFile(1, "Sample Media", "00:05:30", "Action",MediaType.Video, null, 1080);
            
            var mediaPlayBackServices=new PlayBackServices(mediaRepository);
            var mediaPlayBackController=new MediaPlayBackController(mediaPlayBackServices);
            

            var userRepository = new UsersRepository();
            var userRepositoryService = new UserRepositoryService(userRepository,mediaPlayBackServices);
            var userRepositoryController = new UserRepositoryController(userRepositoryService);
            userRepositoryController.AddUser("hiba","hiba@gmail.com","hiba1234");
            

           User user1 = userRepositoryController.GetUserByEmail("hiba@gmail.com");
            Console.WriteLine($"Username: {user1.Username}, UserEmail: {user1.Email}");

       

           IEnumerable<MediaFile> allMediaFiles =  mediaFileRepositoryController.GetAllMediaFiles();
           foreach (MediaFile mediaFile in allMediaFiles)
           {
            if(mediaFile!=null)
            {   
               Console.WriteLine($"Media ID: {mediaFile.MediaId}, Title: {mediaFile.Title}");
           }
           }

            int mediaId = 1;
            MediaFile mediaFileById =  mediaFileRepositoryController.ReadMediaFile(mediaId);
           
            if (mediaFileById != null)
            {
                 mediaPlayBackController.playMedia(mediaFileById);
                Console.WriteLine($"Media ID: {mediaFileById.MediaId}, Title: {mediaFileById.Title}");
                 mediaPlayBackController.playMedia(mediaFileById);
                  mediaPlayBackController.stopMedia(mediaFileById);
            }
            else
            {
                Console.WriteLine($"Media file with ID {mediaId} not found.");
            }
        }
    }
}

