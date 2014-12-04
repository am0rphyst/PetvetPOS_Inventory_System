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
        private MenuBar menuBar1;
        MenuControl[] menuControls;
        
        public frmMain()
        {
            InitializeComponent();
            initSideBar();

            menuControls = new MenuControl[3];
            menuControls[0] = new MenuControl();
            menuControls[0].setIconImage = Properties.Resources.iconmonstr_user_14_icon_256;
            menuControls[0].accessIconLabel = "Users";
            // menuControl2
            menuControls[1] = new MenuControl();
            menuControls[1].setIconImage = Properties.Resources.iconmonstr_barcode_2_icon_256;
            menuControls[1].accessIconLabel = "P.O.S.";
            // menuContorl3
            menuControls[2] = new MenuControl();
            menuControls[2].setIconImage = Properties.Resources.iconmonstr_archive_8_icon_256;
            menuControls[2].accessIconLabel = "Inventory";

            menuBar1.accessMenuControl = menuControls;
            menuBar1.controlTitleBar(titlebar1);
            titlebar1.setMenuControls(menuBar1.accessMenuControl);
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

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
            this.menuBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(105, 617);
            this.menuBar1.TabIndex = 0;
            this.panelSidebar.Controls.Add(this.menuBar1);
        }
    }
}
