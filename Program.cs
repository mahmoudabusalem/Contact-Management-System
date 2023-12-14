namespace ContactManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Numerics;

    class Program
    {
        static Contact contactList = new Contact();

        static void Main()
        {
            Console.WriteLine("   ___         _           _      __  __                                 _             _ _         _   _          \r\n  / __|___ _ _| |_ __ _ __| |_   |  \\/  |__ _ _ _  __ _ __ _ ___ _ _    /_\\  _ __ _ __| (_)__ __ _| |_(_)___ _ _  \r\n | (__/ _ \\ ' \\  _/ _` / _|  _|  | |\\/| / _` | ' \\/ _` / _` / -_) '_|  / _ \\| '_ \\ '_ \\ | / _/ _` |  _| / _ \\ ' \\ \r\n  \\___\\___/_||_\\__\\__,_\\__|\\__|  |_|  |_\\__,_|_||_\\__,_\\__, \\___|_|   /_/ \\_\\ .__/ .__/_|_\\__\\__,_|\\__|_\\___/_||_|\r\n                                                       |___/                |_|  |_|                              ");
            while (true)
            {
                Console.WriteLine("\nContact Management System");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Edit User");
                Console.WriteLine("3. Delete User");
                Console.WriteLine("4. Search User");
                Console.WriteLine("5. Display All Users");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice (1-6): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddUser();
                        break;
                    case "2":
                        EditUser();
                        break;
                    case "3":
                        DeleteUser();
                        break;
                    case "4":
                        SearchUser();
                        break;
                    case "5":
                        DisplayAllUsers();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }
        }

        static void AddUser()
        {
            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Gender: ");
            string gender = Console.ReadLine();
            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            Console.Write("Enter Added Date: ");
            string addedDate = Console.ReadLine();

            User newUser = new User(id, firstName, lastName, gender, city, addedDate);

            Console.WriteLine("Enter Address Information:");
            Console.Write("Place: ");
            string addressPlace = Console.ReadLine();
            Console.Write("Type (e.g., Home, Work): ");
            string addressType = Console.ReadLine();
            Console.Write("Description: ");
            string addressDescription = Console.ReadLine();
            Address userAddress = new Address(addressPlace, addressType, addressDescription);
            newUser.AddAddress(userAddress);

            Console.WriteLine("Enter Email Information:");
            Console.Write("Email: ");
            string emailAddress = Console.ReadLine();
            Console.Write("Type (e.g., Personal, Work): ");
            string emailType = Console.ReadLine();
            Console.Write("Description: ");
            string emailDescription = Console.ReadLine();
            Email userEmail = new Email(emailAddress, emailType, emailDescription);
            newUser.AddEmail(userEmail);

            Console.WriteLine("Enter Phone Information:");
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Type (e.g., Mobile, Home): ");
            string phoneType = Console.ReadLine();
            Console.Write("Description: ");
            string phoneDescription = Console.ReadLine();
            Phone userPhone = new Phone(phoneNumber, phoneType, phoneDescription);
            newUser.AddPhone(userPhone);

            contactList.AddUser(newUser);
            Console.WriteLine("User added successfully.");
        }


        static void EditUser()
        {
            Console.Write("Enter ID of the user to edit: ");
            int userId = Convert.ToInt32(Console.ReadLine());

            User userToEdit = contactList.GetUsers().Find(user => user.GetUserId() == userId);

            if (userToEdit != null)
            {
                Console.Write("Enter New First Name: ");
                string newFirstName = Console.ReadLine();
                Console.Write("Enter New Last Name: ");
                string newLastName = Console.ReadLine();
                Console.Write("Enter New Gender: ");
                string newGender = Console.ReadLine();
                Console.Write("Enter New City: ");
                string newCity = Console.ReadLine();
                Console.Write("Enter New Added Date: ");
                string newAddedDate = Console.ReadLine();

                contactList.EditUser(userToEdit, newFirstName, newLastName, newGender, newCity, newAddedDate);

                Console.WriteLine("Enter New Address Information:");
                Console.Write("Place: ");
                string newAddressPlace = Console.ReadLine();
                Console.Write("Type (e.g., Home, Work): ");
                string newAddressType = Console.ReadLine();
                Console.Write("Description: ");
                string newAddressDescription = Console.ReadLine();
                Address newAddress = new Address(newAddressPlace, newAddressType, newAddressDescription);
                userToEdit.AddAddress(newAddress);

                Console.WriteLine("Enter New Email Information:");
                Console.Write("Email: ");
                string newEmailAddress = Console.ReadLine();
                Console.Write("Type (e.g., Personal, Work): ");
                string newEmailType = Console.ReadLine();
                Console.Write("Description: ");
                string newEmailDescription = Console.ReadLine();
                Email newEmail = new Email(newEmailAddress, newEmailType, newEmailDescription);
                userToEdit.AddEmail(newEmail);

                Console.WriteLine("Enter New Phone Information:");
                Console.Write("Phone Number: ");
                string newPhoneNumber = Console.ReadLine();
                Console.Write("Type (e.g., Mobile, Home): ");
                string newPhoneType = Console.ReadLine();
                Console.Write("Description: ");
                string newPhoneDescription = Console.ReadLine();
                Phone newPhone = new Phone(newPhoneNumber, newPhoneType, newPhoneDescription);
                userToEdit.AddPhone(newPhone);

                Console.WriteLine("User edited successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }



        static void DeleteUser()
        {
            Console.Write("Enter ID of the user to delete: ");
            int userId = Convert.ToInt32(Console.ReadLine());

            User userToDelete = contactList.GetUsers().Find(user => user.GetUserId() == userId);

            if (userToDelete != null)
            {
                contactList.DeleteUser(userToDelete);
                Console.WriteLine("User deleted successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }


        static void SearchUser()
        {
            Console.WriteLine("Enter search criteria:");
            Console.Write("Search by First Name, Last Name, City, or Gender: ");
            string searchCriteria = Console.ReadLine();

            contactList.SearchUser(searchCriteria);
        }

        static void DisplayAllUsers()
        {
            contactList.ShowAll();
        }
    }
}