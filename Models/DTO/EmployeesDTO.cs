using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DemoMVC.Models.DTO
{
    public class EmployeesDTO
    {
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
        public string? AppUserId { get; set; }
    }
}
