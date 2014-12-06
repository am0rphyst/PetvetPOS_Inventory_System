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
        MasterController masterController;
        Panel userControlPanel;

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

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            partB.Visible = true;
            label2.Visible = true;
            timer1.Start();
           // returnHome();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            partB.Visible = true;
            label2.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            partB.Visible = false;
            label2.Visible = false;
            label2.Visible = false;
        }

        public string accessLoginName 
        {
            get
            {
                return loginName.Text;
            }
            set
            {
                loginName.Text = value;
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

        private void partB_Click(object sender, EventArgs e)
        {
            returnHome();
        }

        private void rectangleShape1_Click_1(object sender, EventArgs e)
        {
            returnHome();
        }

        
    }
}
