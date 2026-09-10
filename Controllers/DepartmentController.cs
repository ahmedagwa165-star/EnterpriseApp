using Microsoft.AspNetCore.Mvc;

namespace EnterpriseApp.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult TestAjax()
        {
            return View();
        }
    }
}