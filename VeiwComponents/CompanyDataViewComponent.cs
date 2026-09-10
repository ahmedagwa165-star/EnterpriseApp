using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EnterpriseApp.Data;

namespace EnterpriseApp.ViewComponents
{
    public class CompanyDataViewComponent : ViewComponent
    {
        private readonly EnterpriseDbContext _context;
        public CompanyDataViewComponent(EnterpriseDbContext context) => _context = context;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = new CompanyDataVM
            {
                TotalEmployees = await _context.Employees.CountAsync(),
                TotalDepartments = await _context.Departments.CountAsync(),
                AverageSalary = await _context.Employees.AverageAsync(e => e.Salary)
            };
            return View(data);
        }
    }

    public class CompanyDataVM
    {
        public int TotalEmployees { get; set; }
        public int TotalDepartments { get; set; }
        public decimal AverageSalary { get; set; }
    }
}