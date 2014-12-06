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
        frmMain form;
        Panel userControlPanel;
        User user;
        MasterController masterController;

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

        public frmMain setForm 
        {
            get
            {
                return form;
            }
            set
            {
                form = value;
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Login login = new Login();
            user = login.userLogin(username, password);
            
            if (user != null)
            {
                username = user.getUsername;
                UserControl userAdminPane = new UserAdministration();
                masterController.changeCurrentContent(userAdminPane);
                masterController.setMenuBar();
                showUserSettingsControl(username);
            }

           // createSession(form.accessSession);
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        //public void createSession(Session session){
        //    session = new Session(user);
        //}
    }
}
