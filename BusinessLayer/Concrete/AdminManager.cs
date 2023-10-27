using BusinessLayer.Abstruct;
using DataAccessLayer.Abstruct;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal adminDal;
        Context c=new Context();
        public AdminManager(IAdminDal _IAdminDal)
        {
            adminDal = _IAdminDal;
        }
        public void TAdd(Admin t)
        {
            adminDal.Insert(t);
        }

        public void TDelete(Admin t)
        {
            adminDal.Delete(t);
        }

        public Admin TGetByID(int id)
        {
            return adminDal.GetByID(id);
        }

        public List<Admin> TGetList()
        {
            return adminDal.GetList();
        }

        public void TUpdate(Admin t)
        {
            adminDal.Update(t);
        }
        public Admin GetBy(Expression<Func<Admin, bool>> expression)
        {
            return c.admins.FirstOrDefault(expression);
        }

    }
}
