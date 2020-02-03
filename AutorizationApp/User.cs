using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorizationApp
{
    public class User
    {
        public User(string login, string password,string email )
        {
            Login = login;
            Password = password;
            Email = email;
        }
        public User()
        {

        }

        
        public int Id { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
