using System.Collections.Generic;
using System.Linq;
using SmartStore.Web.Framework.Modelling;

namespace SmartStore.Web.Models.Common
{
    public class PhonesModel : ModelBase
    {
        public PhonesModel()
        {
            Phones = new List<PhoneModel>();
        }

		public ICollection<PhoneModel> Phones { get; private set; }
	}

    public class PhoneModel
    {
        private const string CountryCode = "+38";

        public string OutputNumber { get; set; }

        public string Number
        {
            get
            {
                var formatted = OutputNumber.RegexRemove("[^0-9]");

                var i = 0;
                while (CountryCode.Contains(formatted[0]))
                {
                    i++;
                }

                return CountryCode + formatted.Substring(i, formatted.Length - i);
            }
        }
    }
}