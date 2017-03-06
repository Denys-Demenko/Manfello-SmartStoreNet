using FluentValidation;
using SmartStore.Services.Localization;
using SmartStore.Web.Models.Common;

namespace SmartStore.Web.Validators.Common
{
    public class OrderCakeValidator : AbstractValidator<OrderCakeModel>
    {
        public OrderCakeValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.OrderRulesAgreement)
                .Must(x => x == true)
                .WithMessage(localizationService.GetResource("OrderCake.OrderCakeAgreement.MustBeAccepted"));

            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("ContactUs.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
            RuleFor(x => x.FullName).NotEmpty().WithMessage(localizationService.GetResource("ContactUs.FullName.Required"));
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage(localizationService.GetResource("OrderCake.Phone.Required"));
            RuleFor(x => x.PhoneNumber).Phone().WithMessage(localizationService.GetResource("Common.PhoneError"));
        }
    }
}