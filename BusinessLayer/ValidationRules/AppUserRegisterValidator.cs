using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator: AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanını boş geçemezsiniz...!");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyad alanını boş geçemezsiniz...!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanını boş geçemezsiniz...!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı alanını boş geçemezsiniz...!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanını boş geçemezsiniz...!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanını boş geçemezsiniz...!");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız.");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız.");
            RuleFor(x => x.UserName).Equal(y=>y.ConfirmPassword).WithMessage("Şifreler birbiri ile uyuşmuyor.");
        }
    }
}
