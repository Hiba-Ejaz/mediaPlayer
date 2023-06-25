

using MediaPlayer.Application;
using MediaPlayer.Domain;

namespace MediaPlayer.Infrastructure
{
    public class UsersRepository:IUserRepository
    {
       private List<User> users=new();
    
        public void AddUser(string username,string email,string password)
        {
            var user = new User(username, email, password);
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

          public User GetUserByEmail(string email)
          {
          return users.FirstOrDefault(user => user.Email == email);
            }   

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

    }
}