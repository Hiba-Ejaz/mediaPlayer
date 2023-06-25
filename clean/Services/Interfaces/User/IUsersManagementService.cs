
using MediaPlayer.Domain;

namespace MediaPlayer.Application
{
    public interface IUsersManagementService
    {
       public void AddUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(User user);
        public User GetUser(User user);
        public IEnumerable<User> GetAllUsers();  
    }
}