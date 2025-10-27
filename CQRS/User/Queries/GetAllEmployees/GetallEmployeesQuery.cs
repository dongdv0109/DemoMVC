using DemoMVC.Models;
using MediatR;

namespace DemoMVC.CQRS.User.Queries.GetAllEmployees
{
    public class GetallEmployeesQuery: IRequest<List<Employees>>
    {
    }
}
