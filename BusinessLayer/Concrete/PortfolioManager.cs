using BusinessLayer.Abstruct;
using EntityLayer.Concrete;
using DataAccessLayer.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal portfolioDal;
        public PortfolioManager(IPortfolioDal _portfolioDal)
        {
            portfolioDal = _portfolioDal;
        }
        public void TAdd(Portfolio t)
        {
            portfolioDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
           portfolioDal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return portfolioDal.GetByID(id);
        }

        public List<Portfolio> TGetList()
        {
          return portfolioDal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            portfolioDal.Update(t);
        }
    }
}
