using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class UserAccount : IUserAccount
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Navigation Properties
        // public virtual IList<Task> Tasks { get; set; }

        // Constructors
        public UserAccount() { }
        public UserAccount(int userId, string username, string password)
        {
            UserId = userId;
            Username = username;
            Password = password;
        }
    }
}
