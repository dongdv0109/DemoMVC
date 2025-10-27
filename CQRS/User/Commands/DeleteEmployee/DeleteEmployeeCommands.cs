using DemoMVC.Models;
using DemoMVC.Models.DTO;
using MediatR;

namespace DemoMVC.CQRS.User.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommands : IRequest<Employees>
    {
        public Guid Id { get; set; }
        public DeleteEmployeeCommands(Guid id)
        {
            Id = id;
        }
    }
}
