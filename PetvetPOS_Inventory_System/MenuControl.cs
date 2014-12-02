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
        Color origColor;
        Titlebar titlebar;
        MenuBar menuBar;
        bool isSelected;

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

        public MenuBar accessMenuBar
        {
            set
            {
                menuBar = value;
            }
                
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
           // icon.BackColor = Color.White;
            isSelected = true;
        }

        private void icon_Click(object sender, EventArgs e)
        {
            //isSelected = true;
            //select();
            titlebar.setTitle = menuName.Text;
            titlebar.setImage = icon.BackgroundImage;
            menuBar.unselectAll();
            this.select();
            menuBar.updateMenus();
        }

        private void icon_MouseHover(object sender, EventArgs e)
        {
            icon.BorderColor = Color.Gold;
        }

        public void redraw()
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
            //icon.BackColor = origColor;
            isSelected = false;
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
