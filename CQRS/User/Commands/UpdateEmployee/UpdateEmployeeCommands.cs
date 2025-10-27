using DemoMVC.Models.DTO;
using MediatR;

namespace DemoMVC.CQRS.User.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommands:IRequest<EmployeesDTO>
    {
        public EmployeesDTO UpdateEmployee { get; set; }
        public UpdateEmployeeCommands(EmployeesDTO employeesDTO) 
        {
            UpdateEmployee = employeesDTO;
        }
    }
}
