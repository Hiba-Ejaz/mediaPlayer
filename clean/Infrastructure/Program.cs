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
            var mediaManagementServices = new MediaManagementServices(mediaRepository);
            var mediaFileRepositoryController = new MediaFileRepositoryController(mediaManagementServices);
            mediaFileRepositoryController.AddMediaFile(1, "Sample Media", "00:05:30", "Action",MediaType.Video, null, 1080);

            var userRepository = new UsersRepository();
            var userRepositoryService = new UserRepositoryService(userRepository);
            var userRepositoryController = new UserRepositoryController(userRepositoryService);
            userRepositoryController.AddUser("hiba","hiba@gmail.com","hiba1234");

           User userByEmail = userRepositoryController.GetUserByEmail("hiba@gmail.com");
            Console.WriteLine($"Username: {userByEmail.Username}, UserEmail: {userByEmail.Email}");

           IEnumerable<MediaFile> allMediaFiles =  mediaFileRepositoryController.GetAllMediaFiles();
           foreach (MediaFile mediaFile in allMediaFiles)
           {
            if(mediaFile!=null)
               Console.WriteLine($"Media ID: {mediaFile.MediaId}, Title: {mediaFile.Title}");
           }

            int mediaId = 1;
            MediaFile mediaFileById =  mediaFileRepositoryController.ReadMediaFile(mediaId);
            if (mediaFileById != null)
            {
                Console.WriteLine($"Media ID: {mediaFileById.MediaId}, Title: {mediaFileById.Title}");
            }
            else
            {
                Console.WriteLine($"Media file with ID {mediaId} not found.");
            }
        }
    }
}

