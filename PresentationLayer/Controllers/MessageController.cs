using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Numerics;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        Context _context = new Context();
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public IActionResult Index()
        {
            var messages = _context.messages.ToList();
            return View(messages);
        }


        public IActionResult MessageDetail(int id)
        {
            var message = _context.messages.Find(id);

            if (message != null)
            {
                // Mesajı okundu olarak işaretle
                message.Status = true;
                _context.SaveChanges();
            }

            return View(message);
        }

       

    }
}
