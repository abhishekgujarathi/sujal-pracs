using System.Collections.Generic;

namespace Practical_13_2.Models
{
    public interface IEmployeeService
    {
        List<EmployeeViewModel> GetAllEmployees();
        string CreateEmployee(Employee emp);
        string UpdateEmployee(Employee emp);
        string DeleteEmployee(int id);
        List<EmployeeCountByDesignationViewModel> GetEmployeeCountByDesignation();
        Employee GetEmployeeById(int id);
    }
}
