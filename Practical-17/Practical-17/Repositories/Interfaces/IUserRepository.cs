using Practical_17.Models.Entities;

namespace Practical_17.Repositories.Interfaces;

public interface IUserRepository
{
    List<User> GetAllUsers();
}