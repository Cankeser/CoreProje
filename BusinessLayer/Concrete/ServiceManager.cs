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
    public class ServiceManager : IServiceService
    {
        IServiceDal serviceDal;
        public ServiceManager(IServiceDal _serviceDal)
        {
            serviceDal = _serviceDal;
        }
        public void TAdd(Service t)
        {
           serviceDal.Insert(t);    
        }

        public void TDelete(Service t)
        {
           serviceDal.Delete(t);
        }

        public Service TGetByID(int id)
        {
            return serviceDal.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return serviceDal.GetList();
        }

        public void TUpdate(Service t)
        {
           serviceDal.Update(t);
        }
    }
}
