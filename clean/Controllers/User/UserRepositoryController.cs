
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
   public void AddUser(User user){
    _usersManagementService.AddUser(user);
    }
    public void DeleteUser(User user){
    _usersManagementService.DeleteUser(user);
    }
     public User GetUser(User user){
    return _usersManagementService.GetUser(user);
    }
     public IEnumerable<User> GetAllUsers(){
    return  _usersManagementService.GetAllUsers();
    }
    }
}