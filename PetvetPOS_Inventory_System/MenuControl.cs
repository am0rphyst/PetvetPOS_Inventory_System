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
        bool isSelected;
        Color origColor;
        Titlebar titlebar;

        public MenuControl()
        {
            InitializeComponent();
            ovalShape1 = icon;
            menuName = lblDesc;
            origColor = icon.BackColor;
        }

        public MenuControl(Image image, string menuString)
        {
            InitializeComponent();
            ovalShape1 = icon;
            menuName = lblDesc;
            setIconImage = image;
            menuName.Text = menuString;
            origColor = icon.BackColor;
        }

        public Image setIconImage 
        {   
            set
            {
                ovalShape1.BackgroundImage = value;
            }
        }

        public string accessIconLabel
        {
            set
            {
                menuName.Text = value;
            }
            get
            {
                return menuName.Text;
            }
        }

        public void select()
        {
            if (isSelected)
            {
                icon.BackColor = Color.White;
            }
            else
            {
                icon.BackColor = origColor;
            }
        }

        private void icon_Click(object sender, EventArgs e)
        {
            //isSelected = true;
            //select();
            titlebar.setTitle = menuName.Text;
        }

        private void icon_MouseHover(object sender, EventArgs e)
        {
            icon.BorderColor = Color.Gold;
        }

        private void icon_MouseEnter(object sender, EventArgs e)
        {
            icon.BorderColor = Color.Gold;
        }

        private void icon_MouseLeave(object sender, EventArgs e)
        {
            icon.BorderColor = Color.White;
        }

        public void unselect()
        {
            isSelected = false;
            select();
            icon.BackColor = origColor;
        }

        public Titlebar accessTitlebar
        {
            set
            {
                titlebar = value;
            }
        }

    }
}
