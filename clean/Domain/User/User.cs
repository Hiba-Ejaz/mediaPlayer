
namespace MediaPlayer.Domain{
    public class User
    {
       public User(string username,String email,String password){
        Username=username;
        Email=email;
        Password=password;
       }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        
    }
}