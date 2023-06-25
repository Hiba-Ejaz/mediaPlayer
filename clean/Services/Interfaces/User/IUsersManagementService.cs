
using MediaPlayer.Domain;

namespace MediaPlayer.Application
{
    public interface IUsersManagementService
    {
       public void AddUser(string username,string email,string password);
        public void UpdateUser(User user);
        public void DeleteUser(User user);
        public User GetUserByEmail(string Email);
        public IEnumerable<User> GetAllUsers();  
    }
}