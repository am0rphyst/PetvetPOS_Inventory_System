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
        private MenuControl[] menuControls;
        private Titlebar titlebar1;

        public frmMain()
        {
            InitializeComponent();
            initTitleBar();
            initSideBar();
            masterController = new MasterController(mainPanel, menuBar1, titlebar1,this);
            setUpMenuControls();
        }

        public void setUpMenuControls()
        {
            menuControls = new MenuControl[4];
            // menuControl 1
            menuControls[0] = new MenuControl(Properties.Resources.iconmonstr_user_14_icon_256, "Users");
            menuControls[0].accessMapPanel = new UserAdministration();
            // menuControl 2
            menuControls[1] = new MenuControl(Properties.Resources.iconmonstr_barcode_2_icon_256, "P.O.S.");
            menuControls[1].accessMapPanel = new POS();
            // menuControl 3
            menuControls[2] = new MenuControl(Properties.Resources.iconmonstr_archive_8_icon_256, "Inventory");
            menuControls[2].accessMapPanel = new Inventory();
            // menuControl 4
            menuControls[3] = new MenuControl(Properties.Resources.iconmonstr_document_file_2_icon_256, "Reports");
            menuControls[3].accessMapPanel = new Reports();

            menuBar1.accessMenuControl = menuControls;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            initLoginPane();
        }

        private void initLoginPane()
        {
            loginPane = new LoginPane();
            masterController.changeCurrentContent(loginPane);
            loginPane.accessMasterController = masterController;
            loginPane.setUserControlPanel = userControlPanel;
        }

        public void initSideBar()
        {
            this.menuBar1 = new PetvetPOS_Inventory_System.MenuBar();
            this.menuBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(105, 617);
            this.menuBar1.TabIndex = 0;
            this.panelSidebar.Controls.Add(this.menuBar1);
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            lblDate.Text = DateTime.Now.Date.ToLongDateString();
        }

        private void initTitleBar()
        {
            titlebar1 = new Titlebar();
            titlebar1.Dock = DockStyle.Fill;
            titlebar1.Location = new Point(0, 0);
            titlebar1.Name = "titlebar1";
            titlebar1.setTitle = "HOME";
            titlebar1.Size = new System.Drawing.Size(782, 76);
            titlebar1.TabIndex = 0;
            titlebar1.TabStop = false;
            this.panelHeader.Controls.Add(this.titlebar1);
        }
    }
}
