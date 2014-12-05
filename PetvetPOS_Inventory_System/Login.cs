using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    class Login
    {
        User user;

        public User userLogin(string username, string password)
        {
            if (validateUser(username, password))
            {
                return user;
            }
            return null;
        }

        private bool validateUser(string username, string password)
        {
            user = new User(username, password);
            if (user.isValid())
            {
                return true;
            }
            return false;
        }
    }
}
