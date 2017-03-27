using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FluentValidation.Attributes;
using SmartStore.Web.Framework;
using SmartStore.Web.Framework.Modelling;
using SmartStore.Web.Validators.Common;

namespace SmartStore.Web.Models.Common
{
	[Validator(typeof(OrderCakeValidator))]
    public partial class OrderCakeModel : ModelBase
    {
	    public OrderCakeModel()
	    {
	        CakeTypes = new List<SelectListItem>();
            Fillings = new List<SelectListItem>();
            Layerings = new List<SelectListItem>();
            Sizes = new List<SelectListItem>();
            Coatings = new List<SelectListItem>();
        }

        [AllowHtml]
        [SmartResourceDisplayName("ContactUs.FullName")]
        public string FullName { get; set; }

        [SmartResourceDisplayName("OrderCake.Phone")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [AllowHtml]
        [SmartResourceDisplayName("ContactUs.Email")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

        [SmartResourceDisplayName("Products.Sku")]
        public string SKU { get; set; }

        [SmartResourceDisplayName("OrderCake.CakeType")]
        public string CakeType { get; set; }
        public ICollection<SelectListItem> CakeTypes { get; private set; }

        [SmartResourceDisplayName("OrderCake.Filling")]
        public string Filling { get; set; }
        public ICollection<SelectListItem> Fillings { get; private set; }

        [SmartResourceDisplayName("OrderCake.Layering")]
        public string Layering { get; set; }
        public ICollection<SelectListItem> Layerings { get; private set; }

        [SmartResourceDisplayName("OrderCake.Size")]
        public string Size { get; set; }
        public ICollection<SelectListItem> Sizes { get; private set; }

        [SmartResourceDisplayName("OrderCake.Coating")]
        public string Coating { get; set; }
        public ICollection<SelectListItem> Coatings { get; private set; }

        [SmartResourceDisplayName("OrderCake.Design")]
        public string DesignFileName { get; set; }

        [AllowHtml]
        [SmartResourceDisplayName("OrderCake.Suggestions")]
        public string Suggestions { get; set; }

        [SmartResourceDisplayName("OrderCake.TargetDate")]
        public DateTime TargetDate { get; set; }

        [SmartResourceDisplayName("OrderCake.OrderRulesAgreement")]
        public bool OrderRulesAgreement { get; set; }

        public bool SuccessfullySent { get; set; }
        public string Result { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}