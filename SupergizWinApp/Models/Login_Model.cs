using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupergizWinApp.Models
{
    class Login_Model
    {
        public string Username  {private set; get ;}
        public string Password { private set; get; }

        public Login_Model(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
