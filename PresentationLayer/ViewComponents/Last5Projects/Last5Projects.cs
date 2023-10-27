using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PresentationLayer.ViewComponents.Last5Projects
{
    public class Last5Projects:ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var last5 =portfolioManager.TGetList().OrderByDescending(p => p.PortfolioID).Take(5).ToList();
            return View(last5);
        }
    }
}
