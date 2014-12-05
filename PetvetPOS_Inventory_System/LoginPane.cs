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
        Panel mainPanel;
        UserControl nextControl, currentControl;
        User user;
        MasterController masterController;

        public void nextPane()
        {
            //mainPanel.Controls.re
            nextControl = new UserAdministration();
            nextControl.Dock = System.Windows.Forms.DockStyle.Fill;
            nextControl.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Controls.Add(nextControl);
        }

        public LoginPane()
        {
            InitializeComponent();
        }

        public void setMainPanel(Panel panel)
        {
            mainPanel = panel;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Login login = new Login();
            user = login.userLogin(username, password);
           
            if (user != null)
            {
                UserControl userAdminPane = new UserAdministration();
                masterController.changeCurrentContent(userAdminPane);
                masterController.setMenuBar();
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
        //public void createSession(Session session){
        //    session = new Session(user);
        //}
    }
}
