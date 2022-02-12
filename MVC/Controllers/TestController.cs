using MVC.Models;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Update()
        {
            var person = new Person()
            {
                Name = "Jay",
                Address = "Seoul",
                Age = 30,
                Major = "Computer Science",
            };
            
            return View(person);
        }
    }
}