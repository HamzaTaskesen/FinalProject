using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(10);
            //RuleFor(p => p.ColorId).Must(StartWith1);
        }
    }
}
        //private bool StartWith1(int arg)
        //{
        //    return arg.StartsWith(1);
        //}
    
