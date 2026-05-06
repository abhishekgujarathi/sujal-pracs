using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practical_13_2.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Mobile Number is required")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Must be 10 digits")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Only numeric values allowed")]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(1, double.MaxValue, ErrorMessage = "Salary must be greater than 0")]
        [Display(Name = "Salary")]
        public decimal Salary { get; set; }

        [StringLength(100, ErrorMessage = "Max 100 characters allowed")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        public int? DesignationId { get; set; }

        [ForeignKey("DesignationId")]
        public virtual Designation Designation { get; set; }
    }
}