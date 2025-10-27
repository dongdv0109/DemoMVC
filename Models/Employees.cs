using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Employees
    {
        [Key]
        public Guid EmpId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public string? DateOfBirth { get; set; }
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        [DisplayName("Identification code")]
        public string? AppUserId { get; set; }
        [ForeignKey("AppUserId")]
        public virtual AppUser? AppUser { get; set; }

    }
}
