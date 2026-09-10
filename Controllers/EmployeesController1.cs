using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EnterpriseApp.Data;

namespace EnterpriseApp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EnterpriseDbContext _context;
        public EmployeesController(EnterpriseDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employees.Include(e => e.Department).ToListAsync();
            return View(employees);
        }

        [HttpGet]
        public async Task<JsonResult> GetEmployeesAjax()
        {
            var employees = await _context.Employees
                .Select(e => new { e.EmployeeID, e.FirstName, e.LastName, e.Salary })
                .ToListAsync();
            return Json(employees);
        }
    }
}