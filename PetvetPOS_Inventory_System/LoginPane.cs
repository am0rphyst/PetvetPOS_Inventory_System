using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public partial class LoginPane : MyUserControl
    {
        User user;
        int loginAttempt = 0;

        public LoginPane()
        {
            InitializeComponent();
        }

        public LoginPane(MasterController masterController)
        {
            InitializeComponent();
            accessMasterController = masterController;
        }

        private void showUserSettingsControl(string username)
        {
            masterController.showUserSettingsControl(username);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
        
            Login login = new Login();
            user = login.userLogin(username, password);
            
            if (user != null)
            {
                MyUserControl nextControl;
                string level = user.getUserLevel();
                string menuName;
                bool isAdmin = false;
         
                if (level == "admin")
                {
                    nextControl = new Reports();
                    menuName = "Reports";
                    isAdmin = true;
                }
                else
                {
                    nextControl = new POS();
                    menuName = "P.O.S.";
                    isAdmin = false;
                    
                }

                masterController.initMenuBar(isAdmin);
                showUserSettingsControl(username);
                masterController.changeCurrentContent(nextControl);
                masterController.defaultSelectedMenu(menuName);
            }
            else
            {
                loginAttempt++;

                if (loginAttempt == 3)
                {
                    MessageBox.Show("Oopss.. 3 failed login attemps have reach. Window will now close.");
                    masterController.closeForm();
                }

                MessageBox.Show("Login Failed. " + (3 - loginAttempt) + " attemp/s left.");
                txtPassword.Clear();
            }

        }

        public MasterController accessMasterController
        { 
            get
            {
                 return masterController; 
            }
            set
            {
                masterController = value;
                masterController.setFormReturnkey = btnLogin;
            } 
        }

    }
}
