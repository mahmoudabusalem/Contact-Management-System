using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementSystem
{

    public class User
    {
        private int Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Gender { get; set; }
        private string City { get; set; }
        private string AddedDate { get; set; }

        private List<Address> Addresses;
        private List<Email> Emails;
        private List<Phone> Phones;

        public User(int id, string firstName, string lastName, string gender, string city, string addedDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            City = city;
            AddedDate = addedDate;

            Addresses = new List<Address>();
            Emails = new List<Email>();
            Phones = new List<Phone>();
        }

        public int GetUserId()
        {
            return Id;
        }

        public void Edit(string firstName, string lastName, string gender, string city, string addedDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            City = city;
            AddedDate = addedDate;
        }

        public bool Search(string searchData)
        {
            return FirstName.Contains(searchData) || LastName.Contains(searchData) ||
                   City.Contains(searchData) || Gender.Contains(searchData);
        }

        public void Show()
        {
            Console.WriteLine($"User Information:");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Added Date: {AddedDate}");

            Console.WriteLine("\nAddresses:");
            foreach (var address in Addresses)
            {
                Console.WriteLine(address.GetAddress());
            }

            Console.WriteLine("\nEmails:");
            foreach (var email in Emails)
            {
                Console.WriteLine(email.GetEmail());
            }

            Console.WriteLine("\nPhones:");
            foreach (var phone in Phones)
            {
                Console.WriteLine(phone.GetPhone());
            }

            Console.WriteLine(new string('-', 30));
        }

        public void AddAddress(Address address)
        {
            Addresses.Add(address);
        }

        public void AddEmail(Email email)
        {
            Emails.Add(email);
        }

        public void AddPhone(Phone phone)
        {
            Phones.Add(phone);
        }
    }

}
