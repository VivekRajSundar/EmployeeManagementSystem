using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is from Index function in the Home Controller";
        }
    }
}
