using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View("Index");
        }
        [HttpGet("contact")]
        public string Contact()
        {
            return "Contact Me!";
        }
    }
}