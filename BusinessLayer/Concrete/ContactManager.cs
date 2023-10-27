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
    public class ContactManager : IContactService
    {
        IContactDal contactDal;
        public ContactManager(IContactDal _contactDal)
        {
            contactDal = _contactDal;
        }
        public void TAdd(Contact t)
        {
           contactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
         contactDal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            return contactDal.GetByID(id);
        }

        public List<Contact> TGetList()
        {
          return contactDal.GetList();
        }

        public void TUpdate(Contact t)
        {
           contactDal.Update(t);
        }
    }
}
