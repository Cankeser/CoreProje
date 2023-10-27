using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PresentationLayer.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        MessageManager MessageManager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = MessageManager.TGetList().OrderByDescending(d=>d.Date).Take(4).ToList();
            return View(values);
        }

    }
}
