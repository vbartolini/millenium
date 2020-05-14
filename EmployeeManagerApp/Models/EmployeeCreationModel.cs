using System.ComponentModel.DataAnnotations;

namespace EmployeeManagerApp.Models
{
    public class EmployeeCreationModel
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
    }
}
