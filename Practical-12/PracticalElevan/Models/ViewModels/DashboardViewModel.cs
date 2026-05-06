using System.Collections.Generic;

namespace PracticalTwelve.Models
{
    public class DashboardViewModel
    {
        public List<DesignationCountViewModel> CountByDesignation { get; set; }
        public List<EmployeeWithDesignationViewModel> DisplayByDesignation { get; set; }
        public List<EmployeeDetailsViewModel> DisplayByView { get; set; }
        public List<DesignationMoreThanOneViewModel> MoreThanOne { get; set; }
        public EmployeeDetailsViewModel MaxSalaryEmployee { get; set; }
        public List<EmployeeDetailsViewModel> DisplayByStoredProcedure { get; set; }
    }
}