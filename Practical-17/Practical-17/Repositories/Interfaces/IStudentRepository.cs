using Practical_17.Models.Entities;

namespace Practical_17.Repositories.Interfaces;

public interface IStudentRepository
{
    List<Student> GetAll();

    Student GetById(int id);

    void Add(Student student);

    void Update(Student student);

    void Delete(int id);

    void Save();
}