

using MediaPlayer.Application;
using MediaPlayer.Domain;

namespace MediaPlayer.Infrastructure
{
    public class UsersRepository:IUserRepository
    {
       private List<User> users=new();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void DeleteUser(User user)
        {
           //users.Remove(u=u.id==user.id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public User GetUser(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}