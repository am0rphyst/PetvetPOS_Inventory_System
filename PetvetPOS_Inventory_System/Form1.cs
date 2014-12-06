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
        MasterController masterController;
        private MenuBar menuBar1;
        private LoginPane loginPane;
        MenuControl[] menuControls;
        //Session session;

        public frmMain()
        {
            InitializeComponent();
            initSideBar();
            masterController = new MasterController(mainPanel, menuBar1, titlebar1,this);

            menuControls = new MenuControl[4];
            menuControls[0] = new MenuControl(Properties.Resources.iconmonstr_user_14_icon_256, "Users");
            menuControls[0].accessMapPanel = new UserAdministration();
            menuControls[1] = new MenuControl(Properties.Resources.iconmonstr_barcode_2_icon_256,"P.O.S.");
            menuControls[1].accessMapPanel = new POS();
            menuControls[2] = new MenuControl(Properties.Resources.iconmonstr_archive_8_icon_256,"Inventory");
            menuControls[2].accessMapPanel = new Inventory();
            menuControls[3] = new MenuControl(Properties.Resources.iconmonstr_document_file_2_icon_256, "Reports");
            menuControls[3].accessMapPanel = new Reports();

            menuBar1.accessMenuControl = menuControls;
            menuBar1.controlTitleBar(titlebar1);
            titlebar1.setMenuControls(menuBar1.accessMenuControl);
          //  loginPane.setForm = this;
        }

        //public Session accessSession 
        //{
        //    get
        //    {
        //        return this.session;
        //    }
        //    set; 
        //}
        private void ovalShape1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            initLoginPane();
        }

        private void initLoginPane()
        {
            this.loginPane = new PetvetPOS_Inventory_System.LoginPane();
            this.loginPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Controls.Add(this.loginPane);
            loginPane.accessMasterController = masterController;
            masterController.accessCurrentContent = loginPane;
            loginPane.setUserControlPanel = userControlPanel;

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString() + " " + DateTime.Today.DayOfWeek.ToString();
        }

        private void titlebar1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
