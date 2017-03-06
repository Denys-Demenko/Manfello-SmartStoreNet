using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using FluentValidation.Validators;

namespace SmartStore.Web.Validators
{
    public static class ValidatorExtensions
    {
        /// <summary>
        /// Defines a phone number validator for the current rule builder that ensures that the specified string is a valid phone number.
        /// 
        /// </summary>
        public static IRuleBuilderOptions<T, string> Phone<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator((IPropertyValidator)new PhoneValidator());
        }
    }
}