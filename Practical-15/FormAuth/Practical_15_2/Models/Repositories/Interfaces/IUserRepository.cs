using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_15_2.Models
{
    public interface IUserRepository
    {
        User GetUser(string username, string password);
        void AddUser(User user);
        void Save();
        User CheckUser(string username);
    }
}