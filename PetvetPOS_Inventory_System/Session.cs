using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    class Session
    {
        private User currentUser;
        private DateTime dateLogin;
        private TimeSpan timeLogin;
   
        public Session(User user)
        {
            currentUser = user;
            dateLogin = DateTime.Today;
            timeLogin = DateTime.Now.TimeOfDay;
        }

        public User getCurrentUser()
        {
            return currentUser;
        }
    }
}
