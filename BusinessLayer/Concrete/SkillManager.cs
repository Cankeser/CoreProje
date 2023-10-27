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
    public class SkillManager : ISkillService
    {
        ISkillDal skillDal;
        public SkillManager(ISkillDal _skillDal)
        {
            skillDal = _skillDal;
        }
        public void TAdd(Skill t)
        {
            skillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            skillDal.Delete(t);
        }

        public Skill TGetByID(int id)
        {
            return skillDal.GetByID(id);
        }

        public List<Skill> TGetList()
        {
            return skillDal.GetList();
        }

        public void TUpdate(Skill t)
        {
            skillDal.Update(t);
        }
    }
}
