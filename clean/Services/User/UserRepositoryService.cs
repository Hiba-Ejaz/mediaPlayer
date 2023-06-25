
using MediaPlayer.Domain;


namespace MediaPlayer.Application
{
    public class UserRepositoryService : IUsersManagementService
    {
        private IUserRepository _userRepository;
        private IPlayBackServices _MediaPlayBackServices;
       public UserRepositoryService(IUserRepository userRepository,IPlayBackServices mediaPlayBackServices){
        _userRepository=userRepository;
        _MediaPlayBackServices=mediaPlayBackServices;
        }
        public void AddUser(string username,string email,string password)
        {
            _userRepository.AddUser(username,email,password);
        }

        public void DeleteUser(User user)
        {
            _userRepository.DeleteUser(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserByEmail(string email)
        {
           return _userRepository.GetUserByEmail(email);
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
        void playMedia( MediaFile media){
           _MediaPlayBackServices.playMedia(media); 
        }
        void pauseMedia(MediaFile media){
            _MediaPlayBackServices.pauseMedia(media);
        }
        void stopMedia(MediaFile media){
        _MediaPlayBackServices.stopMedia(media);
        }
        void seekMedia(MediaFile media){

        }
    }
}