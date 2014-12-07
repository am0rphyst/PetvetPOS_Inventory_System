using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    class MenuList
    {
        MasterController masterController;
        public MenuControl[] menuControls;

        public MenuList(MasterController masterController)
        {
            this.masterController = masterController;
        }

        public MenuControl[] getList
        {
            get
            {
                return menuControls;
            }
        }
    }
}
