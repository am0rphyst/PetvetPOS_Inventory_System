using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public partial class Inventory : MyUserControl
    {
        public Inventory()
        {
            InitializeComponent();
        }

        public Inventory(MasterController masterController):base(masterController)
        {
            InitializeComponent();
        }
    }
}
