using Practical_17.Models.Entities;

namespace Practical_17.Data.Seed;

public static class DbSeeder
{
    public static void Seed(AppDbContext context)
    {
        if (!context.Roles.Any())
        {
            var roles = new List<Role>
                {
                    new Role
                    {
                        RoleName = "Admin"
                    },
                    new Role
                    {
                        RoleName = "Normal"
                    }
                };

            context.Roles.AddRange(roles);
            context.SaveChanges();
        }

        // checkin if user already seededd
        if (!context.Users.Any())
        {
            var adminUser = new User
            {
                FirstName = "Admin",
                LastName = "test",
                EmailAddress = "admin@p17.com",
                MobileNumber = "1234567890",
                Password = "admin123",
                RoleId = 1
            };

            context.Users.Add(adminUser);

            var sujalUser = new User
            {
                FirstName = "Sujal",
                LastName = "test",
                EmailAddress = "sujal@p17.com",
                MobileNumber = "0987654321",
                Password = "sujal123",
                RoleId = 2
            };

            context.Users.Add(sujalUser);

            context.SaveChanges();
        }
    }
}