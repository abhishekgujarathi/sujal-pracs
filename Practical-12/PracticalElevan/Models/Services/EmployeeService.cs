using System.Collections.Generic;


namespace PracticalTwelve.Models
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _repo = new EmployeeRepository();

        public void AddEmployee(Employee emp)
        {
            _repo.Insert(emp);
        }

        public void UpdateEmployeeFirstName()
        {
            _repo.UpdateFirstName();
        }

        public void UpdateEmployeeMiddleName()
        {
            _repo.UpdateMiddleName();
        }

        public void DeleteEmployeeLessThanTwo()
        {
            _repo.DeleteLessThan2();
        }

        public void DeleteEmployeeAll()
        {
            _repo.DeleteAll();
        }

        public List<Employee> GetAllEmployees()
        {
            return _repo.GetAll();
        }
    }
}