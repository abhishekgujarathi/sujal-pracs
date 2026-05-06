using System.Collections.Generic;

namespace Practical_14.Models
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _repo; 
        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        public List<Employee> GetEmployees()
        {
            return _repo.GetAll();
        }

        public Employee GetEmployee(int id)
        {
            return _repo.GetById(id);
        }

        public void CreateEmployee(Employee emp)
        {
            _repo.Add(emp);
            _repo.Save();
        }

        public void UpdateEmployee(Employee emp)
        {
            _repo.Update(emp);
            _repo.Save();
        }

        public void DeleteEmployee(int id)
        {
            _repo.Delete(id);
            _repo.Save();
        }
    }
}