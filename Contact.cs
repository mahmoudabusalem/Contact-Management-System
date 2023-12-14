using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementSystem
{

    public class Contact
    {
        private List<User> Users;
        private int count;

        public Contact()
        {
            Users = new List<User>();
            count = 0;
        }

        public List<User> GetUsers()
        {
            return Users;
        }

        public void AddUser(User user)
        {
            Users.Add(user);
            count++;
        }

        public void EditUser(User user, string firstname, string lastname, string gender, string city, string addedDate)
        {
            user.Edit(firstname, lastname, gender, city, addedDate);
        }

        public int CountUser()
        {
            return count;
        }

        public void SearchUser(string searchCriteria)
        {
            foreach (User user in Users)
            {
                if (user.Search(searchCriteria))
                {
                    user.Show();
                }
            }
        }

        public void DeleteUser(User user)
        {
            Users.Remove(user);
            count--;
        }

        public void ShowAll()
        {
            foreach (User user in Users)
            {
                user.Show();
            }
        }
    }

}
