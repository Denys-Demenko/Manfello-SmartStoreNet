using System;
using System.Collections.Generic;
using System.Linq;
using SmartStore.Web.Framework.Modelling;

namespace SmartStore.Web.Models.Common
{
    public class ContactsModel : ModelBase
    {
        public ContactsModel()
        {
            Contacts = new List<ContactModel>();
        }

		public ICollection<ContactModel> Contacts { get; private set; }
	}

    public class ContactModel
    {
        public ContactType Type { get; set; }

        public string Contact { get; set; }

        public string Link
        {
            get
            {
                switch (Type)
                {
                    case ContactType.Email:
                        return "mailto:" + Contact;
                    default:
                        return "#";
                }
            }
        }

        public string IconClass
        {
            get
            {
                switch (Type)
                {
                    case ContactType.Email:
                        return "fa-envelope-o";
                    default:
                        return string.Empty;
                }
            }
        }
    }

    public enum ContactType { Email }
}