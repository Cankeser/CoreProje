using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager aboutManager=new AboutManager(new EfAboutDal());
       
        public IViewComponentResult Invoke()
        {
          
            var values=aboutManager.TGetList();
            return View(values);
        }

    }
}
