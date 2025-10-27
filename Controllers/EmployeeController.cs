using DemoMVC.CQRS.User.Commands;
using DemoMVC.CQRS.User.Commands.DeleteEmployee;
using DemoMVC.CQRS.User.Commands.UpdateEmployee;
using DemoMVC.CQRS.User.Queries.GetAllEmployees;
using DemoMVC.CQRS.User.Queries.GetEmployeeById;
using DemoMVC.Database;
using DemoMVC.Models;
using DemoMVC.Models.DTO;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMediator _mediator;
        public EmployeeController(AppDbContext context, IMediator mediator)
        {
            _mediator = mediator;
            _context = context;
        }
        public async Task<ActionResult> Index()
        {
            var allUser = await _mediator.Send(new GetallEmployeesQuery());
            return View(allUser);
        }
        // GET: EmployeeController


        //GET: EmployeeController/Details/5
        public async Task<ActionResult> Details(Guid id)
        {
            var employee = await _mediator.Send(new GetemployeeByIdQuery(id));
            return View(employee);
        }



        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Employees employees, IFormCollection collection)
        { 
            EmployeesDTO emp = new()
            {
                Name = employees.Name,
                Email = employees.Email,
                DateOfBirth = employees.DateOfBirth,
                PhoneNumber = employees.PhoneNumber,
                Address = employees.Address,
            };
            await _mediator.Send(new CreateEmployeeCommands(emp));
            return RedirectToAction("Index", "Employee");
        }

        // GET: EmployeeController/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            var employee = await _mediator.Send(new GetemployeeByIdQuery(id));
            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EmployeesDTO employeesDTO, IFormCollection collection)
        {
            await _mediator.Send(new UpdateEmployeeCommands(employeesDTO));
            return RedirectToAction("Index", "Employee");
        }

        // GET: EmployeeController/Delete/5


        // POST: EmployeeController/Delete/5


        public async Task<ActionResult> DeleteEmp(Guid id)
        {
            await _mediator.Send(new DeleteEmployeeCommands(id));
            return RedirectToAction("Index", "Employee");
        }
    }
}
