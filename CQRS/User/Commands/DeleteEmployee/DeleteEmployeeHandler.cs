using AutoMapper;
using DemoMVC.Database;
using DemoMVC.Models;
using DemoMVC.Models.DTO;
using DemoMVC.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.CQRS.User.Commands.DeleteEmployee
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommands, Employees>
    {
        private readonly AppDbContext _dbcontext;
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public DeleteEmployeeHandler(AppDbContext dbcontext, IMapper mapper,IEmployeeRepository employeeRepository)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }
        public async Task<Employees> Handle(DeleteEmployeeCommands request, CancellationToken cancellationToken)
        {
            //var emp = await _dbcontext.Employees.AsNoTracking().FirstOrDefaultAsync(a => a.EmpId == request.Id);
            //if (emp == null)
            //{
            //    return null;
            //}
            //_dbcontext.Employees.Remove(emp);
            //await _dbcontext.SaveChangesAsync();
            //return emp;
           var emp = await _employeeRepository.Delete(request.Id);
           return emp;
        }

    }
}
