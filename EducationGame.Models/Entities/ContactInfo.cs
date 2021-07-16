using System;
using System.Collections.Generic;
using System.Text;

namespace EducationGame.Models.Entities
{
    public class ContactInfo
    {
        public ContactInfo()
        {
            Emails = new HashSet<Email>();
        }
        public int ContactInfoId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Addresses { get; set; }

        public string PhoneNumber
        { get; set; }
        public ICollection<Email> Emails { get; set; }
    }
}
