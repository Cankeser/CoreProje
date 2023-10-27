using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var values = aboutManager.TGetList();
            return View( values);
        }

        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var values = aboutManager.TGetByID(id);
            return View(values);
        }
        
        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteAbout(About about)
        {
            aboutManager.TDelete(about);
            return RedirectToAction("Index");
        }


    }
}
