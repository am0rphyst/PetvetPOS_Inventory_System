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
    public partial class UserSettingsControl : UserControl
    {
        public UserSettingsControl()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            partB.Visible = true;
            label2.Visible = true;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            partB.Visible = true;
            label2.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            partB.Visible = false;
            label2.Visible = false;
            label2.Visible = false;
        }

        private void UserSettingsControl_Load(object sender, EventArgs e)
        {

        }

        
    }
}
