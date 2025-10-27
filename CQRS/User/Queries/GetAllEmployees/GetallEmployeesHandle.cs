using AutoMapper;
using DemoMVC.Database;
using DemoMVC.Models;
using DemoMVC.Models.DTO;
using DemoMVC.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.CQRS.User.Queries.GetAllEmployees
{
    public class GetallEmployeesHandle : IRequestHandler<GetallEmployeesQuery, List<Employees>>
    {  
        private readonly AppDbContext _dbcontext;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public GetallEmployeesHandle(AppDbContext dbcontext, IEmployeeRepository employeeRepository,IMapper mapper)
        {
            _dbcontext = dbcontext;
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<List<Employees>> Handle(GetallEmployeesQuery request, CancellationToken cancellationToken)
        {
        //    var UserList = await _dbcontext.Employees.ToListAsync();
          var userList = await _employeeRepository.GetAllEmployees();
            var userListDTO =  _mapper.Map<List<Employees>>(userList);
           
            return userListDTO;
        }
    }
}
