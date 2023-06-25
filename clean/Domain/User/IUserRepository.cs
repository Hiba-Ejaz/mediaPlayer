using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPlayer.Domain
{
    public interface IUserRepository
    {
        public void AddUser(string username,string email,string password);
        public void UpdateUser(User user);
        public void DeleteUser(User user);
        public User GetUserByEmail(string email);
        public IEnumerable<User> GetAllUsers();
    }
}