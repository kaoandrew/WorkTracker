using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

        // Constructors
        public LoginDto(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
