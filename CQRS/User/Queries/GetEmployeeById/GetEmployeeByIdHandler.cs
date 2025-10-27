using AutoMapper;
using DemoMVC.Database;
using DemoMVC.Models.DTO;
using DemoMVC.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.CQRS.User.Queries.GetEmployeeById
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetemployeeByIdQuery, EmployeesDTO>
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeByIdHandler(AppDbContext DbContext, IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _appDbContext = DbContext;
            _mapper = mapper;
            _employeeRepository = employeeRepository;

        }
        public async Task<EmployeesDTO> Handle(GetemployeeByIdQuery request, CancellationToken cancellationToken)
        {
            //var empId = await _appDbContext.Employees.Where(a => a.EmpId == request.Id).FirstOrDefaultAsync();
            //if (empId == null)
            //{
            //    return null;
            //}
            //var employeeDTO = _mapper.Map<EmployeesDTO>(empId);
            //return employeeDTO;
            var emp = await _employeeRepository.GetEmployeeById(request.Id);
          
            var empDTO = _mapper.Map<EmployeesDTO>(emp);
            return empDTO; 
        }
    }
}
