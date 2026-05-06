using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_15_2.Models
{
    public class UserService : IUserService
    {
        private IUserRepository _repo;

        public UserService()
        {
            _repo = new UserRepository();
        }

        public User ValidateUser(string name, string password)
        {
            return _repo.GetUser(name, password);
        }

        public bool Register(User user)
        {
            var u = _repo.CheckUser(user.Username);
            if (u == null)
            {
                _repo.AddUser(user);
                _repo.Save();

                return true;
            }
            return false;
        }
        
    }
}