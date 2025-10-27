using AutoMapper;
using DemoMVC.Database;
using DemoMVC.Models;
using DemoMVC.Models.DTO;
using DemoMVC.Repository;
using MediatR;

namespace DemoMVC.CQRS.User.Commands.UpdateEmployee
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommands, EmployeesDTO>
    {
        private readonly AppDbContext _DbContext;
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public UpdateEmployeeHandler(AppDbContext DbContext, IMapper mapper,IEmployeeRepository employeeRepository)
        {
            _DbContext = DbContext;
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }
        public async Task<EmployeesDTO> Handle(UpdateEmployeeCommands request, CancellationToken cancellationToken)
        {
            var emp = _mapper.Map<Employees>(request.UpdateEmployee);
            //_DbContext.Employees.Update(emp);
            //await _DbContext.SaveChangesAsync();
            //var updateEmployee = _mapper.Map<EmployeesDTO>(emp);
            //return updateEmployee;
            emp = await _employeeRepository.Update(emp);
            var employDTO  = _mapper.Map<EmployeesDTO>(emp);
            
            return employDTO;
        }
    }
}
