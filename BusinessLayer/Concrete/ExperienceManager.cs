using BusinessLayer.Abstruct;
using DataAccessLayer.Abstruct;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal experienceDal;
        public ExperienceManager(IExperienceDal _experienceDal)
        {
            experienceDal = _experienceDal;
        }
        public void TAdd(Experience t)
        {
           experienceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
           experienceDal.Delete(t);
        }

        public Experience TGetByID(int id)
        {
           return experienceDal.GetByID(id);    
        }

        public List<Experience> TGetList()
        {
            return experienceDal.GetList();
        }

        public void TUpdate(Experience t)
        {
            experienceDal.Update(t);   
        }
    }
}
