using AutoMapper;
using DemoMVC.Database;
using DemoMVC.Models;
using DemoMVC.Models.DTO;
using DemoMVC.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace DemoMVC.CQRS.User.Commands
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommands, EmployeesDTO>
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;
        private readonly IEmployeeRepository _employeeRepository;
        public CreateEmployeeHandler (IMapper mapper, AppDbContext context,IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _context = context;
            _employeeRepository = employeeRepository;
        }
        public async Task<EmployeesDTO> Handle(CreateEmployeeCommands request, CancellationToken cancellationToken)
        {
            var employee = _mapper.Map<Employees>(request.EmployeesDTO);
            //var employeeEntity = await _context.Employees.AddAsync(employee);
            //await _context.SaveChangesAsync();
            //var employeeDTO = _mapper.Map<EmployeesDTO>(employeeEntity.Entity);
            //return employeeDTO;
            employee = await _employeeRepository.Add(employee);
    
          
            var employeeDTO = _mapper.Map<EmployeesDTO>(employee);
            //await _context.SaveChangesAsync();
            return employeeDTO;


        }
    }
}
