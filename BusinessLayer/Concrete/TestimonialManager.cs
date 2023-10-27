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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal testimonialService;
        public TestimonialManager(ITestimonialDal _testimonialDal)
        {
            testimonialService = _testimonialDal;
        }
        public void TAdd(Testimonial t)
        {
            testimonialService.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            testimonialService.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return testimonialService.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return testimonialService.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            testimonialService.Update(t);
        }
    }
}
