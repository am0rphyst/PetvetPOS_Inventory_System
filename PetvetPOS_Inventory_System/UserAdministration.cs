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
    public partial class UserAdministration : MyUserControl
    {
        public UserAdministration()
        {
            InitializeComponent();
        }

        public UserAdministration(MasterController masterController):base(masterController)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
