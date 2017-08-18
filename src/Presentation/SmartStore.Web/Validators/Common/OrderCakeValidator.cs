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

            RuleFor(x => x.CakeType).NotEmpty().WithMessage(localizationService.GetResource("OrderCake.CakeType.Required"));
            RuleFor(x => x.Filling).NotEmpty().WithMessage(localizationService.GetResource("OrderCake.Filling.Required"));
            RuleFor(x => x.Layering).NotEmpty().WithMessage(localizationService.GetResource("OrderCake.Layering.Required"));
            RuleFor(x => x.Size).NotEmpty().WithMessage(localizationService.GetResource("OrderCake.Size.Required"));
            RuleFor(x => x.Coating).NotEmpty().WithMessage(localizationService.GetResource("OrderCake.Coating.Required"));
        }
    }
}