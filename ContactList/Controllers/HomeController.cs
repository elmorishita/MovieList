using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ContactList.Models;

namespace ContactList.Controllers
{
    public class HomeController : Controller
    {
        private PhoneContext context { get; set; }

        public HomeController(PhoneContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var phNumbers = context.Contacts.OrderBy(c => c.Name).ToList();
            return View(phNumbers);
        }
    
    }
}