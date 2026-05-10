using Practical_17.Data;
using Practical_17.Models.Entities;
using Practical_17.Repositories.Interfaces;

namespace Practical_17.Repositories.Implementations;

public class StudentRepository : IStudentRepository
{
    private readonly AppDbContext _context;

    public StudentRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Student> GetAll()
    {
        return _context.Students.ToList();
    }

    public Student GetById(int id)
    {
        return _context.Students.Find(id);
    }

    public void Add(Student student)
    {
        _context.Students.Add(student);
    }

    public void Update(Student student)
    {
        _context.Students.Update(student);
    }

    public void Delete(int id)
    {
        var student = _context.Students.Find(id);

        if (student != null)
        {
            _context.Students.Remove(student);
        }
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}