using System.Collections.Generic;
using System.Linq;

namespace Practical_14.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private Practical_14Entities3 _context;

        public EmployeeRepository(Practical_14Entities3 context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public void Add(Employee emp)
        {
            _context.Employees.Add(emp);
        }

        public void Update(Employee emp)
        {
            var e = _context.Employees.Find(emp.Id);
            if (e != null)
            {
                e.Name = emp.Name;
                e.DOB = emp.DOB;
                e.Age = emp.Age;
            }
        }

        public void Delete(int id)
        {
            var emp = _context.Employees.Find(id);
            if (emp != null)
            {
                _context.Employees.Remove(emp);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}