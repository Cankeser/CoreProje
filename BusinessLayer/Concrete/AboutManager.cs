using BusinessLayer.Abstruct;
using EntityLayer.Concrete;
using DataAccessLayer.Abstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal aboutDal;
    
        public AboutManager(IAboutDal _aboutDal)
        {
            aboutDal = _aboutDal;
        }
        public void TAdd(About t)
        {
            aboutDal.Insert(t);
        }

        public void TDelete(About t)
        { 
           aboutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            return aboutDal.GetByID(id);
        }

        public List<About> TGetList()
        {
          return aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            aboutDal.Update(t);
        }
    }
}
