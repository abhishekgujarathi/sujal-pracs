using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.Data.SqlClient;

namespace Practical_15_2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Default") { }

        public DbSet<User> Users { get; set; }
    }
}