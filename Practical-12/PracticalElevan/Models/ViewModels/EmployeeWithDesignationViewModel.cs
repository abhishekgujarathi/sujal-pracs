using System;
using System.ComponentModel.DataAnnotations;

namespace PracticalTwelve.Models
{
    public class EmployeeWithDesignationViewModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string DesignationName { get; set; }

    }
}