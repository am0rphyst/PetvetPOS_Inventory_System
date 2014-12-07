using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public partial class frmMain : Form
    {
        private MasterController masterController;
        private MenuBar menuBar1;
        private LoginPane loginPane;
        private Titlebar titlebar1;
        private UserSettingsControl userSettingsControl;

        public frmMain()
        {
            InitializeComponent();
            masterController = new MasterController(this, mainPanel);
            titlebar1 = new Titlebar(panelHeader, masterController);
            menuBar1 = new MenuBar(panelSidebar, masterController);
            userSettingsControl = new UserSettingsControl(userControlPanel, masterController);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loginPane = new LoginPane(masterController);
            masterController.changeCurrentContent(loginPane);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            lblDate.Text = DateTime.Now.Date.ToLongDateString();
        }

    }
}
