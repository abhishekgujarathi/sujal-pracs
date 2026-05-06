using System.Collections.Generic;

namespace Practical_13_2.Models
{
    public interface IEmployeeRepository
    {
        List<EmployeeViewModel> GetAllEmployees();
        void AddEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int id);
        Employee GetEmployeeById(int id);
        List<EmployeeCountByDesignationViewModel> GetEmployeeCountByDesignation();
        void Save();
    }
}
