using Practical_17.Models.Entities;
using Practical_17.Repositories.Interfaces;
using Practical_17.Services.Interfaces;

namespace Practical_17.Services.Implementations;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public List<User> GetAllUsers()
    {
        return _repository.GetAllUsers();
    }
}