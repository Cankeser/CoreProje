﻿using DataAccessLayer.Abstruct;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entityframework
{
    public class EfSkillDal : GenericRepository<Skill>,ISkillDal
    {
    }
}
