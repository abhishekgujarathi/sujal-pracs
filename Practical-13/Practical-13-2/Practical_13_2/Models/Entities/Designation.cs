using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practical_13_2.Models
{
    public class Designation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Designation Name is required")]
        [StringLength(50, ErrorMessage = "Maximum 50 characters allowed")]
        [Display(Name = "Designation")]
        public string DesignationName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}