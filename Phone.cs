using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementSystem
{
    public class Phone
    {
        private string PhoneNumber { get; set; }
        private string Type { get; set; }
        private string Description { get; set; }

        public Phone(string phone, string type, string description)
        {
            PhoneNumber = phone;
            Type = type;
            Description = description;
        }

        public void SetPhone(string phone)
        {
            PhoneNumber = phone;
        }

        public void SetType(string type)
        {
            Type = type;
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public string GetPhone()
        {
            return $"Phone: {PhoneNumber}\nType: {Type}\nDescription: {Description}";
        }
    }

}
