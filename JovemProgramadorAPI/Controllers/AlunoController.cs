using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorAPI.Controllers
{
    
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
