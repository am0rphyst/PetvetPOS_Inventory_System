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
    public partial class UserSettingsControl : MyUserControl
    {
        private string username;

        public UserSettingsControl()
        {
            InitializeComponent();
        }

        public UserSettingsControl(Panel panel, MasterController masterController):base(panel,false)
        {
            InitializeComponent();
            this.masterController = masterController;
            this.masterController.setUserSettingsControl = this;
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

        public void appearWithName(string name)
        {
            accessLoginName = name;
            appear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            returnHome();
        }

        public void returnHome()
        {
            disappear();
            LoginPane loginPane = new LoginPane(masterController);
            masterController.changeCurrentContent(loginPane);
            masterController.clearMenuBar();
            masterController.clearTitleHeader();
        } 

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnHome();
        }

        private void UserSettingsControl_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void UserSettingsControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == (Keys)Keys.F12)
            {
                returnHome();
            }
        }
        
    }
}
