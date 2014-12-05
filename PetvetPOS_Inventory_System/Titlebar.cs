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
        MenuControl[] menuControls;
        MasterController masterController;

        public void setMenuControls(MenuControl[] menuControls)
        {
            this.menuControls = menuControls;
            foreach (MenuControl menuControl in menuControls)
            {
                menuControl.accessTitlebar = this;
            }
        }



        public Titlebar()
        {
            InitializeComponent();
            lblTitle.Text = "HOME";

            qwerty qwe = new qwerty();
            qwe.Location = new Point(0,0);
            qwe.Size = new Size(134, 89);
            this.panel1.Controls.Add(qwe);
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
        private void label1_Click(object sender, EventArgs e)
        {
           
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
