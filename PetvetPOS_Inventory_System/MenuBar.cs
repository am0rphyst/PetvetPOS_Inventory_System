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

        public MenuBar()
        {
            InitializeComponent();
            // set the menu Controls to the array
            menuControls = new MenuControl[3];
            // menuControl1
            menuControls[0] = menuControl1;
            menuControls[0].setIconImage = Properties.Resources.iconmonstr_user_14_icon_256;
            menuControls[0].setIconLabel = "Users";
            // menuControl2
            menuControls[1] = menuControl2;
            menuControls[1].setIconImage = Properties.Resources.iconmonstr_barcode_2_icon_256;
            menuControls[1].setIconLabel = "POS";
            // menuContorl3
            menuControls[2] = menuControl3;
            menuControls[2].setIconImage = Properties.Resources.iconmonstr_archive_8_icon_256;
            menuControls[2].setIconLabel = "Inventory";
         //   menuControls[0] = menuControl1;
           // menuControls[0] = new MenuControl(Properties.Resources.iconmonstr_user_14_icon_256, "Users");
        }

        private void MenuBar_Load(object sender, EventArgs e)
        {

        }
    }
}
