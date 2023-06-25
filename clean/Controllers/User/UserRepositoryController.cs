
using MediaPlayer.Application;
using MediaPlayer.Domain;

namespace MediaPlayer.Controller
{
    public class UserRepositoryController
    {
     private IUsersManagementService _usersManagementService;
    public UserRepositoryController(IUsersManagementService usersManagementService){
         _usersManagementService=usersManagementService;
    }
   public void AddUser(string username,string email,string password){
    _usersManagementService.AddUser(username,email,password);
    }
    public void DeleteUser(User user){
    _usersManagementService.DeleteUser(user);
    }
     public User GetUserByEmail(string email){
    return _usersManagementService.GetUserByEmail(email);
    }
     public IEnumerable<User> GetAllUsers(){
    return  _usersManagementService.GetAllUsers();
    }
    }
}