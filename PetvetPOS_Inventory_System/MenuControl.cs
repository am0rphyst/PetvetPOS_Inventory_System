using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PetvetPOS_Inventory_System
{
    public partial class MenuControl : UserControl
    {
        Label menuName;
        Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;

        public MenuControl()
        {
            InitializeComponent();
            ovalShape1 = icon;
            menuName = lblDesc;
        }

        public MenuControl(Image image, string menuString)
        {
            InitializeComponent();
            ovalShape1 = icon;
            menuName = lblDesc;
            setIconImage = image;
            menuName.Text = menuString;
        }

        public Image setIconImage 
        {   
            set
            {
                ovalShape1.BackgroundImage = value;
            }
        }

        public string setIconLabel
        {
            set
            {
                menuName.Text = value;
            }
        }

        public void isSelected(bool flag)
        {
            if (flag)
            {
                icon.BackColor = Color.White;
            }
            else
            {
        
            }
        }

        private void icon_Click(object sender, EventArgs e)
        {
            icon.BackColor = Color.White;
        }

        private void icon_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void icon_MouseEnter(object sender, EventArgs e)
        {
            icon.BorderColor = Color.Gold;
        }

        private void icon_MouseLeave(object sender, EventArgs e)
        {
            icon.BorderColor = Color.White;
        }
    }
}
