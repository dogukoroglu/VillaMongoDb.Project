using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Entity.Entities;

namespace Villa.Business.Validators
{
	public class QuestionValidator : AbstractValidator<Quest>
	{
        public QuestionValidator()
        {
            RuleFor(x => x.Question).NotEmpty().WithMessage("Soru alanı boş bırakılamaz!");
            RuleFor(x => x.Question).MinimumLength(4).WithMessage("En az 4 karakter girişi yapınız!");
            RuleFor(x => x.Answer).NotEmpty().WithMessage("Cevap alanı boş bırakılamaz!");
			RuleFor(x => x.Answer).MinimumLength(4).WithMessage("En az 4 karakter girişi yapınız!");
		}
	}
}
