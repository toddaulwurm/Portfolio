using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]
        public string Portfolio()
        {
            return "This is my Portfolio!";
        }
        [HttpGet("projects")]
        public string Projects()
        {
            return "Projects!";
        }
        [HttpGet("contact")]
        public string Contact()
        {
            return "Contact Me!";
        }
    }
}