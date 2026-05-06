using System.Collections.Generic;

namespace Practical_13_2.Models
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        public List<EmployeeViewModel> GetAllEmployees()
        {
            return _repo.GetAllEmployees();
        }
        public string CreateEmployee(Employee emp)
        {
            if (emp == null)
                return "Employee data is null";

            _repo.AddEmployee(emp);
            _repo.Save();

            return $"{emp.FirstName} :: Added Successfully";
        }
        public string UpdateEmployee(Employee emp)
        {
            if (emp == null)
                return "Employee data is null";

            var e = _repo.GetEmployeeById(emp.Id);

            if (e == null)
                return $"Employee with ID {emp.Id} :: Not Found";

            _repo.UpdateEmployee(emp);
            _repo.Save();

            return $"{emp.Id} :: Updated Successfully";
        }

        public string DeleteEmployee(int id)
        {
            var e = _repo.GetEmployeeById(id);

            if (e == null)
                return $"Employee with ID {id} :: Not Found";

            _repo.DeleteEmployee(id);
            _repo.Save();

            return $"{e.FirstName} :: Deleted Successfully";
        }
        public List<EmployeeCountByDesignationViewModel> GetEmployeeCountByDesignation()
        {
            return _repo.GetEmployeeCountByDesignation();
        }
        public Employee GetEmployeeById(int id)
        {
            return _repo.GetEmployeeById(id);
        }
    }
}
