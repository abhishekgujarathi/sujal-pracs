using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_15_2.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _db = new AppDbContext();

        public User GetUser(string username, string password)
        {
            return _db.Users.FirstOrDefault(m => m.Username == username && m.Password == password);
        }
        public User CheckUser(string username)
        {
            return _db.Users.FirstOrDefault(m => m.Username == username);
        }

        public void AddUser(User user)
        {
            _db.Users.Add(user);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}