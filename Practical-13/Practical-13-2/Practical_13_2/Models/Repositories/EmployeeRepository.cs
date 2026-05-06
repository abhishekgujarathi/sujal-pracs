using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Practical_13_2.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<EmployeeViewModel> GetAllEmployees()
        {
            return _context.Employees
                .AsNoTracking()
                .Select(e => new EmployeeViewModel
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    MiddleName = e.MiddleName,
                    LastName = e.LastName,
                    DesignationName = e.Designation != null ? e.Designation.DesignationName : null,
                    DOB = e.DOB,
                    MobileNumber = e.MobileNumber,
                    Address = e.Address,
                    Salary = e.Salary

                })
                .ToList();

        }
        public void AddEmployee(Employee emp)
        {
            _context.Employees.Add(emp);
        }
        public void UpdateEmployee(Employee emp) 
        {
            var existing = _context.Employees.Find(emp.Id);

            if (existing != null)
            {
                existing.FirstName = emp.FirstName;
                existing.MiddleName = emp.MiddleName;
                existing.LastName = emp.LastName;
                existing.DOB = emp.DOB;
                existing.MobileNumber = emp.MobileNumber;
                existing.Address = emp.Address;
                existing.Salary = emp.Salary;
                existing.DesignationId = emp.DesignationId;
            }
        }
        public void DeleteEmployee(int id)
        {
            var e = _context.Employees.Find(id);

            if(e != null)
            {
                _context.Employees.Remove(e);

            }
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }
        public List<EmployeeCountByDesignationViewModel> GetEmployeeCountByDesignation()
        {
            return _context.Designations
                .GroupJoin(
                    _context.Employees,
                    d => d.Id,
                    e => e.DesignationId,
                    (d, employees) => new EmployeeCountByDesignationViewModel
                    {
                        DesignationName = d.DesignationName,
                        EmployeeCount = employees.Count()
                    }
                )
                .ToList();
        }
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
