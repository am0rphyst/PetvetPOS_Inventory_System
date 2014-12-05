using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetvetPOS_Inventory_System;

namespace PetvetPOS_Inventory_System
{
    public partial class MenuBar : UserControl
    {
        MenuControl[] menuControls;
        Titlebar titlebar;
        MasterController masterController;

        public void initControlLocation()
        {
            int i = 0;
            int startingPosition = 15;

            foreach (MenuControl menuControl in menuControls)
            {
                menuControl.Location = new System.Drawing.Point(6, startingPosition);
                menuControl.TabIndex = i;
                this.Controls.Add(menuControl);
                i++;
                startingPosition += 150;
            }
        }

        public MenuBar()
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

        private void MenuBar_Load(object sender, EventArgs e)
        {

        }

        private void menuControl1_Load(object sender, EventArgs e)
        {

        }

        public void controlTitleBar(Titlebar titlebar)
        {
            this.titlebar = titlebar;
        }

        public void updateMenus()
        {
            foreach (MenuControl menuControl in menuControls)
            {
                menuControl.redraw();
            }
        }

        public void unselectAll()
        {
            foreach (MenuControl menuControl in menuControls)
            {
                menuControl.unselect();
            }
        }

        private void menuControl1_Click(object sender, EventArgs e)
        {
            //unselectAll();
            //menuControl2.unselect();
            //menuControl3.unselect();
            //menuControl1.select();
            //menuControls[0].select();
            //titlebar.setTitle = menuControl1.accessIconLabel;
            //titlebar.Refresh();
        }

        private void menuControl2_Load(object sender, EventArgs e)
        {

           // unselectAll();
            //menuControls[1].select();
        }

        private void menuControl3_Click(object sender, EventArgs e)
        {
            //titlebar.setTitle = menuControl3.accessIconLabel;
            //titlebar.Refresh();

            //unselectAll();
            ////menuControls[2].select();
        }

        private void menuControl2_Click(object sender, EventArgs e)
        {
            //titlebar.setTitle = menuControl2.accessIconLabel;
            //titlebar.Refresh();
            //unselectAll();
        }

        public MenuControl[] accessMenuControl
        {
            get
            {
                return menuControls;
            }

            set
            {
                this.menuControls = value;
                setMenuControl();
               // initControlLocation();
            }
        }

        public void setMenuControl()
        {
            foreach(MenuControl menuControl in menuControls)
	        {
                menuControl.accessMenuBar = this;
                menuControl.accessTitlebar = titlebar;
                menuControl.accessMasterController = this.masterController;
    	    }
        }

        public void controlMenuControls()
        {
            foreach (MenuControl menuControl in menuControls)
            {
                menuControl.accessMenuBar = this;
            }
        }

    }
}
