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
        private MenuControl[] menuControls;
        private MasterController masterController;

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
                startingPosition += 140;
            }
        }

        public void selectControlbyIndex(int index)
        {
            if (index > menuControls.Length)
                return;

            unselectAll();
            menuControls[index].select();
            masterController.updateTitle(menuControls[index].accessIconLabel, menuControls[index].getIconImage);
            updateMenus();
        }

        public void selectControlbyName(string name)
        {
            unselectAll();
            foreach (MenuControl menuControl in menuControls)
            {
                if (menuControl.accessIconLabel == name)
                {
                    menuControl.select();
                    masterController.updateTitle(menuControl.accessIconLabel, menuControl.getIconImage);
                    updateMenus();
                    break;
                }
            }
        }

        public void removeMenuControls()
        {
            foreach (MenuControl menuControl in menuControls)
            {
                this.Controls.Remove(menuControl);
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
            }
        }

        public void setMenuControl()
        {
            foreach(MenuControl menuControl in menuControls)
	        {
                menuControl.accessMenuBar = this;
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
