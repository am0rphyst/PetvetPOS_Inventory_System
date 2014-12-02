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
        MenuControl[] menuControls = new MenuControl[3];
        Titlebar titlebar;

        public MenuBar()
        {
            InitializeComponent();
            // set the menu Controls to the array
            // menuControl1
            menuControls[0] = menuControl1;
            menuControls[0].setIconImage = Properties.Resources.iconmonstr_user_14_icon_256;
            menuControls[0].accessIconLabel = "Users";
            // menuControl2
            menuControls[1] = menuControl2;
            menuControls[1].setIconImage = Properties.Resources.iconmonstr_barcode_2_icon_256;
            menuControls[1].accessIconLabel = "P.O.S.";
            // menuContorl3
            menuControls[2] = menuControl3;
            menuControls[2].setIconImage = Properties.Resources.iconmonstr_archive_8_icon_256;
            menuControls[2].accessIconLabel = "Inventory";
            //   menuControls[0] = menuControl1;
            // menuControls[0] = new MenuControl(Properties.Resources.iconmonstr_user_14_icon_256, "Users");
            setMenuControl();
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

        public MenuControl[] getMenuControl
        {
            get
            {
                return menuControls;
            }

        }

        public void setMenuControl()
        {
            foreach(MenuControl menuControl in menuControls)
	        {
                menuControl.accessMenuBar = this;
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
