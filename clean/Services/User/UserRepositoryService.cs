
using MediaPlayer.Domain;


namespace MediaPlayer.Application
{
    public class UserRepositoryService : IUsersManagementService
    {
        private IUserRepository _userRepository;
        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }

        public void DeleteUser(User user)
        {
            _userRepository.DeleteUser(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUser(User user)
        {
           return _userRepository.GetUser(user);
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}