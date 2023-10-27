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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal featureDal;
        public FeatureManager(IFeatureDal _featureDal)
        {
           featureDal = _featureDal;
        }
        public void TAdd(Feature t)
        {
            featureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
           featureDal.Delete(t);
        }

        public Feature TGetByID(int id)
        {
            return featureDal.GetByID(id);
        }

        public List<Feature> TGetList()
        {
          return featureDal.GetList();
        }

        public void TUpdate(Feature t)
        {
            featureDal.Update(t);
        }
    }
}
