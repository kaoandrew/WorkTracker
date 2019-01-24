using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IUserAccount
    {
        int UserId { get; }
        string Username { get; }
        string Password { get; }
    }
}
