using DemoMVC.Models;
using System.Runtime.InteropServices;

namespace DemoMVC.Repository
{
    public interface IEmployeeRepository
    {
        Task<Employees> Add(Employees employee);
        Task<Employees> Delete(Guid id);
        Task<Employees> Update(Employees employees);
        Task <List<Employees>> GetAllEmployees();
        Task<Employees> GetEmployeeById(Guid id);
    }
}
