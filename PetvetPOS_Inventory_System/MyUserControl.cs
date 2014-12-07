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
    public partial class MyUserControl : UserControl
    {
        public MasterController masterController;
        private Panel container;

        public MyUserControl()
        {
            InitializeComponent();
        }

        public MyUserControl(Panel panel,bool isVisible)
        {
            InitializeComponent();
            this.container = panel;

            if (isVisible)
            {
                appear();
            }
           
        }

        public MyUserControl(MasterController masterController)
        {
            this.masterController = masterController;
            
        }
        public void appear()
        {
            this.Dock = DockStyle.Fill;
            this.Location = new Point(0, 0);
            this.container.Controls.Add(this);
        }

        public void disappear()
        {
            container.Controls.Remove(this);
        }
        private void MyUserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == (Keys)Keys.F12)
            {
                 masterController.logout();
            }

        }
    }
}
