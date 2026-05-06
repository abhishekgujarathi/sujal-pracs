using System;
using System.ComponentModel.DataAnnotations;

namespace Practical_13_1.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50,ErrorMessage ="maximum 50 chars allowed")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]

        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Age is required")]

        public int Age { get; set; }
    }
}