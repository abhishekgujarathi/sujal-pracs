using System.Collections.Generic;

namespace Practical_13_1.Models
{
    internal interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(int id);

        void CreateEmployee(Employee emp);

        void UpdateEmployee(Employee emp);

        void DeleteEmployee(int id);

    }
}
