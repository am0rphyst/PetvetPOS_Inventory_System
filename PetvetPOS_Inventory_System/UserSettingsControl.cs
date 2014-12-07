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
    public partial class UserSettingsControl : UserControl
    {
        private MasterController masterController;
        private Panel userControlPanel;
        private string username;

        public UserSettingsControl()
        {
            InitializeComponent();
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
            }
        }

        public string accessLoginName 
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                loginName.Text = "Hi " + username + "!";
            }
        }

        private void UserSettingsControl_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            returnHome();
        }

        public void returnHome()
        {
            LoginPane loginPane = new LoginPane();
            masterController.changeCurrentContent(loginPane);
            loginPane.accessMasterController = masterController;
            loginPane.setUserControlPanel = userControlPanel;
            masterController.clearMenuBar();
            userControlPanel.Controls.Remove(this);
            masterController.clearTitleHeader();
        }

        public Panel accessUserControlPanel 
        {
            get
            {
                return userControlPanel;
            }
            set
            {
                userControlPanel = value;
            }
        }

 

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnHome();
        }

        
    }
}
