using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {

        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IActionResult Index()
        {
            var values = contactManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult EditContact(int id)
        {
            var values = contactManager.TGetByID(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult EditContact(Contact contact)
        {
            contactManager.TUpdate(contact);
            return RedirectToAction("Index");
        }

    }
}

