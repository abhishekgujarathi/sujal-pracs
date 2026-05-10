using Practical_17.Models.Entities;

namespace Practical_17.Services.Interfaces;

public interface IStudentService
{
    List<Student> GetAllStudents();

    Student GetStudentById(int id);

    void AddStudent(Student student);

    void UpdateStudent(Student student);

    void DeleteStudent(int id);
}