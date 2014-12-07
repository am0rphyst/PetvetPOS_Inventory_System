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
        private MasterController masterController;


        public Titlebar()
        {
            InitializeComponent();
            lblTitle.Text = "HOME";
        }

        public string setTitle 
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value.ToUpper();
            }
        }

        public Image setImage
        {
            set
            {
                pictureBox1.Image = value;
            }
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

    }
}
