using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementSystem
{
    public class Email
    {
        private string EmailAddress { get; set; }
        private string Type { get; set; }
        private string Description { get; set; }

        public Email(string email, string type, string description)
        {
            EmailAddress = email;
            Type = type;
            Description = description;
        }

        public void SetEmail(string email)
        {
            EmailAddress = email;
        }

        public void SetType(string type)
        {
            Type = type;
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public string GetEmail()
        {
            return $"Email: {EmailAddress}\nType: {Type}\nDescription: {Description}";
        }
    }

}
