using Microsoft.AspNetCore.Mvc;

namespace Api.User.Controllers
{
    public class DanhMucController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
