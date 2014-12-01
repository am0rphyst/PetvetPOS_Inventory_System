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
    public partial class Titlebar : UserControl
    {
        public Titlebar()
        {
            InitializeComponent();
        }

        public string setTitle 
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
