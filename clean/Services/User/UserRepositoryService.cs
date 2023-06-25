
using MediaPlayer.Domain;


namespace MediaPlayer.Application
{
    public class UserRepositoryService : IUsersManagementService
    {
        private IUserRepository _userRepository;
       public UserRepositoryService(IUserRepository userRepository){
        _userRepository=userRepository;
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
    }
}