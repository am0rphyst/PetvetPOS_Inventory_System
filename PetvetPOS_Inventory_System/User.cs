using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    class User
    {
        string username, password;
        
        public User(string username, string password){
            this.username = username;
            this.password = password;
        }

        // TODO
        public bool isValid()
        {
            if ((username == "Randy") && (password == "Pogi"))
            {
                return true;
            }
            return false;
        }

        public string getUsername 
        { 
            get
            {
             return username;   
            }
        }
    }
}
