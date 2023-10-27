using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("500 karakterden fazla girilemez");
            RuleFor(x => x.Age).NotEmpty().WithMessage("yaş boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("yaş boş geçilemez").EmailAddress().WithMessage("lütfen mail formatında giriniz");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("yaş boş geçilemez");
            RuleFor(x => x.Address).NotEmpty().WithMessage("yaş boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("yaş boş geçilemez");    
    
        }
       
    }
}
