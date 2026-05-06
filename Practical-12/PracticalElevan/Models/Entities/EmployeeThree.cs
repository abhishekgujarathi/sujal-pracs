using System;
using System.ComponentModel.DataAnnotations;

namespace PracticalTwelve.Models
{
    public class EmployeeThree
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Mobile Number is required")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Enter valid 10-digit mobile number")]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(0, 999999999, ErrorMessage = "Enter valid salary")]
        public decimal Salary { get; set; }

        [Display(Name ="Designation")]
        public int? DesignationID { get; set; }

        public Designation Designation { get; set; }
    }
}