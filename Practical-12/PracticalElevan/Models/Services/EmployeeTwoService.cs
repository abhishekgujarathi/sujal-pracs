using System.Collections.Generic;

namespace PracticalTwelve.Models
{
    public class EmployeeTwoService
    {
        private readonly EmployeeTwoRepository _repo = new EmployeeTwoRepository();

        public void AddEmployee(EmployeeTwo emp)
        {
            _repo.Insert(emp);
        }

        public List<EmployeeTwo> GetEmployeeBefore2000()
        {
            return _repo.GetBefore2000();
        }

        public int CountEmployeeNullMiddleName()
        {
            return _repo.CountNullMiddleName();
        }

        public int GetEmployeeTotalSalary()
        {
            return _repo.GetTotalSalary();
        }


        public List<EmployeeTwo> GetAllEmployees()
        {
            return _repo.GetAll();
        }
    }
}