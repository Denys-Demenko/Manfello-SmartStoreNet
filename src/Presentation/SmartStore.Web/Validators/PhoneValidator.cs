using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using FluentValidation.Resources;
using FluentValidation.Validators;
using SmartStore.Core.Localization;
using SmartStore.Web.Framework.Localization;

namespace SmartStore.Web.Validators
{
    /// <summary>
    /// Ensures that the property value is a valid phone number.
    /// 
    /// </summary>
    [SetWorkingCulture]
    public class PhoneValidator : PropertyValidator
    {
        static PhoneValidator()
        {
            T = NullLocalizer.Instance;
        }

        public PhoneValidator()
          : base(T("Common.PhoneError"))
        {
            
        }

        public static Localizer T { get; set; }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            string rawValue = context.PropertyValue as string;
            if (rawValue == null)
            {
                return true;
            }

            string value = Regex.Replace(rawValue, "[- \t\\(\\)]", string.Empty);
            foreach (char c in Enumerable.Reverse<char>(value.ToCharArray()))
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}