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
    public partial class LoginPane : UserControl
    {
        Panel userControlPanel;
        User user;
        MasterController masterController;
        int loginAttempt = 0;

        public LoginPane()
        {
            InitializeComponent();
        }

        public Panel setUserControlPanel 
        {
            set
            {
                userControlPanel = value;
            }
        }

        private void showUserSettingsControl(string username)
        {
            UserSettingsControl userSettingsControl = new UserSettingsControl();
            userSettingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            userSettingsControl.Location = new System.Drawing.Point(0, 0);
            this.userControlPanel.Controls.Add(userSettingsControl);
            userSettingsControl.accessMasterController = masterController;
            userSettingsControl.accessUserControlPanel = userControlPanel;
            userSettingsControl.accessLoginName = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl nextControl;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string level, menuName;

            Login login = new Login();
            user = login.userLogin(username, password);
            
            if (user != null)
            {
                username = user.getUsername;
                level = user.getUserLevel();
               
                if (level == "admin")
                {
                    nextControl = new Reports();
                    menuName = "Reports";
                }
                else
                {
                    nextControl  = new POS();
                    menuName = "P.O.S.";
                }

                showUserSettingsControl(username);
                masterController.changeCurrentContent(nextControl);
                masterController.setMenuBar();
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
