using Practical_17.Models.Entities;
using Practical_17.Repositories.Interfaces;
using Practical_17.Services.Interfaces;

namespace Practical_17.Services.Implementations;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;

    public StudentService(IStudentRepository repository)
    {
        _repository = repository;
    }

    public List<Student> GetAllStudents()
    {
        return _repository.GetAll();
    }

    public Student GetStudentById(int id)
    {
        return _repository.GetById(id);
    }

    public void AddStudent(Student student)
    {
        _repository.Add(student);
        _repository.Save();
    }

    public void UpdateStudent(Student student)
    {
        _repository.Update(student);
        _repository.Save();
    }

    public void DeleteStudent(int id)
    {
        _repository.Delete(id);
        _repository.Save();
    }
}
