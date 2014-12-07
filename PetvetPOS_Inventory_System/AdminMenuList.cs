using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    class AdminMenuList:MenuList
    {
        public AdminMenuList(MasterController masterController):base(masterController)
        {
            menuControls = new MenuControl[4];
            // menuControl 1
            menuControls[0] = new MenuControl(Properties.Resources.iconmonstr_user_14_icon_256, "Users", new UserAdministration());
            // menuControl 2
            menuControls[1] = new MenuControl(Properties.Resources.iconmonstr_barcode_2_icon_256, "P.O.S.", new POS());
            // menuControl 3
            menuControls[2] = new MenuControl(Properties.Resources.iconmonstr_archive_8_icon_256, "Inventory", new Inventory());
            // menuControl 4
            menuControls[3] = new MenuControl(Properties.Resources.iconmonstr_document_file_2_icon_256, "Reports", new Reports());
            // this is set to set register this menuBar to the menuControls
        }


    }
}
