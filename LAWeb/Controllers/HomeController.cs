using LACore.Interfaces;
using LAInfrastructure.Interfaces;
using LAWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Linq;

namespace LAWeb.Controllers
{
    public class HomeController : Controller
    {
        private IProbabilityService _probabilityService;
        public HomeController(IProbabilityService probabilityService)
        {
            _probabilityService = probabilityService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        [Route("/api/home/getdata/{top}")]
        public IActionResult GetHomeData(int top = 10)
        {
            return new ObjectResult(new HomeVM { TopProbable = _probabilityService.GetTopNumbers(top).ToList() });
        }
    }
}
