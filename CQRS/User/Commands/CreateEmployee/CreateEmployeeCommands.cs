using DemoMVC.Models.DTO;
using MediatR;

namespace DemoMVC.CQRS.User.Commands
{
    public class CreateEmployeeCommands : IRequest<EmployeesDTO>
    {
        public CreateEmployeeCommands(EmployeesDTO employeesDTO) 
        { 
            EmployeesDTO = employeesDTO;
        }
        public EmployeesDTO EmployeesDTO { get; }
    }
}
