using DemoMVC.Models.DTO;
using MediatR;
using System;

namespace DemoMVC.CQRS.User.Queries.GetEmployeeById
{
    public class GetemployeeByIdQuery : IRequest<EmployeesDTO>
    {
        public Guid Id { get; set; }
        public GetemployeeByIdQuery(Guid id)
        {
            Id  = id;
        }
    }


}
