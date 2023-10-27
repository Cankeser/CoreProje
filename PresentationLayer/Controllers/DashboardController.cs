using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
       Context c=new Context();
        public IActionResult Index()
        {
            ViewBag.v1 = c.skills.Count();
            ViewBag.v2=c.messages.Where(x=>x.Status==false).Count();
            ViewBag.v3=c.messages.Where(x=>x.Status==true).Count();
            ViewBag.v4=c.experiences.Count();
            return View();
        }
       


    }
}
