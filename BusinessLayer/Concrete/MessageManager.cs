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
    public class MessageManager : IMessageService
    {
        IMessageDal messageDal;
        public MessageManager(IMessageDal _messageDal)
        {
            messageDal = _messageDal;
        }
        public void TAdd(Message t)
        {
           messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
         messageDal.Delete(t);
        }

        public Message TGetByID(int id)
        {
            return messageDal.GetByID(id);
        }

        public List<Message> TGetList()
        {
          return messageDal.GetList();
        }

        public void TUpdate(Message t)
        {
           messageDal.Update(t);
        }
    }
}
