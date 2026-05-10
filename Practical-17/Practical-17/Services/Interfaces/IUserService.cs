using Practical_17.Models.Entities;

namespace Practical_17.Services.Interfaces;

public interface IUserService
{
    List<User> GetAllUsers();
}