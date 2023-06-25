using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPlayer.Domain
{
    public interface IUserRepository
    {
        public void AddUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(User user);
        public User GetUser(User user);
        public IEnumerable<User> GetAllUsers();
    }
}