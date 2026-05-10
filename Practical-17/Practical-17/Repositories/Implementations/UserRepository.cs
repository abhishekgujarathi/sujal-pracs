using Microsoft.EntityFrameworkCore;
using Practical_17.Data;
using Practical_17.Models.Entities;
using Practical_17.Repositories.Interfaces;

namespace Practical_17.Repositories.Implementations;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<User> GetAllUsers()
    {
        return _context.Users
            .Include(u => u.Role)
            .ToList();
    }
}