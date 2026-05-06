using System;
using System.ComponentModel.DataAnnotations;

namespace Practical_14.Models
{
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee{}

    public class EmployeeMetaData
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int? Age { get; set; }
    }
}