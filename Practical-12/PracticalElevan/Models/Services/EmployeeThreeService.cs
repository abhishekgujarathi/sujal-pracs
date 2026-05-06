using System.Collections.Generic;

namespace PracticalTwelve.Models
{
    public class EmployeeThreeService
    {
        private readonly EmployeeThreeRepository _repo = new EmployeeThreeRepository();

        public List<DesignationCountViewModel> GetCountByDesignation()
        {
             return _repo.CountByDesignation();
        }
        public List<EmployeeWithDesignationViewModel> GetDisplayByDesignation()
        {
            return _repo.DisplayByDesignation();
        }
        public List<EmployeeDetailsViewModel> GetDisplayByView()
        {
            return _repo.DisplayByView();
        }

        public void InsertEmployee(EmployeeThree emp)
        {
            _repo.InsertEmployee(emp);
        }
        public string InsertDesignation(Designation desg)
        {
            if (_repo.IsDesignationExists(desg.DesignationName))
            {
                return "Designation already exists";
            }

            _repo.InsertDesignation(desg);
            return "Success";
        }
        public List<DesignationMoreThanOneViewModel> GetMoreThanOneEmployeeDesignation()
        {
            return _repo.MoreThanOneEmployeeDesignation();
        }
        public List<EmployeeDetailsViewModel> GetDisplayByStoredProcedure()
        {
            return _repo.DisplayByStoredProcedure();
        }
        public List<EmployeeDetailsByDesignationViewModel> GetDisplayEmployeesByDesignationStoredProcedure(int id)
        {
            return _repo.DisplayEmployeesByDesignationStoredProcedure(id);
        }

        public EmployeeDetailsViewModel GetMaxSalaryEmployee()
        {
            return _repo.MaxSalaryEmployee();
        }
        public List<Designation> GetDesignations()
        {
            return _repo.GetAllDesignations();
        }
        public void CreateIndex()
        {
            _repo.CreateNonClusteredIndexOnDesignationId();
        }
    }
}