using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Miasin.Web.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return Content("Hello");
        }
    }
}