using System;
using System.ComponentModel.DataAnnotations;

namespace Practical_11.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Max 100 characters allowed")]
        public string Address { get; set; }
    }
}