using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return HeaderPartial();
        }
        public PartialViewResult NavbarPartial()
        {
            return NavbarPartial();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return NavbarPartial();
        }
        [HttpPost]
        public PartialViewResult SendMessage(Message p)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now);
            p.Status = false;
            messageManager.TAdd(p);

            return PartialView("index");
        }



    }
}
