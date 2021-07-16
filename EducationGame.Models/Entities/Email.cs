using System;
using System.Collections.Generic;
using System.Text;

namespace EducationGame.Models.Entities
{
    public class Email
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public int ContactInfoId { get; set; }
        public ContactInfo ContactInfo { get; set; }
    }
}
