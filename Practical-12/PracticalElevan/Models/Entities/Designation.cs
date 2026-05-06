using System.ComponentModel.DataAnnotations;

namespace PracticalTwelve.Models
{
    public class Designation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Designation is required")]
        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        public string DesignationName { get; set; }
    }
}