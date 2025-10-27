using AutoMapper;
using DemoMVC.Models;
using DemoMVC.Models.DTO;

namespace DemoMVC.Mapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employees, EmployeesDTO>
                ().ReverseMap();
        }
    }
}
