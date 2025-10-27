using AutoMapper;
using DemoMVC.Database;
using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DemoMVC.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        public EmployeeRepository(IMapper mapper, AppDbContext appDbContext)
        {
            _mapper = mapper;
            _dbContext = appDbContext;
        }
        public async Task<Employees> Add(Employees employee)
        {

            await _dbContext.Employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync();
            return employee;

        }

        public async Task<Employees> Delete(Guid id)
        {
            //tim toi eployee theo id
            var employee = await _dbContext.Employees.AsNoTracking().FirstOrDefaultAsync(x => x.EmpId == id);
            if (employee != null) 
            {
               _dbContext.Employees.Remove(employee);
                await _dbContext.SaveChangesAsync();
                
            }
            return null ;
            
        }

      

        public async Task<List<Employees>> GetAllEmployees()
        {
            var listemployee = await _dbContext.Employees.ToListAsync();
            return listemployee;
        }

        public async Task<Employees> GetEmployeeById(Guid id)
        {
            var empl = await _dbContext.Employees.Where(a => a.EmpId == id).FirstOrDefaultAsync();
            if (empl == null)
            {
                return null;
            }
            return empl;


        }

        public async Task<Employees> Update(Employees employees)
        {
            _dbContext.Employees.Update(employees);
            await _dbContext.SaveChangesAsync();
            return employees;
        }
    }
}
